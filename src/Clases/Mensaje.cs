using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter.Clases
{
    public class Mensaje
    {
        int? id_receiver;
        int? id_sender;
        string message;

        public Mensaje(int? id_receiver, int? id_sender, string message)
        {
            this.id_receiver = id_receiver;
            this.id_sender = id_sender;
            this.message = message;
        }

        public string Message { get { return message; } }

        public static void EnviarMensaje(Mensaje chat)
        {
            string query = "INSERT INTO `pet4sitter`.`chat` (`id_receiver`, `id_sender`, `messages`) VALUES (@id_receiver, @id_sender, @mensaje);";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("id_receiver",chat.id_receiver);
            com.Parameters.AddWithValue("id_sender", chat.id_sender);
            com.Parameters.AddWithValue("mensaje", chat.message);
            com.ExecuteNonQuery();
        }
        public static List<Mensaje> ListarMensajes(string query)
        {
            List<Mensaje> mensajes = new List<Mensaje>();

            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("idUsuActual", Data.CurrentUser.IdUser);
            using (MySqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    int? idChat = reader.IsDBNull(reader.GetOrdinal("id")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("id"));
                    int? idSender = reader.IsDBNull(reader.GetOrdinal("id_sender")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("id_sender"));
                    string message = reader.GetString(reader.GetOrdinal("messages"));
                    Mensaje mensaje = new Mensaje(idChat, idSender, message);
                    mensajes.Add(mensaje);
                }
                reader.Close();
            }

            return mensajes;
        }

        public static List<Mensaje> ObtenerUltimosChats()
        {
            List<Mensaje> mensajes = new List<Mensaje>();

            string query = @"
        SELECT distinct c.id_sender ,messages
        FROM chat c
        WHERE c.id_receiver = @idUsuActual
        ORDER BY date DESC;
    ";

            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("idUsuActual", Data.CurrentUser.IdUser);
            using (MySqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    int? id_sender = reader.IsDBNull(0) ? (int?)null : reader.GetInt32(0);
                    string message = reader.GetString(1);
                    Mensaje mensaje = new Mensaje(null, id_sender, message);
                    mensajes.Add(mensaje);
                }
                reader.Close();
            }
            

            return mensajes;
        }

        public static int ContarTotalChats()
        {
            int res = 0;
            try
            {
                string query = @"
        SELECT COUNT(DISTINCT IF(id_sender = @CurrentUserId, id_receiver, id_sender)) AS total_chats
        FROM chat
        WHERE id_receiver = @CurrentUserId OR id_sender = @CurrentUserId";

                using (MySqlCommand cmd = new MySqlCommand(query, ConBD.Conexion))
                {
                    cmd.Parameters.AddWithValue("@CurrentUserId", Data.CurrentUser.IdUser);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al contar los chats: {ex.Message}");
            }
            return res;
        }


    }
}

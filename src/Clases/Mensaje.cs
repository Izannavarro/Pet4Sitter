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

        /// <summary>
        /// Envía un mensaje y lo inserta en la base de datos.
        /// </summary>
        /// <param name="chat">El objeto Mensaje que contiene la información del mensaje a enviar.</param>
        public static void EnviarMensaje(Mensaje chat)
        {
            string query = "INSERT INTO `pet4sitter`.`chat` (`id_receiver`, `id_sender`, `messages`) VALUES (@id_receiver, @id_sender, @mensaje);";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("id_receiver", chat.id_receiver);
            com.Parameters.AddWithValue("id_sender", chat.id_sender);
            com.Parameters.AddWithValue("mensaje", chat.message);
            com.ExecuteNonQuery();
        }

        /// <summary>
        /// Lista los mensajes de acuerdo con la consulta proporcionada.
        /// </summary>
        /// <param name="query">La consulta SQL para listar los mensajes.</param>
        /// <returns>Una lista de objetos Mensaje obtenidos de la base de datos.</returns>
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

        /// <summary>
        /// Cuenta el número total de chats únicos del usuario actual.
        /// </summary>
        /// <returns>El número total de chats únicos del usuario actual.</returns>
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

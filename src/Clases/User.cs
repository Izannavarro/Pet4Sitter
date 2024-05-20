using MySql.Data.MySqlClient;
using System;
using BCrypt.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace pet4sitter.Clases
{
    public class User
    {
        private int? idUser;
        private string idGoogle;
        private string name;
        private string surname;
        private string email;
        private string dni;
        private string password;
        private string location;
        private bool? premium;
        private bool? sitter;
        private bool? admin;
        private string image;
        private double? latitud;
        private double? longitud;

        public string IdGoogle { get { return this.idGoogle; } }

        public string Name { get { return this.name; } }
        
        public bool? Premium { get { return this.premium; } }
        public string Image { get { return this.image; } } 

        // Constructor
        public User() { }
        public User(int? idUser, string idGoogle, string name, string surname, string email, string dni, string password, string location, bool? premium, bool? sitter, bool? admin, string image, double? latitud, double? longitud)
        {
            this.idUser = idUser;
            this.idGoogle = idGoogle;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.dni = dni;
            this.password = password;
            this.location = location;
            this.premium = premium;
            this.sitter = sitter;
            this.admin = admin;
            this.image = image;
            this.latitud = latitud;
            this.longitud = longitud;
        }
        public User (int? idUser,string name, string email,string dni, string password, bool? sitter,bool? admin)
        {
            this.idUser = idUser;
            this.name = name;
            this.email= email;
            this.dni = dni;
            this.password = password;
            this.sitter = sitter;
            this.admin = admin;
        }
        public static List<User> ListarUsuarios(string query)
        {
            List<User> list = new List<User>();
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new User(
                                            reader.IsDBNull(reader.GetOrdinal("id_user")) ? (int?)null : reader.GetInt32("id_user"),
                                            reader.IsDBNull(reader.GetOrdinal("id_google")) ? null : reader.GetString("id_google"),
                                            reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString("name"),
                                            reader.IsDBNull(reader.GetOrdinal("surname")) ? null : reader.GetString("surname"),
                                            reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                                            reader.IsDBNull(reader.GetOrdinal("dni")) ? null : reader.GetString("dni"),
                                            reader.IsDBNull(reader.GetOrdinal("password")) ? null : reader.GetString("password"),
                                            reader.IsDBNull(reader.GetOrdinal("location")) ? null : reader.GetString("location"),
                                            reader.IsDBNull(reader.GetOrdinal("premium")) ? (bool?)null : reader.GetBoolean("premium"),
                                            reader.IsDBNull(reader.GetOrdinal("sitter")) ? (bool?)null : reader.GetBoolean("sitter"),
                                            reader.IsDBNull(reader.GetOrdinal("admin")) ? (bool?)null : reader.GetBoolean("admin"),
                                            reader.IsDBNull(reader.GetOrdinal("image")) ? null : (string)reader["image"],
                                            reader.IsDBNull(reader.GetOrdinal("latitud")) ? (double?)null : reader.GetDouble("latitud"),
                                            reader.IsDBNull(reader.GetOrdinal("longitud")) ? (double?)null : reader.GetDouble("longitud")
                                        ));

            }
            return list;
        }

        public static User EncontrarUsuario(string email)
        {
            User user = null;
            string query = "SELECT * FROM users WHERE email = @Email";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("@Email", email);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                user = new User(
                                            reader.IsDBNull(reader.GetOrdinal("id_user")) ? (int?)null : reader.GetInt32("id_user"),
                                            reader.IsDBNull(reader.GetOrdinal("id_google")) ? null : reader.GetString("id_google"),
                                            reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString("name"),
                                            reader.IsDBNull(reader.GetOrdinal("surname")) ? null : reader.GetString("surname"),
                                            reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                                            reader.IsDBNull(reader.GetOrdinal("dni")) ? null : reader.GetString("dni"),
                                            reader.IsDBNull(reader.GetOrdinal("password")) ? null : reader.GetString("password"),
                                            reader.IsDBNull(reader.GetOrdinal("location")) ? null : reader.GetString("location"),
                                            reader.IsDBNull(reader.GetOrdinal("premium")) ? (bool?)null : reader.GetBoolean("premium"),
                                            reader.IsDBNull(reader.GetOrdinal("sitter")) ? (bool?)null : reader.GetBoolean("sitter"),
                                            reader.IsDBNull(reader.GetOrdinal("admin")) ? (bool?)null : reader.GetBoolean("admin"),
                                            reader.IsDBNull(reader.GetOrdinal("image")) ? null : (string)reader["image"],
                                            reader.IsDBNull(reader.GetOrdinal("latitud")) ? (double?)null : reader.GetDouble("latitud"),
                                            reader.IsDBNull(reader.GetOrdinal("longitud")) ? (double?)null : reader.GetDouble("longitud")
                                        );
            }
            return user;
        }

        public static User EncontrarUsuarioGoogle(string idGoogle)
        {
            User user = new User(null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            string query = "SELECT * FROM users WHERE id_google = @idGoogle";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("@idGoogle", idGoogle);
            MySqlDataReader reader = com.ExecuteReader();
            
            while (reader.Read())
            {
                user = new User(
                                            reader.IsDBNull(reader.GetOrdinal("id_user")) ? (int?)null : reader.GetInt32("id_user"),
                                            reader.IsDBNull(reader.GetOrdinal("id_google")) ? null : reader.GetString("id_google"),
                                            reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString("name"),
                                            reader.IsDBNull(reader.GetOrdinal("surname")) ? null : reader.GetString("surname"),
                                            reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                                            reader.IsDBNull(reader.GetOrdinal("dni")) ? null : reader.GetString("dni"),
                                            reader.IsDBNull(reader.GetOrdinal("password")) ? null : reader.GetString("password"),
                                            reader.IsDBNull(reader.GetOrdinal("location")) ? null : reader.GetString("location"),
                                            reader.IsDBNull(reader.GetOrdinal("premium")) ? (bool?)null : reader.GetBoolean("premium"),
                                            reader.IsDBNull(reader.GetOrdinal("sitter")) ? (bool?)null : reader.GetBoolean("sitter"),
                                            reader.IsDBNull(reader.GetOrdinal("admin")) ? (bool?)null : reader.GetBoolean("admin"),
                                            reader.IsDBNull(reader.GetOrdinal("image")) ? null : (string)reader["image"],
                                            reader.IsDBNull(reader.GetOrdinal("latitud")) ? (double?)null : reader.GetDouble("latitud"),
                                            reader.IsDBNull(reader.GetOrdinal("longitud")) ? (double?)null : reader.GetDouble("longitud")
                                        );
            }
            return user;
        }

        public static int RegistrarUsuario(User u)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(u.password);
            string query = "INSERT INTO users (name, surname, email, dni, password, location, sitter";
            MySqlCommand comando = new MySqlCommand(query, ConBD.Conexion);
            comando.Parameters.AddWithValue("@name", u.name);
            comando.Parameters.AddWithValue("@surname", u.surname);
            comando.Parameters.AddWithValue("@email", u.email);
            comando.Parameters.AddWithValue("@dni", u.dni);
            comando.Parameters.AddWithValue("@password", hashedPassword);
            comando.Parameters.AddWithValue("@location", u.location);
            comando.Parameters.AddWithValue("@sitter", u.sitter);

            // Verificar si idGoogle no es nulo y agregarlo a la consulta
            if (u.idGoogle != null)
            {
                query += ", id_google";
                comando.Parameters.AddWithValue("@idGoogle", u.idGoogle);
            }
            else
            {
                query += "";
            }

            query += ",latitud,longitud)";

            query += " VALUES (@name, @surname, @email, @dni, @password, @location, @sitter";

            // Agregar parámetro idGoogle si es necesario
            if (u.idGoogle != null)
            {
                query += ", @idGoogle";
            }

            query += ", @latitud,@longitud);";
            comando.Parameters.AddWithValue("latitud", u.latitud);
            comando.Parameters.AddWithValue("longitud", u.longitud);

            comando.CommandText = query;

            int res = comando.ExecuteNonQuery();

            return res;
        }

        public static bool CompruebaUsuarioExistente(string email)
        {
            string query = "Select count(email) from users where email=@email";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("email", email);

            int res = int.Parse(com.ExecuteScalar().ToString());
            if(res > 0)
            {
                return true;
            }
            return false;
        }

        public static bool CompruebaCredencialesUsuario(string email,string password)
        {
            string query = "select password from users where email=@email";
            MySqlCommand com = new MySqlCommand(query,ConBD.Conexion);
            com.Parameters.AddWithValue("email", email);

            string hashContraseñaAlmacenada = com.ExecuteScalar() as string;

            if (hashContraseñaAlmacenada != null && BCrypt.Net.BCrypt.Verify(password, hashContraseñaAlmacenada))
            {
                // La contraseña coincide, devolver true
                return true;
            }
            else
            {
                // La contraseña no coincide o no se encontró el usuario, devolver false
                return false;
            }

        }

        public static bool CompruebaUsuarioConGoogle(string idGoogle)
        {
            string query = "Select count(*) from users where id_google=@idGoogle";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("idGoogle", idGoogle);

            int res = int.Parse(com.ExecuteScalar().ToString());
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public static bool CompruebaPremium(User u)
        {
            string query = "select premium from users where email=@email;";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("email" , u.email);
            int res = int.Parse(com.ExecuteScalar().ToString());
            return res == 1;
        }
        public static DataTable CargarUsuarios()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string consulta = "SELECT id_user, name, email, dni, password, sitter, admin FROM users";
                using (MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion))
                {
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        dataTable.Load(reader);
                        reader.Close();
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los usuarios: " + ex.Message);
            }

            return dataTable;
        }
        public static void EliminarUsuarios(int id)
        {
            try {
                string consulta = String.Format("DELETE from users WHERE id_user = '{0}';", id);
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Close();
                }

            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar usuario: " + ex.Message);
            }
        }

    }
   
}

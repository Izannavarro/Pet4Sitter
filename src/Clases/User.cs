using MySql.Data.MySqlClient;
using System;
using BCrypt.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

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
        private byte[] image;
        private double? latitud;
        private double? longitud;

        public string IdGoogle { get { return this.idGoogle; } }
        public string Name { get { return this.name; } }
        public string Surname { get { return surname; } }
        public string Password { get { return password; } }
        public string Email { get { return email; } }
        public string Location { get { return location; } }
        public bool? Premium { get { return this.premium; } }
        public byte[] Image { get { return this.image; } }
        public int? IdUser { get { return this.idUser; } }
        public double? Latitud { get { return this.latitud; } }
        public double? Longitud { get { return this.longitud; } }
        public bool? Sitter { get { return sitter; } }
        public bool? Admin { get { return admin; } }

        // Constructor
        public User() { }
        public User(int? idUser, string idGoogle, string name, string surname, string email, string dni, string password, string location, bool? premium, bool? sitter, bool? admin, byte[] image, double? latitud, double? longitud)
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

        public User(int? idUser, string name, string email, string dni, string password, bool? sitter, bool? admin, byte[] img)
        {
            this.idUser = idUser;
            this.name = name;
            this.email = email;
            this.dni = dni;
            this.password = password;
            this.sitter = sitter;
            this.admin = admin;
            this.image = img;
        }

        public static List<User> ListarUsuarios(string query)
        {
            List<User> list = new List<User>();
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                byte[] ArrImg = reader.IsDBNull(reader.GetOrdinal("image")) ? null : (byte[])reader["image"];

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
                                            reader.IsDBNull(reader.GetOrdinal("image")) ? null : ArrImg,
                                            reader.IsDBNull(reader.GetOrdinal("latitud")) ? (double?)null : reader.GetDouble("latitud"),
                                            reader.IsDBNull(reader.GetOrdinal("longitud")) ? (double?)null : reader.GetDouble("longitud")
                                        ));

            }
            reader.Close();
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
                
                byte[] ArrImg = reader.IsDBNull(reader.GetOrdinal("image")) ? null : reader["image"] as byte [];

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
                                            reader.IsDBNull(reader.GetOrdinal("image")) ? null : ArrImg,
                                            reader.IsDBNull(reader.GetOrdinal("latitud")) ? (double?)null : reader.GetDouble("latitud"),
                                            reader.IsDBNull(reader.GetOrdinal("longitud")) ? (double?)null : reader.GetDouble("longitud")
                                        );
            }
            return user;
        }

        public static User EncontrarUsuario(int id)
        {
            User user = null;
            string query = "SELECT * FROM users WHERE id_user = @id";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                byte[] ArrImg = reader.IsDBNull(reader.GetOrdinal("image")) ? null : (byte[])reader["image"];

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
                                            reader.IsDBNull(reader.GetOrdinal("image")) ? null : ArrImg,
                                            reader.IsDBNull(reader.GetOrdinal("latitud")) ? (double?)null : reader.GetDouble("latitud"),
                                            reader.IsDBNull(reader.GetOrdinal("longitud")) ? (double?)null : reader.GetDouble("longitud")
                                        );
            }
            reader.Close();
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
                byte[] ArrImg = reader.IsDBNull(reader.GetOrdinal("image")) ? null : (byte[])reader["image"];

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
                                            reader.IsDBNull(reader.GetOrdinal("image")) ? null : ArrImg,
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
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public static bool CompruebaCredencialesUsuario(string email, string password)
        {
            string query = "select password from users where email=@email";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
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
            com.Parameters.AddWithValue("email", u.email);
            int res = int.Parse(com.ExecuteScalar().ToString());
            return res == 1;
        }
        public static DataTable CargarUsuarios()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string consulta = "SELECT id_user, name, email, dni, password, sitter, admin, image FROM users";
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
            try
            {
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

        public static List<User> ObtenerUsuariosCercanos(double? latitudReferencia, double? longitudReferencia, double precioDesde, double precioHasta, int offset, int limit)
        {
            List<User> usuariosCercanos = new List<User>();

            // Consulta SQL parametrizada
            string query = @"
            SELECT *
            FROM users
            WHERE price >= @PrecioDesde AND price <= @PrecioHasta
            ORDER BY SQRT(POW(latitud - @LatitudReferencia, 2) + POW(longitud - @LongitudReferencia, 2)) Limit @Limit OFFSET @Offset";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, ConBD.Conexion))
                {
                    // Parámetros de la consulta
                    command.Parameters.AddWithValue("@LatitudReferencia", latitudReferencia);
                    command.Parameters.AddWithValue("@LongitudReferencia", longitudReferencia);
                    command.Parameters.AddWithValue("@PrecioDesde", precioDesde);
                    command.Parameters.AddWithValue("@PrecioHasta", precioHasta);
                    command.Parameters.AddWithValue("@Limit", limit);
                    command.Parameters.AddWithValue("@Offset", offset);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] ArrImg = reader.IsDBNull(reader.GetOrdinal("image")) ? null : (byte[])reader["image"];
                            User user = new User(
                                    reader.IsDBNull(reader.GetOrdinal("id_user")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("id_user")),
                                    reader.IsDBNull(reader.GetOrdinal("id_google")) ? null : reader.GetString(reader.GetOrdinal("id_google")),
                                    reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString(reader.GetOrdinal("name")),
                                    reader.IsDBNull(reader.GetOrdinal("surname")) ? null : reader.GetString(reader.GetOrdinal("surname")),
                                    reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString(reader.GetOrdinal("email")),
                                    reader.IsDBNull(reader.GetOrdinal("dni")) ? null : reader.GetString(reader.GetOrdinal("dni")),
                                    reader.IsDBNull(reader.GetOrdinal("password")) ? null : reader.GetString(reader.GetOrdinal("password")),
                                    reader.IsDBNull(reader.GetOrdinal("location")) ? null : reader.GetString(reader.GetOrdinal("location")),
                                    reader.IsDBNull(reader.GetOrdinal("premium")) ? (bool?)null : reader.GetBoolean(reader.GetOrdinal("premium")),
                                    reader.IsDBNull(reader.GetOrdinal("sitter")) ? (bool?)null : reader.GetBoolean(reader.GetOrdinal("sitter")),
                                    reader.IsDBNull(reader.GetOrdinal("admin")) ? (bool?)null : reader.GetBoolean(reader.GetOrdinal("admin")),
                                    reader.IsDBNull(reader.GetOrdinal("image")) ? null : ArrImg,
                                    reader.IsDBNull(reader.GetOrdinal("latitud")) ? (double?)null : reader.GetDouble(reader.GetOrdinal("latitud")),
                                    reader.IsDBNull(reader.GetOrdinal("longitud")) ? (double?)null : reader.GetDouble(reader.GetOrdinal("longitud"))
                                    );

                            usuariosCercanos.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener usuarios cercanos: " + ex.Message);
            }

            return usuariosCercanos;
        }

        public static int ContarUsuariosCercanos(double? latitudReferencia, double? longitudReferencia, double precioDesde, double precioHasta)
        {
            int totalUsuarios = 0;

            // Consulta SQL para contar el número de usuarios
            string query = @"
    SELECT COUNT(*)
    FROM users
    WHERE price >= @PrecioDesde AND price <= @PrecioHasta";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, ConBD.Conexion))
                {
                    // Parámetros de la consulta
                    command.Parameters.AddWithValue("@PrecioDesde", precioDesde);
                    command.Parameters.AddWithValue("@PrecioHasta", precioHasta);
                    command.Parameters.AddWithValue("@LatitudReferencia", latitudReferencia);
                    command.Parameters.AddWithValue("@LongitudReferencia", longitudReferencia);

                    totalUsuarios = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al contar usuarios cercanos: " + ex.Message);
            }
            return totalUsuarios;
        }
        public static void ActualizarUsuario(User u)
        {
            try
            {
                string consulta = "UPDATE users SET name = @name, surname = @surname, location = @location, email = @Email, password = @password, image = @image, latitud = @latitud, longitud = @longitud WHERE id_user = @id_user";
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                comando.Parameters.AddWithValue("@name", u.Name);
                comando.Parameters.AddWithValue("@surname", u.Surname);
                comando.Parameters.AddWithValue("@location", u.Location);
                comando.Parameters.AddWithValue("@Email", u.Email);
                comando.Parameters.AddWithValue("@password", u.Password);
                comando.Parameters.AddWithValue("@image", u.Image);
                comando.Parameters.AddWithValue("@id_user", u.IdUser);
                comando.Parameters.AddWithValue("@latitud", u.Latitud);
                comando.Parameters.AddWithValue("@longitud", u.Longitud);
                comando.ExecuteNonQuery();
                Data.CurrentUser = User.EncontrarUsuario((int)u.idUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar tu Perfil", ex.Message);
            }
        }

    }



}
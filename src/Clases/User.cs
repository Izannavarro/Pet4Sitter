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
using System.Runtime.ConstrainedExecution;

namespace pet4sitter.Clases
{
    /// <summary>
    /// La clase User representa un usuario del sistema, incluyendo información como nombre, apellido, correo electrónico, contraseña, etc.
    /// </summary>
    public class User
    {
        private int? idUser;
        private string idGoogle;
        private string name;
        private string surname;
        private string email;
        private string dni;
        private string password;
        private double? precio;
        private string location;
        private bool? premium;
        private bool? sitter;
        private bool? admin;
        private byte[] image;
        private double? latitud;
        private double? longitud;

        // Propiedades
        public string IdGoogle { get { return this.idGoogle; } }
        public string Name { get { return this.name; } }
        public string Surname { get { return surname; } }
        public string Password { get { return password; } }
        public double? Precio { get { return precio; } }
        public string Email { get { return email; } }
        public string Dni { get { return dni; } }
        public string Location { get { return location; } }
        public bool? Premium { get { return this.premium; } }
        public byte[] Image { get { return this.image; } }
        public int? IdUser { get { return this.idUser; } }
        public double? Latitud { get { return this.latitud; } }
        public double? Longitud { get { return this.longitud; } }
        public bool? Sitter { get { return sitter; } }
        public bool? Admin { get { return admin; } }

        // Constructores
        public User() { }
        public User(int? idUser, string idGoogle, string name, string surname, string email, string dni, string password, double? precio, string location, bool? premium, bool? sitter, bool? admin, byte[] image, double? latitud, double? longitud)
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
            this.precio = precio;
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

        // Métodos estáticos
        /// <summary>
        /// Obtiene una lista de usuarios según la consulta SQL especificada.
        /// </summary>
        /// <param name="query">La consulta SQL para seleccionar usuarios.</param>
        /// <returns>Una lista de usuarios.</returns>
        public static List<User> ListarUsuarios(string query)
        {
            // Crea una lista para almacenar usuarios
            List<User> list = new List<User>();

            // Ejecuta la consulta SQL para obtener datos del usuario
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            MySqlDataReader reader = com.ExecuteReader();

            // Lee los resultados de la consulta y agrega usuarios a la lista
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
                    reader.IsDBNull(reader.GetOrdinal("price")) ? (double?)null : reader.GetDouble("price"),
                    reader.IsDBNull(reader.GetOrdinal("location")) ? null : reader.GetString("location"),
                    reader.IsDBNull(reader.GetOrdinal("premium")) ? (bool?)null : reader.GetBoolean("premium"),
                    reader.IsDBNull(reader.GetOrdinal("sitter")) ? (bool?)null : reader.GetBoolean("sitter"),
                    reader.IsDBNull(reader.GetOrdinal("admin")) ? (bool?)null : reader.GetBoolean("admin"),
                    reader.IsDBNull(reader.GetOrdinal("image")) ? null : ArrImg,
                    reader.IsDBNull(reader.GetOrdinal("latitud")) ? (double?)null : reader.GetDouble("latitud"),
                    reader.IsDBNull(reader.GetOrdinal("longitud")) ? (double?)null : reader.GetDouble("longitud")
                ));
            }

            // Cierra el lector de datos y devuelve la lista de usuarios
            reader.Close();
            return list;
        }

        /// <summary>
        /// Busca un usuario por su dirección de correo electrónico en la base de datos.
        /// </summary>
        /// <param name="email">Dirección de correo electrónico del usuario a buscar.</param>
        /// <returns>El usuario encontrado o null si no se encuentra.</returns>
        public static User EncontrarUsuario(string email)
        {
            User user = null;
            string query = "SELECT * FROM users WHERE email = @Email";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("@Email", email);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                byte[] ArrImg = reader.IsDBNull(reader.GetOrdinal("image")) ? null : reader["image"] as byte[];

                user = new User(
                                            reader.IsDBNull(reader.GetOrdinal("id_user")) ? (int?)null : reader.GetInt32("id_user"),
                                            reader.IsDBNull(reader.GetOrdinal("id_google")) ? null : reader.GetString("id_google"),
                                            reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString("name"),
                                            reader.IsDBNull(reader.GetOrdinal("surname")) ? null : reader.GetString("surname"),
                                            reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                                            reader.IsDBNull(reader.GetOrdinal("dni")) ? null : reader.GetString("dni"),
                                            reader.IsDBNull(reader.GetOrdinal("password")) ? null : reader.GetString("password"),
                                            reader.IsDBNull(reader.GetOrdinal("price")) ? (double?)null : reader.GetDouble("price"),
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

        /// <summary>
        /// Busca un usuario por su identificador único en la base de datos.
        /// </summary>
        /// <param name="id">Identificador único del usuario a buscar.</param>
        /// <returns>El usuario encontrado o null si no se encuentra.</returns>
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
                                            reader.IsDBNull(reader.GetOrdinal("price")) ? (double?)null : reader.GetDouble("price"),
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

        /// <summary>
        /// Busca un usuario por su identificador de Google en la base de datos.
        /// </summary>
        /// <param name="idGoogle">Identificador de Google del usuario a buscar.</param>
        /// <returns>El usuario encontrado o un usuario vacío si no se encuentra.</returns>
        public static User EncontrarUsuarioGoogle(string idGoogle)
        {
            User user = new User(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
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
                                            reader.IsDBNull(reader.GetOrdinal("price")) ? (double?)null : reader.GetDouble("price"),
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

        /// <summary>
        /// Registra un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="u">Usuario a registrar.</param>
        /// <returns>El número de filas afectadas en la base de datos.</returns>
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

        /// <summary>
        /// Comprueba si ya existe un usuario con el correo electrónico especificado en la base de datos.
        /// </summary>
        /// <param name="email">Correo electrónico del usuario a comprobar.</param>
        /// <returns>True si el usuario existe, False si no.</returns>
        public static bool CompruebaUsuarioExistente(string email)
        {
            string query = "SELECT COUNT(email) FROM users WHERE email=@email";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("email", email);

            // Ejecuta la consulta y obtiene el resultado como un entero
            int res = int.Parse(com.ExecuteScalar().ToString());

            // Si el resultado es mayor que 0, significa que el usuario existe
            return res > 0;
        }

        /// <summary>
        /// Comprueba si las credenciales de un usuario son válidas.
        /// </summary>
        /// <param name="email">Correo electrónico del usuario.</param>
        /// <param name="password">Contraseña del usuario.</param>
        /// <returns>True si las credenciales son válidas, False si no.</returns>
        public static bool CompruebaCredencialesUsuario(string email, string password)
        {
            string query = "SELECT password FROM users WHERE email=@email";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("email", email);

            // Obtiene el hash de la contraseña almacenada en la base de datos
            string hashContraseñaAlmacenada = com.ExecuteScalar() as string;

            // Verifica si la contraseña proporcionada coincide con la almacenada en la base de datos
            if (hashContraseñaAlmacenada != null && BCrypt.Net.BCrypt.Verify(password, hashContraseñaAlmacenada))
            {
                // La contraseña coincide, devuelve true
                return true;
            }
            else
            {
                // La contraseña no coincide o no se encontró el usuario, devuelve false
                return false;
            }
        }

        /// <summary>
        /// Actualiza la contraseña de un usuario en la base de datos.
        /// </summary>
        /// <param name="email">Correo electrónico del usuario.</param>
        /// <param name="nuevaContraseña">Nueva contraseña a establecer.</param>
        public static void ActualizarContraseña(string email, string nuevaContraseña)
        {
            // Actualiza la contraseña en la base de datos
            string query = "UPDATE users SET password = @nuevaContraseña WHERE email = @email";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("nuevaContraseña", nuevaContraseña);
            com.Parameters.AddWithValue("email", email);
            com.ExecuteNonQuery();
        }


        /// <summary>
        /// Comprueba si ya existe un usuario asociado a un ID de Google en la base de datos.
        /// </summary>
        /// <param name="idGoogle">ID de Google del usuario a comprobar.</param>
        /// <returns>True si el usuario existe, False si no.</returns>
        public static bool CompruebaUsuarioConGoogle(string idGoogle)
        {
            string query = "SELECT COUNT(*) FROM users WHERE id_google=@idGoogle";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("idGoogle", idGoogle);

            int res = int.Parse(com.ExecuteScalar().ToString());

            // Si el resultado es mayor que 0, significa que el usuario con el ID de Google existe
            return res > 0;
        }

        /// <summary>
        /// Comprueba si un usuario tiene una suscripción premium.
        /// </summary>
        /// <param name="u">Usuario a comprobar.</param>
        /// <returns>True si el usuario tiene una suscripción premium, False si no.</returns>
        public static bool CompruebaPremium(User u)
        {
            string query = "SELECT premium FROM users WHERE email=@email";
            MySqlCommand com = new MySqlCommand(query, ConBD.Conexion);
            com.Parameters.AddWithValue("email", u.email);

            int res = int.Parse(com.ExecuteScalar().ToString());

            // Devuelve true si el usuario tiene una suscripción premium (valor 1 en la base de datos)
            return res == 1;
        }

        /// <summary>
        /// Carga información de usuarios desde la base de datos en un DataTable.
        /// </summary>
        /// <returns>DataTable con la información de los usuarios.</returns>
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

        /// <summary>
        /// Elimina un usuario de la base de datos dado su ID.
        /// </summary>
        /// <param name="id">ID del usuario a eliminar.</param>
        public static void EliminarUsuarios(int id)
        {
            try
            {
                string consulta = String.Format("DELETE FROM users WHERE id_user = '{0}'", id);
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar usuario: " + ex.Message);
            }
        }

        /// <summary>
        /// Obtiene una lista de usuarios cercanos según una referencia de latitud y longitud, con opciones de filtro y ordenamiento.
        /// </summary>
        /// <param name="latitudReferencia">Latitud de referencia para calcular la distancia.</param>
        /// <param name="longitudReferencia">Longitud de referencia para calcular la distancia.</param>
        /// <param name="precioDesde">Precio mínimo.</param>
        /// <param name="precioHasta">Precio máximo.</param>
        /// <param name="ordenarPorDistancia">Indica si se debe ordenar por distancia.</param>
        /// <param name="ordenDistanciaOrden">Orden de la distancia (ASC o DESC).</param>
        /// <param name="ordenarPorPrecio">Indica si se debe ordenar por precio.</param>
        /// <param name="ordenPrecioOrden">Orden del precio (ASC o DESC).</param>
        /// <param name="offset">Desplazamiento para paginación.</param>
        /// <param name="limit">Límite de resultados para paginación.</param>
        /// <returns>Una lista de usuarios cercanos que cumplen con los criterios de búsqueda.</returns>
        public static List<User> ObtenerUsuariosCercanos(double? latitudReferencia, double? longitudReferencia,
                                                  double precioDesde, double precioHasta,
                                                  bool ordenarPorDistancia, string ordenDistanciaOrden,
                                                  bool ordenarPorPrecio, string ordenPrecioOrden,
                                                  int offset, int limit)
        {
            List<User> usuariosCercanos = new List<User>();

            // Consulta SQL parametrizada
            string query = @"
    SELECT *
    FROM users
    WHERE price >= @PrecioDesde AND price <= @PrecioHasta AND id_user != @IdUsuario AND sitter = 1";

            // Agregar condiciones de ordenamiento si se requiere
            if (ordenarPorDistancia)
            {
                query += " ORDER BY SQRT(POW(latitud - @LatitudReferencia, 2) + POW(longitud - @LongitudReferencia, 2))";
                query += " " + ordenDistanciaOrden; // Agregar ASC o DESC
            }
            else if (ordenarPorPrecio)
            {
                query += " ORDER BY price";
                query += " " + ordenPrecioOrden; // Agregar ASC o DESC
            }

            // Agregar límite y desplazamiento
            query += " LIMIT @Limit OFFSET @Offset";

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
                    command.Parameters.AddWithValue("@IdUsuario", Data.CurrentUser.idUser);

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
                                    reader.IsDBNull(reader.GetOrdinal("price")) ? (double?)null : reader.GetDouble("price"),
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


        /// <summary>
        /// Cuenta el número de usuarios que cumplen con los criterios de búsqueda cercana.
        /// </summary>
        /// <param name="latitudReferencia">Latitud de referencia para calcular la distancia.</param>
        /// <param name="longitudReferencia">Longitud de referencia para calcular la distancia.</param>
        /// <param name="precioDesde">Precio mínimo.</param>
        /// <param name="precioHasta">Precio máximo.</param>
        /// <returns>El número total de usuarios que cumplen con los criterios de búsqueda cercana.</returns>
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

        /// <summary>
        /// Actualiza la información de un usuario en la base de datos.
        /// </summary>
        /// <param name="u">El objeto User con la información actualizada.</param>
        public static void ActualizarUsuario(User u)
        {
            try
            {
                string consulta = "UPDATE users SET name = @name, surname = @surname, location = @location, email = @Email, password = @password, image = @image, latitud = @latitud, longitud = @longitud, sitter = @sitter WHERE id_user = @id_user";
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                comando.Parameters.AddWithValue("@name", u.Name);
                comando.Parameters.AddWithValue("@surname", u.Surname);
                comando.Parameters.AddWithValue("@location", u.Location);
                comando.Parameters.AddWithValue("@Email", u.Email);
                comando.Parameters.AddWithValue("@password", u.Password);
                comando.Parameters.AddWithValue("@image", u.Image);
                comando.Parameters.AddWithValue("@id_user", u.IdUser);
                comando.Parameters.AddWithValue("@latitud", u.Latitud);
                comando.Parameters.AddWithValue("@sitter", u.Sitter);
                comando.Parameters.AddWithValue("@longitud", u.Longitud);
                comando.ExecuteNonQuery();
                Data.CurrentUser = User.EncontrarUsuario((int)u.idUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar tu Perfil", ex.Message);
            }
        }

        /// <summary>
        /// Activa la cuenta de un usuario como cuidador.
        /// </summary>
        /// <param name="u">El objeto User que representa al usuario a activar como cuidador.</param>
        public static void ActivarCuidador(User u)
        {
            try
            {
                string consulta = "UPDATE users SET sitter = 1, price = @price WHERE id_user = @id_user";
                MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
                comando.Parameters.AddWithValue("@id_user", u.IdUser);
                comando.Parameters.AddWithValue("price", u.Precio);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo convertir tu usuario a Cuidador", ex.Message);
            }
        }
    }
}
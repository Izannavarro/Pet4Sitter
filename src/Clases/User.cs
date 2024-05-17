using MySql.Data.MySqlClient;
using System;
using BCrypt.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piTest.Clases
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

        // Constructor
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


    }
}

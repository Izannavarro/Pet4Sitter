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

        public string IdGoogle { get { return this.idGoogle; } }

        public string Name { get { return this.name; } }

        // Constructor
        public User(int? idUser, string idGoogle, string name, string surname, string email, string dni, string password, string location, bool? premium, bool? sitter, bool? admin, byte[] image)
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
                query += ", id_google)";
                comando.Parameters.AddWithValue("@idGoogle", u.idGoogle);
            }
            else
            {
                query += ")";
            }

            query += " VALUES (@name, @surname, @email, @dni, @password, @location, @sitter";

            // Agregar parámetro idGoogle si es necesario
            if (u.idGoogle != null)
            {
                query += ", @idGoogle";
            }

            query += ");";

            comando.CommandText = query;

            int res = comando.ExecuteNonQuery();

            return res;
        }
    }
}

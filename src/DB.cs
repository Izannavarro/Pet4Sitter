using System;
using MySql.Data.MySqlClient;

public class DB
{
    static string connectionString = "server=127.0.0.1;port=3306;database=pet4sitter;uid=root;password=";

    public static string ConnectionString { get { return connectionString; } }

    public static void SelectAllFromUsers()
    {
        // Establecer la cadena de conexión
        string connectionString = ConnectionString;

        // Crear la conexión
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            // Abrir la conexión
            connection.Open();

            // Consulta SQL
            string query = "SELECT * FROM users";

            // Crear un comando SQL con la consulta y la conexión
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Ejecutar el comando y obtener un lector de datos
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Iterar sobre los resultados y mostrarlos por la terminal
                    while (reader.Read())
                    {
                        // Imprimir cada columna del registro actual
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write($"{reader.GetName(i)}: {reader.GetValue(i)}\t");
                        }
                        Console.WriteLine();
                    }
                }
            }

            // Cerrar la conexión
            connection.Close();
        }
    }
}

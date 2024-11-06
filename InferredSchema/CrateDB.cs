using Microsoft.Data.SqlClient;

namespace PokeApi.InferredSchema
{
    public class CrateDB
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=YOUR_SERVER_NAME;Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crear la base de datos 'pokemon'
                string createDatabaseQuery = @"CREATE DATABASE pokemon;";
                using (SqlCommand command = new SqlCommand(createDatabaseQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Usar la base de datos 'pokemon'
                string useDatabaseQuery = @"USE pokemon;";
                using (SqlCommand command = new SqlCommand(useDatabaseQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Crear la tabla 'tipos'
                string createTiposTableQuery = @"
                CREATE TABLE tipos (
                    id INT PRIMARY KEY,
                    nombre VARCHAR(255) NOT NULL
                );";
                using (SqlCommand command = new SqlCommand(createTiposTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Crear la tabla 'pokemones'
                string createPokemonesTableQuery = @"
                CREATE TABLE pokemones (
                    id INT PRIMARY KEY,
                    nombre VARCHAR(255) NOT NULL,
                    tipo_primario INT NOT NULL,
                    tipo_secundario INT NULL,
                    FOREIGN KEY (tipo_primario) REFERENCES tipos(id),
                    FOREIGN KEY (tipo_secundario) REFERENCES tipos(id)
                );";
                using (SqlCommand command = new SqlCommand(createPokemonesTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Crear la tabla 'entrenadores'
                string createEntrenadoresTableQuery = @"
                CREATE TABLE entrenadores (
                    idEntrenador INT PRIMARY KEY,
                    nombreEntrenador VARCHAR(255) NOT NULL
                );";
                using (SqlCommand command = new SqlCommand(createEntrenadoresTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Crear la tabla 'pokemon_entrenador'
                string createPokemonEntrenadorTableQuery = @"
                CREATE TABLE pokemon_entrenador (
                    idEntrenador INT NOT NULL,
                    idPokemon INT NOT NULL,
                    nivelPokemon INT NOT NULL,
                    hp INT NOT NULL,
                    hp_max INT NOT NULL,
                    ataque INT NOT NULL,
                    defensa INT NOT NULL,
                    ataque_especial INT NOT NULL,
                    defensa_especial INT NOT NULL,
                    velocidad INT NOT NULL,
                    PRIMARY KEY (idEntrenador, idPokemon),
                    FOREIGN KEY (idEntrenador) REFERENCES entrenadores(idEntrenador),
                    FOREIGN KEY (idPokemon) REFERENCES pokemones(id)
                );";
                using (SqlCommand command = new SqlCommand(createPokemonEntrenadorTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Base de datos y tablas creadas exitosamente.");


        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_API.Models
{
    public class MovieContext
    {
        public string ConnectionString {get; set;}

        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieItem> GetAllMovie()
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_movie", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releasedate = reader.GetDateTime("releasedate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> GetMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_movie WHERE id =@id", conn);
                cmd.Parameters.AddWithValue("@id",id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releasedate = reader.GetDateTime("releasedate")
                        });
                    }
                }
            }
            return list;
        }
        public string AddMovie(MovieItem movie)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_movie(name, genre, duration, releasedate) VALUES (@name, @genre, @duration, @releasedate)", conn);
                cmd.Parameters.AddWithValue("@name", movie.name);
                cmd.Parameters.AddWithValue("@genre", movie.genre);
                cmd.Parameters.AddWithValue("@duration", movie.duration);
                cmd.Parameters.AddWithValue("@releasedate", movie.releasedate);

                var response = cmd.ExecuteNonQuery();

                if (response == 1)
                {
                    return "success";
                }
                else
                {
                    return "failed";
                }
            }
        }

        public string UpdateMovie(int id, MovieItem newMovie)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand updt = new MySqlCommand("UPDATE tb_movie SET name=@name,genre=@genre,duration=@duration,releasedate=@releasedate WHERE id=@id", conn);
                updt.Parameters.AddWithValue("@name", newMovie.name);
                updt.Parameters.AddWithValue("@genre", newMovie.genre);
                updt.Parameters.AddWithValue("@duration", newMovie.duration);
                updt.Parameters.AddWithValue("@releasedate", newMovie.releasedate);
                updt.Parameters.AddWithValue("@id", id);
                var response = updt.ExecuteNonQuery();

                if (response == 1)
                {
                    return "success";
                }
                else
                {
                    return "failed";
                }
            }
        }

        public string DeleteMovie(int id) {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand del = new MySqlCommand("DELETE FROM tb_movie WHERE id=@id", conn);
                del.Parameters.AddWithValue("@id", id);
                var response = del.ExecuteNonQuery();

                if (response == 1)
                {
                    return "success";
                }
                else
                {
                    return "failed";
                }
            }
        }

    }
}
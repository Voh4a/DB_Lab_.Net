using DBContex.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContex.Classes
{
    public class MovieContex : IMovieContex
    {
        public MySQL_Connection DB { get; set; }

        public MovieContex()
        {
            DB = new MySQL_Connection();
        }

        public IEnumerable<Movie> GetAll()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Movie", DB.MySqlConnect);
            MySqlDataReader reader = command.ExecuteReader();

            List<Movie> list = new List<Movie>();
            Movie movie;

            while (reader.Read())
            {
                movie = new Movie
                {
                    mID = Convert.ToInt32(reader[0]),
                    Title = Convert.ToString(reader[1]),
                    Year = Convert.ToString(reader[2]),
                    Director = Convert.ToString(reader[3])
                };

                list.Add(movie);
            }

            return list;
        }

        public void Add(Movie movie)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO Movie (title, year, director) VALUES(@title, @year, @director)", DB.MySqlConnect);

            command.Parameters.AddWithValue("@title", movie.Title);
            command.Parameters.AddWithValue("@year", movie.Year);
            command.Parameters.AddWithValue("@director", movie.Director);

            command.ExecuteNonQuery();
        }

        public void Update(Movie movie)
        {
            MySqlCommand command = new MySqlCommand("UPDATE Movie SET title = @title, year = @year, director = @director WHERE mID = @mID", DB.MySqlConnect);

            command.Parameters.AddWithValue("@title", movie.Title);
            command.Parameters.AddWithValue("@year", movie.Year);
            command.Parameters.AddWithValue("@director", movie.Director);
            command.Parameters.AddWithValue("@mID", movie.mID);

            command.ExecuteNonQuery();
        }

        public void Delete(int _mID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM Movie WHERE mID = @mID", DB.MySqlConnect);

            command.Parameters.AddWithValue("@mID", _mID);

            command.ExecuteNonQuery();
        }
    }
}

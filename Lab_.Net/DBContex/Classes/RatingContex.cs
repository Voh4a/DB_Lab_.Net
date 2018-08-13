using DBContex.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContex.Classes
{
    public class RatingContex : IRatingContex
    {
        public MySQL_Connection DB { get; set; }

        public RatingContex()
        {
            DB = new MySQL_Connection();
        }

        public IEnumerable<Rating> GetAll()
        {
            MySqlCommand command = new MySqlCommand("SELECT Rating.rID, Rating.mID, stars, ratingDate, name, title, year, director FROM Rating " +
                "JOIN Reviewer on Reviewer.rID = Rating.rID JOIN Movie on Movie.mID = Rating.mID", DB.MySqlConnect);

            MySqlDataReader reader = command.ExecuteReader();

            List<Rating> list = new List<Rating>();
            Rating rating;

            while (reader.Read())
            {
                rating = new Rating
                {
                    rID = Convert.ToInt32(reader[0]),
                    mID = Convert.ToInt32(reader[1]),
                    Stars = Convert.ToInt32(reader[2]),
                    RatingDate = Convert.ToDateTime(reader[3])
                };
                rating.reviewer.Name = Convert.ToString(reader[4]);
                rating.movie.Title = Convert.ToString(reader[5]);
                rating.movie.Year = Convert.ToString(reader[6]);
                rating.movie.Director = Convert.ToString(reader[7]);

                list.Add(rating);
            }

            return list;
        }

        public void Add(Rating rating)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO Rating VALUES(@rID, @mID, @stars, @ratingDate)", DB.MySqlConnect);

            command.Parameters.AddWithValue("@rID", rating.rID);
            command.Parameters.AddWithValue("@mID", rating.mID);
            command.Parameters.AddWithValue("@stars", rating.Stars);
            command.Parameters.AddWithValue("@ratingDate", rating.RatingDate);

            command.ExecuteNonQuery();
        }

        public void Update(Rating rating)
        {
            MySqlCommand command = new MySqlCommand("UPDATE Rating SET stars = @stars, ratingDate = @ratingDate WHERE rID = @rID AND mID = @mID", DB.MySqlConnect);

            command.Parameters.AddWithValue("@rID", rating.rID);
            command.Parameters.AddWithValue("@mID", rating.mID);
            command.Parameters.AddWithValue("@stars", rating.Stars);
            command.Parameters.AddWithValue("@ratingDate", rating.RatingDate);

            command.ExecuteNonQuery();
        }

        public void Delete(int _rID, int _mID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM Rating WHERE rID = @rID AND mID = @mID", DB.MySqlConnect);

            command.Parameters.AddWithValue("@rID", _rID);
            command.Parameters.AddWithValue("@mID", _mID);

            command.ExecuteNonQuery();
        }
    }
}

using DBContex.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContex.Classes
{
    public class ReviewerContex : IReviewerContex
    {
        public MySQL_Connection DB { get; set; }

        public ReviewerContex()
        {
            DB = new MySQL_Connection();
        }

        public IEnumerable<Reviewer> GetAll()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Reviewer", DB.MySqlConnect);
            MySqlDataReader reader = command.ExecuteReader();

            List<Reviewer> list = new List<Reviewer>();
            Reviewer reviewer;

            while(reader.Read())
            {
                reviewer = new Reviewer
                {
                    rID = Convert.ToInt32(reader[0]),
                    Name = Convert.ToString(reader[1])
                };

                list.Add(reviewer);
            }

            return list;
        }

        public void Add(Reviewer reviewer)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO Reviewer (name) VALUES(@name)", DB.MySqlConnect);

            command.Parameters.AddWithValue("@name", reviewer.Name);

            command.ExecuteNonQuery();
        }

        public void Update(Reviewer reviewer)
        {
            MySqlCommand command = new MySqlCommand("UPDATE Reviewer SET name = @name WHERE rID = @rID", DB.MySqlConnect);

            command.Parameters.AddWithValue("@rID", reviewer.rID);
            command.Parameters.AddWithValue("@name", reviewer.Name);

            command.ExecuteNonQuery();
        }

        public void Delete(int _rID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM Reviewer WHERE rID = @rID", DB.MySqlConnect);

            command.Parameters.AddWithValue("@rID", _rID);

            command.ExecuteNonQuery();
        }
    }
}

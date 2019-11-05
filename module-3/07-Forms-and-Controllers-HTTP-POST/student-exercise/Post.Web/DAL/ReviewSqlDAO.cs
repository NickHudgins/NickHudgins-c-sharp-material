using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();

            string reviewsSql = @"Select * from reviews";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(reviewsSql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reviews.Add(MapRowToReview(reader));
                }
            }
            return reviews;

        }
        private Review MapRowToReview(SqlDataReader reader)
        {
            return new Review()
            {
                Name = Convert.ToString(reader["username"]),
                Stars = Convert.ToInt32(reader["rating"]),
                ReviewTitle = Convert.ToString(reader["review_title"]),
                BookReview = Convert.ToString(reader["review_text"]),
                Date = Convert.ToDateTime(reader["review_date"])
            };
        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public void SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "Insert into reviews values(@username, @stars, @reviewtitle, @bookreview, @date);";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", newReview.Name);
                    cmd.Parameters.AddWithValue("@stars", newReview.Stars);
                    cmd.Parameters.AddWithValue("@reviewtitle", newReview.ReviewTitle);
                    cmd.Parameters.AddWithValue("@bookreview", newReview.BookReview);
                    cmd.Parameters.AddWithValue("@date", newReview.Date);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


    }
}
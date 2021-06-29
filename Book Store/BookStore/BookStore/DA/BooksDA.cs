using BookStore.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BookStore.DA
{

    public class BooksDA
    {
        private IConfiguration configuration;

        public BooksDA(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void Insert()
        {
            string connStr = configuration.GetConnectionString("MyConnStr");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            List<BooksModel> listBooks = null;
            string query = "Select * from tbl_Books";
            SqlCommand cmd = new SqlCommand(query, conn);
        }

        public List<BooksModel> Read()
        {
            string connStr = configuration.GetConnectionString("MyConnStr");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            List<BooksModel> listBooks = null;
            string query = "Select * from tbl_Books";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                listBooks = new List<BooksModel>();
                while (dr.Read())
                {
                    BooksModel bm = new BooksModel();

                    bm.ID = Convert.ToInt16(dr["id"]);
                    bm.BooksName = Convert.ToString(dr["BooksName"]);
                    bm.AuthorID = Convert.ToInt16(dr["AuthorID"]);
                    bm.Price = Convert.ToInt32(dr["Price"]);

                    listBooks.Add(bm);
                }
                listBooks.TrimExcess();
            }
            return listBooks;
        }

        public void UpdateBooks(BooksModel bm)
        {
            //Step #1 - Connect to the DB
            string connStr = configuration.GetConnectionString("MyConnStr");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - Create Command
            string query = "UPDATE tbl_books SET BooksName = @books ,AuthorID = @authorid,Price = @price WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", bm.ID);
            cmd.Parameters.AddWithValue("@books", bm.BooksName);
            cmd.Parameters.AddWithValue("@authorid", bm.AuthorID);
            cmd.Parameters.AddWithValue("@price", bm.Price);


            //Step #3 - Query DB
            cmd.ExecuteNonQuery();

            //Step #4 - Close Connection
            conn.Close();
        }

        public void DeleteBooks(int id)
        {
            try
            {
                //Step #1 - Connect to the DB
                string connStr = configuration.GetConnectionString("MyConnStr");
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                //Step #2 - Create Command
                string query = "DELETE tbl_Books where id = @id ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                //Step #3 - Query DB
                cmd.ExecuteNonQuery();

                //Step #4 - Close Connection
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public BooksModel getBooksByID(int id)
        {
            BooksModel bm = new BooksModel();
            //Step #1 - Connect to the DB
            string connStr = configuration.GetConnectionString("MyConnStr");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step #2 - Create Command
            string query = "select * from tbl_Books where id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            //Step #3 - Query DB
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            bm.BooksName = (reader["BooksName"].ToString());
            bm.AuthorID = reader.GetInt32(2);
            bm.Price = reader.GetInt32(3);
            bm.ID = id;

            //Step #4 - Close Connection
            conn.Close();
            return bm;
        }
    }
}

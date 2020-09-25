using CLCMinesweeperApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CLCMinesweeperApp.Services.Data
{
    public class SecurityDAO
    {
        public bool FindByUser(UserLogin user)
        {

            string connectionString = "Server =.; Database = minesweeperApp; Trusted_Connection = True";
            string query = @"select rtrim(USERNAME) from dbo.Player where USERNAME = " + user.userName;
            bool results = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            if (reader.GetString(7).Equals(user.userName))
                            {
                                results = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return results;


        }

    }
}
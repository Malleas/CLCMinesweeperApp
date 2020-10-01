using CLCMinesweeperApp.Models;
using CLCMinesweeperApp.Services.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CLCMinesweeperApp.Services.Business
{
    public class UserService
    {
        public bool CreateUser(Player player)
        {
            string connectionString = "Server =.; Database = minesweeperApp; Trusted_Connection = True";
            string query = @"insert into dbo.Player(FirstName,LastName,Gender,Age,State,EmailAddress,Username,Password) VALUES (@firstName,@lastName,@gender,@age,@state,@emailAddress,@username,@password)";
            bool results = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                   
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@firstName",player.firstName);
                    command.Parameters.AddWithValue("@lastName", player.lastname);
                    command.Parameters.AddWithValue("@gender", player.gender.ToString());
                    command.Parameters.AddWithValue("@age", int.Parse(player.age));
                    command.Parameters.AddWithValue("@state", player.state.ToString());
                    command.Parameters.AddWithValue("@emailAddress", player.emailAddress);
                    command.Parameters.AddWithValue("@username", player.userName);
                    command.Parameters.AddWithValue("@password", player.password);

                    command.Connection.Open();
                   int x = command.ExecuteNonQuery();
                   if(x < 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        results = true;
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
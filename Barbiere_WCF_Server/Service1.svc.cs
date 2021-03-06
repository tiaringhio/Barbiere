﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Barbiere_WCF_Server {
    public class Service1 : IService1 {
        // When the user tries to register first i have to check that the username chosen is available
        bool IService1.UserChecker(string Utente)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    sqlcon.Open();
                    SqlCommand UserChecker = new SqlCommand("SELECT Utente FROM Clienti Where Utente = @Utente", sqlcon);
                    UserChecker.Parameters.AddWithValue("@Utente", Utente);
                    var result = UserChecker.ExecuteScalar();
                    if (result != null)
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception checkerException)
            {
                Console.WriteLine(checkerException.ToString());
            }
            return false;
        }

        // With this method i add the values in the database, using a stored procedure.
        // I chose to use a stored procedure because it's cleaner and more secure, since
        // i use parameters the code is not vulnerable to SQL Injection
        public string Registration(string Nome, string Cognome, string Utente, string Password, bool Admin)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand UserAdd = new SqlCommand("UserAdd", sqlCon);
                    UserAdd.CommandType = CommandType.StoredProcedure;
                    UserAdd.Parameters.AddWithValue("@Nome", Nome);
                    UserAdd.Parameters.AddWithValue("@Cognome", Cognome);
                    UserAdd.Parameters.AddWithValue("@Utente", Utente);
                    UserAdd.Parameters.AddWithValue("@Password", Password);
                    UserAdd.Parameters.AddWithValue("@Admin", Admin);
                    UserAdd.ExecuteNonQuery();
                }
                return "Success!";
            }
            catch
            {
                return "Error!";
            }
        }

        // This stored procedure checks that user and password exist in the db,
        // after that it checks that the user is admin using a DataReader, returing
        // true or false
        public bool Login(string Utente, string Password)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand LoginChecker = new SqlCommand("LoginChecker", sqlCon);
                    LoginChecker.CommandType = CommandType.StoredProcedure;
                    LoginChecker.Parameters.AddWithValue("@Utente", Utente);
                    LoginChecker.Parameters.AddWithValue("@Password", Password);
                    LoginChecker.ExecuteNonQuery();
                    SqlDataReader myReader = LoginChecker.ExecuteReader(CommandBehavior.CloseConnection);
                    try
                    {
                        while (myReader.Read())
                        {
                            if ((bool) myReader["Admin"])
                                return true;
                        }
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        // This stored procedure adds the booking details received from the form in the database, simple as that
        public string AddBooking(string Utente, DateTime Date, DateTime Time)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand AddBooking = new SqlCommand("AddBooking", sqlCon);
                    AddBooking.CommandType = CommandType.StoredProcedure;
                    AddBooking.Parameters.AddWithValue("@Utente", Utente);
                    AddBooking.Parameters.AddWithValue("@Data", SqlDbType.Date);
                    AddBooking.Parameters["@Data"].Value = Date;
                    AddBooking.Parameters.AddWithValue("@Ora", SqlDbType.DateTime);
                    AddBooking.Parameters["@Ora"].Value = Time;
                    AddBooking.ExecuteNonQuery();
                }
                return "It works!";
            }
            catch
            {
                return "Error!";
            }
        }

        // In this function i use a stored procedure where i update the password given the user that the client inputs.
        public string PasswordRecovery(string Utente, string Password)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand PasswordRecovery = new SqlCommand("PasswordRecovery", sqlCon);
                    PasswordRecovery.CommandType = CommandType.StoredProcedure;
                    PasswordRecovery.Parameters.AddWithValue("@Utente", Utente);
                    PasswordRecovery.Parameters.AddWithValue("@Password", Password);
                    PasswordRecovery.ExecuteNonQuery();
                }
                return "It works!";
            }
            catch
            {
                return "Error!";
            }
        }

        // This function allows the user to change username and password,
        // i used a stored procedure that allows me to check which field is empty,
        // so that the user can change either username or password or both in one simple click.
        public string UserPasswordChange(string Utente, string Password, string oldUtente, string oldPassword)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    sqlcon.Open();
                    using (SqlCommand UserPasswordChange = new SqlCommand("UserPasswordChange", sqlcon))
                    {
                        UserPasswordChange.CommandType = CommandType.StoredProcedure;
                        UserPasswordChange.Parameters.AddWithValue("@Utente", Utente);
                        UserPasswordChange.Parameters.AddWithValue("@Password", Password);
                        UserPasswordChange.Parameters.AddWithValue("@OldUser", oldUtente);
                        UserPasswordChange.Parameters.AddWithValue("@OldPassword", oldPassword);
                        UserPasswordChange.ExecuteNonQuery();
                    }
                }
                return "It Works!";
            }
            catch
            {
                return "Error";
            }
        }
    }
}

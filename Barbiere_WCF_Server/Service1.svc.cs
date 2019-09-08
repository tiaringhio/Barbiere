using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception exce)
            {
                Console.WriteLine(exce.ToString());
            }
            throw new NotImplementedException();
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "Error!";
            }
        }

        // LOGIN
        
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
                    var result = LoginChecker.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool isAdmin { get; set; }
        public bool Admin(string User)
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                sqlCon.Open();
                SqlCommand AdminChecker = new SqlCommand("SELECT Admin FROM Clienti WHERE Utente = @Utente AND @Admin = Admin",sqlCon);
                AdminChecker.Parameters.AddWithValue("@Utente", User);
                AdminChecker.Parameters.AddWithValue("@Admin", isAdmin);
                AdminChecker.ExecuteNonQuery();
                SqlDataReader myReader = AdminChecker.ExecuteReader(CommandBehavior.CloseConnection);
                try
                {
                    if (myReader.Read())
                    {
                        bool adminino = (bool) myReader["Admin"];
                        if (adminino)
                            return true;
                        else
                            return false;
                    }

                }
                catch
                {

                }
            }
            {
                
            }
            throw new NotImplementedException();
        }

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
                return "funziona";
            }
            catch (Exception exc)
            {
                return "errorino";
            }
        }

        // In this function i use a stored procedure where i update the password given the user that the client inputs.
        // The password will be hashed trough EasyEncryption, via the MD5 protocol.
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
        // so that the user can change either username or password or both in one simple click
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
                return "magari va";
            }
            catch
            {
                return "errore";
            }
        }
    }
}

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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 {
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

                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception exce)
            {
                Console.WriteLine(exce.ToString());
            }
            throw new NotImplementedException();
        }

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
            throw new NotImplementedException();
        }

        // LOGIN
        public  bool isAdmin { get; set; }
        public bool Login(string Utente, string Password, bool Admin)
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

                    if (myReader.Read())
                    {
                        bool isAdmin = (bool)myReader["Admin"];
                        
                        if (isAdmin)
                            return true;
                        else
                            return false;     
                    }
                    // If the data is incorrect it means tha either the user or the password are wrong
                }
            }
            catch (Exception gne)
            {
                gne.ToString();
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











        public string PasswordRecovery(string Utente, string Password)
        {
            throw new NotImplementedException();
        }



        public string UserPasswordChange(string Utente, string Password)
        {
            throw new NotImplementedException();
        }


    }
}

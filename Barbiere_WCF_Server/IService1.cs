using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Barbiere_WCF_Server {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1 {
        [OperationContract]
        // FATTO
        string Registration(string Nome, string Cognome, string Utente, string Password, bool Admin);
        [OperationContract]
        // FATTO
        bool UserChecker(string Utente);
        [OperationContract]
        bool Login(string Utente, string Password, bool Admin);
        [OperationContract]
        string AddBooking(string Utente, DateTime Date, DateTime Time);
        [OperationContract]
        // FATTO
        string PasswordRecovery(string Utente, string Password);
        [OperationContract]
        // FATTO
        string UserPasswordChange(string Utente, string Password, string oldUtente, string oldPassword);
    }
}

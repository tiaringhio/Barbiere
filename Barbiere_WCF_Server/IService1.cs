﻿using System;
using System.Collections.Generic;
using System.Data;
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
        string Registration(string Nome, string Cognome, string Utente, string Password, bool Admin);
        [OperationContract]
        bool UserChecker(string Utente);
        [OperationContract]
        bool Login(string Utente, string Password);
        [OperationContract]
        string AddBooking(string Utente, DateTime Date, DateTime Time);
        [OperationContract]
        string PasswordRecovery(string Utente, string Password);
        [OperationContract]
        string UserPasswordChange(string Utente, string Password, string oldUtente, string oldPassword);
    }
}

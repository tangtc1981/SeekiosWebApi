//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServiceWebRole
{
    using System;
    using System.Collections.Generic;
    
    public partial class alertRecipient
    {
        public int idalertRecipient { get; set; }
        public string nameRecipient { get; set; }
        public int alert_idalert { get; set; }
        public string phoneNumber { get; set; }
        public string phoneNumberType { get; set; }
        public string email { get; set; }
        public string emailType { get; set; }
        public System.DateTime dateAlertRecipientCreation { get; set; }
    
        public virtual alert alert { get; set; }
    }
}

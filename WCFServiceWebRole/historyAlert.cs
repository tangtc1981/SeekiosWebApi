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
    
    public partial class historyAlert
    {
        public int idalert { get; set; }
        public string content { get; set; }
        public Nullable<int> mode_idmode { get; set; }
        public string title { get; set; }
        public int alertDefinition_idalertType { get; set; }
        public System.DateTime dateAlertCreation { get; set; }
        public int nbrOfRecipient { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceSeekiosUnitTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class operation
    {
        public int idoperation { get; set; }
        public System.DateTime dateBeginOperation { get; set; }
        public Nullable<System.DateTime> dateEndOperation { get; set; }
        public int user_iduser { get; set; }
        public Nullable<int> seekios_idseekios { get; set; }
        public Nullable<int> mode_idmode { get; set; }
        public int operationType_idoperationType { get; set; }
        public int amount { get; set; }
        public bool isOnSeekios { get; set; }
    
        public virtual user user { get; set; }
    }
}
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
    
    public partial class location
    {
        public int idlocation { get; set; }
        public Nullable<double> longitude { get; set; }
        public Nullable<double> latitude { get; set; }
        public Nullable<double> altitude { get; set; }
        public Nullable<double> accuracy { get; set; }
        public Nullable<System.DateTime> dateLocationCreation { get; set; }
        public Nullable<int> mode_idmode { get; set; }
        public int seekios_idseekios { get; set; }
        public int locationDefinition_idlocationDefinition { get; set; }
    
        public virtual locationDefinition locationDefinition { get; set; }
        public virtual seekiosProduction seekiosProduction { get; set; }
    }
}

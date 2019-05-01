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
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.device = new HashSet<device>();
            this.operation = new HashSet<operation>();
            this.seekios = new HashSet<seekios>();
            this.token = new HashSet<token>();
        }
    
        public int iduser { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public Nullable<int> remainingRequest { get; set; }
        public byte[] userPicture { get; set; }
        public Nullable<bool> isValidate { get; set; }
        public Nullable<int> defaultTheme { get; set; }
        public Nullable<System.DateTime> dateLastConnection { get; set; }
        public string phoneNumber { get; set; }
        public string socialNetworkUserId { get; set; }
        public Nullable<int> socialNetworkType { get; set; }
        public Nullable<System.DateTime> dateCreation { get; set; }
        public string validationToken { get; set; }
        public string resetPasswordToken { get; set; }
        public int countryResources_idcountryResources { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<device> device { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<operation> operation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seekios> seekios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<token> token { get; set; }
    }
}

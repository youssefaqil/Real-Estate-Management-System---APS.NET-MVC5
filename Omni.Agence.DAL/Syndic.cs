//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Omni.Agence.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Syndic
    {
        public Syndic()
        {
            this.Locals = new HashSet<Local>();
        }
    
        public int CodeSynd { get; set; }
        public int NumAdresse { get; set; }
        public string NomSynd { get; set; }
        public string PrenomSynd { get; set; }
        public string TelSynd { get; set; }
        public string CinSynd { get; set; }
        public Nullable<int> Salaire { get; set; }
    
        public virtual Adresse Adresse { get; set; }
        public virtual ICollection<Local> Locals { get; set; }
    }
}

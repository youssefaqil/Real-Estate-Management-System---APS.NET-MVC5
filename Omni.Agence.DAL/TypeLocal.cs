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
    
    public partial class TypeLocal
    {
        public TypeLocal()
        {
            this.Locals = new HashSet<Local>();
        }
    
        public int NumTypeLocal { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Local> Locals { get; set; }
    }
}
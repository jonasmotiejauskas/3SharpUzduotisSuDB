//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3SharpUzduotisSuDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musis
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public System.DateTime Prasidejo { get; set; }
        public Nullable<System.DateTime> Baigesi { get; set; }
    
        public virtual Valstybe Vieta { get; set; }
        public virtual Karas Karas { get; set; }
        public virtual Karvedys Laimetojas { get; set; }
        public virtual MusioDalyvis MusioDalyvis { get; set; }
    }
}

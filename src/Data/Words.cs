//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Words
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Words()
        {
            this.Translations = new HashSet<Translations>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public int App { get; set; }
        public bool Ativo { get; set; }
    
        public virtual Apps Apps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Translations> Translations { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VerificaFirme.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategorieEsclusione
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategorieEsclusione()
        {
            this.Modulo = new HashSet<Modulo>();
            this.ModuloNominativo = new HashSet<ModuloNominativo>();
        }
    
        public string Cod { get; set; }
        public string Descrizione { get; set; }
        public string DescrizioneBreve { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modulo> Modulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModuloNominativo> ModuloNominativo { get; set; }
    }
}

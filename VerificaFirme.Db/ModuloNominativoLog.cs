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
    
    public partial class ModuloNominativoLog
    {
        public int ID { get; set; }
        public int IDModuloNominativo { get; set; }
        public int NumeroRiga { get; set; }
        public string Username { get; set; }
        public System.DateTime DataOraModifica { get; set; }
    
        public virtual ModuloNominativo ModuloNominativo { get; set; }
    }
}

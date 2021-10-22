using System;
namespace bronzetti.christian._5h.docentiAssenti.Models
{
    public class Assenza
    {   
        public DateTime Ora { get; set; }
        public string Classe { get; set; }
        public string DocenteAssente { get; set; }
        public string Sostituto1 { get; set; }
        public string Sostituto2 { get; set; }
        public string Pagamento { get; set; }
        public string Note { get; set; }
        public string Firma { get; set; }
    }
}
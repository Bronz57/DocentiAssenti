using System;
namespace bronzetti.christian._5h.docentiAssenti.Models
{
    public class Assenza
    {   
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Ora { get; set; }
        public string Classe { get; set; }
        public string DocenteAssente { get; set; }
        public string Sostituto1 { get; set; }
        public string Sostituto2 { get; set; }
        public string Pagamento { get; set; }
        public string Note { get; set; }
        public string Firma { get; set; }

        public override string ToString()
        {
            return $"Data: {this.Data}, Docente: {this.DocenteAssente}, Classe: {this.Classe}";
        }
    }
}
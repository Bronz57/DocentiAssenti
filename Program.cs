using System;
using bronzetti.christian._5h.docentiAssenti.Models;
using System.Collections.Generic;
namespace bronzetti.christian._5h.docentiAssenti
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Assenza> assenze = new List<Assenza>();
            Assenza a = new();
            a.Classe = "5H";
            a.DocenteAssente = "Luca Bianchi";
            a.Data = DateTime.Now;

           Assenza b = new();
           b.Classe = "5I";
           b.DocenteAssente = "Luca Rossi";
           b.Data = DateTime.Now;
           assenze.Add(a);
           assenze.Add(b);

           foreach(Assenza x in assenze)
                Console.WriteLine(x);
        }
    }
}

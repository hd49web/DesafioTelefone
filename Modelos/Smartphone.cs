using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTelefone.Modelos
{
    public abstract class Smartphone
    {
        public string Numero {get; set;}
        public string Modelos{get;set;}
        public string Imei{get;set;}
        public string Memoria{get;set;}
        
        public Smartphone(string numero, string Modelo, string imei, string memoria)
        {
            Modelos = Modelo;
            Numero = numero;
            Imei = imei;
            Memoria = memoria;
        }
        public void Ligar()
    {
        Console.WriteLine("Ligando......");
    }
        public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo Ligação ...........");
    }
        public abstract void InstalarAplicativo(string nomeApp) ;
           }
}

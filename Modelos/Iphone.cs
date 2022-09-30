using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTelefone.Modelos
{
    public class Iphone : Smartphone
    {
         public Iphone(string numero, string Modelo, string imei, string memoria) : base(numero, Modelo, imei, memoria)
        {
            Console.WriteLine($"Numero do Telefone: {numero}");
            Console.WriteLine($"Modelo Nokia: {Modelo}");
            Console.WriteLine($"Numero do Imei: {imei}");
            Console.WriteLine($"Quantidade de Memoria :{memoria}");
        }
     
        public override void InstalarAplicativo(string nomeApp) 
        {
              //throw new NotImplementedException();
              Console.WriteLine($"Instalando o Aplicativo do  {nomeApp} no aparelho Iphone");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelularCsharp.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarApp(string nome)
        {
            System.Console.WriteLine($"Instalando o aplicativo {nome} no Iphone ");
        }
    }
}
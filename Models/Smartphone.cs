using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelularCsharp.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            System.Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            System.Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarApp(string nome);
        
    }
}
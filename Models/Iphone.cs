using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public Iphone ()
        {

        }
        public Iphone ( string numero, string modelo, string imei, int memoria ) : base (numero, modelo,  imei, memoria)
        {

        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iniciando processo de instalação de {nomeApp}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1Sabrinaouton
{
    class Program
    {
        static void Main(string[] args)
		{
			double dolar;
			double dolaresenpesos;
			double dolaresenpesosno;
			double dolaroficial;
			double dolarparalelo;
			double euros;
			double pesos;
			Console.Write("Ingrese los Dolares:");
			dolar = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese la cantidad de pesos que desea comprar: ");
			pesos = int.Parse(Console.ReadLine());
			dolaroficial = 230;
			dolarparalelo = 280;
			dolaresenpesos =pesos/dolaroficial;
			dolaresenpesosno = pesos/dolarparalelo;
			euros = pesos / 1.17;
			Console.WriteLine($"con {dolaresenpesos} dolares oficiales se puede comprar:   {pesos} $ ");
			Console.WriteLine($"con {dolaresenpesosno} dolar no oficial se puede comprar:   {pesos} $");
			Console.WriteLine("El total de Pesos en Euros es:  " + euros);

			Console.ReadLine();
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detector
{
    public class Datos
    {
		public void CalcularDistancias()
		{

			float x1, y1, x2, y2;
			double distancia;
			char si = 's';

			while (si == 's')
			{
				//Primera Coordenada.
				Console.WriteLine("Ingresar coordenada del Punto 1");
				Console.WriteLine("coordenada 'X' y presione la tecla 'enter'");
				x1 = float.Parse(Console.ReadLine());

				Console.WriteLine("coordenada 'Y' y presione la tecla 'enter'");
				y1 = float.Parse(Console.ReadLine());
				Console.WriteLine("coordenada: ({0},{1})", x1, y1);

				//Segunda Coordenada.
				Console.WriteLine("Ingresar coordenada del Punto 2");
				Console.WriteLine("coordenada 'X' y presione la tecla 'enter'");
				x2 = float.Parse(Console.ReadLine());

				Console.WriteLine("coordenada 'Y' y presione la tecla 'enter'");
				y2 = float.Parse(Console.ReadLine());
				Console.WriteLine("coordenada: ({0},{1})", x2, y2);

				//Calcular distancia entre los dos puntos.
	   	        distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

				//Imprimir distancia entre las coordenadas ingresadas.
	            Console.WriteLine("La distancia del punto 1 ({0},{1}) y el punto 2 ({2},{3}) es: {4}", x1, y1, x2, y2, Math.Round( distancia,2));
				
				Console.WriteLine("------------------------\n");
				
				Console.WriteLine("¿Desea Calcular otra distancia? presione 's' para continuar ó 'n' para finalizar y salir del programa");
		        
				si = char.Parse(Console.ReadLine());
		        Console.Clear();
		    }
	    }
    }
}

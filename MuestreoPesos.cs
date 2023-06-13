using System;

public class MuestreoPesos
{
	public void programa()
	{
        string caso = "";
        do
        {
            Console.Clear();
            Console.Write("Ingrese la cantidad de personas en el muestreo: ");
            int cantidadPersonas = Convert.ToInt32(Console.ReadLine());
            int contadorNinos = 0;
            int contadorJovenes = 0;
            int contadorAdultos = 0;
            int contadorViejos = 0;
            double sumaPesosNinos = 0;
            double sumaPesosJovenes = 0;
            double sumaPesosAdultos = 0;
            double sumaPesosViejos = 0;
            for (int i = 1; i <= cantidadPersonas; i++)
            {
                Console.Write($"Ingrese la edad de la persona #{i}: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Ingrese el peso de la persona #{i}: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                if (edad >= 0 && edad <= 13)
                {
                    contadorNinos++;
                    sumaPesosNinos += peso;
                }
                else if (edad >= 14 && edad <= 30)
                {
                    contadorJovenes++;
                    sumaPesosJovenes += peso;
                }
                else if (edad >= 31 && edad <= 60)
                {
                    contadorAdultos++;
                    sumaPesosAdultos += peso;
                }
                else if (edad >= 61)
                {
                    contadorViejos++;
                    sumaPesosViejos += peso;
                }
            }
            double promedioPesoNinos = contadorNinos > 0 ? sumaPesosNinos / contadorNinos : 0;
            double promedioPesoJovenes = contadorJovenes > 0 ? sumaPesosJovenes / contadorJovenes : 0;
            double promedioPesoAdultos = contadorAdultos > 0 ? sumaPesosAdultos / contadorAdultos : 0;
            double promedioPesoViejos = contadorViejos > 0 ? sumaPesosViejos / contadorViejos : 0;
            Console.WriteLine($"Cantidad de niños: {contadorNinos}");
            Console.WriteLine($"Cantidad de jóvenes: {contadorJovenes}");
            Console.WriteLine($"Cantidad de adultos: {contadorAdultos}");
            Console.WriteLine($"Cantidad de viejos: {contadorViejos}");
            Console.WriteLine($"Promedio de peso de los niños: {promedioPesoNinos}");
            Console.WriteLine($"Promedio de peso de los jóvenes: {promedioPesoJovenes}");
            Console.WriteLine($"Promedio de peso de los adultos: {promedioPesoAdultos}");
            Console.WriteLine($"Promedio de peso de los viejos: {promedioPesoViejos}");

            Console.WriteLine("¿Desea ingresar de nuevo? s/n");
            caso = Console.ReadLine();
            Console.Clear();
        } while (caso == "s");
        Console.ReadLine();
    }
}
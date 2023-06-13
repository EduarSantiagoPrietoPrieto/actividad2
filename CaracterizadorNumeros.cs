using System;

public class Caracterizador_de_numeros
{
	public void program()
	{
        string caso = "";
        do
        {
            Console.Clear();
            Console.Write("Ingrese la cantidad de números: ");
            int cantidadNumeros = int.Parse(Console.ReadLine());

            int positivos = 0;
            int negativos = 0;
            int neutros = 0;
            int sumaPositivos = 0;
            int sumaNegativos = 0;

            for (int i = 1; i <= cantidadNumeros; i++)
            {
                Console.Write($"Ingrese el número #{i}: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    positivos++;
                    sumaPositivos += numero;
                }
                else if (numero < 0)
                {
                    negativos++;
                    sumaNegativos += numero;
                }
                else
                {
                    neutros++;
                }
            }
            Console.WriteLine($"Cantidad de números positivos: {positivos}");
            Console.WriteLine($"Cantidad de números negativos: {negativos}");
            Console.WriteLine($"Cantidad de números neutros: {neutros}");
            Console.WriteLine($"Sumatoria de números positivos: {sumaPositivos}");
            Console.WriteLine($"Sumatoria de números negativos: {sumaNegativos}");
            Console.WriteLine("¿Desea ingresar de nuevo? s/n");
            caso = Console.ReadLine();
            Console.Clear();
        } while (caso == "s");
    }
}
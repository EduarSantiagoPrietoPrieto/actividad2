using System;

public class Matrices1
{
	public void program()
	{
        string caso = "";
        do
        {
            // Solicitar al usuario el tamaño de los vectores
            Console.Write("Ingrese el tamaño de los vectores: ");
            int tamaño = int.Parse(Console.ReadLine());

            // Crear los arreglos para los vectores
            int[] vector1 = new int[tamaño];
            int[] vector2 = new int[tamaño];

            // Solicitar al usuario los valores del primer vector
            Console.WriteLine("Ingrese los valores del primer vector:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Valor {0}: ", i + 1);
                vector1[i] = int.Parse(Console.ReadLine());
            }

            // Solicitar al usuario los valores del segundo vector
            Console.WriteLine("Ingrese los valores del segundo vector:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Valor {0}: ", i + 1);
                vector2[i] = int.Parse(Console.ReadLine());
            }

            // Calcular el producto punto
            int productoPunto = CalcularProductoPunto(vector1, vector2);

            // Imprimir el resultado
            Console.WriteLine("El producto punto de los vectores es: " + productoPunto);
            Console.WriteLine("¿Desea ingresar de nuevo? s/n");
            caso = Console.ReadLine();
            Console.Clear();
        } while (caso == "s");
    }
    static int CalcularProductoPunto(int[] vector1, int[] vector2)
    {
        if (vector1.Length != vector2.Length)
        {
            throw new ArgumentException("Los vectores deben tener la misma longitud");
        }
        int productoPunto = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            productoPunto += vector1[i] * vector2[i];
        }
        return productoPunto;
    }
}


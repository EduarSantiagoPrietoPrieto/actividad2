using System;

public class Matrices2
{
	public void program()
	{
        string caso = "";
        do
        {
            Console.Clear();
            // Solicitar al usuario el tamaño de la matriz
            Console.Write("Ingrese el número de filas de la matriz: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());
            // Crear la matriz
            int[,] matriz = new int[filas, columnas];
            // Solicitar al usuario si desea llenar la matriz manualmente o aleatoriamente
            Console.WriteLine("¿Cómo desea llenar la matriz?");
            Console.WriteLine("1. Ingresar valores manualmente");
            Console.WriteLine("2. Generar valores aleatorios");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Llenar la matriz manualmente
                LlenarMatrizManualmente(matriz);
            }
            else if (opcion == 2)
            {
                // Llenar la matriz con valores aleatorios
                LlenarMatrizAleatoriamente(matriz);
            }
            else
            {
                Console.WriteLine("Opción inválida. Se generará la matriz con valores aleatorios.");
                LlenarMatrizAleatoriamente(matriz);
            }
            // Encontrar el elemento mínimo
            int minimo = EncontrarElementoMinimo(matriz);
            // Imprimir el resultado
            /*for (int i = 0; i < filas; i++)
            {
                for (int j = 0; i < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }*/
            Console.WriteLine("El elemento mínimo en la matriz es: " + minimo);
            Console.WriteLine("Matriz");
            for (int i = 0; i < filas; i++){
                for(int j = 0; j < columnas; j++){
                    Console.Write(matriz[i, j]+" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("¿Desea ingresar de nuevo? s/n");
            caso = Console.ReadLine();
            Console.Clear();
        } while (caso == "s");
    }

    static void LlenarMatrizManualmente(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        Console.WriteLine("Ingrese los valores de la matriz:");

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write("Valor [{0},{1}]: ", i, j);
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void LlenarMatrizAleatoriamente(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        Random random = new Random();

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = random.Next(100); // Generar un número aleatorio entre 0 y 99
            }
        }
    }

    static int EncontrarElementoMinimo(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int minimo = matriz[0, 0];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] < minimo)
                {
                    minimo = matriz[i, j];
                }
            }
        }

        return minimo;
    }
}
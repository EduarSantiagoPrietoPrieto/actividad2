using System;

public class estacion_climatica
{

    public void iniciar()
	{
        string[] subcadenas;
        do {
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Por favor ingrese los valores maximo y minimo de la siguiente forma 15,20");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Para teminar el ingreso de datos ingrese los valoes de la siguiente forma 0,0");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            string cadena = Console.ReadLine();
            subcadenas = cadena.Split(',');
            foreach (string subcadena in subcadenas)
            {
                Console.WriteLine(subcadena);
            }

        } while (subcadenas[0] != "0" || subcadenas[1] != "0");
	}
}

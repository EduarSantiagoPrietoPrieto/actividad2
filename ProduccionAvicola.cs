using System;

public class ProduccionAvicola
{

    public void iniciar()
	{
		string salir = "n";
        do
        {
            double proceso = 0;
            double calculo = 0;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Por favor digite la cantidad de gallinas");
            double gallinas = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor digite la cantidad de dias");
            double dias = double.Parse(Console.ReadLine());
            for (int i = 1; i <= dias; i++)
            {
                calculo = Math.Pow(gallinas, i);
                calculo = calculo / calcularFactorial(i);
                proceso = proceso + calculo;
            }
            Console.WriteLine("El resultado es: " + (proceso + 1));
            Console.WriteLine("Quieres realizar otra consulta? s/n");
                    salir = Console.ReadLine();
                    if (salir == "S" || salir == "s")
                    {
                        salir = "s";

                    }
                    else if (salir == "n" || salir == "N")
                    {
                        salir = "n";
                    }
                    else
                    {
                        Console.WriteLine("opcion invalida");
                    }
        } while (salir != "n");
    }
	public double calcularFactorial(double numero)
	{
		if (numero == 0)
		{
			return 1;
		}
        else
        {
            return numero * calcularFactorial(numero - 1);
        }
    }
}

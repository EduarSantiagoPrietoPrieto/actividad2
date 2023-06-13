using System;

public class ProduccionSemanal
{
	public void operacion()
	{
        int caso;
		
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
        string salir = "n";
		do
		{
            List<int> list = new List<int>();
            Console.WriteLine("-------------------");
			Console.WriteLine("-------------------");
			for (int i = 0; i < dias.Length; i++)
			{
				Console.WriteLine("Por favor digite la cantidad de unidades producidas el dia " + dias[i]);
				list.Add(int.Parse(Console.ReadLine()));
			}
			caso = this.determinador(list.Sum());
            double res;
            switch (caso)
			{
				case 0:
                    res = list.Sum();
                    res = res*2;
					Console.WriteLine("La cantidad de unidades produccidas es: " + list.Sum());
                    Console.WriteLine("La cantidad de dinero de esta semana es: " + res);
					break;
				case 1:
                    res = list.Sum();
                    res = (res * 2) + (res * 2 * 0.1);
                    Console.WriteLine("La cantidad de unidades produccidas es: " + list.Sum());
                    Console.WriteLine("La cantidad de dinero de esta semana es: " + res);
                    break;
				case 2:
                    res = list.Sum();
                    res = (res * 2) + (res * 2 * 0.12);
                    Console.WriteLine("La cantidad de unidades produccidas es: " + list.Sum());
                    Console.WriteLine("La cantidad de dinero de esta semana es: " + res);
                    break;
				case 3:
                    res = list.Sum();
                    res = (res * 2) + (res * 2 * 0.14);
                    Console.WriteLine("La cantidad de unidades produccidas es: " + list.Sum());
                    Console.WriteLine("La cantidad de dinero de esta semana es: " + res);
                    break;
				case 4:
                    res = list.Sum();
                    res = (res * 2) + (res * 2 * 0.16);
                    Console.WriteLine("La cantidad de unidades produccidas es: " + list.Sum());
                    Console.WriteLine("La cantidad de dinero de esta semana es: " + res);
                    break;
            }
            Console.WriteLine("¿Desea digitar un nuevo empleado s/n?");
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
            Console.Clear();
        } while (salir != "n");
	}
	public int determinador(int res)
	{
		int caso = 0;
		if (res <= 99)
		{
            caso = 0;
        }
		if (res > 99 && res <= 199)
		{
			caso = 1;

        }
        if (res > 199 && res <= 299)
        {
            caso = 2;
        }
        if (res > 299 && res <= 399)
        {
            caso = 3;

        }
        if (res > 400)
        {
            caso = 4;
        }
		return caso;
    }
}

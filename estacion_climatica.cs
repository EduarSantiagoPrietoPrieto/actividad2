public class estacion_climatica
{
    public void iniciar()
    {
        String salir = "n";
        do
        {
            string[] subcadenas;
            List<int> menor = new List<int>();
            List<int> mayor = new List<int>();
            int diasFallidos = 0;
            double promedioFallidos = 0;
            do
            {
                Console.Clear();
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
                do
                {
                    if (subcadenas.Length == 3)
                    {
                        Console.WriteLine("Solo se debe digitar 2 numeros");
                        Console.WriteLine("Digite de nuevo");
                        cadena = Console.ReadLine();
                        subcadenas = cadena.Split(',');
                    }
                } while (subcadenas.Length == 3);
                if (subcadenas[0] == "9" || subcadenas[1] == "9")
                {
                    diasFallidos++;
                }
                int caja1 = Convert.ToInt32(subcadenas[0]); 
                int caja2 = Convert.ToInt32(subcadenas[1]);
                if (caja1 > caja2)
                {
                    int caja3;
                    caja3 = caja1;
                    caja1 = caja2;
                    caja2 = caja3;
                }
                menor.Add(caja1);
                mayor.Add(caja2);
            } while (subcadenas[0] != "0" || subcadenas[1] != "0");
            int res = mayor.Count();
            res = res - 1;
            Console.WriteLine("La cantidad de dias fue:" + res);
            Console.WriteLine("El promedio del mayor " + mayor.Max());
            Console.WriteLine("El promedio del menor " + menor.Max());
            Console.WriteLine("La cantidad de dias fallido fueron:" + diasFallidos);
            if (diasFallidos == 0)
            {
                promedioFallidos = 0;
            }
            else
            {
                promedioFallidos = (double)diasFallidos / (mayor.Count - 1);
            }
            Console.WriteLine("El porcentaje que represento fue: " + promedioFallidos);
            Console.WriteLine("Desea ingresar un nuevo esenario s/n");
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
        } while (salir != "s");
        
    }
}
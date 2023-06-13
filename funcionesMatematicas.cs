
class funcionesMatematicas
{
    public void funciones()
    {
        double numero1;
        double numero2;
        int opc;
        string caso = "";
        string salir = "n";

        do
        {

            Console.WriteLine("Funciones matematicas");
            Console.WriteLine("1 Obtener el valor maximo");
            Console.WriteLine("2 Obtener el valor minimo");
            Console.WriteLine("3 Obtener la potencia");
            Console.WriteLine("4 Obtener la raiz");
            Console.WriteLine("5 Obtener el promedio");
            Console.WriteLine("6 Obtener la distancia");
            Console.WriteLine("7 Obtener el residuo");
            Console.WriteLine("8 Obtener el mayor entero");
            Console.WriteLine("9 Obtener el menor entero");
            Console.WriteLine("10 Obtener la parte decimal");
            Console.WriteLine("11 Salir de funciones matematicas");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Obtener el valor maximo");
                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    double maximo = Math.Max(numero1, numero2);
                    Console.WriteLine("Máximo: " + maximo);

                    break;
                case 2:
                    Console.WriteLine("Obtener el valor minimo");
                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    double minimo = Math.Min(numero1, numero2);
                    Console.WriteLine("Mínimo: " + minimo);

                    break;
                case 3:
                    Console.WriteLine("Obtener la potencia");

                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    Double potencia = Math.Pow(numero1, numero2);
                    Console.WriteLine("Potencia: " + potencia);

                    break;
                case 4:
                    Console.WriteLine("Obtener la raiz");
                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    double raiz = Math.Pow(numero1, 1.0 / numero2);
                    Console.WriteLine("Raíz: " + raiz);

                    break;
                case 5:
                    Console.WriteLine("Obtener el promedio");
                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    double promedio = (numero1 + numero2) / 2.0;
                    Console.WriteLine("Promedio: " + promedio);

                    break;
                case 6:
                    Console.WriteLine("Obtener la distancia");
                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    double distancia = Math.Abs(numero1 - numero2);
                    Console.WriteLine("Distancia: " + distancia);

                    break;
                case 7:
                    Console.WriteLine("Obtener el residuo");
                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    double residuo = numero1 % numero2;
                    Console.WriteLine("Residuo: " + residuo);

                    break;
                case 8:
                    Console.WriteLine("Obtener el mayor entero");
                    Console.WriteLine("Ingrese un numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    double mayorEntero = Math.Ceiling(numero1);
                    Console.WriteLine("Mayor entero: " + mayorEntero);

                    break;
                case 9:
                    Console.WriteLine("Obtener el menor entero");
                    Console.WriteLine("Ingrese un numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    double menorEntero = Math.Floor(numero1);
                    Console.WriteLine("Menor entero: " + menorEntero);

                    break;
                case 10:
                    Console.WriteLine("Obtener la parte decimal");
                    Console.WriteLine("Ingrese un numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    double parteDecimal = numero1 - Math.Truncate(numero1);
                    Console.WriteLine("Parte decimal: " + parteDecimal);
                    break;
                case 11:
                    Console.WriteLine("Seguro que quieres salir? s/n");
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
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;


            }
        } while (salir != "s");



        //Console.Clear();


    }

}
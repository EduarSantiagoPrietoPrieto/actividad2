/*Operaciones Matemáticas, programando la división por cero (este
caso no se puede presentar), el programa debe imprimir resultados con un solo
decimal, utilice un menú de opciones para seleccionar la operación a realizar. El
programa debe solicitarle al usuario si desea repetir el proceso, y no se deben
acumular resultados en las variables.
Entradas
numero1
numero2

Procesos
Suma
Resta
Producto
división

Salidas
numero1
numero2
Suma
Resta
Producto
división

Condiciones
Condicional: numero 2 diferente de 0
Crear un menú de opciones que me seleccione la operación
Las salidas tengan un solo decimal*/


class operacionesMatematicas
{
    public void operaciones()
    {
        string salir = "no";

        int numero2;
        int numero1;
        int resultado;
        int opc;
        do
        {
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("1 Operaciones matematicas");
            Console.WriteLine("1 Sumar");
            Console.WriteLine("2 Restar");
            Console.WriteLine("3 Multiplicar");
            Console.WriteLine("4 Dividir");
            Console.WriteLine("5 salir de Operaciones matematicas");
            Console.WriteLine("Ingrese una opcion");
            Console.WriteLine("__________________________________________________");
            opc = Convert.ToInt32(Console.ReadLine());


            switch (opc)
            {

                case 1:
                    Console.WriteLine("ingrese el primer numero a sumar");
                    numero1 = Convert.ToInt32(Console.ReadLine()); //
                    Console.WriteLine("ingrese el segundo numero a sumar");
                    numero2 = Convert.ToInt32(Console.ReadLine()); //
                    resultado = numero1 + numero2;
                    Console.WriteLine("El resultado de la suma es: " + resultado.ToString("F1"));
                    break;

                case 2:
                    Console.WriteLine("ingrese el primer numero a restar");
                    numero1 = Convert.ToInt32(Console.ReadLine()); //
                    Console.WriteLine("ingrese el segundo numero a restar");
                    numero2 = Convert.ToInt32(Console.ReadLine()); //
                    resultado = numero1 - numero2;
                    Console.WriteLine("El resultado de la resta es: " + resultado.ToString("F1"));
                    break;

                case 3:
                    Console.WriteLine("ingrese el primer numero a multiplicar");
                    numero1 = Convert.ToInt32(Console.ReadLine()); //
                    Console.WriteLine("ingrese el segundo numero a multiplicar");
                    numero2 = Convert.ToInt32(Console.ReadLine()); //
                    resultado = numero1 * numero2;
                    Console.WriteLine("El resultado de la multiplicación es: " + resultado.ToString("F1"));
                    break;

                case 4:
                    Console.WriteLine("ingrese el primer numero a dividir");
                    numero1 = Convert.ToInt32(Console.ReadLine()); //
                    Console.WriteLine("ingrese el segundo numero a dividir");
                    numero2 = Convert.ToInt32(Console.ReadLine()); //
                    if (numero2 == 0)
                    {
                        Console.WriteLine("La división por cero no está definida");
                        break;
                    }
                    else
                    {

                        resultado = numero1 / numero2;
                        Console.WriteLine("El resultado de la division es: " + resultado.ToString("F1"));
                        break;
                    }
                case 5:

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

    }

}


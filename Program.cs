class Program
{
    static async void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("Universidad Ecci");
            Console.WriteLine("Tecnologia en desarrollo informatico");
            Console.WriteLine("Grupo 5AN");
            Console.WriteLine("Soluciones .Net Implementadas");
            Console.WriteLine("1 Operaciones matematicas");
            Console.WriteLine("2 Funciones matematicas");
            Console.WriteLine("3 Validador de respuestas");
            Console.WriteLine("4 Produccion semanal");
            Console.WriteLine("5 Estecion climatica");
            Console.WriteLine("6 Caracterizador de numeros");
            Console.WriteLine("7 Muestreo de pesos");
            Console.WriteLine("8 Produccion avicola");
            Console.WriteLine("9 Sistema de notas universidad ECCI");
            Console.WriteLine("10 Nomina d empleados");
            Console.WriteLine("11 Salir Programa");
            Console.WriteLine("Dijite el numero de solucion a realizar");
            Console.WriteLine("__________________________________________________");


            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:

                    operacionesMatematicas oprMat = new operacionesMatematicas();
                    oprMat.operaciones();

                    break;
                case 2:
                    
                    funcionesMatematicas funMat = new funcionesMatematicas();
                    funMat.funciones();

                    break;
                case 3:
                
                    validadorRespuestas valRes = new validadorRespuestas();
                    valRes.validador();

                    break;
                case 4:
                    
                  Console.WriteLine("Llamando a Conectar de Nequi");
                ConectorNequi conector = new ConectorNequi();
                await conector.Conectar();
                    break;
                case 5:
                    Console.WriteLine("5 Estecion climatica");
                    break;
                case 6:
                    Console.WriteLine("6 Caracterizador de numeros");
                    break;
                case 7:
                    Console.WriteLine("7 Muestreo de pesos");
                    break;
                case 8:
                    Console.WriteLine("8 Produccion avicola");
                    break;
                case 9:
                    Console.WriteLine("9 Sistema de notas universidad ECCI");
                    break;
                case 10:
                    Console.WriteLine("10 Nomina de empleados");
                    break;


            }


        } while (opcion != 11);

    }
}
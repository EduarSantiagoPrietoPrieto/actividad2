using Menu;

class Program
{
    static void Main()
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
            Console.WriteLine("5 Estacion climatica");
            Console.WriteLine("6 Caracterizador de numeros");
            Console.WriteLine("7 Muestreo de pesos");
            Console.WriteLine("8 Produccion avicola");
            Console.WriteLine("9 Sistema de notas universidad ECCI");
            Console.WriteLine("10 Nomina d empleados");
            Console.WriteLine("11 Calculadora de producto de matrices ");
            Console.WriteLine("12 Crear matrices nxn");
            Console.WriteLine("13 Salir Programa");
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
                    ProduccionSemanal res = new ProduccionSemanal();
                    res.operacion();
                    break;
                case 5:
                    estacion_climatica apl = new estacion_climatica();
                    apl.iniciar();
                    break;
                case 6:
                    Caracterizador_de_numeros ppp = new Caracterizador_de_numeros();
                    ppp.program();
                    break;
                case 7:
                    MuestreoPesos pp = new MuestreoPesos();
                    pp.programa();
                    break;
                case 8:
                    ProduccionAvicola xml = new ProduccionAvicola();
                    xml.iniciar();
                    break;
                case 9:
                    Console.WriteLine("9 Sistema de notas universidad ECCI");
                    sistemaDeEvaluacion sisEval = new sistemaDeEvaluacion();
                    sisEval.programa();
                    break;
                case 10:
                    nomina pk = new nomina();
                    pk.programa();
                    break;
                case 11:
                    Matrices1 q = new Matrices1();
                    q.program();
                    break;
                case 12:
                    Matrices2 qq = new Matrices2();
                    qq.program();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        } while (opcion != 13);

    }
}

class sistemaDeEvaluacion
{
    public void programa()
    {
        //Definir Dos Vectores materia y estudiante vacios
        String[] materia;
        String[] estudiante;
        //Definir una Matriz de Notas Vacia
        double[,] notas;
        //definir el numero de estudiantes y de materias
        int materias, estudiantes;
        String salir = "s";
        while (salir.ToLower() == "s")
        {
            Console.Clear();
            Console.WriteLine("Sistema de notas universidad ECCI");
            Console.WriteLine("Universidad Ecci");
            Console.WriteLine("Tecnologia en Desarrollo Informatico");
            Console.WriteLine("Grupo 5AN");
            Console.WriteLine("Sistema de Calificaciones");
            //Entradas
            Console.WriteLine("Digite el Numero de Materias");
            materias = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite el Numero de Estudiantes");
            estudiantes = Convert.ToInt16(Console.ReadLine());
            //Dimensionar Vector materia con el numero de materias a Insertar
            materia = new String[materias];
            //Dimensionar Vector estudiantes con el numero de estudiantes a Insertar
            estudiante = new String[estudiantes];
            //Dimensionar Matriz de Notas con filas:No. materias, columnas: No.estudiantes
            notas = new double[materias, estudiantes];
            //Carga del vector con los nombres de las materias
            for (int i = 0; i < materia.Length; i++)
            {
                Console.WriteLine("Digite el Nombre de la Materia No. " + i + "=");
                materia[i] = Console.ReadLine();
            }
            //Carga del vector con las cedulas de los estudiantes
            for (int j = 0; j < estudiante.Length; j++)
            {
                Console.WriteLine("Digite la cedula del estudiante No. " + j + "=");
                estudiante[j] = Console.ReadLine();
            }
            //Carga de la matriz de notas(estudiantes y materias) 
            for (int i = 0; i < materia.Length; i++)
            {
                for (int j = 0; j < estudiante.Length; j++)
                {
                    Console.WriteLine("Digite la nota de " + materia[i] +
                    " de " + estudiante[j] + "=");
                    notas[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            //Muestra el vector con las materias
            Console.WriteLine("Materias Cargadas en el Sistema");
            for (int i = 0; i < materia.Length; i++)
            {
                Console.WriteLine(materia[i]);
            }
            //Muestra el vector con las materias
            Console.WriteLine("Materias Cargadas en el Sistema");
            for (int j = 0; j < estudiante.Length; j++)
            {
                Console.WriteLine(estudiante[j]);
            }
            //Carga de la matriz de notas(estudiantes y materias) 
            Console.WriteLine("Matriz de Notas Cargadas en el Sistema");
            for (int i = 0; i < materia.Length; i++)
            {
                for (int j = 0; j < estudiante.Length; j++)
                {
                    Console.Write(notas[i, j] + "    ");
                }
                Console.WriteLine();
            }
            //Procesos
            double suma = 0, promedio = 0;
            //Matriz de Notas
            Console.WriteLine("Materias Cargadas en el Sistema");
            for (int i = 0; i < materia.Length; i++)
            {
                for (int j = 0; j < estudiante.Length; j++)
                {
                    suma = suma + notas[i, j];
                }
                promedio = suma / estudiantes;
                Console.WriteLine("Promedio de " + materia[i] + "=" + promedio);
                suma = 0;
                promedio = 0;
            }
            //promedio por estudiante 
            for (int i = 0; i < estudiante.Length; i++)
            {
                for (int j = 0; j < materia.Length; j++)
                {
                    suma = suma + notas[j, i];
                }
                promedio = suma / estudiantes;
                Console.WriteLine("Promedio de " + estudiante[i] + "=" + promedio.ToString("F1"));
                suma = 0;
                promedio = 0;
            }
            //Procesos


            Console.WriteLine("Desea Repetir la Ejecucion del Programa s / n");
            salir = Console.ReadLine();
            if (salir.ToLower() != "s" && salir.ToLower() != "n")
            {
                Console.WriteLine("Opción inválida. Saliendo del programa.");
                break;
            }
            Console.Clear();
        }//Cierre del While


    }
}


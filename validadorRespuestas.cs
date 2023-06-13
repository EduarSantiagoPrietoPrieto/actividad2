/*Elaborar una aplicación C Sharp que solicite el número de
respuestas correctas, incorrectas y en blanco, correspondientes a postulantes, y
muestre su puntaje final considerando, que por cada respuesta correcta tendrá 4
puntos, respuestas incorrectas tendrá -1 y respuestas en blanco tendrá 0.*/

class validadorRespuestas
{

    public void validador()
    {
        int respuestasCorrecttas;
        int respuestasIncorrecttas;
        int respuestasEnBlanco;
        int puntajeFinal;
        string salir ="s", nombre ;
        do
        {
            Console.WriteLine("Validador de respuestas");
            Console.WriteLine("Escribe el nombre del postulante");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de respuestas correctas");
            respuestasCorrecttas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de respuestas incorrectas");
            respuestasIncorrecttas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de respuestas en blanco");
            respuestasEnBlanco = Convert.ToInt32(Console.ReadLine());
            puntajeFinal = respuestasCorrecttas * 4 + respuestasIncorrecttas * -1 + respuestasEnBlanco * 0;
            Console.WriteLine("El puntaje final del postulante " + nombre + " es de " + puntajeFinal);
            Console.WriteLine("Desea realizar otra validacion (s = si) (n = no)");
            salir = Console.ReadLine(); //
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
}   
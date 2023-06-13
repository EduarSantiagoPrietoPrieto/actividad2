using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class nomina
    {
        public void programa()
        {
            //Este programa elabora la nomnia de empleados de la Universidad Ecci
            //Variables de Identificacion del Empleado o de entrada
            String tipo_documento, numero, nombre;
            int salario, dias, hed, hen, hefd, hefn;
            //Variables de Salarios Devengados por el empleado o proceso
            int auxilio_transporte, sueldo, recargo_nocturno;
            double vhed, vhen, vhefd, vhefn, total_devengado;
            //Variables de Salarios Deducidos por el empleado o proceso
            double salud, pension, prestamos, fondo_solidaridad;
            double total_deducido, neto_pagado;
            //Variables de entrada
            string salir = "s";
            while (salir.ToLower() == "s")
            {
                Console.Clear();
                Console.WriteLine("Universidad Ecci");
                Console.WriteLine("Tecnologia en Desarrollo Informatico");
                Console.WriteLine("Grupo 5AN");
                Console.WriteLine("Nomina de Empleados Universidad Ecci");
                Console.WriteLine("Digite el tipo de Documento del Empleado CC, CE, PSP:");
                tipo_documento = Console.ReadLine();
                Console.WriteLine("Digite el Numero de Documento del Empleado:");
                numero = Console.ReadLine();
                Console.WriteLine("Digite el Nombre Completo del Empleado:");
                nombre = Console.ReadLine();
                Console.WriteLine("Digite el salario del Empleado = ");
                salario = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite los dias laborados por el Empleado = ");
                dias = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite las horas extras diurnas laboradas por el Empleado = ");
                hed = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite las horas extras nocturnas laboradas por el Empleado = ");
                hen = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite las horas extras festivas diurnas laboradas por el Empleado = ");
                hefd = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite las horas extras festivas nocturnas laboradas por el Empleado = ");
                hefn = int.Parse(Console.ReadLine());
                //Variables de Proceso
                //Devengado
                auxilio_transporte = 140606 / 30 * dias;
                sueldo = salario / 30 * dias;
                Console.WriteLine("el empleado tiene recargo nocturno s / n");
                String recargo = Console.ReadLine();
                if (recargo == "s")
                    recargo_nocturno = salario * 35 / 100;
                else
                    recargo_nocturno = 0;
                vhed = salario / 240 * 1.25;
                vhen = salario / 240 * 1.75;
                vhefd = salario / 240 * 2;
                vhefn = salario / 240 * 2.25;
                total_devengado = auxilio_transporte + sueldo
                + recargo_nocturno + vhed + vhefd + vhefn + vhefn;
                //Deducido
                salud = (total_devengado - auxilio_transporte) * 4 / 100;
                pension = (total_devengado - auxilio_transporte) * 4 / 100;
                if (salario >= 1160000 && salario <= 2320000)
                    prestamos = salario * 10 / 100;
                else if (salario > 2320000 && salario <= 5800000)
                    prestamos = salario * 5 / 100;
                else
                    prestamos = salario * 1 / 100;

                if (salario >= 49600000 && salario <= 18560000)
                    fondo_solidaridad = salario * 1 / 100;
                else if (salario > 18560000 && salario <= 19720000)
                    fondo_solidaridad = salario * 1.2 / 100;
                else if (salario > 19720000 && salario <= 20880000)
                    fondo_solidaridad = salario * 1.4 / 100;
                else if (salario > 20880000 && salario <= 22040000)
                    fondo_solidaridad = salario * 1.6 / 100;
                else if (salario > 22040000 && salario <= 23200000)
                    fondo_solidaridad = salario * 1.8 / 100;
                else if (salario > 23200000)
                    fondo_solidaridad = salario * 2 / 100;
                else
                    fondo_solidaridad = 0;

                total_deducido = salud + pension + prestamos + fondo_solidaridad;
                neto_pagado = total_devengado - total_deducido;
                //Salidas
                Console.Clear();
                Console.WriteLine("Universidad Ecci");
                Console.WriteLine("Tecnologia en Desarrollo Informatico");
                Console.WriteLine("Grupo 5AN");
                Console.WriteLine("Nomina de Empleados Universidad Ecci");
                Console.WriteLine("Informacion del Empleado");
                Console.WriteLine("Tipo de Documento:" + tipo_documento);
                Console.WriteLine("Tipo de Documento:" + numero);
                Console.WriteLine("Nombre del Empleado:" + nombre);
                Console.WriteLine("Salario del Empleado:" + salario);
                Console.WriteLine("Dias Laborados por el Empleado = " + dias);
                Console.WriteLine("Horas extras Diurnas= " + hed);
                Console.WriteLine("Horas extras Nocturnas= " + hen);
                Console.WriteLine("Horas extras Festivas Diurnas= " + hefd);
                Console.WriteLine("Horas extras Festivas Nocturnas= " + hefn);
                Console.WriteLine("Salarios Devengados por el Empleado");
                Console.WriteLine("Sueldo= " + sueldo);
                Console.WriteLine("Auxilio de Transporte= " + auxilio_transporte);
                Console.WriteLine("Recargo Nocturno = " + recargo_nocturno);
                Console.WriteLine("Valor Horas extras Diurnas= " + vhed);
                Console.WriteLine("Valor Horas extras Nocturnas= " + vhen);
                Console.WriteLine("Valor Horas extras Festivas Diurnas= " + vhefd);
                Console.WriteLine("Valor Horas extras Festivas Nocturnas= " + vhefn);
                Console.WriteLine("Total Devengado = " + total_devengado);
                Console.WriteLine("Salarios Deducidos para el Empleado");
                Console.WriteLine("Salud = " + salud);
                Console.WriteLine("Pension = " + pension);
                Console.WriteLine("Prestamos = " + prestamos);
                Console.WriteLine("Fondo de Solidaridad = " + fondo_solidaridad);
                Console.WriteLine("Total Deducido = " + total_deducido);
                Console.WriteLine("Neto Pagado = " + neto_pagado);
                Console.WriteLine("Desea Liquidar otro empleado s / n");
                salir = Console.ReadLine();
                if (salir.ToLower() != "s" && salir.ToLower() != "n")
                {
                    Console.WriteLine("Opción inválida. Saliendo del programa.");
                    break;
                }

            }//Cierre del While




        }
    }
}

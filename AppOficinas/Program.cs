using System;

namespace AppOficinas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean 3 instancias, un objeto para cada sala
            Sala objSala1 = new Sala();
            Sala objSala2 = new Sala();
            Sala objSala3 = new Sala();
            string opcion;
            //Se rellena la primera fila del Array, así se asignan los dias
            objSala1.rellenar();
            objSala2.rellenar();
            objSala3.rellenar();
            //Inicio, se creó un bucle para estar agendando las reuniones
            do
            {
                Console.Clear();
                Console.WriteLine("♦♦♦♦♦♦♦♦♦ SALA DE JUNTAS ♦♦♦♦♦♦♦♦♦\n");
                Console.WriteLine("Indica la sala que deseas rentar:");
                Console.WriteLine("1)Sala1 \n2)Sala2 \n3)Sala3");
                Console.Write("► ");
                opcion = Console.ReadLine().ToUpper();
                switch (opcion)
                {
                    case "1":
                        {
                            do
                            {
                                Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦ SALA 1 ♦♦♦♦♦♦♦♦♦♦♦♦");
                                Console.Write("► Indique el nombre de la empresa: ");
                                objSala1.NOMBRE_EMPRESA = Console.ReadLine();
                                //----------------------------------------------------------------------------
                                Console.WriteLine("Indica el dia que deseas agendar: ");
                                Console.WriteLine("1.lunes\n2.Martes\n3.Miercoles\n4.Jueves\n5.Viernes\n6.Sabado\n7.Domingo");
                                Console.Write("► ");
                                int dia= int.Parse(Console.ReadLine());
                                //se resta 1 porque la posicion del array inicia en 0
                                objSala1.DIA = dia - 1;
                                //la condición impide agenfar en un dommingo
                                if (objSala1.DIA == 6)
                                { Console.WriteLine("¡Este dia no hay servicio!"); }
                            } while (objSala1.DIA == 6);
                            //Se llama el metodo para agendar el día
                            objSala1.Agendar_dia();
                            //--------------------------------------------------------------------------------
                            int hora_mod, hra;
                            Console.WriteLine("►Indique la hora que iniciará su reunión: ");
                            Console.Write("► ");

                            do
                            {
                                hra = int.Parse(Console.ReadLine());
                                //Se modifica la hora por la posición de los arrays
                                hora_mod = objSala1.modificar_hora(hra);

                                if (objSala1.Agenda_sala[objSala1.DIA, hora_mod] != "¡sala ocupada!")
                                {
                                    //Este if impide agendar donde ya está ocupada
                                    objSala1.HORA = hora_mod;
                                    objSala1.agendar_hora();
                                    
                                }
                                else
                                {
                                    Console.WriteLine("¡Esa hora ya está ocupada! \n►Elije otra:");
                                }
                                //con el bucle permitirá agregar otra hora que esté disponible
                            } while (objSala1.Agenda_sala[objSala1.DIA, hora_mod] != "¡sala ocupada!");

                            //---------------------------------------------------------------------------------
                            int tiempo_reunion;
                            do
                            {
                                Console.WriteLine("►Indica la duración de la reunión: ");
                                Console.WriteLine("1 hora\n2 horas\n3 horas");
                                tiempo_reunion = int.Parse(Console.ReadLine());
                                //Se utilizó una condición para evitar que se agenden reuniones fuera del horario de trabajo
                                if (hra == 19 && tiempo_reunion > 1)
                                {
                                    Console.WriteLine("¡Tu reunión solo puede durar 1 hora!");
                                }
                            } while (hra == 19 && tiempo_reunion > 1);
                            //se guardan los datos y se agendan las horas en la sala segun la duración
                            objSala1.DURACION = tiempo_reunion;
                            objSala1.Duracion_de_reunion();
                            Console.WriteLine("¡Reunion agendada con exito!");
                            Console.ReadKey();

                        }
                        break;
                    case "2":
                        {
                            do
                            {
                                Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦ SALA 2 ♦♦♦♦♦♦♦♦♦♦♦♦");
                                Console.Write("► Indique el nombre de la empresa: ");
                                objSala1.NOMBRE_EMPRESA = Console.ReadLine();
                                //----------------------------------------------------------------------------
                                Console.WriteLine("Indica el dia que deseas agendar: ");
                                Console.WriteLine("1.lunes\n2.Martes\n3.Miercoles\n4.Jueves\n5.Viernes\n6.Sabado\n7.Domingo");
                                Console.Write("► ");
                                int dia = int.Parse(Console.ReadLine());
                                //se resta 1 porque la posicion del array inicia en 0
                                objSala2.DIA = dia - 1;
                                //la condición impide agenfar en un dommingo
                                if (objSala2.DIA == 6)
                                { Console.WriteLine("¡Este dia no hay servicio!"); }
                            } while (objSala2.DIA == 6);
                            //Se llama el metodo para agendar el día
                            objSala2.Agendar_dia();
                            //--------------------------------------------------------------------------------
                            int hora_mod, hra;
                            Console.WriteLine("►Indique la hora que iniciará su reunión: ");
                            Console.Write("► ");

                            do
                            {
                                hra = int.Parse(Console.ReadLine());
                                //Se modifica la hora por la posición de los arrays
                                hora_mod = objSala2.modificar_hora(hra);

                                if (objSala2.Agenda_sala[objSala2.DIA, hora_mod] != "¡sala ocupada!")
                                {
                                    //Este if impide agendar donde ya está ocupada
                                    objSala2.HORA = hora_mod;
                                    objSala2.agendar_hora();

                                }
                                else
                                {
                                    Console.WriteLine("¡Esa hora ya está ocupada! \n►Elije otra:");
                                }
                                //con el bucle permitirá agregar otra hora que esté disponible
                            } while (objSala2.Agenda_sala[objSala2.DIA, hora_mod] != "¡sala ocupada!");

                            //---------------------------------------------------------------------------------
                            int tiempo_reunion;
                            do
                            {
                                Console.WriteLine("►Indica la duración de la reunión: ");
                                Console.WriteLine("1 hora\n2 horas\n3 horas");
                                tiempo_reunion = int.Parse(Console.ReadLine());
                                //Se utilizó una condición para evitar que se agenden reuniones fuera del horario de trabajo
                                if (hra == 19 && tiempo_reunion > 1)
                                {
                                    Console.WriteLine("¡Tu reunión solo puede durar 1 hora!");
                                }
                            } while (hra == 19 && tiempo_reunion > 1);
                            //se guardan los datos y se agendan las horas en la sala segun la duración
                            objSala2.DURACION = tiempo_reunion;
                            objSala2.Duracion_de_reunion();
                            Console.WriteLine("¡Reunion agendada con exito!");
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        {
                            do
                            {
                                Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦ SALA 3 ♦♦♦♦♦♦♦♦♦♦♦♦");
                                Console.Write("► Indique el nombre de la empresa: ");
                                objSala3.NOMBRE_EMPRESA = Console.ReadLine();
                                //----------------------------------------------------------------------------
                                Console.WriteLine("Indica el dia que deseas agendar: ");
                                Console.WriteLine("1.lunes\n2.Martes\n3.Miercoles\n4.Jueves\n5.Viernes\n6.Sabado\n7.Domingo");
                                Console.Write("► ");
                                int dia = int.Parse(Console.ReadLine());
                                //se resta 1 porque la posicion del array inicia en 0
                                objSala3.DIA = dia - 1;
                                //la condición impide agenfar en un dommingo
                                if (objSala3.DIA == 6)
                                { Console.WriteLine("¡Este dia no hay servicio!"); }
                            } while (objSala3.DIA == 6);
                            //Se llama el metodo para agendar el día
                            objSala3.Agendar_dia();
                            //--------------------------------------------------------------------------------
                            int hora_mod, hra;
                            Console.WriteLine("►Indique la hora que iniciará su reunión: ");
                            Console.Write("► ");

                            do
                            {
                                hra = int.Parse(Console.ReadLine());
                                //Se modifica la hora por la posición de los arrays
                                hora_mod = objSala3.modificar_hora(hra);

                                if (objSala3.Agenda_sala[objSala3.DIA, hora_mod] != "¡sala ocupada!")
                                {
                                    //Este if impide agendar donde ya está ocupada
                                    objSala3.HORA = hora_mod;
                                    objSala3.agendar_hora();

                                }
                                else
                                {
                                    Console.WriteLine("¡Esa hora ya está ocupada! \n►Elije otra:");
                                }
                                //con el bucle permitirá agregar otra hora que esté disponible
                            } while (objSala3.Agenda_sala[objSala3.DIA, hora_mod] != "¡sala ocupada!");

                            //---------------------------------------------------------------------------------
                            int tiempo_reunion;
                            do
                            {
                                Console.WriteLine("►Indica la duración de la reunión: ");
                                Console.WriteLine("1 hora\n2 horas\n3 horas");
                                tiempo_reunion = int.Parse(Console.ReadLine());
                                //Se utilizó una condición para evitar que se agenden reuniones fuera del horario de trabajo
                                if (hra == 19 && tiempo_reunion > 1)
                                {
                                    Console.WriteLine("¡Tu reunión solo puede durar 1 hora!");
                                }
                            } while (hra == 19 && tiempo_reunion > 1);
                            //se guardan los datos y se agendan las horas en la sala segun la duración
                            objSala3.DURACION = tiempo_reunion;
                            objSala3.Duracion_de_reunion();
                            Console.WriteLine("¡Reunion agendada con exito!");
                            Console.ReadKey();
                        }
                        break;
                    case "REPORTE":
                        {
                            Console.Clear();
                            //Se muestra el reporte de las salas por separado
                            //se muestra el dia,los horarios y se indica los horarios ocupados.
                            Console.WriteLine("♦♦♦♦ HORARIO DE SALAS ♦♦♦♦");
                            Console.WriteLine("-------- Sala 1 --------");
                            //se recorre el array para conocer su contenido y asi conocer su reporte
                            for (int dias = 0; dias < 6; dias++)
                            {
                                int horario = 9;
                                for (int horas = 1; horas < 12; horas++)
                                {
                                    
                                    Console.WriteLine($"DIA: {objSala1.Agenda_sala[dias,0]} Hora:{horario} : {objSala1.Agenda_sala[dias,horas]}");
                                    horario++;
                                }
                                Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                            }
                            Console.WriteLine("-------- Sala 2 --------");
                            //se recorre el array para conocer su contenido y asi conocer su reporte
                            for (int dias = 0; dias < 6; dias++)
                            {
                                //se creó esta variable para indicar cada hora de la sala 
                                int horario = 9;
                                for (int horas = 1; horas < 12; horas++)
                                {

                                    Console.WriteLine($"DIA: {objSala2.Agenda_sala[dias, 0]} Hora:{horario} : {objSala2.Agenda_sala[dias, horas]}");
                                    horario++;
                                }
                                Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                            }
                            Console.WriteLine("-------- Sala 3 --------");
                            //se recorre el array para conocer su contenido y asi conocer su reporte
                            for (int dias = 0; dias < 6; dias++)
                            {
                                int horario = 9;
                                for (int horas = 1; horas < 12; horas++)
                                {

                                    Console.WriteLine($"DIA: {objSala3.Agenda_sala[dias, 0]} Hora:{horario} : {objSala3.Agenda_sala[dias, horas]}");
                                    horario++;
                                }
                                Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                            }
                            Console.ReadKey();

                        }
                        break;
                    
                }
                Console.WriteLine();
            } while (opcion!="SALIR");
        }
    }
}

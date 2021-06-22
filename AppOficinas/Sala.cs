using System;
using System.Collections.Generic;
using System.Text;

namespace AppOficinas
{
    class Sala
    {
        //Atributos
        int dia;
        int hora,duracion;
        string nombre_empresa;
        //Propiedades
        public int DIA
        {
            set { this.dia = value; }
            get { return this.dia; }
        }
        public string NOMBRE_EMPRESA
        {
            set { this.nombre_empresa = value; }
            get { return this.nombre_empresa; }
        }
        public int HORA
        {
            set { this.hora = value; }
            get { return this.hora; }
        }
        public int DURACION
        {
            set { this.duracion = value; }
            get { return this.duracion; }
        }
        //Array
        //Se creó el array de dos dimensiones para guardar los dias y las horas
        public string[,] Agenda_sala = new string[6,12];
        //se creó un método para rellenar parte del array
        public void rellenar()
        {
            for(int i = 0; i < 6; i++)
            {
                for(int j = 1; j <= 11; j++)
                {
                    Agenda_sala[i, j] = "";
                }
            }
            //se rellenan los dias de trabajo
            Agenda_sala[0, 0] = "Lunes";
            Agenda_sala[1, 0] = "Martes";
            Agenda_sala[2, 0] = "Miercoles";
            Agenda_sala[3, 0] = "Jueves";
            Agenda_sala[4, 0] = "Viernes";
            Agenda_sala[5, 0] = "Sabado";

        }

        
        //Método para asignar el día
        public void Agendar_dia()
        {
            switch (DIA)
            {
                //Se resta 1 al dia porque las posiciones del array inician en 0
                case 1:  { Agenda_sala[dia-1, 0] = "Lunes"; }break;
                case 2: { Agenda_sala[dia-1, 0] = "Martes"; } break;
                case 3: { Agenda_sala[dia-1, 0] = "Miercoles"; } break;
                case 4: { Agenda_sala[dia-1, 0] = "Jueves"; } break;
                case 5: { Agenda_sala[dia-1, 0] = "Viernes"; } break;
                case 6: { Agenda_sala[dia-1, 0] = "Sabado"; } break;

            }
        }
        public void agendar_hora()
        {
            //Al agendar la hora el espacio en el arry se marca como ocupado
            Agenda_sala[DIA, HORA] = "¡sala ocupada!";
        }
        //con este método se marcaran como ocupados los espacios de la duracion de la reunión
        public void Duracion_de_reunion()
        {
            for(int i = 0; i < DURACION; i++)
            {
                Agenda_sala[DIA, HORA + i] = "¡sala ocupada!";
            }
        }
        //Este método se utilizó para modificar la hora respecto a el lugar que ocupará en el array
        public int modificar_hora(int hra)
        {
            switch (hra)
            {
                case (9): { hora = 1; } break;
                case (10): { hora = 2; } break;
                case (11): { hora = 3; } break;
                case (12): { hora = 4; } break;
                case (13): { hora = 5; } break;
                case (14): { hora = 6; } break;
                case (15): { hora = 7; } break;
                case (16): { hora = 8; } break;
                case (17): { hora = 9; } break;
                case (18): { hora = 10; } break;
                case (19): { hora = 11; } break;
            }
            return hora;
        }
    }
}

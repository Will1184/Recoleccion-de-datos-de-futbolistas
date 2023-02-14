using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM21057Guia5Ejercicio7
{
    internal class Futbolista
    {
        private string nombre,equipo;
        private int goles, asistencias;

        public Futbolista()
        {
        }

        public Futbolista(string nombre, string equipo, int goles, int asistencias)
        {
            this.nombre = nombre;
            this.equipo = equipo;
            this.goles = goles;
            this.asistencias = asistencias;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }
        public int Goles
        {
            get { return goles; }
            set { goles = value; }
        }
        public int Asistencias
        {
            get { return asistencias; }
            set { asistencias = value; }
        }

        
    }
}

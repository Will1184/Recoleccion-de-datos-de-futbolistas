

// Guía:5
// Ejercicio:#7
// Fecha: 18/09/2022
// Autor: BRANDON WILLIAM GOMEZ MONGE
// Carnet: GM21057
// GD: #1
// Instructora: NELLY LISSETTE HENRIQUEZ SANCHEZ

using System.Drawing;

namespace GM21057Guia5Ejercicio7
{
    // Diseñe y codifique un programa que registre 5 jugadores de futbol con los siguientes datos: nombre del jugador, nombre del equipo, cantidad de goles, cantidad de asistencias.
    // Y se pide que calcule: El jugador con la mayor cantidad de goles anotados, su nombre y el nombre del equipo.
    // El jugador con la mayor cantidad de asistencias, su nombre y nombre del equipo. 
    //El nombre del jugador con menos goles anotados y la cantidad de goles que tiene de diferencia con el máximo goleador

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Futbolista> futbolistas = new List<Futbolista>();
        private Futbolista futbolist = new Futbolista();
        private int goles = 0;
        private int peorGoleador;
        private int asistencias = 0;
        private int indice_edit = -1;

          
private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Futbolista futbolista = new Futbolista(textNombre.Text, textEquipo.Text, int.Parse(textGoles.Text), int.Parse(textAsistencia.Text));
       

            if (indice_edit > -1)
            {
                futbolistas[indice_edit] = futbolista;
                indice_edit = -1;
            }
            else
            {
                futbolistas.Add(futbolista); //sino solo lo guardamos 
            }
          

            if (futbolista.Goles >= goles)
            {
                goles = futbolista.Goles;
                dataGridMayorAnotador.Rows[0].Cells[0].Value = goles;
                dataGridMayorAnotador.Rows[0].Cells[1].Value = futbolista.Nombre;
                dataGridMayorAnotador.Rows[0].Cells[2].Value = futbolista.Equipo;

            }
            if (futbolista.Asistencias >= asistencias)
            {
                asistencias = futbolista.Asistencias;
                dataGridMayorAsistidor.Rows[0].Cells[0].Value = asistencias;
                dataGridMayorAsistidor.Rows[0].Cells[1].Value = futbolista.Nombre;
                dataGridMayorAsistidor.Rows[0].Cells[2].Value = futbolista.Equipo;
            }
          
            
            if (futbolista.Goles <= goles)
            {
                peorGoleador = futbolista.Goles;
                int diferenciaGoles = goles - peorGoleador;
                dataGridPeorGoleador.Rows[0].Cells[0].Value = futbolista.Nombre;
                dataGridPeorGoleador.Rows[0].Cells[1].Value = futbolista.Equipo;
                dataGridPeorGoleador.Rows[0].Cells[2].Value = peorGoleador;
                dataGridPeorGoleador.Rows[0].Cells[3].Value = diferenciaGoles;
            }

            eliminar();
            actualizar();

        }
        private void actualizar() 
        //método para actualizar la información mostrada en el datagrid
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = futbolistas;
        }
        private void eliminar()
        //Metodo para borrar los datos del textBox
        {
            textNombre.Clear();
            textEquipo.Clear();
            textGoles.Clear();
            textAsistencia.Clear();
        }
    
        
          

        //Metodo para salir del programa
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
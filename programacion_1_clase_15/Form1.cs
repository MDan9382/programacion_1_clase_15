using MySql.Data.MySqlClient;
using programacion_1_clase_15.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace programacion_1_clase_15
{
    public partial class Form1 : Form
    {
        private Personaje_DB personaje;
        public Form1()
        {
            InitializeComponent();
            personaje = new Personaje_DB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConeccion())
            {
                MessageBox.Show("Simon ");

            }
            else
            {
                MessageBox.Show("Nelson");
            }
        }
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttoncargar_Click(object sender, EventArgs e)
        {
            dataGridViewpersonaje.DataSource = personaje.LeerPersonajes();
        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxnombre.Text;
            string raza = textBoxraza.Text;
            int nivel_de_poder = (int)numericUpDownnivel_de_poder.Value;
            int respuesta = personaje.CrearPersonaje(nombre,raza,nivel_de_poder); ;
            if (respuesta > 0 )
            {
                MessageBox.Show("Creado correctamente");
                dataGridViewpersonaje.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}

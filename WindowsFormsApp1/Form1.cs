using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=fjeclot;database=unityproject;";
        public Form1()
        {
            InitializeComponent();
        }

        private void inputBuscarPotenciador_TextChanged(object sender, EventArgs e)
        {
            buscarPotenciadores();
        }
        private void inputBuscar_TextChanged_1(object sender, EventArgs e)
        {
            buscarEnemigos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            BorrarDatosEnemigos();
        }
        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            ModificarDatosEnemigos();
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            InsertarRegistrosEnemigos();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            BorrarDatosEnemigos();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void buttonModificarPotenciador_Click(object sender, EventArgs e)
        {
            ModificarDatosPotenciadores();
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputVelDisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputHealth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarRegistrosPotenciadores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            borrarDatosEnemigos();
        }

        private void CargarDatos()
        {
            string Consulta = "SELECT * FROM enemigos";
            MySqlConnection cnn = new MySqlConnection(this.connectionString);
            MySqlDataAdapter mda = new MySqlDataAdapter(Consulta, cnn);
            DataSet ds = new DataSet();
            mda.Fill(ds, "enemigos");
            grid.DataSource = ds;
            grid.DataMember = "enemigos";

            string Consulta2 = "SELECT * FROM potenciadores";
            MySqlDataAdapter mda2 = new MySqlDataAdapter(Consulta2, cnn);
            DataSet ds2 = new DataSet();
            mda2.Fill(ds2, "potenciadores");
            dataGridPotenciadores.DataSource = ds2;
            dataGridPotenciadores.DataMember = "potenciadores";
        }

        private void InsertarRegistrosEnemigos()
        {
            string Consulta = "INSERT INTO enemigos(nombre,vel_disp,salud,vel) VALUES('" + inputName.Text + "','" + inputVelDisp.Text + "','" + inputHealth.Text + "','" + inputVel.Text + "')";
            MySqlConnection cnn = new MySqlConnection(this.connectionString);
            MySqlCommand mc = new MySqlCommand(Consulta, cnn);
            cnn.Open();
            mc.ExecuteNonQuery();
            cnn.Close();
            CargarDatos();
        }

        private void BorrarDatosEnemigos()
        {
            string Consulta = "DELETE FROM enemigos WHERE id_enemigo=" + inputBuscar.Text;
            MySqlConnection cnn = new MySqlConnection(this.connectionString);
            MySqlCommand mc = new MySqlCommand(Consulta, cnn);
            cnn.Open();
            mc.ExecuteNonQuery();
            cnn.Close();
            CargarDatos();
        }

        private void ModificarDatosEnemigos()
        {
            string Consulta = "UPDATE enemigos SET nombre ='" + inputNameUpdate.Text + "', vel_disp =" + inputVelDispUpdate.Text +
                ", salud=" + inputHealthUpdate.Text + ", vel=" + inputVelUpdate.Text + " where id_enemigo =" + inputBuscar.Text;


            MySqlConnection cnn = new MySqlConnection(this.connectionString);
            MySqlCommand mc = new MySqlCommand(Consulta, cnn);
            cnn.Open();
            mc.ExecuteNonQuery();
            cnn.Close();
            CargarDatos();
        }
        private void buscarEnemigos()
        {
            string Consulta = "SELECT * FROM enemigos WHERE id_enemigo =" + inputBuscar.Text;
            MySqlConnection cnn = new MySqlConnection(this.connectionString);
            MySqlDataAdapter mda = new MySqlDataAdapter(Consulta, cnn);
            DataSet ds = new DataSet();
            mda.Fill(ds, "enemigos");
            DataTable dt = ds.Tables["enemigos"];

            foreach (DataRow row in dt.Rows)
            {
                inputNameUpdate.Text = (row[1]).ToString();
                inputVelDispUpdate.Text = (row[2]).ToString();
                inputHealthUpdate.Text = (row[3]).ToString();
                inputVelUpdate.Text = (row[4]).ToString();
            }
            CargarDatos();
        }

        private void buscarPotenciadores()
        {
            string Consulta = "SELECT * FROM potenciadores WHERE id_potenciador =" + inputBuscarPotenciador.Text;
            MySqlConnection cnn = new MySqlConnection(this.connectionString);
            MySqlDataAdapter mda = new MySqlDataAdapter(Consulta, cnn);
            DataSet ds = new DataSet();
            mda.Fill(ds, "potenciadores");
            DataTable dt = ds.Tables["potenciadores"];

            foreach (DataRow row in dt.Rows)
            {
                inputNombrePotenciador.Text = (row[1]).ToString();
                inputDuracionPotenciador.Text = (row[2]).ToString();
            }
            CargarDatos();
        }

        private void ModificarDatosPotenciadores()
        {
            string Consulta = "UPDATE potenciadores SET nombre_potenciador ='" + inputNombrePotenciador.Text + "', duracion_potenciador =" + inputDuracionPotenciador.Text + " where id_potenciador =" + inputBuscarPotenciador.Text;


            MySqlConnection cnn = new MySqlConnection(this.connectionString);
            MySqlCommand mc = new MySqlCommand(Consulta, cnn);
            cnn.Open();
            mc.ExecuteNonQuery();
            cnn.Close();
            CargarDatos();
        }

        private void InsertarRegistrosPotenciadores()
        {
            string Consulta2 = "INSERT INTO potenciadores(nombre_potenciador,duracion_potenciador) VALUES('" + textBox4.Text + "','" + textBox3.Text + "')";
            MySqlConnection cnn2 = new MySqlConnection(this.connectionString);
            MySqlCommand mc2 = new MySqlCommand(Consulta2, cnn2);
            cnn2.Open();
            mc2.ExecuteNonQuery();
            cnn2.Close();
            CargarDatos();
        }

        private void borrarDatosEnemigos()
        {
            string Consulta2 = "DELETE FROM potenciadores WHERE id_potenciador=" + inputBuscarPotenciador.Text;
            MySqlConnection cnn2 = new MySqlConnection(this.connectionString);
            MySqlCommand mc2 = new MySqlCommand(Consulta2, cnn2);
            cnn2.Open();
            mc2.ExecuteNonQuery();
            cnn2.Close();
            CargarDatos();
        }
    }
}

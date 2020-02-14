using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bdd_Proyecto
{
    public partial class _107 : Form
    {
        SqlConnection conexion = new SqlConnection("Server = USER; database=formulario1; integrated security=true");
        public _107()
        {
            InitializeComponent();
        }

        private void _107_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO datos1 (d1,d2,d3,d4,d5,d6,d7,d8,d9,d10,d11,d12,d13,d14,d15) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@d1", text2.Text);
            comando.Parameters.AddWithValue("@d2", text3.Text);
            comando.Parameters.AddWithValue("@d3", text4.Text);
            comando.Parameters.AddWithValue("@d4", text5.Text);
            comando.Parameters.AddWithValue("@d5", text6.Text);
            comando.Parameters.AddWithValue("@d6", text7.Text);
            comando.Parameters.AddWithValue("@d7", text8.Text);
            comando.Parameters.AddWithValue("@d8", text9.Text);
            comando.Parameters.AddWithValue("@d9", text10.Text);
            comando.Parameters.AddWithValue("@d10", text11.Text);
            comando.Parameters.AddWithValue("@d11", text12.Text);
            comando.Parameters.AddWithValue("@d12", text13.Text);
            comando.Parameters.AddWithValue("@d13", text14.Text);
            comando.Parameters.AddWithValue("@d14", text15.Text);
            comando.Parameters.AddWithValue("@d15", text16.Text);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos ingresados con exito");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select *from datos1", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "UPDATE datos1 SET d1=@d1,d2=@d2,d3=@d3,d4=@d4,d5=@d5,d6=@d6,d7=@d7,d8=@d8,d9=@d9,d10=@d10,d11=@d11,d12=@d12,d13=@d13,d14=@d14,d15=@d15 WHERE id=@id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@d1", text2.Text);
            comando.Parameters.AddWithValue("@d2", text3.Text);
            comando.Parameters.AddWithValue("@d3", text4.Text);
            comando.Parameters.AddWithValue("@d4", text5.Text);
            comando.Parameters.AddWithValue("@d5", text6.Text);
            comando.Parameters.AddWithValue("@d6", text7.Text);
            comando.Parameters.AddWithValue("@d7", text8.Text);
            comando.Parameters.AddWithValue("@d8", text9.Text);
            comando.Parameters.AddWithValue("@d9", text10.Text);
            comando.Parameters.AddWithValue("@d10", text11.Text);
            comando.Parameters.AddWithValue("@d11", text12.Text);
            comando.Parameters.AddWithValue("@d12", text13.Text);
            comando.Parameters.AddWithValue("@d13", text14.Text);
            comando.Parameters.AddWithValue("@d14", text15.Text);
            comando.Parameters.AddWithValue("@d15", text16.Text);
            comando.Parameters.AddWithValue("@id", text1.Text);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("registro modificado");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM datos1 WHERE id=@id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", text1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro borrado");
        }
    }
}

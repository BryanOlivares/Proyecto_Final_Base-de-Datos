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
    public partial class _104 : Form
    {
        SqlConnection conexion = new SqlConnection("Server = USER; database=SRI; integrated security=true");
        public _104()
        {
            InitializeComponent();
        }

        private void _104_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO datos (num,cedula,nombres,saldo1,saldo2,saldo3,saldo4,saldo5,saldo6,saldo7,saldo8,saldo9,saldo10,saldo11,saldo12,saldo13,saldo14,saldo15) VALUES (@num,@cedula,@nombres,@saldo1,@saldo2,@saldo3,@saldo4,@saldo5,@saldo6,@saldo7,@saldo8,@saldo9,@saldo10,@saldo11,@saldo12,@saldo13,@saldo14,@saldo15)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@num", text4.Text);
            comando.Parameters.AddWithValue("@cedula", text5.Text);
            comando.Parameters.AddWithValue("@nombres", text6.Text);
            comando.Parameters.AddWithValue("@saldo1", text7.Text);
            comando.Parameters.AddWithValue("@saldo2", text8.Text);
            comando.Parameters.AddWithValue("@saldo3", text9.Text);
            comando.Parameters.AddWithValue("@saldo4", text10.Text);
            comando.Parameters.AddWithValue("@saldo5", text11.Text);
            comando.Parameters.AddWithValue("@saldo6", text12.Text);
            comando.Parameters.AddWithValue("@saldo7", text13.Text);
            comando.Parameters.AddWithValue("@saldo8", text14.Text);
            comando.Parameters.AddWithValue("@saldo9", text15.Text);
            comando.Parameters.AddWithValue("@saldo10", text16.Text);
            comando.Parameters.AddWithValue("@saldo11", text17.Text);
            comando.Parameters.AddWithValue("@saldo12", text18.Text);
            comando.Parameters.AddWithValue("@saldo13", text19.Text);
            comando.Parameters.AddWithValue("@saldo14", text20.Text);
            comando.Parameters.AddWithValue("@saldo15", text21.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos ingresados con exito");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select *from datos", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "UPDATE datos SET num=@num,cedula=@cedula,nombres=@nombres,saldo1=@saldo1,saldo2=@saldo2,saldo3=@saldo3,saldo4=@saldo4,saldo5=@saldo5,saldo6=@saldo6,saldo7=@saldo7,saldo8=@saldo8,saldo9=@saldo9,saldo10=@saldo10,saldo11=@saldo11,saldo12=@saldo12,saldo13=@saldo13,saldo14=@saldo14,saldo15=@saldo15 WHERE id=@id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@num", text4.Text);
            comando.Parameters.AddWithValue("@cedula", text5.Text);
            comando.Parameters.AddWithValue("@nombres", text6.Text);
            comando.Parameters.AddWithValue("@saldo1", text7.Text);
            comando.Parameters.AddWithValue("@saldo2", text8.Text);
            comando.Parameters.AddWithValue("@saldo3", text9.Text);
            comando.Parameters.AddWithValue("@saldo4", text10.Text);
            comando.Parameters.AddWithValue("@saldo5", text11.Text);
            comando.Parameters.AddWithValue("@saldo6", text12.Text);
            comando.Parameters.AddWithValue("@saldo7", text13.Text);
            comando.Parameters.AddWithValue("@saldo8", text14.Text);
            comando.Parameters.AddWithValue("@saldo9", text15.Text);
            comando.Parameters.AddWithValue("@saldo10", text16.Text);
            comando.Parameters.AddWithValue("@saldo11", text17.Text);
            comando.Parameters.AddWithValue("@saldo12", text18.Text);
            comando.Parameters.AddWithValue("@saldo13", text19.Text);
            comando.Parameters.AddWithValue("@saldo14", text20.Text);
            comando.Parameters.AddWithValue("@saldo15", text21.Text);
            comando.Parameters.AddWithValue("@id", text1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("registro modificado");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM datos WHERE id=@id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", text1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro borrado");
        }

        private void text4_TextChanged(object sender, EventArgs e)
        {

        }

        private void text4_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text5_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text7_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text8_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text9_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text10_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text11_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text12_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text13_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text14_TextChanged(object sender, EventArgs e)
        {

        }

        private void text14_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text15_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text16_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text17_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text18_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text19_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text20_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text21_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void text6_KeyPress(object sender, KeyPressEventArgs v)
        {
            validar.sololetras(v);
        }
    }
}

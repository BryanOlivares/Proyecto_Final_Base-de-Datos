using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bdd_Proyecto
{
    public partial class _102A : Form
    {
        SqlConnection conexion = new SqlConnection("Server = USER; database=formulario; integrated security=true");
        public _102A()
        {           InitializeComponent();
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _102A_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cedula;
            cedula = textruc.Text;
            string query = "INSERT INTO usuario (cedula,nombre,año,apellido) VALUES (@cedula,@nombre,@año,@apellido)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@cedula", textruc.Text);
            comando.Parameters.AddWithValue("@nombre", textBox11.Text);
            comando.Parameters.AddWithValue("@año", textaño.Text);
            comando.Parameters.AddWithValue("@apellido", textBox12.Text);
            comando.ExecuteNonQuery();
            if(cedula=="")
            {
                MessageBox.Show("Debe llenar el campo de cedula", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                conexion.Close();
                MessageBox.Show("Datos ingresados con exito");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ingresos (actividades,libre,ocupacion,arriendo,ingreso,rendimiento) VALUES (@actividades,@libre,@ocupacion,@arriendo,@ingreso,@rendimiento)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@actividades", textBox6.Text);
            comando.Parameters.AddWithValue("@libre", textBox5.Text);
            comando.Parameters.AddWithValue("@ocupacion", textBox4.Text);
            comando.Parameters.AddWithValue("@arriendo", textBox3.Text);
            comando.Parameters.AddWithValue("@ingreso", textBox2.Text);
            comando.Parameters.AddWithValue("@rendimiento", textBox1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos ingresados con exito");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select *from ingresos", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO egresos (eduacion,salud,alimentacion,vivienda,vestimenta) VALUES (@eduacion,@salud,@alimentacion,@vivienda,@vestimenta)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@eduacion", textg1.Text);
            comando.Parameters.AddWithValue("@salud", textg2.Text);
            comando.Parameters.AddWithValue("@alimentacion", textg3.Text);
            comando.Parameters.AddWithValue("@vivienda", textg4.Text);
            comando.Parameters.AddWithValue("@vestimenta", textg5.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos ingresados con exito");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select *from egresos", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView2.DataSource = tabla;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ingresos SET actividades=@actividades,libre=@libre,ocupacion=@ocupacion,arriendo=@arriendo,ingreso=@ingreso,rendimiento=@rendimiento  WHERE id=@id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@actividades", textBox6.Text);
            comando.Parameters.AddWithValue("@libre", textBox5.Text);
            comando.Parameters.AddWithValue("@ocupacion", textBox4.Text);
            comando.Parameters.AddWithValue("@arriendo", textBox3.Text);
            comando.Parameters.AddWithValue("@ingreso", textBox2.Text);
            comando.Parameters.AddWithValue("@rendimiento", textBox1.Text);
            comando.Parameters.AddWithValue("@id", textBox9.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("registro modificado");


        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = "UPDATE egresos SET eduacion=@eduacion,salud=@salud,alimentacion=@alimentacion,vivienda=@vivienda,vestimenta=@vestimenta WHERE id=@id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@eduacion", textg1.Text);
            comando.Parameters.AddWithValue("@salud", textg2.Text);
            comando.Parameters.AddWithValue("@alimentacion", textg3.Text);
            comando.Parameters.AddWithValue("@vivienda", textg4.Text);
            comando.Parameters.AddWithValue("@vestimenta", textg5.Text);
            comando.Parameters.AddWithValue("@id", textBox10.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("registro modificado");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ingresos WHERE id=@id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", textBox9.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro borrado");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM egresos WHERE id=@id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", textBox10.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro borrado");
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void textaño_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textruc_KeyPress_1(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs v)
        {
            validar.sololetras(v);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs v)
        {
            validar.sololetras(v);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textg1_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textg2_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textg3_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textg4_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void textg5_KeyPress(object sender, KeyPressEventArgs n)
        {
            validar.solonumeros(n);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

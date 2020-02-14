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
using System.Data.Sql;
using MySql.Data.MySqlClient;
using Npgsql;

namespace Bdd_Proyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool blnfound = false;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=19961805o; Database=login");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from usuarios where nombre='" + textnombre.Text + "' and contraseña='" + textclave.Text + "'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                blnfound = true;
                Seleccion f5 = new Seleccion();
                f5.Show();
                this.Hide();
            }
            if (blnfound == false)
                MessageBox.Show("EL NOMBRE O LA CONTRASEÑA SON INCORRECTOS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            dr.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

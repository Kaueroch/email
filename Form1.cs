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

namespace _11_08
{
    public partial class Form1 : Form
    {
        string MySqlClientString = "server = localhost;Port=3306;" + "User email =root ; Database= tbbase;" + "SSL Mode=0";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(MySqlClientString);
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cadastro ORDER BY email", conn);
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

        }
    }
}

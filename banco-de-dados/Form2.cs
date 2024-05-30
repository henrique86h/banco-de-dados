using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_de_dados
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=bd_cshap;password=;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_csharp (nome, idade) VALUES (@Nome, @Idade)", conn);

            // Inserção no banco de Dados
            cmd.Parameters.AddWithValue("@Nome", textBoxNome.Text);
            cmd.Parameters.AddWithValue("@Idade", textBoxIdade.Text);

            // Abrindo Conexão
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            // Validando a Inserção de Dados
            if (rowsAffected > 0)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir dados.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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

namespace WindowsFormsCliente2Sem
{
    public partial class ExclCliente : Form
    {
        public ExclCliente()
        {
            InitializeComponent();
        }

        private void ExclCliente_Load(object sender, EventArgs e)   {   }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //Conexão com o DB
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=AG_VEICULOS; password=''");
            MySqlCommand sqlQuery = new MySqlCommand("DELETE from CLIENTE WHERE CPF = " + txtCPF.Text, conexao);

            var vResp = MessageBox.Show("Deseja Excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (vResp == DialogResult.Yes)
            {
                try
                {
                    conexao.Open(); // Abrir Conexão            
                    sqlQuery.ExecuteNonQuery();
                    btExcluir.PerformClick(); //Comando de EXCLUSÃO assim que clicar no botão
                    MessageBox.Show("Exclusão efetuada com sucesso", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conexao.Close();
            }
        }
    }
}

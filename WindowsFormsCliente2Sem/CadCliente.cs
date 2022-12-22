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
    public partial class CadCliente : Form
    {
        /* Atividade 2 - M2 
         * Programa: WindowsForms com cadastro, consulta, atualização e exclusão de uma entidade no DB MySQL.
         * Data de entrega: 03/12/2022
         * Nome do projeto: AG Veículos
         * Autora: Amanda Nogueira
         */

        Cliente cliente = new Cliente();
        Veiculo veiculo = new Veiculo();

        public CadCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void textBox6_TextChanged(object sender, EventArgs e) 
        {
            cliente.setResidencial(txtReside.Text);
        }

        private void label4_Click(object sender, EventArgs e) { }

        private void label10_Click(object sender, EventArgs e)  { }

        private void textBox6_TextChanged_1(object sender, EventArgs e)  
        {
            veiculo.setMarca(txtMarca.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            veiculo.setRenavam(txtRenavam.Text);
        }

        private void btCadastar_Click(object sender, EventArgs e)
        {
           //Se os campos não forem preenchidos exibirá na caixa de texto um informativo 
            if(txtNome.Text == "")  { txtNome.Text = "Informar o nome"; }

            if(txtEmail.Text == "") { txtEmail.Text = "Informar o email"; }

            if(txtCel.Text == "") { txtCel.Text = "Informar"; }

            if(txtReside.Text == "") { txtReside.Text = "Informar"; }

            if(txtCpf.Text == "") { txtCpf.Text = "Informar"; }

            if(cBEstado.SelectedItem == null) { cBEstado.Text = "Informar"; }

            if(txtRua.Text == "") { txtRua.Text = "Informar o logradouro"; }

            if(txtCep.Text == "") { txtCep.Text = "Informar"; }

            if(txtNum.Text == "") { txtNum.Text = "*"; }

            if(txtCidade.Text == "") { txtCidade.Text = "Informar"; }

            if(txtRenavam.Text == "") { txtRenavam.Text = "Informar"; }

            if(txtChassi.Text == "") { txtChassi.Text = "Informar"; }

            if(txtModelo.Text == "") { txtModelo.Text = "Informar"; }

            if(txtMarca.Text == "") { txtMarca.Text = "Informar"; }

            if(txtCor.Text == "") { txtCor.Text = "Informar"; }

            if(cBAno.SelectedItem == null) { cBAno.Text = "Informar"; }

            if(txtPlaca.Text == "") { txtPlaca.Text = "Informar"; }

            if (cbCambio.SelectedItem == null) { cbCambio.Text = "Informar"; }

            if(cbCombu.SelectedItem == null ) { cbCombu.Text = "Informar"; }

            if (txtFipe.Text == "" ) { txtFipe.Text = "Informar"; }

            cliente.setSexo(checkedListBox1.Text);

            //Conexão com Database
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database= AG_VEICULOS; password=''");
            //Modelo da tabela e como vai gravar as informações
            MySqlCommand sqlQuery = new MySqlCommand($"INSERT INTO CLIENTE (nome, nascimento, sexo, email, celular, residencial, cpf, estado, logradouro, cep, numero, " +
                $"complemento, cidade, renavam, chassi, modelo, marca, cor, ano, placa, cambio, combustivel, fipe)" +
            $" VALUES ('{cliente.getNome()}', '{cliente.getNascimento().ToString("yyyy-MM-dd")}', '{cliente.getSexo()}', '{cliente.getEmail()}', '{cliente.getCelular()}','{cliente.getResidencial()}', " +
            $"'{cliente.getCpf()}', '{cliente.getEstado()}','{cliente.getLog()}','{cliente.getCep()}', '{cliente.getNumero()}', '{cliente.getComplemento()}', '{cliente.getCidade()}'," +
            $" '{veiculo.getRenavam()}', '{veiculo.getChassi()}', '{veiculo.getModelo()}', '{veiculo.getMarca()}', '{veiculo.getCor()}', '{veiculo.getAno()}', '{veiculo.getPlaca()}', " +
            $"'{veiculo.getCambio()}', '{veiculo.getCombustivel()}', '{veiculo.getFipe()}')", conexao);


            try
            {
                conexao.Open();//Abrir conexão
                //sqlQuery.ExecuteNonQuery();
                btCadastar.PerformClick();
                MessageBox.Show("Dados salvos com sucesso!", "Salvar dados [DB]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) //Erro em salvar
            {
                MessageBox.Show("Erro: " + ex, "ERRO Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close(); //Fecha conexão com o Data
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            cliente.setNome(txtNome.Text);
        }

        private void dateNasc_ValueChanged(object sender, EventArgs e)
        {
            cliente.setNascimento(dateNasc.Value);
        }

        private void groupBox1_Enter(object sender, EventArgs e)  { }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            cliente.setEmail(txtEmail.Text);
        }

        private void txtCel_TextChanged(object sender, EventArgs e)
        {
            cliente.setCelular(txtCel.Text);
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            cliente.setCpf(txtCpf.Text);
        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {
            cliente.setLog(txtRua.Text);
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            cliente.setCep(txtCep.Text);
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            cliente.setNumero(txtNum.Text);
        }

        private void txtComple_TextChanged(object sender, EventArgs e)
        {
            cliente.setComplemento(txtComple.Text);
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            cliente.setCidade(txtCidade.Text);
        }

        private void txtChassi_TextChanged(object sender, EventArgs e)
        {
            veiculo.setChassi(txtChassi.Text);
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            veiculo.setModelo(txtModelo.Text);
        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {
            veiculo.setCor(txtCor.Text);
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            veiculo.setPlaca(txtPlaca.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtFipe_TextChanged(object sender, EventArgs e)
        {
            veiculo.setFipe(Double.Parse(txtFipe.Text));
        }

        private void cBEstado_SelectedIndexChanged(object sender, EventArgs e)  
        {
            cliente.setEstado(cBEstado.Text);
        }

        private void cBAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            veiculo.setAno(cBAno.Text);
        }

        private void cbCambio_SelectedIndexChanged(object sender, EventArgs e)
        {
            veiculo.setCambio(cbCambio.Text);
        }

        private void cbCombu_SelectedIndexChanged(object sender, EventArgs e)
        {
            veiculo.setCombustivel(cbCombu.Text);
        }
    }    
}
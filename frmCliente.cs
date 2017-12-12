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

namespace projeto1
{
   
    public partial class frm_cliente : Form
    {
         //string connection = Insira a String de conexão;
         bool novo;


        public frm_cliente()
        {
            InitializeComponent();

            btn_adicionar.Enabled = true;
            btn_Pesquisar.Enabled = true;
            btn_salvar.Enabled = false;
            btn_excluir.Enabled = false;
            tb_codigocliente.Enabled = false;
            tb_nomeCliente.Enabled = false;
            mkt_dtnascimentoCliente.Enabled = false;
            mkt_cpfCliente.Enabled = false;
            tb_enderecoCliente.Enabled = false;
            tb_numeroCliente.Enabled = false;
            tb_bairroCliente.Enabled = false;
            tb_cidadeCliente.Enabled = false;
            cb_estadoCliente.Enabled = false;
            mkt_telefone.Enabled = false;
            tb_rgCliente.Enabled = false;
            cb_sexoCliente.Enabled = false;
            tb_emailCliente.Enabled = false;
        }

       

        public bool Valida()
        {
            bool r = true;
        
            string cpf = mkt_cpfCliente.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("_", "").Replace(" ", "");
            if (tb_codigocliente.Text == "")
            {
                MessageBox.Show("Insira o Código ");

                return false;
            }
            else if (tb_nomeCliente.Text == "")
            {
                MessageBox.Show("Insira o Nome do Cliente");
                return r;
            }

            else if (mkt_dtnascimentoCliente.Text == "")
            {
                MessageBox.Show("Insira a Data de Nascimento");
                return r;
            }

            else if (tb_enderecoCliente.Text == "")
            {
                MessageBox.Show("Insira o Endereço");
                return r;
            }
            else if (tb_bairroCliente.Text == "")
            {
                MessageBox.Show("Insira o Bairro ");
                return r;
            }

            else if (tb_numeroCliente.Text == "")
            {
                MessageBox.Show("Insira o Numero");
                return r;
            }

            else if (mkt_telefone.Text == "")
            {
                MessageBox.Show("Insira o Telefone");
                return r;
            }

            else if (tb_cidadeCliente.Text == "")
            {
                MessageBox.Show("Insira o Cidade");
                return r;
            }

            else if (cb_estadoCliente.Text == "")
            {
                MessageBox.Show("Insira o Estado");
                return r;
            }


            else if (tb_rgCliente.Text == "")
            {
                MessageBox.Show("Insira o Numero da Identidade");
                return r;
            }

            else if (cpf.Length< 11)
            {
                MessageBox.Show("Insira o seu CPF Corretamente, faltam " + (11 - cpf.Length) + ".");
                return r;
            }

            return r;
        }

        public void Analizar_campos()
        {



        }










        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {

            if (novo) {
                Analizar_campos();
                string sql = "INSERT INTO CLIENTE (NOME_CLIENTE,DATNAS_CLIENTE,CPF_CLIENTE,ENDERECO_CLIENTE,NUM_CLIENTE,BAIRRO_CLIENTE,CIDADE_CLIENTE,ESTADO_CLIENTE,TELEFONE_CLIENTE,EMAIL_CLIENTE,RG_CLIENTE,SEXO_CLIENTE ) "
              + "VALUES ('" + tb_nomeCliente.Text + "', '" + mkt_dtnascimentoCliente.Text + "', '" + mkt_cpfCliente.Text + "', '" + tb_enderecoCliente.Text + "', '" + tb_numeroCliente.Text + "', '" + tb_bairroCliente.Text + "', '" + tb_cidadeCliente.Text + "', '" + cb_estadoCliente.Text + "', '" + mkt_telefone.Text + "', '" + tb_emailCliente.Text + "', '" + tb_rgCliente.Text + "', '" + cb_sexoCliente.Text + "')";

                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    btn_adicionar.Enabled = true;
                    btn_Pesquisar.Enabled = true;
                    tb_pesquisar.Enabled = true;
                    tb_codigocliente.Enabled = false;
                    tb_nomeCliente.Enabled = false;
                    tb_bairroCliente.Enabled = false;
                    tb_cidadeCliente.Enabled = false;
                    tb_enderecoCliente.Enabled = false;
                    tb_numeroCliente.Enabled = false;
                    tb_rgCliente.Enabled = false;
                    mkt_cpfCliente.Enabled = false;
                    mkt_dtnascimentoCliente.Enabled = false;
                    tb_emailCliente.Enabled = false;
                    cb_sexoCliente.Enabled = false;
                    mkt_telefone.Enabled = false;
                    cb_estadoCliente.Enabled = false;

                    tb_codigocliente.Text = " ";
                    tb_nomeCliente.Text = " ";
                    mkt_dtnascimentoCliente.Text = " ";
                    mkt_cpfCliente.Text = " ";
                    tb_enderecoCliente.Text = " ";
                    tb_numeroCliente.Text = " ";
                    tb_bairroCliente.Text = " ";
                    tb_cidadeCliente.Text = " ";
                    cb_estadoCliente.Text = " ";
                    mkt_telefone.Text = " ";
                    tb_rgCliente.Text = " ";
                    cb_sexoCliente.Text = " ";
                    tb_emailCliente.Text = " ";
                }



            }
            else
            {
                string sql = "UPDATE CLIENTE SET  NOME_CLIENTE= @Nome, DATNAS_CLIENTE= @datnas, CPF_CLIENTE= @cpf, ENDERECO_CLIENTE= @endereco, " + "NUM_CLIENTE= @numero, BAIRRO_CLIENTE= @bairro, CIDADE_CLIENTE= @cidade, ESTADO_CLIENTE= @estado, TELEFONE_CLIENTE = @telefone, RG_CLIENTE= @rg, SEXO_CLIENTE= @sexo WHERE ID_CLIENTE=@id";
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Nome",tb_nomeCliente .Text);
                cmd.Parameters.AddWithValue("@datnas", mkt_dtnascimentoCliente.Text);
                cmd.Parameters.AddWithValue("@cpf", mkt_cpfCliente.Text);
                cmd.Parameters.AddWithValue("@endereco", tb_enderecoCliente.Text);
                cmd.Parameters.AddWithValue("@numero", tb_numeroCliente.Text);
                cmd.Parameters.AddWithValue("@bairro", tb_bairroCliente.Text);
                cmd.Parameters.AddWithValue("@cidade", tb_cidadeCliente.Text);
                cmd.Parameters.AddWithValue("@estado", cb_estadoCliente.Text);
                cmd.Parameters.AddWithValue("@telefone", mkt_telefone.Text);
                cmd.Parameters.AddWithValue("@rg", tb_rgCliente.Text);
                cmd.Parameters.AddWithValue("@sexo", cb_sexoCliente.Text);
                cmd.Parameters.AddWithValue("@id", tb_codigocliente.Text);

                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    btn_adicionar.Enabled = true;
                    btn_Pesquisar.Enabled = true;
                    tb_codigocliente.Enabled = false;
                    tb_nomeCliente.Enabled = false;
                    tb_bairroCliente.Enabled = false;
                    tb_cidadeCliente.Enabled = false;
                    tb_enderecoCliente.Enabled = false;
                    tb_numeroCliente.Enabled = false;
                    tb_rgCliente.Enabled = false;
                    mkt_cpfCliente.Enabled = false;
                    mkt_dtnascimentoCliente.Enabled = false;
                    cb_sexoCliente.Enabled = false;
                    tb_emailCliente.Enabled = false;
                    mkt_telefone.Enabled = false;
                    cb_estadoCliente.Enabled = false;

                    tb_codigocliente.Text = " ";
                    tb_nomeCliente.Text = " ";
                    mkt_dtnascimentoCliente.Text = " ";
                    mkt_cpfCliente.Text = " ";
                    tb_enderecoCliente.Text = " ";
                    tb_numeroCliente.Text = " ";
                    tb_bairroCliente.Text = " ";
                    tb_cidadeCliente.Text = " ";
                    cb_estadoCliente.Text = " ";
                    mkt_telefone.Text = " ";
                    tb_rgCliente.Text = " ";
                    cb_sexoCliente.Text = " ";
                    tb_emailCliente.Text = " ";
                }


            }
        } 


        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM CLIENTE WHERE ID_CLIENTE = @id";

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", tb_pesquisar.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    btn_salvar.Enabled = true;
                    btn_excluir.Enabled = true;
                    btn_Pesquisar.Enabled = true;
                    tb_codigocliente.Enabled = false;
                    tb_nomeCliente.Enabled = true;
                    mkt_dtnascimentoCliente.Enabled = true;
                    mkt_cpfCliente.Enabled = true;
                    tb_enderecoCliente.Enabled = true;
                    tb_numeroCliente.Enabled = true;
                    tb_bairroCliente.Enabled = true;
                    tb_cidadeCliente.Enabled = true;
                    cb_estadoCliente.Enabled = true;
                    mkt_telefone.Enabled = true;
                    tb_rgCliente.Enabled = true;
                    cb_sexoCliente.Enabled = true;
                    tb_emailCliente.Enabled = true;
                    tb_nomeCliente.Focus();
                    tb_codigocliente.Text = reader[0].ToString();
                    tb_nomeCliente.Text = reader[1].ToString();
                    mkt_dtnascimentoCliente.Text = reader[2].ToString();
                    mkt_cpfCliente.Text = reader[3].ToString();
                    tb_enderecoCliente.Text = reader[4].ToString();
                    tb_numeroCliente.Text = reader[5].ToString();
                    tb_bairroCliente.Text = reader[6].ToString();
                    tb_cidadeCliente.Text = reader[7].ToString();
                    cb_estadoCliente.Text = reader[8].ToString();
                    mkt_telefone.Text = reader[9].ToString();
                    tb_emailCliente.Text = reader[10].ToString();
                    tb_rgCliente.Text = reader[11].ToString();
                    cb_sexoCliente.Text = reader[12].ToString();
                    novo = false;
                }
                else
                    MessageBox.Show("Nenhum registro encontrado com o nome informado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

           // tb_codigocliente.Text = "";

        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tb_codigocliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            btn_salvar.Enabled = true;
            btn_Pesquisar.Enabled = false;
            tb_pesquisar.Enabled = false;
            tb_codigocliente.Enabled = false;
            tb_nomeCliente.Enabled = true;
            mkt_dtnascimentoCliente.Enabled = true;
            mkt_cpfCliente.Enabled = true;
            tb_enderecoCliente.Enabled = true;
            tb_numeroCliente.Enabled = true;
            tb_bairroCliente.Enabled = true;
            tb_cidadeCliente.Enabled = true;
            cb_estadoCliente.Enabled = true;
            mkt_telefone.Enabled = true;
            tb_rgCliente.Enabled = true;
            cb_sexoCliente.Enabled = true;
            tb_emailCliente.Enabled = true;

            tb_pesquisar.Text = " ";
            tb_codigocliente.Text = " ";
            tb_nomeCliente.Text = " ";
            mkt_dtnascimentoCliente.Text = " ";
            mkt_cpfCliente.Text = " ";
            tb_enderecoCliente.Text = " ";
            tb_numeroCliente.Text = " ";
            tb_bairroCliente.Text = " ";
            tb_cidadeCliente.Text = " ";
            cb_estadoCliente.Text = " ";
            mkt_telefone.Text = " ";
            tb_rgCliente.Text = " ";
            cb_sexoCliente.Text = " ";
            tb_emailCliente.Text = " ";

            novo = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            btn_adicionar.Enabled = true;
            btn_Pesquisar.Enabled = true;
            btn_salvar.Enabled = false;
            btn_excluir.Enabled = false;
            tb_pesquisar.Enabled = true;
            tb_codigocliente.Enabled = false;
            tb_nomeCliente.Enabled = false;
            mkt_dtnascimentoCliente.Enabled = false;
            mkt_cpfCliente.Enabled = false;
            tb_enderecoCliente.Enabled = false;
            tb_numeroCliente.Enabled = false;
            tb_bairroCliente.Enabled = false;
            tb_cidadeCliente.Enabled = false;
            cb_estadoCliente.Enabled = false;
            mkt_telefone.Enabled = false;
            tb_rgCliente.Enabled = false;
            cb_sexoCliente.Enabled = false;
            tb_emailCliente.Enabled = false;

            tb_pesquisar.Text = " ";
            tb_codigocliente.Text = " ";
            tb_nomeCliente.Text = " ";
            mkt_dtnascimentoCliente.Text = " ";
            mkt_cpfCliente.Text = " ";
            tb_enderecoCliente.Text = " ";
            tb_numeroCliente.Text = " ";
            tb_bairroCliente.Text = " ";
            tb_cidadeCliente.Text = " ";
            cb_estadoCliente.Text = " ";
            mkt_telefone.Text = " ";
            tb_rgCliente.Text = " ";
            cb_sexoCliente.Text = " ";
            tb_emailCliente.Text = " ";
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_pesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }


    }

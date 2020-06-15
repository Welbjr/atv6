using System;
using System.Windows.Forms;
using BLL;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmCadastroEmpresa : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        public frmCadastroEmpresa(frmPrincipal f)
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            textBox_CNPJ.Clear();
            textBox_DescricaoEmpresa.Clear();
            textBox_IDEmpresa.Clear();
            textBox_NomeEmpresa.Clear();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLocalizar f = new FRMLocalizar();
            f.ShowDialog();

            popularcampos(f.modelempresa);

            alterapropriedades(3);
        }

        private void popularcampos(MODELOEmpresa p)
        {
            if (p != null)
            {
                textBox_CNPJ.Text = p.Cnpj;
                textBox_DescricaoEmpresa.Text = p.Descricao;
                textBox_IDEmpresa.Text = Convert.ToString(p.Id);
                textBox_NomeEmpresa.Text = p.Nome;
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                p.Nome = textBox_NomeEmpresa.Text;
                p.Cnpj = textBox_CNPJ.Text;
                p.Cnpj = textBox_DescricaoEmpresa.Text;

                bllempresa.Incluir(p);
                textBox_IDEmpresa.Text = p.Id.ToString();
                MessageBox.Show("Empresa inserida com sucesso id:" + p.Id);

                limparCampos();
                alterapropriedades(1);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLEmpresa bllempresa = new BLLEmpresa(cx);
                bllempresa.Excluir(Convert.ToInt32(textBox_IDEmpresa.Text));
                MessageBox.Show("Empresa excluida com sucesso.");

                limparCampos();
                alterapropriedades(1);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao excluir erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir erro geral:" + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            alterapropriedades(1);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                p.Nome = textBox_NomeEmpresa.Text;
                p.Descricao = textBox_DescricaoEmpresa.Text;
                p.Cnpj = textBox_CNPJ.Text;

                bllempresa.Incluir(p);
                textBox_IDEmpresa.Text = p.Id.ToString(); ;
                MessageBox.Show("Empresa inserida com sucesso id:" + p.Id);

                limparCampos();
                alterapropriedades(1);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }
    }

        
    
}

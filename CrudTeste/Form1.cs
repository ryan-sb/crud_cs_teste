using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crudProdutosDataSet1.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter1.Fill(this.crudProdutosDataSet1.Produtos);
            // TODO: This line of code loads data into the 'crudProdutosDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.crudProdutosDataSet.Produtos);
        
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-4AQ126F\SQLEXPRESS;Initial Catalog=CrudProdutos;Integrated Security=True");

        void Carrega_dados()
        {

            SqlCommand comando = new SqlCommand("select * from Produtos;", conexao);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            id_prod.Text = "";
            nome_prod.Text = "";
            preco_prod.Text = "";

        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {

                conexao.Open();

                SqlCommand comando = new SqlCommand("insert into Produtos values (@id, @nome_produto, @preco_produto);", conexao);

                comando.Parameters.AddWithValue("@id", int.Parse(id_prod.Text));
                comando.Parameters.AddWithValue("@nome_produto", nome_prod.Text);
                comando.Parameters.AddWithValue("@preco_produto", preco_prod.Text);
                comando.ExecuteNonQuery();

                conexao.Close();

                Carrega_dados();

                MessageBox.Show("Produto inserido com sucesso");
            
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            if (id_prod.Text == "")
            {
                MessageBox.Show("Preencha o campo 'ID Produto' para atualizar o produto desejado.");
            }
            else
            {
                conexao.Open();

                SqlCommand comando = new SqlCommand("update Produtos set nome_produto = @nome_produto, preco_produto = @preco_produto where ID=@id;", conexao);

                comando.Parameters.AddWithValue("@id", int.Parse(id_prod.Text));
                comando.Parameters.AddWithValue("@nome_produto", nome_prod.Text);
                comando.Parameters.AddWithValue("@preco_produto", preco_prod.Text);
                comando.ExecuteNonQuery();

                conexao.Close();

                Carrega_dados();

                MessageBox.Show("Produto atualizado com sucesso");
            }
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            if (id_prod.Text == "")
            {
                MessageBox.Show("Preencha o campo 'ID Produto' para Deletar o produto desejado.");
            }
            else
            {
                conexao.Open();

                SqlCommand comando = new SqlCommand("delete Produtos where ID=@id;", conexao);

                comando.Parameters.AddWithValue("@id", int.Parse(id_prod.Text));
                comando.Parameters.AddWithValue("@nome_produto", nome_prod.Text);
                comando.Parameters.AddWithValue("@preco_produto", preco_prod.Text);
                comando.ExecuteNonQuery();

                conexao.Close();

                Carrega_dados();

                MessageBox.Show("Produto deletado com sucesso");
            }
        }
    }
}

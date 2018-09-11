using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Filmes
{
    public partial class CadastroFilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            FilmeVO filme = new FilmeVO();

            filme.nome = txtNome.Text;
            filme.genero = txtGenero.Text;
            filme.anoLancamento = Convert.ToInt32(txtAnoLancamento.Text);

            ServiceReference1.ServicoClient servico = new ServiceReference1.ServicoClient();

            servico.Inserir(filme);

            lblOK.Text = "Filme Salvo com sucesso";
        }
    }
}
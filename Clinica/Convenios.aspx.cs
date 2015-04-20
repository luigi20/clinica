using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Convenios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["Convenio"] != null)
            {
                Convenio convenio = (Convenio)Session["Convenio"];
                txtBoxNome.Text = convenio.Nome;
                txtBoxSigla.Text = convenio.Sigla;
                txtBoxTel.Text = convenio.Telefone;
            }
            if (Request.QueryString["id"] != null)
            {
                List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
                foreach (Convenio convenio in listaConvenio)
                {
                    if (convenio.Id.Equals(Convert.ToInt16(Request.QueryString["id"].ToString())))
                    {
                        txtBoxNome.Text = convenio.Nome;
                        txtBoxSigla.Text = convenio.Sigla;
                        txtBoxTel.Text = Convert.ToString(convenio.Telefone);


                        Session["convenio"] = convenio;
                        return;
                    }
                }

            }
            else
            {
                if (Session["listaConvenio"] == null)
                {
                    Session["listaConvenio"] = new List<Convenio>();


                }


            }

        }
    }
    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        int contador = Convert.ToInt32(Application["contadorConvenio"]) + 1;
        Application["contadorConvenio"] = contador;
        Convenio convenio = new Convenio(txtBoxNome.Text, txtBoxSigla.Text, txtBoxTel.Text, contador);
        List<Convenio> lista = (List<Convenio>)Session["listaConvenio"]; /* aponta pra lista de session no page load */
        lista.Add(convenio);
        txtBoxNome.Text = "";
        txtBoxSigla.Text = "";
        txtBoxTel.Text = "";
        this.ExibirMensagem("Cadastramento Realizado com Sucesso");
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {


        Convenio convenio = (Convenio)Session["convenio"];
        convenio.Nome = txtBoxNome.Text;
        convenio.Sigla = txtBoxSigla.Text;
        convenio.Telefone = txtBoxTel.Text;
        this.ExibirMensagem("Alteração Realizado com Sucesso");


    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {

        Convenio convenio = (Convenio)Session["convenio"];
        List<Convenio> lista = (List<Convenio>)Session["listaConvenio"];

        lista.Remove(convenio);

        txtBoxNome.Text = "";
        txtBoxSigla.Text = "";
        txtBoxTel.Text = "";
        this.ExibirMensagem("Exclusão Realizado com Sucesso");

    }


    public void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
    }
}
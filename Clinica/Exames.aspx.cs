using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exames : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
            ddlConvenio.DataSource = listaConvenio;
            ddlConvenio.DataTextField = "Nome";
            ddlConvenio.DataValueField = "Nome";
            ddlConvenio.DataBind();
            if (Session["Exame"] != null)
            {
                Exame exame = (Exame)Session["Exame"];
                txtBoxCodigo.Text = exame.Codigo;
                txtBoxNome.Text = exame.Nome;
                txtAreaObs.Text = exame.Observacoes;
                gdvDados.DataSource = exame.ListaConvenio;
                gdvDados.DataBind();
            }
            if (Request.QueryString["codigo"] != null)
            {
                List<Exame> listaExame = (List<Exame>)Session["listaExame"];
                foreach (Exame exame in listaExame)
                {
                    if (exame.Codigo.Equals(Convert.ToInt16(Request.QueryString["codigo"].ToString())))
                    {
                        txtBoxNome.Text = exame.Nome;
                        txtBoxCodigo.Text = exame.Codigo;
                        txtAreaObs.Text = exame.Observacoes;
                        Session["exame"] = exame;
                        break;
                    }
                }
            }
            else
            {
                if (Session["listaExame"] == null)
                {
                    Session["listaExame"] = new List<Exame>();

                }

            }

        }
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Convenio convenio = this.obterConvenio();
        Exame exame = new Exame(txtBoxCodigo.Text, txtBoxNome.Text, txtAreaObs.Text);
        List<Exame> lista = (List<Exame>)Session["listaExame"];
        lista.Add(exame);
        List<Convenio> listaAux = (List<Convenio>)Session["listaAuxConvenio"];
        exame.ListaConvenio.AddRange(listaAux);
        txtBoxNome.Text = "";
        txtBoxCodigo.Text = "";
        txtAreaObs.Text = "";
        gdvDados.Visible = false;
        this.ExibirMensagem("Cadastramento Realizado com Sucesso");
        return;


    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Convenio convenio = this.obterConvenio();
        Exame exame = (Exame)Session["exame"];
        exame.Nome = txtBoxNome.Text;
        exame.Codigo = txtBoxCodigo.Text;
        exame.Observacoes = txtAreaObs.Text;
        List<Convenio> listaAux = (List<Convenio>)Session["listaAuxConvenio"];
        exame.ListaConvenio.AddRange(listaAux);
        txtBoxNome.Text = "";
        txtBoxCodigo.Text = "";
        txtAreaObs.Text = "";
        this.ExibirMensagem("Alteração Realizada com Sucesso");
        return;


    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        Convenio convenio = this.obterConvenio();
        Exame exame = (Exame)Session["exame"];
        List<Exame> lista = (List<Exame>)Session["listaExame"];
        lista.Remove(exame);
        txtBoxNome.Text = "";
        txtBoxCodigo.Text = "";
        txtAreaObs.Text = "";
        this.ExibirMensagem("Exclusão Realizado com Sucesso");
        return;


    }

    protected void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
    }

    protected void btnAdicionar_Click(object sender, EventArgs e)
    {
        gdvDados.Visible = true;
        Convenio convenio = this.obterConvenio();
        List<Convenio> listaAux = (List<Convenio>)Session["listaAuxConvenio"];
        if (listaAux == null)
        {
            listaAux = new List<Convenio>();
        }
        if (!listaAux.Contains(convenio))
        {
            listaAux.Add(convenio);
            gdvDados.DataSource = listaAux;
            gdvDados.DataBind();
            Session["listaAuxConvenio"] = listaAux;
            return;
        }
        else
        {

            this.ExibirMensagem("Convênio Já Foi Adicionado !!!");
            return;
        }

    }

    protected void btnExcluirGrid_Click(object sender, EventArgs e)
    {
        Convenio convenio = this.obterConvenio();
        List<Convenio> listaAux = (List<Convenio>)Session["listaAux"];
        listaAux.Remove(convenio);
        gdvDados.DataSource = listaAux;
        gdvDados.DataBind();
        Session["listaAuxConvenio"] = listaAux;
        return;

    }


    public Convenio obterConvenio()
    {
        List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
        foreach (Convenio convenio in listaConvenio)
        {
            if (convenio.Nome.Equals(ddlConvenio.Text))
            {
                return convenio;

            }


        }
        return null;
    }
}
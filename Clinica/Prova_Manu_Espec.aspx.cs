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
            if (Session["especialidade"] != null)
            {
                Prova_Especialidade especialidade = (Prova_Especialidade)Session["especialidade"];
                txtBoxNome.Text = especialidade.NomeEspecialidade;
                txtBoxDescricao.Text = especialidade.Descricao;
            }
            if (Request.QueryString["id"] != null)
            {
                List<Prova_Especialidade> listaEspecialidade = (List<Prova_Especialidade>)Session["listaEspecialidade"];
                foreach (Prova_Especialidade especialidade in listaEspecialidade)
                {
                    if (especialidade.Id.Equals(Convert.ToInt16(Request.QueryString["id"].ToString())))
                    {
                        txtBoxNome.Text = especialidade.NomeEspecialidade;
                        txtBoxDescricao.Text = especialidade.Descricao;


                        Session["especialidade"] = especialidade;
                        break;
                    }
                }

            }
            else
            {
                if (Session["listaEspecialidade"] == null)
                {
                    Session["listaEspecialidade"] = new List<Prova_Especialidade>();


                }


            }

        }
    }
    protected void btnCadastrar_Click(object sender, EventArgs e)
    {

        List<Prova_Especialidade> lista = (List<Prova_Especialidade>)Session["listaEspecialidade"]; /* aponta pra lista de session no page load */
        if (lista.Count > 0)
        {

            foreach (Prova_Especialidade esp in lista)
            {
                if (esp.NomeEspecialidade.Equals(txtBoxNome.Text))
                {

                    this.ExibirMensagem("Especialidade já Cadastrada !!!");
                    return;
                }
            }
            this.Cadastrar(lista);
        }
        else
        {
            this.Cadastrar(lista);

        }



    }

    public void Cadastrar(List<Prova_Especialidade> lista)
    {
        int contador = Convert.ToInt32(Application["contadorEspecialidade"]) + 1;
        Application["contadorEspecialidade"] = contador;
        Prova_Especialidade especialidade = new Prova_Especialidade(txtBoxNome.Text, txtBoxDescricao.Text, contador);
        lista.Add(especialidade);

        this.ExibirMensagem("Cadastro Realizado Com Sucesso");

    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {

        Prova_Especialidade especialidade = (Prova_Especialidade)Session["especialidade"];
        especialidade.NomeEspecialidade = txtBoxNome.Text;
        especialidade.Descricao = txtBoxDescricao.Text;
        this.ExibirMensagem("Alteração Realizada Com Sucesso");



    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {

        Prova_Especialidade especialidade = (Prova_Especialidade)Session["especialidade"];
        List<Prova_Especialidade> lista = (List<Prova_Especialidade>)Session["listaEspecialidade"];
        if (especialidade.ListaMedicos.Count == 0)
        {
            lista.Remove(especialidade);
            txtBoxNome.Text = "";
            txtBoxDescricao.Text = "";

            this.ExibirMensagem("Exclusão Realizado com Sucesso");
        }
        else
        {
            this.ExibirMensagem("Existem " + especialidade.ListaMedicos.Count + " medicos associados a esta especialidade e por isto a exclusão não pode ser realizada");
            return;
        }



    }


    public void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
    }
}
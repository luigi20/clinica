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
            List<Prova_Especialidade> listaEspecialidade = (List<Prova_Especialidade>)Session["listaEspecialidade"];
            gdvDados.DataSource = listaEspecialidade;
            gdvDados.DataBind();
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


        List<Prova_Especialidade> listaEspecialidade = (List<Prova_Especialidade>)Session["listaEspecialidade"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        int id = Convert.ToInt32(gdvDados.DataKeys[row.RowIndex]["Id"]);


        foreach (Prova_Especialidade especialidade in listaEspecialidade)
        {
            if (especialidade.Id == id)
            {

                Session["especialidade"] = especialidade;
                Response.Redirect("Prova_Manu_Espec.aspx");

            }
        }
       


    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {

        List<Prova_Especialidade> listaEspecialidade = (List<Prova_Especialidade>)Session["listaEspecialidade"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        int id = Convert.ToInt32(gdvDados.DataKeys[row.RowIndex]["Id"]);


        foreach (Prova_Especialidade especialidade in listaEspecialidade)
        {
            if (especialidade.Id == id)
            {
                if (especialidade.ListaMedicos.Count == 0)
                {
                    listaEspecialidade.Remove(especialidade);
                    
                    
                }
                else
                {
                    this.ExibirMensagem("Existem " + especialidade.ListaMedicos.Count + " medicos associados a esta especialidade e por isto a exclusão não pode ser realizada");

                }
                return;

            }
        }

    }


    public void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        if (rdbEscolha.SelectedValue.Equals("1"))
        {
            List<Prova_Especialidade> lista = (List<Prova_Especialidade>)Session["listaEspecialidade"];
            var consulta = (from esp in lista

                            where (!String.IsNullOrEmpty(txtBoxNome.Text) && esp.NomeEspecialidade.Equals(txtBoxNome.Text)) &&
                                     (!String.IsNullOrEmpty(txtBoxDescricao.Text) && esp.Descricao.Contains(txtBoxDescricao.Text))
                            select esp).ToList<Prova_Especialidade>();
            if (consulta.Count > 0)
            {
                gdvDados.DataSource = consulta;
                gdvDados.DataBind();
                return;
            }
            else
            {
                this.ExibirMensagem("Nenhum Registro Foi Retornado !!!");
            }
            

        }
        else if (rdbEscolha.SelectedValue.Equals("2"))
        {
            List<Prova_Especialidade> lista = (List<Prova_Especialidade>)Session["listaEspecialidade"];
            var consulta = (from esp in lista

                            where (!String.IsNullOrEmpty(txtBoxNome.Text) && esp.NomeEspecialidade.Equals(txtBoxNome.Text)) ||
                                     (!String.IsNullOrEmpty(txtBoxDescricao.Text) && esp.Descricao.Contains(txtBoxDescricao.Text))
                            select esp).ToList<Prova_Especialidade>();
            if (consulta.Count > 0)
            {
                gdvDados.DataSource = consulta;
                gdvDados.DataBind();
                return;
            }
            else
            {
                this.ExibirMensagem("Nenhum Registro Foi Retornado !!!");
            }
        }
        else
        {
            this.ExibirMensagem("Deve-se Escolher Uma das Opções do RadioButton");

        }
        
    }
}
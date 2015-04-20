using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PesquisarMedico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            List<Medico> listaMedico = (List<Medico>)Session["listaMedicos"];
            gdvDados.DataSource = listaMedico;
            gdvDados.DataBind();
            List<Prova_Especialidade> listaEspecialidade = (List<Prova_Especialidade>)Session["listaEspecialidade"];
            ddlEspecialidade.DataSource = listaEspecialidade;
            ddlEspecialidade.DataTextField = "NomeEspecialidade";
            ddlEspecialidade.DataValueField = "NomeEspecialidade";
            ddlEspecialidade.DataBind();
            
        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {

      if (rdbEscolha.SelectedValue.Equals("1"))
        {
            List<Medico> lista = (List<Medico>)Session["listaMedicos"];
            var consulta = (from esp in lista

                            where (!String.IsNullOrEmpty(txtBoxCrm.Text) && esp.Crm.Equals(txtBoxCrm.Text)) &&
                                     (!String.IsNullOrEmpty(ddlEspecialidade.Text) && esp.Especialidade.NomeEspecialidade.Equals(ddlEspecialidade.Text))
                            select esp).ToList<Medico>();
            if (consulta.Count > 0)
            {
                gdvDados.DataSource = consulta;
                gdvDados.DataBind();
                return;
            }
            else
            {
                this.ExibirMensagem("Nenhum Registro Foi Retornado !!!");
                return;
            }
            

        }
        else if (rdbEscolha.SelectedValue.Equals("2"))
        {
            List<Medico> lista = (List<Medico>)Session["listaMedicos"];
            var consulta = (from esp in lista

                            where (!String.IsNullOrEmpty(txtBoxCrm.Text) && esp.Crm.Equals(txtBoxCrm.Text)) ||
                                     (!String.IsNullOrEmpty(ddlEspecialidade.Text) && esp.Especialidade.NomeEspecialidade.Equals(ddlEspecialidade.Text))
                            select esp).ToList<Medico>();
            if (consulta.Count > 0)
            {
                gdvDados.DataSource = consulta;
                gdvDados.DataBind();
                return;
            }
            else
            {
                this.ExibirMensagem("Nenhum Registro Foi Retornado !!!");
                return;
            }
        }
        else
        {
            this.ExibirMensagem("Deve-se Escolher Uma das Opções do RadioButton");
            return;
        }
        
    }
            
    
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        //grvPessoa.DataKeys[ e. row.RowIndex]["indx_ch_indexador"].ToString()
        List<Medico> listaMedicos = (List<Medico>)Session["listaMedicos"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        string crm = Convert.ToString(gdvDados.DataKeys[row.RowIndex]["crm"]);
        for (int i = 0; i < listaMedicos.Count; i++)
        {
            if (listaMedicos[i].Crm.Contains(crm))
            {
                listaMedicos.Remove(listaMedicos[i]);

            }
            break;
        }

        gdvDados.DataSource = listaMedicos;
        gdvDados.DataBind();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        List<Medico> listaMedicos = (List<Medico>)Session["listaMedicos"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        string crm = Convert.ToString(gdvDados.DataKeys[row.RowIndex]["Crm"]);


        foreach (Medico medico in listaMedicos)
        {
            if (medico.Crm.Contains(crm))
            {

                Session["medico"] = medico;
                Response.Redirect("Medico.aspx");

            }
        }

    }

public void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
    }
}
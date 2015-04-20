using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PesquisarConsulta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Consulta> listaConsulta = (List<Consulta>)Session["listaConsulta"];
            gdvDados.DataSource = listaConsulta;
            gdvDados.DataBind();
        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        List<Consulta> listaConsulta = (List<Consulta>)Session["listaConsulta"];
        if (listaConsulta != null)
        {
            List<Consulta> listaAux = new List<Consulta>();
            foreach (Consulta consulta in listaConsulta)
            {
                if (txtBoxNumConsulta.Text != "" && consulta.Id.Equals(Convert.ToInt32(txtBoxNumConsulta.Text)))
                {
                    listaAux.Add(consulta);
                   
                }


            }
            if (listaAux.Count > 0)
            {

                gdvDados.DataSource = listaAux;
                gdvDados.DataBind();
                return;
            }

        }

    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        //grvPessoa.DataKeys[ e. row.RowIndex]["indx_ch_indexador"].ToString()
        List<Consulta> listaConsulta = (List<Consulta>)Session["listaConsulta"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        int id = Convert.ToInt32(gdvDados.DataKeys[row.RowIndex]["Id"]);


        foreach (Consulta consulta in listaConsulta)
        {
            if (consulta.Id == id)
            {
                listaConsulta.Remove(consulta);
                consulta.NomePaciente.ListaConsulta.Remove(consulta);
                consulta.MedicoCrm.ListaConsulta.Remove(consulta);
                consulta.NomeConvenio.ListaConsulta.Remove(consulta);
                gdvDados.DataSource = listaConsulta;
                gdvDados.DataBind();
                this.ExibirMensagem("Consulta Excluida com Sucesso");
                return;
            }
        }


       
    }



    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        List<Consulta> listaConsulta = (List<Consulta>)Session["listaConsulta"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        int id = Convert.ToInt32(gdvDados.DataKeys[row.RowIndex]["Id"]);


        foreach (Consulta consulta in listaConsulta)
        {
            if (consulta.Id == id)
            {
                
                Session["consulta"] = consulta;
            }
        }
        Response.Redirect("MarcarConsulta.aspx");
    }
    protected void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
    }
}
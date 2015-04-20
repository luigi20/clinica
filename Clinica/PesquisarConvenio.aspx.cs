using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PesquisarConvenio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
            gdvDados.DataSource = listaConvenio;
            gdvDados.DataBind();
        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
        List<Convenio> listaAux = new List<Convenio>();
        foreach (Convenio Convenio in listaConvenio)
        {
            if (txtBoxNome.Text != "" && Convenio.Id.Equals(Convert.ToInt32(txtBoxNome.Text)))
            {
                listaAux.Add(Convenio);
                
            }


        }
        if (listaAux.Count > 0)
        {

            gdvDados.DataSource = listaAux;
            gdvDados.DataBind();
            return;
        }
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        //grvPessoa.DataKeys[ e. row.RowIndex]["indx_ch_indexador"].ToString()
        List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        int id = Convert.ToInt32(gdvDados.DataKeys[row.RowIndex]["Id"]);


        for (int i = 0; i < listaConvenio.Count; i++)
        {
            if (listaConvenio[i].Id == id)
                listaConvenio.Remove(listaConvenio[i]);
        }




        gdvDados.DataSource = listaConvenio;
        gdvDados.DataBind();
    }

    protected void gvdDados_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
        gdvDados.PageIndex = e.NewPageIndex;
        gdvDados.DataSource = listaConvenio;
        gdvDados.DataBind();

    }

    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        int id = Convert.ToInt32(gdvDados.DataKeys[row.RowIndex]["Id"]);


        foreach (Convenio convenio in listaConvenio)
        {
            if (convenio.Id == id)
            {

                Session["convenio"] = convenio;
                Response.Redirect("Convenios.aspx");
               
            }
        }
       
    }

}
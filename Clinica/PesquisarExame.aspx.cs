using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PesquisarExame : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Exame> listaExame = (List<Exame>)Session["listaExame"];
            gdvDados.DataSource = listaExame;
            gdvDados.DataBind();
        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        List<Exame> listaExame = (List<Exame>)Session["listaExame"];
        List<Exame> listaAux = new List<Exame>();
        foreach (Exame Exame in listaExame)
        {
            if (txtBoxCodigo.Text != "" && Exame.Codigo.Contains(txtBoxCodigo.Text))
            {
                listaAux.Add(Exame);
                
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
        List<Exame> listaExame = (List<Exame>)Session["listaExame"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        string codigo = Convert.ToString(gdvDados.DataKeys[row.RowIndex]["Codigo"]);


        for (int i = 0; i < listaExame.Count; i++)
        {
            if (listaExame[i].Codigo == codigo)
                listaExame.Remove(listaExame[i]);
        }




        gdvDados.DataSource = listaExame;
        gdvDados.DataBind();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        List<Exame> listaExame = (List<Exame>)Session["listaExame"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        string codigo = Convert.ToString(gdvDados.DataKeys[row.RowIndex]["codigo"]);


        foreach (Exame exame in listaExame)
        {
            if (exame.Codigo.Contains(codigo))
            {

                Session["Exame"] = exame;
                Response.Redirect("Exames.aspx");

            }
        }

    }

}
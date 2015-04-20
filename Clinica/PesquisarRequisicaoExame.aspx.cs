using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PesquisarRequisicaoExame : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<RequisicaoExame> listaRequisicaoExame = (List<RequisicaoExame>)Session["listaRequisicao"];
            gdvDados.DataSource = listaRequisicaoExame;
            gdvDados.DataBind();
        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        List<RequisicaoExame> listaRequisicaoExame = (List<RequisicaoExame>)Session["listaRequisicao"];
        if (listaRequisicaoExame != null)
        {
            List<RequisicaoExame> listaAux = new List<RequisicaoExame>();
            foreach (RequisicaoExame RequisicaoExame in listaRequisicaoExame)
            {
                if (txtBoxNumExame.Text != "" && RequisicaoExame.Id.Equals(Convert.ToInt32(txtBoxNumExame.Text)))
                {
                    listaAux.Add(RequisicaoExame);
                    break;
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
        List<RequisicaoExame> listaRequisicaoExame = (List<RequisicaoExame>)Session["listaRequisicao"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        int id = Convert.ToInt32(gdvDados.DataKeys[row.RowIndex]["Id"]);


        for (int i = 0; i < listaRequisicaoExame.Count; i++)
        {
            if (listaRequisicaoExame[i].Id == id)
                listaRequisicaoExame.Remove(listaRequisicaoExame[i]);
        }




        gdvDados.DataSource = listaRequisicaoExame;
        gdvDados.DataBind();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        List<RequisicaoExame> listaRequisicaoExame = (List<RequisicaoExame>)Session["listaRequisicao"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        int id = Convert.ToInt32(gdvDados.DataKeys[row.RowIndex]["Id"]);


        foreach (RequisicaoExame requisicaoExame in listaRequisicaoExame)
        {
            if (requisicaoExame.Id == id)
            {

                Session["requisicaoExame"] = requisicaoExame;
                Response.Redirect("RequisicaoExames.aspx");

            }
        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PesquisaTodosCamposConsulta : System.Web.UI.Page
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
        /*var query  = (from p in products              
              from o in orders                            
              from c in customers
              where p.ProductId == o.ProdutctId && 
            o.CustomerId == c.CustomerId
              select new { ProductId = p.ProductId, 
                 OrderId =o.OrderId,
                           CustomerId = c.CustomerId).ToList();*/
        List<Consulta> lista = (List<Consulta>)Session["listaConsulta"];

        var consulta = (from c in lista

                        where (!String.IsNullOrEmpty(txtBoxCRM.Text) || c.MedicoCrm.Crm.Equals(txtBoxCRM.Text)) &&
                                 (!String.IsNullOrEmpty(txtBoxConvenio.Text) || c.NomeConvenio.Id.Equals(txtBoxConvenio.Text)) &&
                                  (!String.IsNullOrEmpty(txtBoxCpf.Text) || c.NomePaciente.CPF.Equals(txtBoxCpf.Text)) &&
                            (!String.IsNullOrEmpty(txtBoxData.Text) || c.DataConsulta.ToShortDateString().Equals(txtBoxData.Text)) &&
                            (!String.IsNullOrEmpty(rdbSituacao.Text) || c.Situacao.Equals(rdbSituacao.Text)) &&
                            (!String.IsNullOrEmpty(ddlTurno.Text) || c.Situacao.Equals(ddlTurno.Text))
                        select c).ToList<Consulta>();
        if (consulta.Count > 0)
        {
            gdvDados.Visible = true;
            gdvDados.DataSource = consulta;
            gdvDados.DataBind();
            return;
        }
        else
        {
            gdvDados.Visible = false;
            this.ExibirMensagem("A Pesquisa Não Retornou Nenhum Registro !!!");
            return;
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
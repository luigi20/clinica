using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PesquisarConsultaConvenio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Consulta> listaConsultaPaciente = (List<Consulta>)Session["listaConsulta"];
            gdvDados.DataSource = listaConsultaPaciente;
            gdvDados.DataBind();

        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        if ((txtBoxConvenio.Text) != "")
        {
            List<Consulta> listaConsultaPaciente = (List<Consulta>)Session["listaConsulta"];
            int id = Convert.ToInt16(txtBoxConvenio.Text);

            foreach (Consulta consultaPaciente in listaConsultaPaciente)
            {

                if (txtBoxConvenio.Text != "" && consultaPaciente.NomeConvenio.Id == id)
                {
                    Convenio convenio = consultaPaciente.NomeConvenio;

                    gdvDados.DataSource = convenio.ListaConsulta;
                    gdvDados.DataBind();
                    return;
                }


            }
        }
        else
        {
            this.ExibirMensagem("Campo Deve Ser Preenchido !!!");
        }
    

    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        //grvPessoa.DataKeys[ e. row.RowIndex]["indx_ch_indexador"].ToString()
        List<Consulta> listaConsultaPaciente = (List<Consulta>)Session["listaConsulta"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        int id = Convert.ToInt32(gdvDados.DataKeys[row.RowIndex]["Id"]);
        foreach (Consulta consulta in listaConsultaPaciente)
        {
            if (consulta.Id == id)
            {
                listaConsultaPaciente.Remove(consulta);
                consulta.NomePaciente.ListaConsulta.Remove(consulta);
                consulta.MedicoCrm.ListaConsulta.Remove(consulta);
                consulta.NomeConvenio.ListaConsulta.Remove(consulta);
                gdvDados.DataSource = listaConsultaPaciente;
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
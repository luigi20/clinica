using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListaConsultaPaciente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Consulta> listaConsultaPaciente = (List<Consulta>)Session["listaConsultaDePaciente"];
            gdvDados.DataSource = listaConsultaPaciente;
            gdvDados.DataBind();
        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        List<Consulta> listaConsultaPaciente = (List<Consulta>)Session["listaConsultaDePaciente"];
        List<Consulta> listaAux = new List<Consulta>();

        foreach (Consulta consultaPaciente in listaConsultaPaciente)
        {
            if (txtBoxCpf.Text != "" && consultaPaciente.NomePaciente.CPF.Equals(txtBoxCpf.Text))
            {
               
                   listaAux.Add(consultaPaciente);
                
            }


        }
        if (listaAux.Count > 0)
        {

            gdvDados.DataSource = listaAux;
            gdvDados.DataBind();
        }
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        //grvPessoa.DataKeys[ e. row.RowIndex]["indx_ch_indexador"].ToString()
        List<Consulta> listaConsultaPaciente = (List<Consulta>)Session["listaConsultaDePaciente"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        string cpf = Convert.ToString(gdvDados.DataKeys[row.RowIndex]["Cpf"]);


        for (int i = 0; i < listaConsultaPaciente.Count; i++)
        {
            if (listaConsultaPaciente[i].NomePaciente.CPF == cpf)
                listaConsultaPaciente.Remove(listaConsultaPaciente[i]);
        }




        gdvDados.DataSource = listaConsultaPaciente;
        gdvDados.DataBind();
    }
}
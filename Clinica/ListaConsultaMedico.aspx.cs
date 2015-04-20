using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListaConsultaMedico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Consulta> listaConsultaMedico = (List<Consulta>)Application["listaConsultaMedico"];
            gdvDados.DataSource = listaConsultaMedico;
            gdvDados.DataBind();
        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        List<Consulta> listaConsultaMedico = (List<Consulta>)Application["listaConsultaMedico"];
        List<Consulta> listaAux = new List<Consulta>();

        foreach (Consulta consultaMedico in listaConsultaMedico)
        {
            if (txtBoxCrm.Text != "" && consultaMedico.MedicoCrm.Crm.Equals(txtBoxCrm.Text))
            {

                listaAux.Add(consultaMedico);

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
        List<Consulta> listaConsultaMedico = (List<Consulta>)Application["listaConsultaMedico"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        string crm = Convert.ToString(gdvDados.DataKeys[row.RowIndex]["Crm"]);


        for (int i = 0; i < listaConsultaMedico.Count; i++)
        {
            if (listaConsultaMedico[i].MedicoCrm.Crm== crm)
                listaConsultaMedico.Remove(listaConsultaMedico[i]);
        }




        gdvDados.DataSource = listaConsultaMedico;
        gdvDados.DataBind();
    }
}
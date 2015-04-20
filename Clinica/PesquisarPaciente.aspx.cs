using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PesquisarPaciente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Paciente> listaPaciente = (List<Paciente>)Session["listaPaciente"];
            gdvDados.DataSource = listaPaciente;
            gdvDados.DataBind();
        }
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        List<Paciente> listaPaciente = (List<Paciente>)Session["listaPaciente"];
        List<Paciente> listaAux = new List<Paciente>();
        foreach (Paciente paciente in listaPaciente)
        {
           
             if (txtBoxCPF.Text != "" && paciente.CPF.Contains(txtBoxCPF.Text))
            {
                listaAux.Add(paciente);
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

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        //grvPessoa.DataKeys[ e. row.RowIndex]["indx_ch_indexador"].ToString()
        List<Paciente> listaPaciente = (List<Paciente>)Session["listaPaciente"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        string cpf = Convert.ToString(gdvDados.DataKeys[row.RowIndex]["Cpf"]);


        for (int i = 0; i < listaPaciente.Count; i++)
        {
            if (listaPaciente[i].CPF == cpf)
                listaPaciente.Remove(listaPaciente[i]);
        }




        gdvDados.DataSource = listaPaciente;
        gdvDados.DataBind();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        List<Paciente> listaPacientes = (List<Paciente>)Session["listaPaciente"];
        GridViewRow row =
            (GridViewRow)((Button)sender).NamingContainer;

        string cpf = Convert.ToString(gdvDados.DataKeys[row.RowIndex]["Cpf"]);


        foreach (Paciente paciente in listaPacientes)
        {
            if (paciente.CPF.Contains(cpf))
            {

                Session["paciente"] = paciente;
                Response.Redirect("Paciente.aspx");

            }
        }

    }

}
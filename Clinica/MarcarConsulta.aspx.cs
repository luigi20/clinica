using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Formulario3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {


            List<Medico> listaMedico = (List<Medico>)Session["listaMedicos"];
            List<Paciente> listaPaciente = (List<Paciente>)Session["listaPaciente"];
            List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
            ddlConvenio.DataSource = listaConvenio;
            ddlConvenio.DataTextField = "Nome";
            ddlConvenio.DataValueField = "Nome";
            ddlConvenio.DataBind();

            ddlMedico.DataSource = listaMedico;
            ddlMedico.DataTextField = "Nome";
            ddlMedico.DataValueField = "Crm";
            ddlMedico.DataBind();

            ddlPaciente.DataSource = listaPaciente;
            ddlPaciente.DataTextField = "Nome";
            ddlPaciente.DataValueField = "Nome";
            ddlPaciente.DataBind();
            if (Session["consulta"] != null)
            {
                Consulta consulta = (Consulta)Session["consulta"];
                ddlPaciente.Text = consulta.NomePaciente.Nome;
                ddlConvenio.Text = consulta.NomeConvenio.Nome;
                CalendarioConsulta.SelectedDate = consulta.DataConsulta;
                ddlMedico.Text = consulta.MedicoCrm.Crm;
                ddlTurno.Text = consulta.Turno;
                rdbSituacao.Text = consulta.Situacao;
                rdbSituacao.Items.FindByValue("Realizada").Enabled = true;
                rdbSituacao.Items.FindByValue("Cancelada").Enabled = true;
            }


            if (Request.QueryString["id"] != null)
            {
                List<Consulta> listaConsulta = (List<Consulta>)Session["listaConsulta"];
                foreach (Consulta consulta in listaConsulta)
                {
                    if (consulta.Id.Equals(Convert.ToInt16(Request.QueryString["id"].ToString())))
                    {

                        ddlPaciente.Text = consulta.NomePaciente.Nome;
                        ddlConvenio.Text = consulta.NomeConvenio.Nome;
                        CalendarioConsulta.SelectedDate = consulta.DataConsulta;
                        ddlMedico.Text = consulta.MedicoCrm.Nome;
                        ddlTurno.Text = consulta.Turno;
                        Session["consulta"] = consulta;
                    }
                }


            }
            else
            {
                if (Session["listaConsulta"] == null)
                {
                    Session["listaConsulta"] = new List<Consulta>();
                }
            }

        }
    }
    protected void MarcarConsul_Click(object sender, EventArgs e)
    {

        this.Cadastrar();
    }

    protected void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Consulta consulta = (Consulta)Session["consulta"];
        Medico medico = consulta.MedicoCrm;
        Paciente paciente = consulta.NomePaciente;
        Convenio convenio = consulta.NomeConvenio;
        string data = consulta.DataConsulta.ToShortDateString();
        List<Consulta> listaConsulta = (List<Consulta>)Session["listaConsulta"];
        listaConsulta.Remove(consulta);
        medico.ListaConsulta.Remove(consulta);
        paciente.ListaConsulta.Remove(consulta);
        convenio.ListaConsulta.Remove(consulta);
        if (medico.DicConsulta.ContainsKey(data))
        {
            foreach (List<Consulta> value in medico.DicConsulta.Values)
            {

                value.Remove(consulta);
                break;
            }
        }

        this.Cadastrar();

    }

    public void Cadastrar()
    {
        Paciente paciente = this.obterPaciente();
        Medico medico = this.obterMedico();
        int contador = 0;
        int contConsulta = 0;
        string data = CalendarioConsulta.SelectedDate.ToShortDateString();
        Dictionary<string, List<Consulta>> dicConsultaCadastradas = medico.DicConsulta;
        if (dicConsultaCadastradas.Count == 0)
        {
            Convenio convenio = this.obterConvenio();
            contador = Convert.ToInt32(Application["contadorConsulta"]) + 1;
            Application["contadorConsulta"] = contador;
            Consulta consulta = new Consulta(paciente, medico,
                     convenio, CalendarioConsulta.SelectedDate, ddlTurno.Text, contador, rdbSituacao.Text);
            List<Consulta> lista = (List<Consulta>)Session["listaConsulta"];
            lista.Add(consulta);
            medico.ListaConsulta.Add(consulta);
            paciente.ListaConsulta.Add(consulta);
            convenio.ListaConsulta.Add(consulta);
            dicConsultaCadastradas.Add(data, medico.ListaConsulta);
            ddlConvenio.SelectedIndex = -1;
            ddlMedico.SelectedIndex = -1;
            ddlPaciente.SelectedIndex = -1;
            ddlTurno.SelectedIndex = -1;
            this.ExibirMensagem("Consulta Marcada com Sucesso");
            return;
        }

        else
        {
            foreach (KeyValuePair<string, List<Consulta>> dicConsulta in dicConsultaCadastradas)
            {

                if (dicConsulta.Key.Equals(data))
                {

                    foreach (Consulta c in dicConsulta.Value)
                    {

                        if (c.Turno.Equals(ddlTurno.Text))
                        {

                            contConsulta++;
                        }
                    }

                }

            }

            if (contConsulta >= medico.NumAtendimento)
            {
                this.ExibirMensagem("Limite Consultas Atingido Para o Medico "
                                     + medico.Nome + " em " +
                                     CalendarioConsulta.SelectedDate.ToShortDateString() +
                                     " No Turno da " + ddlTurno.Text);
                return;
            }
            else
            {
                Convenio convenio = this.obterConvenio();
                contador = Convert.ToInt32(Application["contadorConsulta"]) + 1;
                Application["contadorConsulta"] = contador;
                Consulta consulta = new Consulta(paciente, medico,
                convenio, CalendarioConsulta.SelectedDate, ddlTurno.Text, contador, rdbSituacao.Text);
                List<Consulta> lista = (List<Consulta>)Session["listaConsulta"];
                lista.Add(consulta);
                medico.ListaConsulta.Add(consulta);
                paciente.ListaConsulta.Add(consulta);
                convenio.ListaConsulta.Add(consulta);
                dicConsultaCadastradas[data] = medico.ListaConsulta;
                ddlConvenio.SelectedIndex = -1;
                ddlMedico.SelectedIndex = -1;
                ddlPaciente.SelectedIndex = -1;
                ddlTurno.SelectedIndex = -1;
                this.ExibirMensagem("Consulta Marcada com Sucesso");
                Session["consulta"] = null;
                return;

            }

        }


    }
    protected void rdbSituacao_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (rdbSituacao.SelectedIndex == 1)
        {
            lblMedicamento.Visible = true;
            txtBoxMedicamentos.Visible = true;
        }
        else
        {
            lblMedicamento.Visible = false;
            txtBoxMedicamentos.Visible = false;
        }
    }

    public Paciente obterPaciente()
    {
        List<Paciente> listaPaciente = (List<Paciente>)Session["listaPaciente"];
        foreach (Paciente paciente in listaPaciente)
        {
            if (paciente.Nome.Equals(ddlPaciente.Text))
            {
                return paciente;
            }

        }
        return null;
    }



    public Convenio obterConvenio()
    {
        List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
        foreach (Convenio convenio in listaConvenio)
        {
            if (convenio.Nome.Equals(ddlConvenio.Text))
            {
                return convenio;

            }


        }
        return null;
    }
    public Medico obterMedico()
    {
        List<Medico> listaMedico = (List<Medico>)Session["listaMedicos"];
        foreach (Medico medico in listaMedico)
        {
            if (medico.Nome.Equals(ddlMedico.Text))
            {
                return medico;

            }


        }
        return null;
    }
}
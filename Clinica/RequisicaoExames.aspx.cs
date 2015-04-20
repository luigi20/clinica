using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exames : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["requisicaoExame"] != null)
            {
                RequisicaoExame requisicaoExame = (RequisicaoExame)Session["requisicaoExame"];
                ddlPaciente.Text = requisicaoExame.NomePaciente.Nome;
                ddlExame.Text = requisicaoExame.NomeExame.Nome;
                CalendarioConsulta.SelectedDate = requisicaoExame.Data;
                rdbObservacoes.SelectedValue = requisicaoExame.Observacoes;
                txtBoxValor.Text = requisicaoExame.Valor.ToString();
            }
            List<Paciente> listaPaciente = (List<Paciente>)Session["listaPaciente"];
            ddlPaciente.DataSource = listaPaciente;
            ddlPaciente.DataTextField = "Nome";
            ddlPaciente.DataValueField = "Nome";
            ddlPaciente.DataBind();
            List<Exame> listaExame = (List<Exame>)Session["listaExame"];
            ddlExame.DataSource = listaExame;
            ddlExame.DataTextField = "Nome";
            ddlExame.DataValueField = "Nome";
            ddlExame.DataBind();

            if (Request.QueryString["id"] != null)
            {
                List<RequisicaoExame> listaRequisicao = (List<RequisicaoExame>)Session["listaRequisicao"];

                foreach (RequisicaoExame requisicaoExame in listaRequisicao)
                {
                    if (requisicaoExame.Id.Equals(Convert.ToInt16(Request.QueryString["id"].ToString())))
                    {

                        ddlPaciente.Text = requisicaoExame.NomePaciente.Nome;
                        ddlExame.Text = requisicaoExame.NomeExame.Nome;
                        CalendarioConsulta.SelectedDate = requisicaoExame.Data;
                        rdbObservacoes.SelectedValue = requisicaoExame.Observacoes;
                        txtBoxValor.Text = requisicaoExame.Valor.ToString();

                        Session["requisicaoExame"] = requisicaoExame;
                    }
                }
            }
            else
            {
                if (Session["listaRequisicao"] == null)
                {
                    Session["listaRequisicao"] = new List<RequisicaoExame>();
                }

            }

        }
    }
    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Paciente paciente = this.obterPaciente();
        Exame exame = this.obterExame();
        int contador = 0;
        if (exame.ListaConvenio.Contains(paciente.NomeConvenio))
        {
            contador = Convert.ToInt32(Application["contadorRequisicao"]) + 1;
            Application["contadorRequisicao"] = contador;
            RequisicaoExame requisicaoExame = new RequisicaoExame(paciente, exame, CalendarioConsulta.SelectedDate,
                     rdbObservacoes.Text, Convert.ToDouble(txtBoxValor.Text), paciente.NomeConvenio, contador);

            List<RequisicaoExame> lista = (List<RequisicaoExame>)Session["listaRequisicao"];
            lista.Add(requisicaoExame);
            ddlPaciente.SelectedIndex = -1;
            ddlExame.SelectedIndex = -1;
            rdbObservacoes.SelectedIndex = -1;
            txtBoxValor.Text = "";
            this.ExibirMensagem("Cadastramento Realizado com Sucesso");
            return;
        }
        else
        {
            this.ExibirMensagem("Convênio do paciente não permite a realização deste exame !!!");
            return;
        }

    }

    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Paciente paciente = this.obterPaciente();
        Exame exame = this.obterExame();
        RequisicaoExame requisicaoExame = (RequisicaoExame)Session["requisicaoExame"];

        if (exame.ListaConvenio.Contains(paciente.NomeConvenio))
        {
            requisicaoExame.NomeConvenio = paciente.NomeConvenio;
            requisicaoExame.NomeExame.Nome = ddlExame.Text;
            requisicaoExame.NomePaciente.Nome = ddlPaciente.Text;
            requisicaoExame.Observacoes = rdbObservacoes.SelectedValue;
            requisicaoExame.Valor = Convert.ToDouble(txtBoxValor.Text);
            ddlPaciente.SelectedIndex = -1;
            ddlExame.SelectedIndex = -1;
            rdbObservacoes.SelectedIndex = -1;
            txtBoxValor.Text = "";
            this.ExibirMensagem("Alteração Realizado com Sucesso !!!");
        }
        else
        {
            this.ExibirMensagem("Este Exame Não É Feito Pelo Convenio !!!");
            return;
        }

    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        Paciente paciente = this.obterPaciente();
        Exame exame = this.obterExame();
        if (exame.ListaConvenio.Contains(paciente.NomeConvenio))
        {
            RequisicaoExame requisicaoExame = (RequisicaoExame)Session["requisicaoExame"];
            List<RequisicaoExame> lista = (List<RequisicaoExame>)Session["listaRequisicao"];
            lista.Remove(requisicaoExame);
            ddlPaciente.SelectedIndex = -1;
            ddlExame.SelectedIndex = -1;
            rdbObservacoes.SelectedIndex = -1;
            txtBoxValor.Text = "";
            this.ExibirMensagem("Exclusão Realizado com Sucesso");
            return;
        }

    }



    protected void ExibirMensagem(string mensagem)
    {

        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
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

    public Exame obterExame()
    {
        List<Exame> listaExame = (List<Exame>)Session["listaExame"];
        foreach (Exame exame in listaExame)
        {
            if (exame.Nome.Equals(ddlExame.Text))
            {
                return exame;

            }


        }
        return null;
    }
 
}
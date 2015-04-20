using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Formulario1 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            List<Prova_Especialidade> listaEspecialidade = (List<Prova_Especialidade>)Session["listaEspecialidade"];
            ddlEspecialidade.DataSource = listaEspecialidade;
            ddlEspecialidade.DataTextField = "NomeEspecialidade";
            ddlEspecialidade.DataValueField = "NomeEspecialidade";
            ddlEspecialidade.DataBind();
            if (Session["medico"] != null)
            {
                Medico medico = (Medico)Session["medico"];
                txtBoxNome.Text = medico.Nome;
                txtBoxEndereco.Text = medico.Endereco;
                txtBoxTel.Text = medico.Telefone;

                txtBoxCpf.Text = medico.CPF;
                txtBoxCRM.Text = medico.Crm;
                txtBoxCidade.Text = medico.Cidade;
                ddlEstado.SelectedValue = medico.Estado;

                ddlAtendimento.SelectedValue = medico.NumAtendimento.ToString();
            }
            if (Request.QueryString["crm"] != null)
            {
                List<Medico> listaMedico = (List<Medico>)Session["listaMedicos"];
                foreach (Medico medico in listaMedico)
                {
                    if (medico.Crm.Equals(Request.QueryString["crm"].ToString()))
                    {
                        txtBoxNome.Text = medico.Nome;
                        txtBoxEndereco.Text = medico.Endereco;
                        txtBoxTel.Text = medico.Telefone;

                        txtBoxCpf.Text = medico.CPF;
                        txtBoxCRM.Text = medico.Crm;
                        txtBoxCidade.Text = medico.Cidade;
                        ddlEstado.SelectedValue = medico.Estado;

                        ddlAtendimento.SelectedValue = medico.NumAtendimento.ToString();
                        Session["medico"] = medico;
                    }
                }
            }
            else
            {
                if (Session["listaMedicos"] == null)
                {
                    Session["listaMedicos"] = new List<Medico>();
                }

            }
        }

    }


    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Prova_Especialidade especialidade = this.obterEspecialidade();
        Medico medico = new Medico(txtBoxNome.Text, txtBoxEndereco.Text, txtBoxCpf.Text, txtBoxTel.Text,
                   txtBoxCidade.Text, ddlEstado.Text, txtBoxCRM.Text, Convert.ToInt16(ddlAtendimento.Text), especialidade);
        if (ddlEspecialidade.Text.Equals("Selecione"))
        {
            this.ExibirMensagem("Escolha uma especialidade para o Medico !!!");
            return;
        }
        else
        {
            List<Medico> lista = (List<Medico>)Session["listaMedicos"];
            lista.Add(medico);
            especialidade.ListaMedicos.Add(medico);
            txtBoxNome.Text = "";
            txtBoxCRM.Text = "";
            txtBoxCidade.Text = "";
            txtBoxCpf.Text = "";
            txtBoxEndereco.Text = "";
            txtBoxTel.Text = "";
            ddlAtendimento.SelectedIndex = -1;
            ddlEstado.SelectedIndex = -1;
            this.ExibirMensagem("Cadastro Realizado com Sucesso");
        }

    }

    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Prova_Especialidade especialidade = this.obterEspecialidade();
        Medico medico = (Medico)Session["medico"];
        medico.Especialidade.ListaMedicos.Remove(medico);
        medico.Nome = txtBoxNome.Text;
        medico.Cidade = txtBoxCidade.Text;
        medico.CPF = txtBoxCpf.Text;
        medico.Endereco = txtBoxEndereco.Text;
        medico.Telefone = txtBoxTel.Text;
        medico.Estado = ddlEstado.Text;
        medico.Crm = txtBoxCRM.Text;
        medico.NumAtendimento = Convert.ToInt16(ddlAtendimento.Text);
        medico.Especialidade = especialidade;
        medico.Especialidade.ListaMedicos.Add(medico);
        txtBoxNome.Text = "";
        txtBoxCRM.Text = "";
        txtBoxCidade.Text = "";
        txtBoxCpf.Text = "";
        txtBoxEndereco.Text = "";
        txtBoxTel.Text = "";
        ddlAtendimento.SelectedIndex = -1;
        ddlEstado.SelectedIndex = -1;
        this.ExibirMensagem("Alteração Realizado com Sucesso");
    }

    public Prova_Especialidade obterEspecialidade()
    {
        List<Prova_Especialidade> listaEspecialidade = (List<Prova_Especialidade>)Session["listaEspecialidade"];
        foreach (Prova_Especialidade especialidade in listaEspecialidade)
        {
            if (especialidade.NomeEspecialidade.Equals(ddlEspecialidade.Text))
            {
                return especialidade;
            }

        }
        return null;

    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        Medico medico = (Medico)Session["medico"];
        List<Medico> lista = (List<Medico>)Session["listaMedicos"];
        medico.Especialidade.ListaMedicos.Remove(medico);
        lista.Remove(medico);
        txtBoxNome.Text = "";
        txtBoxCRM.Text = "";
        txtBoxCidade.Text = "";
        txtBoxCpf.Text = "";
        txtBoxEndereco.Text = "";
        txtBoxTel.Text = "";
        ddlAtendimento.SelectedIndex = -1;
        ddlEstado.SelectedIndex = -1;
        this.ExibirMensagem("Exclusão Realizado com Sucesso");
    }

    protected void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
    }


}


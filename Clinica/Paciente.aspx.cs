using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {
            if (Session["paciente"] != null)
            {
                Paciente paciente = (Paciente)Session["paciente"];
                txtBoxNome.Text = paciente.Nome;
                txtBoxEndereco.Text = paciente.Endereco;
                txtBoxTel.Text = Convert.ToString(paciente.Telefone);
                rdbSexo.Text = paciente.Sexo;
                txtBoxCpf.Text = paciente.CPF;

                txtBoxCidade.Text = paciente.Cidade;
                ddlEstado.SelectedValue = paciente.Estado;
                ddlConvenio.SelectedValue = paciente.NomeConvenio.Nome;
                txtBoxAniversario.Text = Convert.ToString(paciente.DataAniversario);

            }
            List<Convenio> listaConvenio = (List<Convenio>)Session["listaConvenio"];
            ddlConvenio.DataSource = listaConvenio;
            ddlConvenio.DataTextField = "Nome";
            ddlConvenio.DataValueField = "Nome";
            ddlConvenio.DataBind();
            if (Request.QueryString["cpf"] != null)
            {
                List<Paciente> listaPaciente = (List<Paciente>)Session["listaPaciente"];
                foreach (Paciente paciente in listaPaciente)
                {
                    if (paciente.CPF.Equals(Request.QueryString["cpf"].ToString()))
                    {
                        txtBoxNome.Text = paciente.Nome;
                        txtBoxEndereco.Text = paciente.Endereco;
                        txtBoxTel.Text = Convert.ToString(paciente.Telefone);
                        rdbSexo.Text = paciente.Sexo;
                        txtBoxCpf.Text = paciente.CPF;

                        txtBoxCidade.Text = paciente.Cidade;
                        ddlEstado.SelectedValue = paciente.Estado;
                        ddlConvenio.SelectedValue = paciente.NomeConvenio.Nome;
                        txtBoxAniversario.Text = Convert.ToString(paciente.DataAniversario);
                        Session["paciente"] = paciente;
                    }
                }
            }
            else
            {
                if (Session["listaPaciente"] == null)
                {
                    Session["listaPaciente"] = new List<Paciente>();
                }

            }

        }

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Convenio convenio = this.obterConvenio();
        Paciente paciente = new Paciente(txtBoxNome.Text, txtBoxEndereco.Text, txtBoxCpf.Text, txtBoxTel.Text,
                                 txtBoxCidade.Text, ddlEstado.Text, Convert.ToDateTime(txtBoxAniversario.Text),
                                 rdbSexo.Text, convenio);
        List<Paciente> lista = (List<Paciente>)Session["listaPaciente"]; /* aponta pra lista de session no page load */
        lista.Add(paciente);
        txtBoxNome.Text = "";
        ddlEstado.Text = "";
        txtBoxCidade.Text = "";
        txtBoxCpf.Text = "";
        txtBoxEndereco.Text = "";
        txtBoxTel.Text = "";
        ddlConvenio.SelectedIndex = -1;
        ddlEstado.SelectedIndex = -1;
        rdbSexo.SelectedIndex = -1;
        txtBoxAniversario.Text = "";
        this.ExibirMensagem("Cadastro Realizado com Sucesso");
    }

    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Paciente paciente = (Paciente)Session["paciente"];
        paciente.Nome = txtBoxNome.Text;
        paciente.Telefone = txtBoxTel.Text;
        paciente.Endereco = txtBoxEndereco.Text;
        paciente.DataAniversario = Convert.ToDateTime(txtBoxAniversario.Text);
        paciente.CPF = txtBoxCpf.Text;
        paciente.Cidade = txtBoxCidade.Text;
        paciente.NomeConvenio.Nome = ddlConvenio.SelectedValue;
        paciente.Estado = ddlEstado.SelectedValue;
        paciente.Sexo = rdbSexo.SelectedValue;
        txtBoxNome.Text = "";
        ddlEstado.Text = "";
        txtBoxCidade.Text = "";
        txtBoxCpf.Text = "";
        txtBoxEndereco.Text = "";
        txtBoxTel.Text = "";
        txtBoxAniversario.Text = "";
        ddlConvenio.SelectedIndex = -1;
        ddlEstado.SelectedIndex = -1;
        rdbSexo.SelectedIndex = -1;
        this.ExibirMensagem("Alteração Realizada com Sucesso");
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        Paciente paciente = (Paciente)Session["paciente"];
        List<Paciente> listaPaciente = (List<Paciente>)Session["listaPaciente"];
        listaPaciente.Remove(paciente);
        txtBoxNome.Text = "";
        ddlEstado.Text = "";
        txtBoxCidade.Text = "";
        txtBoxCpf.Text = "";
        txtBoxEndereco.Text = "";
        txtBoxTel.Text = "";
        txtBoxAniversario.Text = "";
        ddlConvenio.SelectedIndex = -1;
        ddlEstado.SelectedIndex = -1;
        rdbSexo.SelectedIndex = -1;
        this.ExibirMensagem("Exclusão Realizada com Sucesso");
    }



    protected void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
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
}
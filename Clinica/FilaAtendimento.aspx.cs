using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Senha : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Application["listaPreferencial"] == null && Application["listaNormal"] == null)
            {
                Application["listaPreferencial"] = new List<Atendimento>();
                Application["listaNormal"] = new List<Atendimento>();

            }
        }
    }

    protected void btnGerarSenha_Click(object sender, EventArgs e)
    {
        List<Atendimento> listaPreferencial = (List<Atendimento>)Application["listaPreferencial"];
        List<Atendimento> listaNormal = (List<Atendimento>)Application["listaNormal"];

        if (txtBoxCodigo.Text != "" && rdbTipo.SelectedIndex != -1)
        {

            Atendimento atendimento = new Atendimento(txtBoxCodigo.Text, rdbTipo.Text);
            if (atendimento.Tipo.Equals("Preferencial"))
            {
                listaPreferencial.Add(atendimento);

            }
            else
            {
                listaNormal.Add(atendimento);
            }
            this.ExibirMensagem("Senha Gerada com Sucesso");
        }
        this.ExibirMensagem("Os Campos Devem Ser Preenchidos !!!");
        rdbTipo.SelectedIndex = -1;
        txtBoxCodigo.Text = "";
    }
    protected void btnChamarSenha_Click(object sender, EventArgs e)
    {
        List<Atendimento> listaPreferencial = (List<Atendimento>)Application["listaPreferencial"];
        List<Atendimento> listaNormal = (List<Atendimento>)Application["listaNormal"];
        int auxContador = 0;
        int contador = 0;
        if (listaPreferencial.Count > 0)
        {
            auxContador = Convert.ToInt32(Application["contador"]);
            if (auxContador < 5)
            {
                for (int i = 0; i < listaPreferencial.Count; i++)
                {
                    txtBoxSenhaChamada.Text = "";
                    txtBoxTipoSenha.Text = "";
                    if (listaPreferencial[i].Tipo.Equals("Preferencial"))
                    {
                        txtBoxSenhaChamada.Text = listaPreferencial[i].Codigo ;
                        txtBoxTipoSenha.Text = listaPreferencial[i].Tipo;
                        listaPreferencial.Remove(listaPreferencial[i]);
                        contador = Convert.ToInt32(Application["contador"]) + 1;
                        Application["contador"] = contador;
                        this.ExibirMensagem("Senha Chamada com Sucesso");
                        return;
                    }
                }

            }
            else if (listaNormal.Count > 0)
            {
                auxContador = Convert.ToInt32(Application["contador"]);

                for (int i = 0; i < listaNormal.Count; i++)
                {
                    txtBoxSenhaChamada.Text = "";
                    txtBoxTipoSenha.Text = "";
                    if (listaNormal[i].Tipo.Equals("Normal"))
                    {
                        txtBoxSenhaChamada.Text = listaNormal[i].Codigo;
                        txtBoxTipoSenha.Text = listaNormal[i].Tipo;
                        listaNormal.Remove(listaNormal[i]);

                        Application["contador"] = 0;
                        this.ExibirMensagem("Senha Chamada com Sucesso");
                        return;
                    }
                }
            }

        }
        else if (listaNormal.Count > 0)
        {


            auxContador = Convert.ToInt32(Application["contador"]);

            for (int i = 0; i < listaNormal.Count; i++)
            {
                if (listaNormal[i].Tipo.Equals("Normal"))
                {
                    txtBoxSenhaChamada.Text = "";
                    txtBoxTipoSenha.Text = "";
                    txtBoxSenhaChamada.Text = listaNormal[i].Codigo;
                    txtBoxTipoSenha.Text = listaNormal[i].Tipo;
                    listaNormal.Remove(listaNormal[i]);

                    
                    this.ExibirMensagem("Senha Chamada com Sucesso");
                    break;
                }
            }


        }
        else
        {
            this.ExibirMensagem("Não há mais ninguém para Chamar");
        }





    }



    public void ExibirMensagem(string mensagem)
    {
        ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "Alert",
           "<script language='javascript'> { window.alert(\"" + mensagem + "\") }</script>");
    }
}
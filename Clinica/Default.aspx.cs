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
        List<Convenio> listaConvenio = new List<Convenio>();
        Convenio convenio1 = new Convenio("Sem Convenio", "Sem", "0", 0);
        Convenio convenio2 = new Convenio("Bradesco", "Bra", "32542134",1);
        Convenio convenio3 = new Convenio("Itau", "Ita", "32542135",2);
        Convenio convenio4 = new Convenio("Caixa", "CX", "32542136",3);
        Convenio convenio5 = new Convenio("Unimed", "Uni", "32542137",4);
        Convenio convenio6 = new Convenio("Prax", "Prax", "32542139",5);

        listaConvenio.Add(convenio1);
        listaConvenio.Add(convenio2);
        listaConvenio.Add(convenio3);
        listaConvenio.Add(convenio4);
        listaConvenio.Add(convenio5);
        listaConvenio.Add(convenio6);
        int contador = Convert.ToInt32(Application["contadorConvenio"]) + 5;
        Application["contadorConvenio"] = contador;
        Session["listaConvenio"] = listaConvenio;

        List<Exame> listaExame = new List<Exame>();
        Exame exame1 = new Exame("1", "Papanicolau", "");
        Exame exame2 = new Exame("2", "Ultrassonagrafia", "");
        Exame exame3 = new Exame("3", "Urina", "");
        Exame exame4 = new Exame("4", "Fezes", "");
        Exame exame5 = new Exame("5", "Sangue", "");
        listaExame.Add(exame1);
        listaExame.Add(exame2);
        listaExame.Add(exame3);
        listaExame.Add(exame4);
        listaExame.Add(exame5);
        Session["listaExame"] = listaExame;

        List<Prova_Especialidade> listaEspecialidade = new List<Prova_Especialidade>();
        Prova_Especialidade especialidade0 = new Prova_Especialidade("Selecione", "", 0);
        Prova_Especialidade especialidade1 = new Prova_Especialidade("Cardiologia", "", 1);
        Prova_Especialidade especialidade2 = new Prova_Especialidade("Geriatria", "", 2);
        int contadorEspecialidade = Convert.ToInt32(Application["contadorEspecialidade"]) + 2;
        Application["contadorEspecialidade"] = contador;
        listaEspecialidade.Add(especialidade0);
        listaEspecialidade.Add(especialidade1);
        listaEspecialidade.Add(especialidade2);
        Session["listaEspecialidade"] = listaEspecialidade;

        List<Medico> listaMedico = new List<Medico>();
        Medico medico1 = new Medico("Roberto", "rua 13", "343.434.340-30", "32323312", "Aracaju", "Sergipe", "00000",2, especialidade1);
        Medico medico2 = new Medico("Hugo", "rua 13", "343.434.341-31", "323233", "Aracaju", "Sergipe", "00001",2, especialidade1);
        Medico medico3 = new Medico("Pedro", "rua 13", "343.434.123-34", "323233", "Aracaju", "Sergipe", "00002",2, especialidade2);
        Medico medico4 = new Medico("Robert", "rua 13", "343.434.324-34", "323233", "Aracaju", "Sergipe", "00003",2, especialidade2);
        Medico medico5 = new Medico("Bruno", "rua 13", "343.434.432-34", "323233", "Aracaju", "Sergipe", "00004",2, especialidade1);
        listaMedico.Add(medico1);
        listaMedico.Add(medico2);
        listaMedico.Add(medico3);
        listaMedico.Add(medico4);
        listaMedico.Add(medico5);
        especialidade1.ListaMedicos.Add(medico1);
        especialidade1.ListaMedicos.Add(medico2);
        especialidade1.ListaMedicos.Add(medico5);
        especialidade2.ListaMedicos.Add(medico3);
        especialidade2.ListaMedicos.Add(medico4);
        Session["listaMedicos"] = listaMedico;

        List<Paciente> listaPaciente = new List<Paciente>();
        Paciente paciente1 = new Paciente("Dalmson", "rua 13", "343.434.340-30", "323233", "Aracaju", "Sergipe", new DateTime(1990, 10, 20), "masculino",convenio1 );
        Paciente paciente2 = new Paciente("Juliana", "rua 13", "343.434.340-31", "323233", "Aracaju", "Sergipe", new DateTime(1990, 10, 20), "masculino", convenio1);
        Paciente paciente3 = new Paciente("Pedro", "rua 13", "343.434.340-32", "323233", "Aracaju", "Sergipe", new DateTime(1990, 10, 20), "masculino", convenio2);
        Paciente paciente4 = new Paciente("Robert", "rua 13", "343.434.340-33", "323233", "Aracaju", "Sergipe", new DateTime(1990, 10, 20), "masculino", convenio2 );

        listaPaciente.Add(paciente1);
        listaPaciente.Add(paciente2);
        listaPaciente.Add(paciente3);
        listaPaciente.Add(paciente4);
    
        Session["listaPaciente"] = listaPaciente;

        List<Atendimento> listaNormal = new List<Atendimento>();
        List<Atendimento> listaPreferencial = new List<Atendimento>();
        Atendimento atendimento1 = new Atendimento("1", "Preferencial");
        Atendimento atendimento2 = new Atendimento("2", "Preferencial");
        Atendimento atendimento3 = new Atendimento("3", "Preferencial");
        Atendimento atendimento4 = new Atendimento("4", "Preferencial");
        Atendimento atendimento5 = new Atendimento("5", "Preferencial");
        Atendimento atendimento6 = new Atendimento("6", "Preferencial");
        Atendimento atendimento7 = new Atendimento("7", "Preferencial");
        Atendimento atendimento8 = new Atendimento("8", "Preferencial");
        Atendimento atendimento9 = new Atendimento("9","Normal");

        listaPreferencial.Add(atendimento1);
        listaPreferencial.Add(atendimento2);
        listaPreferencial.Add(atendimento3);
        listaPreferencial.Add(atendimento4);
        listaPreferencial.Add(atendimento5);
        listaPreferencial.Add(atendimento6);
        listaPreferencial.Add(atendimento7);
        listaPreferencial.Add(atendimento8);
        listaNormal.Add(atendimento9);
        Application["listaPreferencial"] = listaPreferencial;
        Application["listaNormal"] = listaNormal;

        List<Consulta> listaConsulta = new List<Consulta>();
        Consulta consulta1 = new Consulta(paciente1,medico1,convenio1,new DateTime(2015,03,31),"Manhã",1,"Agendada");
        medico1.ListaConsulta.Add(consulta1);
        convenio1.ListaConsulta.Add(consulta1);
        paciente1.ListaConsulta.Add(consulta1);
        medico1.DicConsulta.Add(new DateTime(2015, 03, 31).ToShortDateString(),medico1.ListaConsulta);
        int contadorConsulta = Convert.ToInt32(Application["contadorConsulta"]) + 1;
        Application["contadorConsulta"] = contadorConsulta;
        listaConsulta.Add(consulta1);

        
        Session["listaConsulta"] = listaConsulta;

        List<RequisicaoExame> listaRequisicao = new List<RequisicaoExame>();
        RequisicaoExame requisicao1 = new RequisicaoExame(paciente1, exame1, new DateTime(2015, 04, 30),"",100,convenio1,1);
        RequisicaoExame requisicao2 = new RequisicaoExame(paciente2, exame2, new DateTime(2015, 04, 30), "", 100, convenio2, 2);
        RequisicaoExame requisicao3 = new RequisicaoExame(paciente3, exame3, new DateTime(2015, 04, 30), "", 100, convenio3, 3);
        RequisicaoExame requisicao4 = new RequisicaoExame(paciente4, exame4, new DateTime(2015, 04, 30), "", 100, convenio4, 4);
        listaRequisicao.Add(requisicao1);
        listaRequisicao.Add(requisicao2);
        listaRequisicao.Add(requisicao3);
        listaRequisicao.Add(requisicao4);
        int contadorRequisicao = Convert.ToInt32(Application["contadorRequisicao"]) + 4;
        Application["contadorRequisicao"] = contador;
        Session["listaRequisicao"] = listaRequisicao;

     
        Response.Redirect("PesquisarPaciente.aspx");
    }
}
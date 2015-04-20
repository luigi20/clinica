using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Medico
/// </summary>
public class Medico : Pessoa
{
    private string crm;
    private int numAtendimento;
    private List<Consulta> listaConsulta;
    private Dictionary<string, List<Consulta>> dicConsulta;
    private Prova_Especialidade especialidade;

    
    public Dictionary<string, List<Consulta>> DicConsulta
    {
        get { return dicConsulta; }
        set { dicConsulta = value; }
    } 




    public Medico(string nome, string endereco, string cpf, string telefone, string cidade, string estado, string crm, int numAtendimento,Prova_Especialidade especialidade)
        : base(nome, endereco, cpf, telefone, cidade, estado)
    {
        this.crm = crm;
        this.numAtendimento = numAtendimento;
        this.dicConsulta = new Dictionary<string,List<Consulta>>();
        this.especialidade = especialidade;
    }


    public String Crm
    {
        get { return crm; }
        set { crm = value; }
    }
    public int NumAtendimento
    {
        get { return numAtendimento; }
        set { numAtendimento = value; }
    }

    public List<Consulta> ListaConsulta
    {
        get
        {
            if (this.listaConsulta == null)
            {
                this.listaConsulta = new List<Consulta>();
            }
            return listaConsulta;
        }
        set { listaConsulta = value; }
    }

    public Prova_Especialidade Especialidade
    {
        get { return especialidade; }
        set { especialidade = value; }
    }
}
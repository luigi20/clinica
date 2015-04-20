using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Paciente
/// </summary>
public class Paciente : Pessoa
{
    private DateTime dataAniversario;


    private String sexo;


    private Convenio nomeConvenio;

    private List<Consulta> listaConsulta;





    public Paciente(string nome, string endereco, string cpf, string telefone, string cidade, string estado, DateTime dataAniversario, string sexo, Convenio nomeConvenio)

        : base(nome, endereco, cpf, telefone, cidade, estado)
    {

        this.dataAniversario = dataAniversario;
        this.sexo = sexo;
        this.nomeConvenio = nomeConvenio;
        this.listaConsulta = new List<Consulta>();

        //
        // TODO: Add constructor logic here
        //
    }

    public DateTime DataAniversario
    {
        get { return dataAniversario; }
        set { dataAniversario = value; }
    }

    public String Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }


    public Convenio NomeConvenio
    {
        get { return nomeConvenio; }
        set { nomeConvenio = value; }
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
}
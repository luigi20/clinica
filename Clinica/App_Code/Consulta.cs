using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Consulta
/// </summary>
public class Consulta
{
    private Paciente nomePaciente;

    private Medico medicoCrm;

    private Convenio nomeConvenio;

    private DateTime dataConsulta;

    private string turno;

    private int id;

    private string situacao;

 


    
   

	public Consulta(Paciente paciente ,Medico medico,Convenio convenio,DateTime dataConsulta,string turno,int id,string situacao)
	{
        this.nomePaciente = paciente;
        this.medicoCrm = medico;
        this.nomeConvenio = convenio;
        this.dataConsulta = dataConsulta;
        this.turno = turno;
        this.id = id;
        this.situacao = situacao;

	}

    public Medico MedicoCrm
    {
        get { return medicoCrm; }
        set { medicoCrm = value; }
    }

    public Paciente NomePaciente
    {
        get { return nomePaciente; }
        set { nomePaciente = value; }
    }

    public Convenio NomeConvenio
    {
        get { return nomeConvenio; }
        set { nomeConvenio = value; }
    }

    public DateTime DataConsulta
    {
        get { return dataConsulta; }
        set { dataConsulta = value; }
    }

    public string Turno
    {
        get { return turno; }
        set { turno = value; }
    }

    public string Situacao
    {
        get { return situacao; }
        set { situacao = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
   
}
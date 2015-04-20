using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RequisicaoExame
/// </summary>
public class RequisicaoExame
{
    private Paciente nomePaciente;

  
    private Exame nomeExame;

   
    private DateTime data;

  
    private string observacoes;

  
    private double valor;


    private Convenio nomeConvenio;

    private int id;


 

	public RequisicaoExame(Paciente paciente,Exame exame,DateTime data,string observacoes,double valor,Convenio convenio,int id)
	{
        this.nomePaciente = paciente;
        this.nomeExame = exame;
        this.data = data;
        this.observacoes = observacoes;
        this.valor = valor;
        this.nomeConvenio = convenio;
        this.id = id;
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

    public double Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    public string Observacoes
    {
        get { return observacoes; }
        set { observacoes = value; }
    }

    public DateTime Data
    {
        get { return data; }
        set { data = value; }
    }

    public Exame NomeExame
    {
        get { return nomeExame; }
        set { nomeExame = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}
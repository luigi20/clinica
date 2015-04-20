using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Exame
/// </summary>
public class Exame
{
    private string codigo;

    
    private string nome;

   
    private string observacoes;

    private List<Convenio> listaConvenio;

   
  
	public Exame(string codigo,string nome,string observacoes)
	{
        this.codigo = codigo;
        this.nome = nome;
        this.observacoes = observacoes;
        this.listaConvenio = new List<Convenio>();
	}

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Observacoes
    {
        get { return observacoes; }
        set { observacoes = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public List<Convenio> ListaConvenio
    {
        get { return listaConvenio; }
        set { listaConvenio = value; }
    }
}
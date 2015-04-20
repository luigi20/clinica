using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Convenios
/// </summary>
public class Convenio
{
    private string nome;

  
    private string telefone;

   
    private string sigla;

    private int id;

    private List<Consulta> listaConsulta;

    public List<Consulta> ListaConsulta
    {
        get { return listaConsulta; }
        set { listaConsulta = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public Convenio(string nome, string sigla, string telefone,int id)
    {
        this.nome = nome;
        this.sigla = sigla;
        this.telefone = telefone;
        this.id= id;
        this.ListaConsulta = new List<Consulta>();
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }


    public string Sigla
    {
        get { return sigla; }
        set { sigla = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }
}
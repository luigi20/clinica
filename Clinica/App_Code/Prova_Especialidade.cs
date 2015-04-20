using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Senha
/// </summary>
public class Prova_Especialidade
{
    private string nomeEspecialidade;
    private string descricao;
    private int id;
    private List<Medico> listaMedicos;

   

	public Prova_Especialidade(string nomeEspecialidade,string descricao,int id)
	{
        this.nomeEspecialidade = nomeEspecialidade;
        this.descricao = descricao;
        this.id = id;
        this.listaMedicos = new List<Medico>();
	}

    public string Descricao
    {
        get { return descricao; }
        set { descricao = value; }
    }

    public string NomeEspecialidade
    {
        get { return nomeEspecialidade; }
        set { nomeEspecialidade = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public List<Medico> ListaMedicos
    {
        get { return listaMedicos; }
        set { listaMedicos = value; }
    }
}

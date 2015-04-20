using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pessoa
/// </summary>
abstract public class Pessoa
{
    private string nome;
    private string endereco;
    private string cpf;
    private string telefone;
    private string cidade;
    private string estado;



    public Pessoa(string nome,string endereco,string cpf,string telefone,String cidade,String estado)
	{

        this.nome = nome;
        this.endereco = endereco;
        this.cpf = cpf;
        this.telefone = telefone;
        this.cidade = cidade;
        this.estado = estado;
    
		//
		// TODO: Add constructor logic here
		//
	}
    

    public string Nome
    {
        get{return nome;}
        set{nome = value;}

    }

    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }
    public string CPF
    {
        get { return cpf; }
        set { cpf = value; }
    }
    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }
    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }
    public string Cidade
    {
        get { return cidade; }
        set { cidade = value; }
    }

 
}
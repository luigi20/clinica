using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Senha
/// </summary>
public class Atendimento
{
	private string codigo;

   
    private string tipo;

 

	public Atendimento(string codigo,string tipo)
	{
        this.tipo = tipo;
        this.codigo = codigo;
	}

     public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

       public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }
}

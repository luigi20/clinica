<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Paciente.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="App_Themes/Estilo1/Principal.css" rel="stylesheet" type="text/css" />
    <link href="App_Themes/Estilo1/StyleSheet.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="JS/Mascara.js">
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="top-nav" class="navbar navbar-inverse navbar-static-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar">
                    </span>
                </button>
                <a class="navbar-brand" href="#">CLÍNICA SÓ SAÚDE</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li class="dropdown"><a class="dropdown-toggle" role="button" data-toggle="dropdown"
                        href="#"><i class="glyphicon glyphicon-user"></i>Admin <span class="caret"></span>
                    </a>
                        <ul id="g-account-menu" class="dropdown-menu" role="menu">
                            <li><a href="#">My Profile</a></li>
                        </ul>
                    </li>
                    <li><a href="#"><i class="glyphicon glyphicon-lock"></i>Logout</a></li>
                </ul>
            </div>
        </div>
        <!-- /container -->
    </div>
    <!-- /Header -->
    <!-- Main -->
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-3">
                <!-- Left column -->
                <hr />
                <ul class="list-unstyled">
                    <li class="nav-header"><a href="#" data-toggle="collapse" data-target="#userMenu">
                        <h5>
                            Cadastros <i class="glyphicon glyphicon-chevron-down"></i>
                        </h5>
                    </a>
                        <ul class="list-unstyled collapse in" id="userMenu">
                            <li class="active"><a href="#"><i class="glyphicon glyphicon-home"></i>Home</a></li>
                            <li><a href="Medico.aspx"><i class="glyphicon glyphicon-briefcase"></i>Médicos</a></li>
                            <li><a href="Paciente.aspx"><i class="glyphicon glyphicon-user"></i>Pacientes</a></li>
                            <li><a href="Convenios.aspx"><i class="glyphicon glyphicon-th-large"></i>Convênios</a></li>
                            <li><a href="Exames.aspx"><i class="glyphicon glyphicon-folder-open"></i>Exames</a></li>
                            <li><a href=""><i class="glyphicon glyphicon-calendar"></i>Consultas</a></li>
                        </ul>
                    </li>
                    <hr />
                    <li class="nav-header"><a href="#" data-toggle="collapse" data-target="#menu2">
                        <h5>
                            Atendimento <i class="glyphicon glyphicon-chevron-down"></i>
                        </h5>
                    </a>
                        <ul class="list-unstyled collapse in" id="menu2">
                            <li><a href="RequisicaoExames.aspx"><i class="glyphicon glyphicon-hand-up"></i>Requisitar
                                Exames</a></li>
                            <li><a href="MarcarConsulta.aspx"><i class="glyphicon glyphicon-hand-right"></i>Marcar
                                Consultas</a></li>
                            <li><a href="FilaAtendimento.aspx"><i class="glyphicon glyphicon-hand-right"></i>Fila
                                de Atendimento</a></li>
                        </ul>
                    </li>
                    <hr />
                    <li class="nav-header"><a href="#" data-toggle="collapse" data-target="#menu2">
                        <h5>
                            Pesquisar <i class="glyphicon glyphicon-chevron-down"></i>
                        </h5>
                    </a>
                        <ul class="list-unstyled collapse in" id="Ul1">
                                                        <li><a href="PesquisarPaciente.aspx"><i class="glyphicon glyphicon-hand-up"></i>Paciente</a></li>
                            <li><a href="PesquisarMedico.aspx"><i class="glyphicon glyphicon-hand-right"></i>Médico</a></li>
                            <li><a href="PesquisarConvenio.aspx"><i class="glyphicon glyphicon-hand-right"></i>Convenio</a></li>
                            <li><a href="PesquisarExame.aspx"><i class="glyphicon glyphicon-hand-right"></i>Exame</a></li>
                            <li><a href="PesquisarConsulta.aspx"><i class="glyphicon glyphicon-hand-right"></i>Consulta</a></li>
                            <li><a href="PesquisarRequisicaoExame.aspx"><i class="glyphicon glyphicon-hand-right"></i>Requisição de Exame</a></li>
                            <li><a href="PesquisarConsultaPaciente.aspx"><i class="glyphicon glyphicon-hand-right"></i>Lista de Consultas Por Paciente</a></li>
                            <li><a href ="PesquisarConsultaMedico.aspx"><i class="glyphicon glyphicon-hand-right"></i>Lista de Consultas Por Medico</a></li>
                            <li><a href ="PesquisarConsultaConvenio.aspx"><i class="glyphicon glyphicon-hand-right"></i>Lista de Consultas Por Convenio</a></li> 
                            <li><a href ="PesquisaTodosCamposConsulta.aspx"><i class="glyphicon glyphicon-hand-right"></i>Lista de Consultas Por Todos os Campos</a></li> 
                        </ul>
                    </li>
                </ul>
            </div>
            <!-- /col-3 -->
            <div class="col-sm-9">
                <!-- column 2 -->
                <ul class="list-inline pull-right">
                    <li><a href="#"><i class="glyphicon glyphicon-cog"></i></a></li>
                </ul>
                <a href="#"><strong><i class="glyphicon glyphicon-dashboard"></i>Pacientes</strong></a>
                <hr />
                <div class="row">
                    <div class="col-md-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <i class="glyphicon glyphicon-wrench pull-right"></i>
                                    <h4 id="head_pagina">
                                        Cadastrar Pacientes</h4>
                                </div>
                            </div>
                            <div class="panel-body">
                                <div class="control-group col-md-10">
                                    <label>
                                        Nome</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtBoxNome" class="form-control" type="text" runat="server" />
                                        <asp:RequiredFieldValidator ID="rfvNome" ControlToValidate="txtBoxNome" runat="server"
                                            ErrorMessage="* Campo Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="control-group col-md-2">
                                    <label>
                                        Cidade</label>
                                    <div class="controls">
                                        <asp:TextBox class="form-control" MaxLength="4" ID="txtBoxCidade" type="text" runat="server" />
                                    </div>
                                </div>
                                <div class="control-group col-md-6">
                                    <label>
                                        Endereco</label>
                                    <div class="controls">
                                        <asp:TextBox class="form-control" MaxLength="14" ID="txtBoxEndereco" type="text"
                                            runat="server" />
                                    </div>
                                </div>
                                <div class="control-group col-md-4">
                                    <label>
                                        Data de Aniversario</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtBoxAniversario" runat="server" onKeyUp=" formataData(this,event);"
                                            MaxLength="10"></asp:TextBox>
                                        <br />
                                        <asp:RegularExpressionValidator ID="revAniver" runat="server" ErrorMessage="Data Inválida"
                                            ControlToValidate="txtBoxAniversario" ValidationExpression="^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/\d{4}$"
                                            ForeColor="Red"></asp:RegularExpressionValidator>
                                        <asp:RequiredFieldValidator ID="rfvAniversario" ControlToValidate="txtBoxAniversario"
                                            runat="server" ErrorMessage="* Campo Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="control-group col-md-12">
                                    <label>
                                        CPF</label>
                                    <div class="controls">
                                        <asp:TextBox class="form-control col-md-6" ID="txtBoxCpf" type="text" runat="server"
                                            MaxLength="14" onKeyUp="formataCPF(this,event)" />
                                        <asp:RegularExpressionValidator ID="revCPF" runat="server" ErrorMessage="CPF Inválido"
                                            ControlToValidate="txtBoxCpf" ValidationExpression="^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$"
                                            ForeColor="Red"></asp:RegularExpressionValidator>
                                        <br />
                                        <asp:RequiredFieldValidator ID="rfvCPF" runat="server" ErrorMessage="* Campo Obrigatorio"
                                            ControlToValidate="txtBoxCpf" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="control-group col-md-12">
                                    <label>
                                        Telefone</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtBoxTel" class="form-control col-md-10" type="text" runat="server"
                                            MaxLength="14" onKeyUp=" formataTelefone(this,event)" />
                                        <br />
                                        <asp:RequiredFieldValidator ID="rfvTelefone" runat="server" ErrorMessage="* Campo Obrigatorio"
                                            ControlToValidate="txtBoxTel" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="control-group col-md-6">
                                    <label>
                                        Estado</label>
                                    <div class="controls">
                                        <asp:DropDownList class="form-control" ID="ddlEstado" name="estado" runat="server">
                                            <asp:ListItem>Selecione um estado</asp:ListItem>
                                            <asp:ListItem>Acre</asp:ListItem>
                                            <asp:ListItem>Alagoas</asp:ListItem>
                                            <asp:ListItem>Amapá</asp:ListItem>
                                            <asp:ListItem>Amazonas</asp:ListItem>
                                            <asp:ListItem>Bahia</asp:ListItem>
                                            <asp:ListItem>Ceará</asp:ListItem>
                                            <asp:ListItem>Distrito Federal</asp:ListItem>
                                            <asp:ListItem>Espírito Santo</asp:ListItem>
                                            <asp:ListItem>Goiás</asp:ListItem>
                                            <asp:ListItem>Maranhão</asp:ListItem>
                                            <asp:ListItem>Mato Grosso</asp:ListItem>
                                            <asp:ListItem>Mato Grosso do Sul</asp:ListItem>
                                            <asp:ListItem>Minas Gerais</asp:ListItem>
                                            <asp:ListItem>Paraná</asp:ListItem>
                                            <asp:ListItem>Paraíba</asp:ListItem>
                                            <asp:ListItem>Pará</asp:ListItem>
                                            <asp:ListItem>Pernambuco</asp:ListItem>
                                            <asp:ListItem>Piauí</asp:ListItem>
                                            <asp:ListItem>Rio de Janeiro</asp:ListItem>
                                            <asp:ListItem>Rio Grande do Norte</asp:ListItem>
                                            <asp:ListItem>Rio Grande do Sul</asp:ListItem>
                                            <asp:ListItem>Roraima</asp:ListItem>
                                            <asp:ListItem>Santa Catarina</asp:ListItem>
                                            <asp:ListItem>Sergipe</asp:ListItem>
                                            <asp:ListItem>São Paulo</asp:ListItem>
                                            <asp:ListItem>Tocantins</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="control-group col-md-6">
                                    <label>
                                        Sexo</label>
                                    <div class="controls">
                                        <asp:RadioButtonList ID="rdbSexo" runat="server" RepeatDirection="Horizontal" BorderStyle="Solid">
                                            <asp:ListItem>Masculino</asp:ListItem>
                                            <asp:ListItem>Feminino</asp:ListItem>
                                        </asp:RadioButtonList>
                                        <asp:RequiredFieldValidator ID="rfvSexo" runat="server" ErrorMessage="* Campo Obrigatorio"
                                            ControlToValidate="rdbSexo" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <br />
                                        <label>
                                            <p style="left: 20px">
                                                Plano de Saude</p>
                                        </label>
                                        <div class="controls">
                                            <asp:DropDownList ID="ddlConvenio" runat="server">
                                                <asp:ListItem Selected="True">Selecione</asp:ListItem>
                                            </asp:DropDownList>
                                            <br />
                                            <asp:RequiredFieldValidator ID="rfvConvenio" runat="server" ErrorMessage="* Campo Obrigatorio"
                                                ControlToValidate="ddlConvenio" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <br />
                                </div>
                                <div class="control-group col-md-12">
                                    <label>
                                    </label>
                                    <div class="controls">
                                        <asp:Button class="btn btn-success" ID="btnSalvar" Text="Cadastrar" runat="server"
                                            OnClick="btnCadastrar_Click" />&nbsp;
                                        <asp:Button class="btn btn-primary" ID="btnEditar" runat="server" Text="Alterar"
                                            OnClick="btnAlterar_Click" />
                                        <asp:Button class="btn btn-danger" ID="btnExcluir" runat="server" Text="Excluir"
                                            OnClick="btnExcluir_Click" Width="70px" />
                                    </div>
                                </div>
                            </div>
                            <!--/panel content-->
                        </div>
                        <!--/panel-->
                    </div>
                    <!--/col-span-12-->
                </div>
                <!--/row-->
                <hr />
            </div>
            <!--/col-span-9-->
        </div>
    </div>
    <!-- /Main -->
    <footer class="text-center">Páginas relacionadas à atividade de <strong>Tecnologias Web</strong>.</footer>
    <div class="modal" id="addWidgetModal">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                        Ã—</button>
                    <h4 class="modal-title">
                        Add Widget</h4>
                </div>
                <div class="modal-body">
                    <p>
                        Add a widget stuff here..</p>
                </div>
                <div class="modal-footer">
                    <a href="#" data-dismiss="modal" class="btn">Close</a> <a href="#" class="btn btn-primary">
                        Save changes</a>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dalog -->
    </div>
    <!-- /.modal -->
    <!-- script references -->
    </form>
</body>
</html>

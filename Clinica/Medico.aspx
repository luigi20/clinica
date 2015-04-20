<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Medico.aspx.cs" Inherits="Formulario1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Clinica</title>
    <link href="App_Themes/Estilo1/Principal.css" rel="stylesheet" type="text/css" />
    <link href="App_Themes/Estilo1/StyleSheet.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="JS/Mascara.js"></script>
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
                <a href="#"><strong><i class="glyphicon glyphicon-dashboard"></i>Médicos</strong></a>
                <hr />
                <div class="row">
                    <div class="col-md-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <i class="glyphicon glyphicon-wrench pull-right"></i>
                                    <h4 id="head_pagina">
                                        Cadastrar Médico</h4>
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
                                        CRM</label>
                                    <div class="controls">
                                        <asp:TextBox class="form-control" ID="txtBoxCRM" type="text" 
                                            runat="server" Width="108px" />
                                        <asp:RequiredFieldValidator ID="rfvCRM" ControlToValidate="txtBoxCRM" runat="server"
                                            ErrorMessage="* Campo Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="control-group col-md-6">
                                    <label>
                                        CPF</label>
                                    <div class="controls">
                                        <asp:TextBox class="form-control" MaxLength="14" ID="txtBoxCpf" type="text" runat="server"
                                            onKeyUp="formataCPF(this,event)" />
                                        <asp:RegularExpressionValidator ID="revCPF" runat="server" ErrorMessage="CPF Inválido"
                                            ControlToValidate="txtBoxCpf" ValidationExpression="^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$"
                                            ForeColor="Red"></asp:RegularExpressionValidator>
                                        <asp:RequiredFieldValidator ID="rfvCPF" ControlToValidate="txtBoxCpf" runat="server"
                                            ErrorMessage="* Campo Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="control-group col-md-4">
                                    <label>
                                        Atendimentos por turno</label>
                                    <div class="controls">
                                        <asp:DropDownList class="form-control" ID="ddlAtendimento" name="dpl_atendimento"
                                            runat="server">
                                            <asp:ListItem Value="" Text="">Selecione </asp:ListItem>
                                            <asp:ListItem Value="1" Text="1">1</asp:ListItem>
                                            <asp:ListItem Value="2" Text="2">2</asp:ListItem>
                                            <asp:ListItem Value="3" Text="3">3</asp:ListItem>
                                            <asp:ListItem Value="4" Text="4">4</asp:ListItem>
                                            <asp:ListItem Value="5" Text="5">5</asp:ListItem>
                                            <asp:ListItem Value="6" Text="6">6</asp:ListItem>
                                            <asp:ListItem Value="7" Text="7">7</asp:ListItem>
                                            <asp:ListItem Value="8" Text="8">8</asp:ListItem>
                                            <asp:ListItem Value="9" Text="9">9</asp:ListItem>
                                            <asp:ListItem Value="10" Text="10">10</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="control-group col-md-12">
                                    <label>
                                        Telefone</label>
                                    <div class="controls">
                                        <asp:TextBox class="form-control col-md-6" ID="txtBoxTel" type="text" runat="server"
                                            MaxLength="14" onKeyUp=" formataTelefone(this,event)" />
                                        <asp:RequiredFieldValidator ID="rfvTelefone" ControlToValidate="txtBoxTel" runat="server"
                                            ErrorMessage="* Campo Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="control-group col-md-12">
                                    <label>
                                        Endereço</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtBoxEndereco" class="form-control col-md-10" type="text" runat="server" />
                                    </div>
                                </div>
                                <div class="control-group col-md-6">
                                    <label>
                                        Estado</label>
                                    <div class="controls">
                                        <asp:DropDownList class="form-control" ID="ddlEstado" name="estado" runat="server">
                                            <asp:ListItem Value="">Selecione um estado</asp:ListItem>
                                            <asp:ListItem Value="1">Acre</asp:ListItem>
                                            <asp:ListItem Value="2">Alagoas</asp:ListItem>
                                            <asp:ListItem Value="3">Amapá</asp:ListItem>
                                            <asp:ListItem Value="4">Amazonas</asp:ListItem>
                                            <asp:ListItem Value="5">Bahia</asp:ListItem>
                                            <asp:ListItem Value="6">Ceará</asp:ListItem>
                                            <asp:ListItem Value="7">Distrito Federal</asp:ListItem>
                                            <asp:ListItem Value="25">Espírito Santo</asp:ListItem>
                                            <asp:ListItem Value="8">Goiás</asp:ListItem>
                                            <asp:ListItem Value="9">Maranhão</asp:ListItem>
                                            <asp:ListItem Value="10">Mato Grosso</asp:ListItem>
                                            <asp:ListItem Value="11">Mato Grosso do Sul</asp:ListItem>
                                            <asp:ListItem Value="12">Minas Gerais</asp:ListItem>
                                            <asp:ListItem Value="13">Paraná</asp:ListItem>
                                            <asp:ListItem Value="14">Paraíba</asp:ListItem>
                                            <asp:ListItem Value="15">Pará</asp:ListItem>
                                            <asp:ListItem Value="16">Pernambuco</asp:ListItem>
                                            <asp:ListItem Value="17">Piauí</asp:ListItem>
                                            <asp:ListItem Value="26">Rio de Janeiro</asp:ListItem>
                                            <asp:ListItem Value="18">Rio Grande do Norte</asp:ListItem>
                                            <asp:ListItem Value="19">Rio Grande do Sul</asp:ListItem>
                                            <asp:ListItem Value="20">Roraima</asp:ListItem>
                                            <asp:ListItem Value="21">Santa Catarina</asp:ListItem>
                                            <asp:ListItem Value="22">Sergipe</asp:ListItem>
                                            <asp:ListItem Value="23">São Paulo</asp:ListItem>
                                            <asp:ListItem Value="24">Tocantins</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="control-group col-md-6">
                                    <label>
                                        Cidade</label>
                                    <div class="controls">
                                        <asp:TextBox class="form-control" ID="txtBoxCidade" type="text" runat="server" />
                                        <br />
                                        Especialidade:<br />
                                        <asp:DropDownList ID="ddlEspecialidade" runat="server">
                                        </asp:DropDownList>
                                    </div>
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

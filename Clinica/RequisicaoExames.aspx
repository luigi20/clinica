<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RequisicaoExames.aspx.cs"
    Inherits="Exames" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                            <li><a href="PesquisarRequisicaoExame.aspx"><i class="glyphicon glyphicon-hand-right">
                            </i>Requisição de Exame</a></li>
                            <li><a href="PesquisarConsultaPaciente.aspx"><i class="glyphicon glyphicon-hand-right">
                            </i>Lista de Consultas Por Paciente</a></li>
                            <li><a href="PesquisarConsultaMedico.aspx"><i class="glyphicon glyphicon-hand-right">
                            </i>Lista de Consultas Por Medico</a></li>
                            <li><a href="PesquisarConsultaConvenio.aspx"><i class="glyphicon glyphicon-hand-right">
                            </i>Lista de Consultas Por Convenio</a></li>
                            <li><a href="PesquisaTodosCamposConsulta.aspx"><i class="glyphicon glyphicon-hand-right">
                            </i>Lista de Consultas Por Todos os Campos</a></li>
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
                <a href="#"><strong><i class="glyphicon glyphicon-dashboard"></i>Exame</strong></a>
                <hr />
                <div class="row">
                    <div class="col-md-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <i class="glyphicon glyphicon-wrench pull-right"></i>
                                    <h4 id="head_pagina">
                                        Requisitar Exame</h4>
                                </div>
                            </div>
                            <div class="panel-body">
                                <div class="control-group col-md-10">
                                    <label>
                                        Exame</label><br />
                                    <br />
                                    <label>
                                        Paciente</label>
                                    <div class="controls">
                                        <label>
                                            <asp:DropDownList ID="ddlPaciente" runat="server" Width="300px">
                                            </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="control-group col-md-2">
                                    <br />
                                    <br />
                                    <label>
                                    </label>
                                    <div class="controls">
                                    </div>
                                </div>
                                <div class="control-group col-md-6">
                                    <label>
                                        Exame</label>
                                    <div class="controls">
                                        <asp:DropDownList ID="ddlExame" runat="server" Width="300px">
                                            <asp:ListItem Selected="True">Selecione</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <br />
                                <div class="control-group col-md-12">
                                    <br />
                                    <br />
                                    <label>
                                        Data</label>
                                    <div class="controls">
                                        <asp:Calendar ID="CalendarioConsulta" runat="server" Caption="Calendario" Width="245px"
                                            BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest"
                                            Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Style="margin-left: 285px;
                                            margin-top: 0px; margin-bottom: 0px">
                                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                            <OtherMonthDayStyle ForeColor="#999999" />
                                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                                                Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" HorizontalAlign="Left" />
                                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                            <WeekendDayStyle BackColor="#CCCCFF" />
                                        </asp:Calendar>
                                    </div>
                                </div>
                                <div class="control-group col-md-12">
                                    <label>
                                        Observacoes</label>
                                    <div class="controls">
                                        <asp:RadioButtonList ID="rdbObservacoes" runat="server" RepeatDirection="Horizontal"
                                            BorderColor="#CCCCCC" BorderStyle="Solid" AutoPostBack="True">
                                            <asp:ListItem>Particular</asp:ListItem>
                                            <asp:ListItem>Convenio</asp:ListItem>
                                        </asp:RadioButtonList>
                                        <asp:RequiredFieldValidator ID="rfvObservaocoes" ControlToValidate="rdbObservacoes"
                                            runat="server" ErrorMessage="* Campo Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="control-group col-md-6">
                                    <label>
                                        Valor</label>
                                    <div class="controls">
                                        <asp:TextBox class="form-control" MaxLength="14" ID="txtBoxValor" type="text" runat="server"
                                            OnKeyUp="formataValor(this, event)" />
                                        <br />
                                        <asp:RequiredFieldValidator ID="rfvValor" ControlToValidate="txtBoxValor" runat="server"
                                            ErrorMessage="* Campo Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="control-group col-md-4">
                                    <br />
                                    <div class="controls">
                                        </select>
                                    </div>
                                </div>
                                <div class="control-group col-md-12">
                                    <label>
                                    </label>
                                    <div class="controls">
                                        <asp:Button class="btn btn-success" ID="btnCadastrar" Text="Cadastrar" runat="server"
                                            OnClick="btnCadastrar_Click" />&nbsp;
                                        <asp:Button class="btn btn-primary" ID="btnAlterar" runat="server" Text="Alterar"
                                            OnClick="btnAlterar_Click" />
                                        <asp:Button class="btn btn-danger" ID="btnExcluir" runat="server" Text="Excluir"
                                            OnClick="btnExcluir_Click" Width="70px" />
                                    </div>
                                </div>
    </form>
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
    </div> </div>
    <!-- /Main -->
    <footer class="text-center">Páginas relacionadas à atividade de  de <strong>Tecnologias Web</strong>.</footer>
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

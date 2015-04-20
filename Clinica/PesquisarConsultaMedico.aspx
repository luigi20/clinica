<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PesquisarConsultaMedico.aspx.cs"
    Inherits="ListaConsultaMedico" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="App_Themes/Estilo1/Principal.css" rel="stylesheet" type="text/css" />
    <link href="App_Themes/Estilo1/StyleSheet.css" rel="stylesheet" type="text/css" />
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
                <a href="#"><strong><i class="glyphicon glyphicon-dashboard"></i>Pesquisar</strong></a>
                <hr />
                <div class="row">
                    <div class="col-md-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <i class="glyphicon glyphicon-wrench pull-right"></i>
                                    <h4 id="head_pagina">
                                        Consulta</h4>
                                </div>
                            </div>
                            <div class="panel-body">
                                <div class="control-group col-md-10">
                                    <label>
                                        CRM do Médico</label>
                                    <div class="controls">
                                        <asp:TextBox class="form-control col-md-6" ID="txtBoxCrm" type="text" runat="server" />
                                    </div>
                                </div>
                                <div class="control-group col-md-6">
                                    &nbsp;<div class="controls">
                                        <br />
                                        <asp:Button class="btn btn-primary" ID="btnPesquisar" runat="server" Text="Pesquisar"
                                            OnClick="btnPesquisar_Click" />
                                    </div>
                                </div>
                                <div class="control-group col-md-12">
                                </div>
                                <div class="control-group col-md-12">
                                    <label>
                                    </label>
                                    <div class="controls">
                                        <br />
                                        <br />
                                        <asp:GridView ID="gdvDados" runat="server" AutoGenerateColumns="False" BorderColor="White"
                                            BorderStyle="Solid" Caption="Consultas" CellPadding="4" ForeColor="#333333" GridLines="Vertical"
                                            Width="789px" DataKeyNames="Id">
                                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="CRM">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblMedicoCrm" runat="server" Text='<%# Bind("MedicoCrm.crm") %>' CausesValidation="false" />
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="Id" HeaderText="ID da Consulta">
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="medicoCrm" HeaderText="CRM" Visible="False">
                                                    <FooterStyle HorizontalAlign="Center" />
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="nomePaciente" HeaderText="Nome do Paciente" Visible="False">
                                                    <FooterStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="Nome do Paciente">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblNomePaciente" runat="server" Text='<%# Bind("NomePaciente.nome") %>'
                                                            CausesValidation="false" />
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="nomeConvenio" HeaderText="Convenio">
                                                    <FooterStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="dataConsulta" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Data da Consulta">
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Turno" HeaderText="Turno">
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Situacao" HeaderText="Situacao">
                                                    <FooterStyle HorizontalAlign="Center" />
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="Ações">
                                                    <ItemTemplate>
                                                        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar"
                                                            CausesValidation="false" />
                                                        <asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click" Text="Excluir"
                                                            CausesValidation="false" />
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <EditRowStyle BackColor="#999999" />
                                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                        </asp:GridView>
                                        <br />
                                        <br />
                                        &nbsp;&nbsp;&nbsp;
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

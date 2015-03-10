<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CadCondominio.aspx.cs" Inherits="sysCondominio.views.Cadastro.CadCondominio" %>

<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=2.0.6.2393, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
            
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>
                    <%: Page.Title %>.</h1>
                <h2>Area do Sistema destinada ao Cadastro dos Clientes ao Condomínio.</h2>
            </hgroup>
            <p>
                <span>Preencha os campos a seguir para efetuar o cadastro do cliente ao Condomínio.</span>
            </p>
            <p>
                <span>Logo após o término, a Alteração ao Condomínio poderá ser realizado. </span>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <layouttemplate>
        <fieldset>
<asp:Panel ID="pnConsCliente" runat="server">
  <ol class="round">
       
        <table style="width: 100%;">
            <tr>
                <td><asp:Label ID="lblnome" runat="server" Text="Digite o Nome : "></asp:Label></td>
                <td>
                   <div class="itensForm"> 
                       <asp:TextBox ID="txtNomeConsulta" runat="server" Width="250px"></asp:TextBox></div>
                </td>
                <td>
                    <asp:Button ID="btnConsultarEntity" runat="server" 
                        OnClick="btnConsultarEntity_Click" Text="Consultar Entity" Width="140px" />
                    <asp:Button ID="btnConsultaNHibernate" runat="server" 
                        onclick="btnConsultaNHibernate_Click" Text="Consulta NHibernate" 
                        Width="140px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="lblSelect" runat="server" Text="Selecionar :" Visible="False"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlNomes" runat="server" Width="247px" Visible="False">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnSelecionarEntity" runat="server" 
                        OnClick="btnSelecionarEntity_Click" Text="Selecionar" Visible="False" 
                        Width="140px" />
                    <asp:Button ID="btnSelecionarNHibernate" runat="server" 
                        onclick="btnSelecionarNHibernate_Click" Text="Selecionar" Visible="False" 
                        Width="140px" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                     &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>


    </ol>



</asp:Panel>
<asp:Panel ID="pnCondominio" runat="server" Visible="False">
    <ol class="round">
       
        <table style="width: 100%;">
            <tr>
                <td>Nome :</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" 
                        ReadOnly="True" Width="250px"></asp:TextBox>
                </td>
                <td>                    
                    <div class="itensForm">
                    </div>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>CPF :</td>
                <td>
                    &nbsp;</td>
                <td>
                    <ew:MaskedTextBox ID="txtCPF" runat="server" Mask="999.999.999-99" 
                        ReadOnly="True" />
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Data de Nascimento :</td>
                <td></td>
                <td>
                    <ew:MaskedTextBox ID="mtxtDtNasc" runat="server" Mask="99/99/9999" 
                        ReadOnly="True" /></td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Ala :</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlAlasEntity" runat="server" AutoPostBack="True" DataSourceID="EntityDataSource2" 
                        DataTextField="numeroAla" DataValueField="id" 
                        onselectedindexchanged="ddlAlasEntity_SelectedIndexChanged" Width="199px" 
                        Visible="False">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlAlasNHibernate" runat="server" AutoPostBack="True" DataSourceID="EntityDataSource2" 
                        DataTextField="numeroAla" DataValueField="id" 
                        onselectedindexchanged="ddlAlasNHibernate_SelectedIndexChanged" Visible="False" 
                        Width="201px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
                    <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Quarto :</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlQuartosEntity" runat="server" 
                        Visible="False" Width="199px">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlQuartosNHibernate" runat="server" Visible="False" 
                        Width="199px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:EntityDataSource ID="EntityDataSource2" runat="server" 
                        ConnectionString="name=BD_CondominioEntities" 
                        DefaultContainerName="BD_CondominioEntities" EnableFlattening="False" 
                        EntitySetName="tabAla">
                    </asp:EntityDataSource>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                     &nbsp;</td>
            </tr>
            <tr>
          <td>Tempo :</td>
                <td> 
                       &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtTempo" runat="server" 
                        Width="250px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                     &nbsp;</td>
            </tr>
            <tr>
                <td>Data de Entrada :</td>
                <td>
                    &nbsp;</td>
                <td>
                    <ew:MaskedTextBox ID="txtDataEntrada" runat="server" Mask="99/99/9999" 
                        Width="253px" />
                </td>
                <td>
                    &nbsp;</td>
                <td></td>
                <td>
                     </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnCadCondEntity" runat="server" OnClick="btnCadCondEntity_Click1" 
                        Text="Cadastrar Entity" Visible="False" Width="140px" />
                </td>
                <td>&nbsp;</td>
                <td>
                     &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnCadCondNHibernate" runat="server" 
                        Text="Cadastrar NHibernate" onclick="btnCadCondNHibernate_Click" 
                        Visible="False" Width="140px" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>


    </ol>
    </asp:Panel>


        </fieldset>
        </layouttemplate>
</asp:Content>

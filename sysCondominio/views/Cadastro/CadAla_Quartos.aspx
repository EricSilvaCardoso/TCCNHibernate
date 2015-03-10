<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadAla_Quartos.aspx.cs" Inherits="sysCondominio.views.Cadastro.CadAla_Quartos" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=2.0.6.2393, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>
                    <%: Page.Title %>.</h1>
                <h2>Area do Sistema destinada ao Cadastro dos Quartos e Alas.</h2>
            </hgroup>
            <p>
                <span>Preencha os campos a seguir para efetuar o cadastro dos Quartos e Alas.</span>
            </p>
            <p>
                <span>Logo após o término, o Cadastro ao Condomínio poderá ser realizado. </span>
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
                <td>Selecione tipo de Cadastro :</td>
                <td>
                   <div class="itensForm"> 
                       <asp:RadioButtonList ID="rblTipoCad" runat="server" 
                           RepeatDirection="Horizontal" Width="228px" AutoPostBack="True" 
                           onselectedindexchanged="rblTipoCad_SelectedIndexChanged">
                           <asp:ListItem Value="1">Alas</asp:ListItem>
                           <asp:ListItem Value="2">Quartos</asp:ListItem>
                       </asp:RadioButtonList>
                    </div>
                </td>
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
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                     &nbsp;</td>
            </tr>
            </table>


    </ol>



</asp:Panel>
<asp:Panel ID="pnAlas" runat="server" Visible="False">
    <ol class="round">
       
        <table style="width: 100%;">
            <tr>
                <td>Número da ALA :</td>
                <td>
                   <div class="itensForm"> 
                       <ew:MaskedTextBox ID="txtALA" runat="server" Mask="999" MaxLength="3" />
                    </div>
                </td>
                <td>
                    <asp:Button ID="btnCadAlaNHibenate" runat="server" Text="Cadastrar NHibernate" 
                        Width="150px" onclick="btnCadAlaNHibernate_Click" />
                    <br />
                    <asp:Button ID="btnCadAlaEntity" runat="server" 
                        onclick="btnCadAlaEntity_Click" Text="Cadastrar Entity" Width="150px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>


    </ol>
    </asp:Panel>
    <asp:Panel ID="pnQuartos" runat="server" Visible="False">
    <ol class="round">
       
        <table style="width: 100%;">
            <tr>
                <td>ALAS&nbsp; :</td>
                <td>
                   <div class="itensForm"> 
                       <asp:DropDownList ID="DropDownList1" runat="server" CssClass="textboxgrande" 
                           Width="199px" DataSourceID="EntityDataSource1" 
                           DataTextField="numeroAla" DataValueField="id">
                       </asp:DropDownList>
                       <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
                           ConnectionString="name=BD_CondominioEntities" 
                           DefaultContainerName="BD_CondominioEntities" EnableFlattening="False" 
                           EntitySetName="tabAla">
                       </asp:EntityDataSource>
                    </div>
                </td>
                <td>Número do Quarto :</td>
                <td>
                    <ew:MaskedTextBox ID="txtNumeroQuarto" runat="server" Mask="999" />
                </td>
            </tr>
             <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button runat="server" Text="Cadastrar NHibernate" 
                        Width="150px" onclick="btnCadQuartoNHibernate_Click" />
                    <br />
                    <asp:Button ID="btnCadQuarto_Entity" runat="server" 
                        onclick="btnCadQuarto_Entity_Click" Text="Cadastrar Entity" 
                        Width="150px" />
                </td>
            </tr>
            </table>


    </ol>
    </asp:Panel>

        </fieldset>
        </layouttemplate>
</asp:Content>

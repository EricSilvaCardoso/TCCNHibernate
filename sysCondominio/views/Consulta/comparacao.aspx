<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="comparacao.aspx.cs" Inherits="sysCondominio.views.Consulta.comparacao" %>
<%@ Register TagPrefix="ew" Namespace="eWorld.UI" Assembly="eWorld.UI, Version=2.0.6.2393, Culture=neutral, PublicKeyToken=24d65337282035f2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 361px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>
                    <%: Page.Title %>.</h1>
                <h2>Area do Sistema destinada a Comparação do Entity Framework com o NHibernate.</h2>
            </hgroup>
            <p>
                <span>Será realizada dois tipos consultas ao Banco de Dados.</span>
            </p>
            <p>
                <span>Assim que a consulta for realizada, o tempo de consulta será exibido logo abaixo na Tela. </span>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <ol class="round">
       
        <table style="width: 100%;">
            <tr>
                <td class="style1">
                    <h5>
                        <asp:ImageButton ID="ibtnNHibernate" runat="server" Height="53px" 
                            ImageUrl="~/Images/NHibernate_2_logo1.png" onclick="ibtnNHibernate_Click" 
                            ToolTip="Carregar Dados NHibernate" Width="99px" />
                    </h5></td>
                <td class="auto-style3">
                   <div class="itensForm"> 
                       <asp:GridView ID="gdvNHibernate" runat="server" AllowPaging="True" CellPadding="4" 
                           ForeColor="#333333" GridLines="None" PageSize="5" 
                           AutoGenerateColumns="False" 
                           onpageindexchanging="gdvNHibernate_PageIndexChanging">
                           <AlternatingRowStyle BackColor="White" />
                           <Columns>
                               <asp:BoundField DataField="id" HeaderText="Id" />
                               <asp:BoundField DataField="nome" HeaderText="Nome" />
                               <asp:BoundField DataField="dt_nascimento" HeaderText="Data Nascimento" />
                           </Columns>
                           <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                           <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                           <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                           <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                           <SortedAscendingCellStyle BackColor="#FDF5AC" />
                           <SortedAscendingHeaderStyle BackColor="#4D0000" />
                           <SortedDescendingCellStyle BackColor="#FCF6C0" />
                           <SortedDescendingHeaderStyle BackColor="#820000" />
                       </asp:GridView>
                    </div>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="lblNHibernate" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <h5>
                        <asp:ImageButton ID="ibtnEntityFramework" runat="server" Height="53px" 
                            ImageUrl="~/Images/EntityFramework.jpg" onclick="ibtnEntityFramework_Click" 
                            ToolTip="Carregar Dados Entity Framework" Width="99px" />
                    </h5>
                    <p>&nbsp;</p>
                    <p>&nbsp;</p></td>
                <td class="auto-style3" colspan="3">
                    <asp:GridView ID="gridEntity" runat="server" AllowPaging="True" 
                        CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5" 
                        AutoGenerateColumns="False" 
                        onpageindexchanging="gridEntity_PageIndexChanging">
                        <AlternatingRowStyle BackColor="White" />
                          <Columns>
                               <asp:BoundField DataField="id" HeaderText="Id" />
                               <asp:BoundField DataField="nome" HeaderText="Nome" />
                               <asp:BoundField DataField="dt_nascimento" HeaderText="Data Nascimento" />
                           </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <EmptyDataTemplate>
                            Id
                        </EmptyDataTemplate>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style1">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblEntity" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="style1">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td>
                     &nbsp;</td>
            </tr>
            </table>


    </ol>
</asp:Content>

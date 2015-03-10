<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CadCliente.aspx.cs" Inherits="sysCondominio.views.Cadastro.CadCliente" %>

<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
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
                <h2>Area do Sistema destinada ao Cadastro dos Clientes.</h2>
            </hgroup>
            <p>
                <span>Preencha os campos a seguir para efetuar o cadastro do cliente.</span>
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
        <asp:Panel ID="pnCAD" runat="server">
    <ol class="round">
       
        <table style="width: 100%;">
            <tr>
                <td>Nome :</td>
                <td>
                   <div class="itensForm"> 
                       <asp:TextBox ID="txtNome" runat="server" Width="250px" 
                        CssClass="textboxgrande"></asp:TextBox></div>
                </td>
                <td>Data de Nascimento :</td>
                <td>
                    <ew:MaskedTextBox ID="txtDtNasc" runat="server" Mask="99/99/9999" />
                </td>
            </tr>
            <tr>
                <td>Sexo:
                </td>
                <td>
                    <asp:DropDownList ID="ddlSexo" runat="server" Width="90px">
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Escolaridade : </td>
                <td>
                    <asp:DropDownList ID="ddlEscolaridade" runat="server">
                        <asp:ListItem>Educacao infantil(Primario)</asp:ListItem>
                        <asp:ListItem>Ensino Fundamental</asp:ListItem>
                        <asp:ListItem>Ensino Medio</asp:ListItem>
                        <asp:ListItem>Superior Incompleto</asp:ListItem>
                        <asp:ListItem>Superior Completo</asp:ListItem>
                        <asp:ListItem>Pos-Graduacao</asp:ListItem>
                        <asp:ListItem>Mestrado</asp:ListItem>
                        <asp:ListItem>Doutorado</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Sit.Ocupacional:</td>
                <td>
                    <ew:MaskedTextBox ID="txtSitOcup" runat="server" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>E-mail :</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="208px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>CPF :</td>
                <td>
                    <ew:MaskedTextBox ID="txtCPF" runat="server" Mask="999.999.999-99" />
                </td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Observação :</td>
                <td>
                    <asp:TextBox ID="txtObservação" runat="server" Width="568px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnCadClienteNHibernate" runat="server" 
                        Text="Cadastrar NHibernate" Width="142px" 
                        onclick="btnCadClienteNHibernate_Click" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:HiddenField ID="hdIdNH" runat="server" />
                </td>
                <td>
                    <asp:HiddenField ID="hdIdEF" runat="server" />
                </td>
                <td>
                     <asp:Button ID="btnCadClienteEntity" runat="server" Text="Cadastrar Entity" 
                         OnClick="btnCadClienteEntity_Click" Width="142px" 
                        />
                </td>
            </tr>
            </table>


    </ol>
</asp:Panel>

<asp:Panel ID="pnTelefones" runat="server" Visible="False" style="margin-right: 0px">
 <ol class="round">
       
        <table style="width: 100%;">
            <tr>
                <td>Número :</td>
                <td>
                   <div class="itensForm"> 
                       <ew:MaskedTextBox ID="txtTel" runat="server" Mask="(99)9999-9999" />
                    </div>
                </td>
                <caption>
                    <t>
                        Adicionar :</td>
                        <tr>
                            <td style="margin-left: 80px">
                                <asp:Button ID="btnAdicionarTelNHibernate" runat="server" 
                                    onclick="btnAdicionarTelNHibernate_Click" Text="Adicionar NHibernate" 
                                    Visible="False" Width="142px" />
                            </td>
                        </tr>
                    </t>
                </caption>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="margin-left: 80px">
                    <asp:Button ID="btnAdicionarTelEntity" runat="server" 
                        OnClick="btnAdicionarTelEntity_Click" Text="Adicionar Entity" 
                        Width="141px" Visible="False" />
                </td>
            </tr>
            <tr>
                <td>Telefones :</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" AutoGenerateColumns="False" 
                        DataSourceID="SqlDataSource1">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="telefone" HeaderText="telefone" 
                                SortExpression="telefone" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
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
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" 
                        GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="telefone" HeaderText="telefone" 
                                SortExpression="telefone" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:BD_CondominioConnectionString %>" 
                        
                        SelectCommand="SELECT [telefone] FROM [tabTelefone] WHERE ([id_cliente] = @id_cliente)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="hdIdEF" Name="id_cliente" PropertyName="Value" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:BD_CondominioConnectionString %>" 
                        
                        SelectCommand="SELECT [telefone] FROM [tabTelefone] WHERE ([id_cliente] = @id_cliente)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="hdIdNH" Name="id_cliente" PropertyName="Value" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                     <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" OnClick="btnFinalizar_Click" 
                        />
                </td>
            </tr>
            </table>


    </ol>


</asp:Panel>


        </fieldset>
        </layouttemplate>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="consCliente.aspx.cs" Inherits="sysCondominio.views.Consulta.consCliente" %>

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
                <h2>Area do Sistema destinada a Consulta dos Clientes ao Condomínio.</h2>
            </hgroup>
            <p>
                <span>Preencha os campos a seguir para efetuar o consulta do Cliente.</span>
            </p>
            <p>
                <span>Logo após a consulta, a Alteração ao Cliente poderá ser realizado. </span>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnConsCliente" runat="server">
        <ol class="round">
            <table style="width: 100%;">
                <tr>
                    <td>
                            <asp:Label ID="lblnome" runat="server" Text="Digite o Nome : "></asp:Label>                      
                    </td>
                    <td>
                        <div class="itensForm">
                            <asp:TextBox ID="txtNomeConsulta" runat="server" Width="250px" CssClass="textboxgrande"></asp:TextBox></div>
                    </td>
                    <td>
                        <asp:Button ID="btnConsultarEntity" runat="server" OnClick="btnConsultarEntity_Click" 
                            Text="Consultar Entity" Width="139px" />
                        <asp:Button ID="btnConsultarNHibernate" runat="server" 
                            onclick="btnConsultarNHibernate_Click" Text="Consultar NHibernate" 
                            Width="139px" />
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>        
                            <asp:Label ID="lblSelec" runat="server" Text="Selecionar :" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlNomes" runat="server" CssClass="textboxgrande" Height="18px"
                            Width="247px" Visible="False">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnSelecionarEntity" runat="server" 
                            OnClick="btnSelecionarEntity_Click" Text="Selecionar " Visible="False" 
                            Width="93px" />
                        <asp:Button ID="btnSelecionarNHibernate" runat="server" 
                            onclick="btnSelecionarNHibernate_Click" Text="Selecionar" Visible="False" 
                            Width="93px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                        </td>
                    <td>
                        &nbsp;
                        </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;
                    </td>
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
    <asp:Panel ID="pnCAD" runat="server" Visible="False">
        <ol class="round">
            <table style="width: 100%;">
                <tr>
                    <td>Nome: </td>
                    <td>
                       
                            <asp:TextBox ID="txtNome" runat="server" Width="250px" CssClass="textboxgrande"></asp:TextBox>
                    </td>
                    <td>
                        
                    </td>
                    <td>
                        </td>
                </tr>
                <tr>
                    <td>Sexo:</td>
                    <td>
                        <asp:TextBox ID="txtSexo" runat="server" Width="250px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Escolaridade: </td>
                    <td>
                        <asp:TextBox ID="txtEscolaridade" runat="server" Width="250px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;<asp:HiddenField ID="hdfIdNH" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Data de Nascimento:</td>
                    <td>
                        <ew:MaskedTextBox ID="txtDtNasc" runat="server" Mask="99/99/9999" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Sit. Ocupacional: </td>
                    <td>
                        <ew:MaskedTextBox ID="txtSitOcup" runat="server" />
                        
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:HiddenField ID="hdID" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>E-mail :</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="208px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>CPF :</td>
                    <td>
                        <ew:MaskedTextBox ID="txtCPF" runat="server" Mask="999.999.999-99" />
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>Observação :</td>
                    <td colspan="1">
                        <asp:TextBox ID="txtObservação" runat="server" Width="568px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:Button ID="btnExcluirCliente" runat="server" 
                            OnClick="btnExcluirCliente_Click" Text="Excluir Cliente" 
                            style="text-align: left" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnAlterarClientes" runat="server" 
                            OnClick="btnAlterarClientes_Click" style="margin-left: 0px" 
                            Text="Alterar Cliente" />
                    </td>
                </tr>
                <tr>
                    <td>Telefones :</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                            DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="telefone" HeaderText="telefone" SortExpression="telefone" />
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
                        <asp:LinkButton ID="btnAlteraTelefones" runat="server" ForeColor="#CC0000" 
                            onclick="btnAlteraTelefones_Click">Adicionar</asp:LinkButton>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:compilandofacilConnectionString %>"
                            
                            
                            SelectCommand="SELECT [telefone] FROM [tabTelefone] WHERE ([id_cliente] = @id_cliente)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="hdID" Name="id_cliente" PropertyName="Value" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                       
                        <asp:Panel ID="pnADDtelEntity" runat="server" Visible="false">
              
                        <table style="width: 100%;">
                            <tr>
                                <td> Número : </td>
                                <td>
                                    <div class="itensForm">
                                        <ew:MaskedTextBox ID="txtTelEntity" runat="server" Mask="(99)9999-9999" />
                                    </div>
                                </td>
                                <td>Adicionar :</td>
                                <td style="margin-left: 80px">
                                    <asp:Button ID="btnAdicionarTEL" runat="server" OnClick="btnAdicionarTEL_Click" 
                                        Text="Adicionar" />
                                </td>
                            </tr>
                        </table>
          </asp:Panel>

                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Panel ID="pnAddTelNHibernate" runat="server" Visible="False">
                        <table style="width: 100%;">
                            <tr>
                                <td>Número :</td>
                                <td>
                                    <div class="itensForm">
                                        <ew:MaskedTextBox ID="txtTelNHibernate" runat="server" Mask="(99)9999-9999" />
                                    </div>
                                </td>
                                <td>Adicionar :</td>
                                <td style="margin-left: 80px">
                                    <asp:Button ID="btnAddTelNHibernate" runat="server" OnClick="btnAdicionarTEL_Click" 
                                        Text="Adicionar " />
                                </td>
                            </tr>
                        </table>
                        </asp:Panel>
                    </td>
                    <td >
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        
                            Condominio:&nbsp;
                    </td>
                    <td>
                        <asp:Panel ID="pnSim" runat="server" Visible="false">
                            <asp:Label ID="lblAla" runat="server" Text="Ala : "></asp:Label>
                            <asp:Label ID="lblAlaConsultado" runat="server" Text=" "></asp:Label>
                            <br />
                            <asp:Label ID="lblQuarto" runat="server" Text="Quarto : "></asp:Label>
                            <asp:Label ID="lblQuartoConsultado" runat="server" Text=" "></asp:Label>
                            <br />
                            <asp:LinkButton ID="btnAlteraCondominio" runat="server" ForeColor="#CC0000">Alterar</asp:LinkButton>
                        </asp:Panel>
                        <asp:Panel ID="pnaNao" runat="server" Visible="false">
                            <asp:Label ID="Label1" runat="server" Text="Não Possui Cadastro no Condomínio : "></asp:Label>
                        </asp:Panel>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
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
</asp:Content>

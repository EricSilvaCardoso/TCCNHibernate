<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sysCondominio.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
<section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Page.Title %>.</h1>
                <h2>Sistema de Cadastro de Clientes de Condomínio.</h2>
            </hgroup>
            <p>
                &nbsp;</p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
 <h3>Opções :</h3>

    <section class="features">
        <section class="feature">
            <asp:ImageButton ID="ImageButton1" runat="server" alt="Cadastrar" 
        width="220" height="200" ImageUrl="~/Images/user.png" 
        PostBackUrl="~/Views/Cadastro/CadCliente.aspx" />
            &nbsp;<h3>Cadastro de Clientes</h3>
            <p>
                Area destinada ao cadastro de Cliente no Condomínio</p>
        </section>

        <section class="feature">
            <asp:ImageButton ID="ImageButton3" runat="server" alt="Cadastrar" 
        width="220" height="200" ImageUrl="~/Images/NuGetGallery.png" 
        PostBackUrl="~/Views/Cadastro/CadCondominio.aspx" />
            <h3>Cadastrar Cliente no Condomínio</h3> <p>
                Area destinada ao Cadastro do Cliente no Condomínio. </p>
        </section>

        <section class="feature">
            <asp:ImageButton ID="ImageButton2" runat="server" alt="Cadastrar" 
        width="220" height="200" ImageUrl="~/Images/consult.png" 
        PostBackUrl="~/Views/Cadastro/CadAla_Quartos.aspx" />
            <h3>Cadastro de Alas e Quartos</h3>
            <p>
                Area destinada ao Cadastro de Alas e Quartos do Condomínio. </p>
        </section>

        <section class="feature">
            <asp:ImageButton ID="ImageButton4" runat="server" alt="Cadastrar" 
        width="220" height="200" ImageUrl="~/Images/consult.png" 
        PostBackUrl="~/Views/Consulta/comparacao.aspx" />
            <h3>Comparação do Entity Framework com Nhibernate</h3>
            <p>
                Area destinada a Comparação dos Modos de Acesso a DADOS. </p>
        </section>

    </section>
</asp:Content>

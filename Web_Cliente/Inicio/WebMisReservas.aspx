<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebMisReservas.aspx.cs" Inherits="Web_Cliente.Inicio.WebMisReservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
      .hiddencol
      {
        display: none;
      }
    </style>

    <nav id="navi" class="navbar navbar-expand-lg navbar-light sticky-top">
        <div class="container">
            <a id="titulo" class="navbar-brand">Reserva Restaurante</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item"> </li>
                </ul>
                <ul class="navbar-nav mr-right">
                    <li class="nav-item">
                        <asp:HyperLink NavigateUrl="~/Inicio/WebRestaurantes.aspx" class="nav-link" runat="server">Restaurantes</asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink NavigateUrl="~/Inicio/WebMisReservas.aspx" class="nav-link" runat="server">Mis Reservas</asp:HyperLink>
                    </li>
                    
                    <li class="nav-item">
                        <asp:HyperLink NavigateUrl="~/Inicio/WebMisReseñas.aspx" class="nav-link" runat="server">Mis Reseñas</asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink NavigateUrl="~/WebInicio.aspx" class="nav-link" runat="server">Cerrar Sesión</asp:HyperLink>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <section class="drivers-area bg-img" style="background-image: url(https://centralrestaurante.com.pe/assets/images/hero.jpg)">
      <div class="title-area">
        <p>Revisa</p>
        <h2>Mis Reservas</h2>
      </div>
    </section>

    <div class="container" style="padding-top: 100px; padding-bottom: 100px;">
              <asp:GridView ID="grvReservas" runat="server" AutoGenerateColumns="False" class="table table-dark table-hover" OnSelectedIndexChanged="grvReservas_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Id_Reserva" HeaderText="IdReserva" ItemStyle-CssClass="hiddencol" HeaderStyle-CssClass="hiddencol" >
<HeaderStyle CssClass="hiddencol"></HeaderStyle>

<ItemStyle CssClass="hiddencol"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Id_Restaurante" HeaderText="IdRestaurante" ItemStyle-CssClass="hiddencol" HeaderStyle-CssClass="hiddencol" >
<HeaderStyle CssClass="hiddencol"></HeaderStyle>

<ItemStyle CssClass="hiddencol"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Nom_Restaurante" HeaderText="Restaurante" />
                    <asp:BoundField DataField="Fecha_Reserva" HeaderText="Fecha" DataFormatString="{0:g}" />
                    <asp:BoundField DataField="Cant_Personas" HeaderText="Nro. Personas" />
                    <asp:BoundField DataField="Estado_Reserva" HeaderText="Estado" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Escribir Reseña" />
                </Columns>
            </asp:GridView>
        </div>
    
    <section id="footer">
            <div class="container">
                <div class="col-md-12">
                    <ul>
                        <li><a href="#nosotros">Nosotros</a></li>
                        <li><a href="#contacto">Contacto</a></li>
                    </ul>
                </div>
                <div id="social">
                    <a href=""><i class="fab fa-twitter-square fa-2x"></i></a>
                    <a href=""><i class="fab fa-facebook-square fa-2x"></i></a>
                    <a href=""><i class="fab fa-instagram-square fa-2x"></i></a>
                </div>
                <div>
                    <p>Copyright © 2021. Todos los derechos reservados.</p>
                </div>
            </div>
    </section>
</asp:Content>

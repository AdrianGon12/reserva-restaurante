<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebReservar.aspx.cs" Inherits="Web_Cliente.Inicio.WebReservar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

    <section class="drivers-area bg-img" style="background-image: url(https://cdn.otstatic.com/cfe/7/images/banner-1280-85a499.jpg)">
      <div class="title-area">
        <p>Genere</p>
        <h2>Su Reserva</h2>
      </div>
    </section>

    <section class="padded" style="padding-top: 100px; padding-bottom: 100px;">
        <div class="container">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                        <div class="form-group">
                            <label>Restaurante</label>
                            <asp:TextBox ID="txtNomRestaurante" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 30px;">
                            <label>Dirección</label>
                            <asp:TextBox ID="txtDirecRestaurante" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 30px;">
                            <label>Fecha</label>
                            <asp:Calendar ID="calFecha" runat="server"></asp:Calendar>
                        </div>
                        <div class="form-group" style="margin-bottom: 30px;">
                            <label>Hora</label>
                            <asp:TextBox ID="txtHora" runat="server" class="form-control" type="time" min="09:00" max="22:00"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 30px;">
                            <label>Nro. Personas</label>
                            <asp:TextBox ID="txtPersonas" type="number" runat="server" class="form-control" min="1"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button class="btn btn-buscar" ID="btnReservar" runat="server" Text="Reservar" style="margin-bottom: 100px;" OnClick="btnReservar_Click" />
                        </div>
                   
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </section>
    
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

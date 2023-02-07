<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebInicio.aspx.cs" Inherits="Web_Cliente.Inicio.WebInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav id="navi" class="navbar navbar-expand-lg navbar-light sticky-top">
        <div class="container">
            <a id="titulo" class="navbar-brand" href="/">Reserva Restaurante</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item"> </li>
                </ul>
                <ul class="navbar-nav mr-right">
                    
                    <li class="nav-item">
                        <asp:HyperLink NavigateUrl="~/WebLogin.aspx" class="nav-link" runat="server">Login</asp:HyperLink>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <section id="header">
    <div id="carouselExampleCaptions" class="carousel slide carousel-fade" data-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="https://img.mesa247.pe/archivos/banners/YZerp5CL4q-1636576578.jpg" class="d-block w-100" alt="">
                <div class="carousel-caption d-md-block position-absolute" style="top: 500px; text-align: left;">
                    <p>Viva la mejor experiencia</p>
                    <h1>Reserve un restaurante</h1>
                    <button type="button" class="boton"><a href="#contacto">Reservar</a></button>
                </div>
            </div>
            <div class="carousel-item">
                <img src="https://img.mesa247.pe/archivos/banners/mbgKHY1t4I-1630773318.jpg" class="d-block w-100" alt="">
                <div class="carousel-caption d-md-block position-absolute" style="top: 500px; text-align: left;">
                    <p>Viva la mejor experiencia</p>
                    <h1>Reserve un restaurante</h1>
                    <button type="button" class="boton"><a href="#contacto">Reservar</a></button>
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
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

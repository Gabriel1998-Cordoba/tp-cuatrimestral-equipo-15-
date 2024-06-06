<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetallesCurso.aspx.cs" Inherits="tp_cuatrimestral_equipo_15.DetallesCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="px-4 py-5 my-5 text-center" style="background-color:mediumpurple; border-radius:10px; margin-left:50px; margin-right:50px;">
      
      <h1 class="display-5 fw-bold text-body-emphasis">C# Nivel 3 (Web ASP)</h1>
      <div class="col-lg-6 mx-auto">
        <p class="lead mb-4">Arrancamos con la etapa Web. En este curso tomamos todo el conocimiento que venimos trabajando y lo ponemos al servicio del desarrollo web sumando herramientas como HTML, CSS, JS y Bootstrap.</p>
        
        <div class="d-grid gap-2 d-sm-flex justify-content-center">
            <asp:Button ID="btnComprar" runat="server" CssClass="btn btn-primary btn-lg px-4 gap-3" Text="Comprar"/>
        </div>
          
     </div>
  </div>
    

    
<div class="container row justify-content-center" style="margin-top:100px; border-top:groove; border-top-color:darkgrey; padding:20px">

        <div class="col-md-5" style="padding:20px; text-align:center">
            <h2 class="display-5 fw-bold text-body-emphasis" style="margin-top:50px;"">¡Este curso es para vos!</h2>
        </div>

        <div class="col-md-5">
            <ul class="list-group list-group-flush">
              <li class="list-group-item">Completamente online</li>
              <li class="list-group-item">Más de 50 videos exclusivos con las explicaciones de los temas</li>
              <li class="list-group-item">Ejercicios de práctica</li>
              <li class="list-group-item">Ejemplos paso a paso</li>
              <li class="list-group-item">Recursos seleccionados para su lectura</li>
              <li class="list-group-item">Canales de consulta</li>
              <li class="list-group-item">Vivos esporádicos a coordinar para consultas varias.</li>
            </ul>
        </div>
</div>

<div class="container row justify-content-center" style="margin-top:100px">

        <div class="col-md-5" style="padding:20px; text-align:center; margin:10px">
            <h2 class="display-5 fw-bold text-body-emphasis">Conocimientos requeridos</h2>
        </div>
            
        <div class="col-md-5" style="padding:20px; text-align:justify; border-left:dotted; border-left-color:darkgrey">
            <p style="">
                Para poder aprovechar este curso al máximo es necesario que cuentes con una base
                sólida en fundamentos de la programación, que conozcas el paradigma de
                Programación Orientada a Objetos y que al menos tengas nociones sobre .NET (o algún
                otro Framework). Los conocimientos necesarios los vemos en los Niveles 1 y 2, aunque
                vos podés tenerlos de otro lado, claro.
            </p>    
        </div>
</div>

    <div class="justify-content-center" style="text-align:center; align-content:center; margin-top:100px" >
        <asp:Button ID="btnComprarFinal" runat="server" CssClass="btn btn-primary btn-lg px-4 gap-3" Text="Comprar"/>
        <asp:Button ID="btnPrograma" runat="server" CssClass="btn btn-secondary btn-lg px-4 gap-3" Text="Programa"/>
    </div>

</asp:Content>

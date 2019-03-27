<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RVideoJuego.aspx.cs" Inherits="FinalProject2.Registros.RVideoJuego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel" style="background-color: black">
        <div class="panel-heading" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: medium; color: white">Registro de VideoJuegos</div>
    </div>
    <div class="panel-body">
        <div class="form-horizontal col-md-12" role="form">
            <div class="form-group">
                <label for="VideoJuegoIdTextBox" class="col-md-2 control-label input-sm" style="font-size: large">VideoJuego Id</label>
                <div class="col-md-2 col-sm-2 col-xs-4">
                    <asp:TextBox ID="VideoJuegoIdTextBox" runat="server" placeholder="0" class="form-control input-sm" Style="font-size: large" TextMode="Number"></asp:TextBox>
                </div>
                <asp:RegularExpressionValidator ID="ValidaID" runat="server" ErrorMessage='El Campo &quot;ID&quot; solo acepta numeros' ControlToValidate="VideoJuegoIdTextBox" ValidationExpression="^[0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-info btn-sm" OnClick="BuscarButton_Click" />
                </div>
            </div>
            <div class="form-group">
                <label for="TituloTextBox" class="col-md-4 control-label input-sm" style="font-size: large">Titulo</label>
                <div class="col-md-7">
                    <asp:TextBox ID="TituloTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidaTitulo" runat="server" ErrorMessage="El campo &quot;Titulo&quot; Esta vacio" ControlToValidate="TituloTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Titulo es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidaTitulo2" runat="server" ErrorMessage='El Campo &quot;CantidadEjemplares&quot; solo acepta letras' ControlToValidate="TituloTextBox" ValidationExpression="^[A-Za-z]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>

                </div>
                <label for="descripcionTextBox" class="col-md-4 control-label input-sm" style="font-size: large">Descripcion</label>
                <div class="col-md-7">
                    <asp:TextBox ID="descripcionTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Validadescripcion" runat="server" ErrorMessage="El campo &quot;descripcion&quot; Esta vacio" ControlToValidate="descripcionTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo descripcion es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="Validadescripcion2" runat="server" ErrorMessage='El Campo &quot;descripcion&quot; solo acepta letras' ControlToValidate="descripcionTextBox" ValidationExpression="^[A-Za-z0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
                <label for="CantidadEjemplaresTextBox" class="col-md-4 control-label input-sm" style="font-size: large">Cantidad de Ejemplares</label>
                <div class="col-md-7">
                    <asp:TextBox ID="CantidadEjemplaresTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage='El Campo &quot;CantidadEjemplares&quot; solo acepta numeros' ControlToValidate="CantidadEjemplaresTextBox" ValidationExpression="^[0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="ValidadCecula" runat="server" ErrorMessage="El campo &quot;CantidadEjemplares&quot; esta vacio" ControlToValidate="CantidadEjemplaresTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo CantidadEjemplares obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                </div>
                <label for="PlataformaTextBox" class="col-md-4 control-label input-sm" style="font-size: large">Plataforma</label>
                <div class="col-md-7">
                    <asp:TextBox ID="PlataformaTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidaPlataforma" runat="server" ErrorMessage="El campo &quot;Plataforma&quot; Esta vacio" ControlToValidate="PlataformaTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Titulo es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidaPlataforma2" runat="server" ErrorMessage='El Campo &quot;Plataforma&quot; solo acepta letras' ControlToValidate="PlataformaTextBox" ValidationExpression="^[A-Za-z#0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
            </div>
            <label for="GeneroTextBox" class="col-md-4 control-label input-sm" style="font-size: large">Genero</label>
            <div class="col-md-7">
                <asp:TextBox ID="GeneroTextBox" runat="server" class="form-control"></asp:TextBox>

                <asp:RequiredFieldValidator ID="ValidaGenero2" runat="server" ErrorMessage="El campo &quot;Genero&quot; Esta vacio" ControlToValidate="GeneroTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Titulo es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="ValidaGenero" runat="server" ErrorMessage='El Campo &quot;Genero&quot; solo acepta numeros' ControlToValidate="GeneroTextBox" ValidationExpression="^[A-Za-z]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <div class="col-md-8">
                    <asp:TextBox ID="FechaTextBox" TextMode="Date" runat="server" class="form-control input-sm" Style="font-size: large" Visible="false"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="panel">
            <div class="text-center">
                <div class="form-group">
                    <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-primary btn-md" OnClick="NuevoButton_Click" />
                    <asp:Button ID="GuardarButton" runat="server" Text="Guardar" class="btn btn-success btn-md" ValidationGroup="Guardar" OnClick="GuardarButton_Click" />
                    <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" class="btn btn-danger btn-md" OnClick="EliminarButton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

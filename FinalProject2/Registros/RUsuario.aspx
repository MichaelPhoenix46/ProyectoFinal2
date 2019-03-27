<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RUsuario.aspx.cs" Inherits="FinalProject2.Registros.RUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel" style="background-color: black">
        <div class="panel-heading" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: medium; color: white">Registro de Usuarios</div>
    </div>
    <div class="panel-body">
        <div class="form-horizontal col-md-12" role="form">
            <div class="form-group">
                <label for="UsuarioIdTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Usuario Id</label>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:TextBox ID="UsuarioIdTextBox" runat="server" placeholder="0" class="form-control input-sm" Style="font-size: large" TextMode="Number"></asp:TextBox>
                </div>
                <asp:RegularExpressionValidator ID="ValidaID" runat="server" ErrorMessage='El Campo &quot;ID&quot; solo acepta numeros' ControlToValidate="UsuarioIdTextBox" ValidationExpression="^[0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-info btn-sm" OnClick="BuscarButton_Click"/>
                </div>
            </div>
            <div class="form-group">
                <label for="NombreTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Nombre</label>
                <div class="col-md-7">
                    <asp:TextBox ID="NombreTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidaNombre" runat="server" ErrorMessage="El campo &quot;Nombre&quot; Esta vacio" ControlToValidate="NombreTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Nombre es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidaNombre2" runat="server" ErrorMessage='El Campo &quot;Cedula&quot; solo acepta letras' ControlToValidate="NombreTextBox" ValidationExpression="^[A-Za-z]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
                <label for="NombreUsuarioTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Nombre de Usuario</label>
                <div class="col-md-7">
                    <asp:TextBox ID="NombreUsuarioTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidaCedula" runat="server" ErrorMessage="El campo &quot;NombreUsuario&quot; Esta vacio" ControlToValidate="NombreUsuarioTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo NombreUsuario es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                </div>
                <label for="PasswordTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Contraseña</label>
                <div class="col-md-7">
                    <asp:TextBox ID="PasswordTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo &quot;Password&quot; Esta vacio" ControlToValidate="PasswordTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Password es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                </div>
                <label for="TelefonoTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Telefono</label>
                <div class="col-md-7">
                    <asp:TextBox ID="TelefonoTextBox" runat="server" placeholder="" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidaTelefono2" runat="server" ErrorMessage="El campo &quot;Telefono&quot; Esta vacio" ControlToValidate="TelefonoTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Telefono es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidaTelefono" runat="server" ErrorMessage='El Campo &quot;Telefono&quot; solo acepta numeros' ControlToValidate="TelefonoTextBox" ValidationExpression="^[0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
                <label for="CedulaTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Cedula</label>
                <div class="col-md-7">
                    <asp:TextBox ID="CedulaTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidaCedula2" runat="server" ErrorMessage='El Campo &quot;Cedula&quot; solo acepta numeros' ControlToValidate="CedulaTextBox" ValidationExpression="^[0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="ValidadCecula" runat="server" ErrorMessage="El campo &quot;Cedula&quot; esta vacio" ControlToValidate="CedulaTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Cedula obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>

                </div>
                <label for="DireccionTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Direccion</label>
                <div class="col-md-7">
                    <asp:TextBox ID="DireccionTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidaDireccion" runat="server" ErrorMessage="El campo &quot;Direccion&quot; Esta vacio" ControlToValidate="DireccionTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Direccion es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidaDireccion2" runat="server" ErrorMessage='El Campo &quot;Direccion&quot; solo acepta letras' ControlToValidate="DireccionTextBox" ValidationExpression="^[A-Za-z0-9#]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
            </div>

        <div class="form-group">
            <div class="col-md-8">
                <asp:TextBox ID="FechaTextBox" TextMode="Date" runat="server" class="form-control input-sm" Style="font-size: large" Visible="false"></asp:TextBox>
            </div>
        </div>
        <div class="panel">
            <div class="text-center">
                <div class="form-group">
                    <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-primary btn-md" OnClick="NuevoButton_Click" />
                        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" class="btn btn-success btn-md" ValidationGroup="Guardar" OnClick="GuardarButton_Click"/>
                    <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" class="btn btn-danger btn-md" OnClick="EliminarButton_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

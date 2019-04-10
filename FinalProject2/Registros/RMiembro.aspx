<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RMiembro.aspx.cs" Inherits="FinalProject2.Registros.RMiembro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel" style="background-color: black">
        <div class="panel-heading" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: medium; color: #000000; background-color: #2ecc71;">Registro de Miembros</div>
    </div>
    <div class="panel-body">
        <div class="form-horizontal col-md-12" role="form">
            <div class="form-group">
                <label for="MiembroIdTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Miembro Id</label>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:TextBox ID="MiembroIdTextBox" runat="server" placeholder="0" class="form-control input-sm" Style="font-size: large" TextMode="Number"></asp:TextBox>
                </div>
                <asp:RegularExpressionValidator ID="ValidaID" runat="server" ErrorMessage='El Campo &quot;ID&quot; solo acepta numeros' ControlToValidate="MiembroIdTextBox" ValidationExpression="^[0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-info btn-sm" OnClick="BuscarButton_Click" />

                </div>
            </div>
            <div class="form-group">
                <label for="NombreTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Nombre</label>
                <div class="col-md-3">
                    <asp:TextBox ID="NombreTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidaNombre" runat="server" ErrorMessage="El campo &quot;Nombre&quot; Esta vacio" ControlToValidate="NombreTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Nombre es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidaNombre2" runat="server" ErrorMessage='El Campo &quot;nombre&quot; solo acepta letras' ControlToValidate="NombreTextBox" ValidationExpression="^[A-Za-z']*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar">*</asp:RegularExpressionValidator>

                </div>
                <label for="CedulaTextBox" class="col-md-1 control-label input-sm" style="font-size: large">Cedula</label>
                <div class="col-md-3">
                    <asp:TextBox ID="CedulaTextBox" runat="server" class="form-control input-sm" Style="font-size: large" TextMode="Number"></asp:TextBox>
                    <asp:RangeValidator ID="CedulaRangeValidator" runat="server" ErrorMessage="Digite una cedula correcta" ControlToValidate="CedulaTextBox" ValidationGroup="Guardar" Display="Dynamic" ForeColor="Red" MaximumValue="11" MinimumValue="11">*</asp:RangeValidator>
                    <asp:RequiredFieldValidator ID="ValidadCecula" runat="server" ErrorMessage="El campo &quot;Cedula&quot; esta vacio" ControlToValidate="CedulaTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Cedula obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>

                    <br>
                </div>
                <label for="DireccionTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Direccion</label>
                <div class="col-md-3">
                    <asp:TextBox ID="DireccionTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidaDireccion" runat="server" ErrorMessage="El campo &quot;Direccion&quot; Esta vacio" ControlToValidate="DireccionTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Direccion es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidaDireccion2" runat="server" ErrorMessage='El Campo &quot;Direccion&quot; solo acepta letras' ControlToValidate="DireccionTextBox" ValidationExpression="^[A-Za-z0-9# ]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
            </div>
            <label for="TelefonoTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Telefono</label>
            <div class="col-md-3 col-sm-2 col-xs-4">
                <asp:TextBox ID="TelefonoTextBox" runat="server" placeholder="" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ValidaTelefono2" runat="server" ErrorMessage="El campo &quot;Telefono&quot; Esta vacio" ControlToValidate="TelefonoTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Telefono es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="ValidaTelefono" runat="server" ErrorMessage='El Campo &quot;Telefono&quot; solo acepta numeros' ControlToValidate="TelefonoTextBox" ValidationExpression="^[0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                <asp:RangeValidator ID="TelefonoRangeValidator" runat="server" ErrorMessage="Digite un Telefono correcto" ControlToValidate="TelefonoTextBox" ValidationGroup="Guardar" Display="Dynamic" ForeColor="Red" MaximumValue="10" MinimumValue="10">*</asp:RangeValidator>

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
                        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" class="btn btn-success btn-md" ValidationGroup="Guardar" OnClick="GuardarButton_Click" />
                        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" class="btn btn-danger btn-md" OnClick="EliminarButton_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CMiembro.aspx.cs" Inherits="FinalProject2.Consultas.CMiembro" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel" style="background-color: black">
        <div class="panel-heading" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: medium; color: #000000; background-color: #2ecc71;">Consulta de Miembros</div>
    </div>
    <div class="form-group">
        <div class="col-md-4">
            <asp:DropDownList ID="FiltroDropDownList" runat="server" Class="form-control input-sm" Style="font-size: medium">
                <asp:ListItem Selected="True">Todo</asp:ListItem>
                <asp:ListItem>MiembroId</asp:ListItem>
                <asp:ListItem>Nombre</asp:ListItem>
                <asp:ListItem>Cedula</asp:ListItem>
                <asp:ListItem>Direccion</asp:ListItem>
                <asp:ListItem>Telefono</asp:ListItem>
                <asp:ListItem>Fecha</asp:ListItem>

            </asp:DropDownList>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="CriterioTextBox" runat="server" class="form-control input-sm" Style="font-size: medium"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-info btn-md" OnClick="BuscarButton_Click" />
        </div>
        <div class="col-md-1">

            <asp:CheckBox ID="FechaCheckBox" runat="server" />
        </div>

        <div id="Desdediv" class="col-md-5">
            <label for="Desde" class="col-md-3 control-label input-sm" style="font-size: large">Desde</label>
            <br>
            <asp:TextBox ID="Desde" runat="server" class="form-control input-sm" Style="font-size: medium" TextMode="Date"></asp:TextBox>
        </div>
        <div id="Hastadiv" class="col-md-5">
            <label for="Hasta" class="col-md-3 control-label input-sm" style="font-size: large">Hasta</label>
            <br>
            <asp:TextBox ID="Hasta" runat="server" class="form-control input-sm" Style="font-size: medium" TextMode="Date"></asp:TextBox>
        </div>
    </div>
    <br />
    <br />
    <div>
        <asp:GridView ID="DatosGridView" runat="server" class="table table-condensed tabled-bordered table-responsive" CellPadding="6" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <HeaderStyle BackColor="Black" Font-Bold="true" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:GridView>
    </div>
    <%--    <script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script>
        $(document).ready(function(){
            #('#Hasta').hide;
        });
    </script>--%>
</asp:Content>


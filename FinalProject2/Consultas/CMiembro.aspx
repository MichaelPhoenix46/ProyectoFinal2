<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CMiembro.aspx.cs" Inherits="FinalProject2.Consultas.CMiembro" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel" style="background-color: black">
        <div class="panel-heading" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: medium; color: white">Consulta de Miembros</div>
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
            </asp:DropDownList>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="CriterioTextBox" runat="server" class="form-control input-sm" Style="font-size: medium"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-info btn-md" OnClick="BuscarButton_Click" />
        </div>
        <div class="col-md-6">
            
            <asp:TextBox ID="Desde" runat="server" class="form-control input-sm" Style="font-size: medium"></asp:TextBox>
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
</asp:Content>

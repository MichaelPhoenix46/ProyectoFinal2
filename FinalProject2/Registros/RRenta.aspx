<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RRenta.aspx.cs" Inherits="FinalProject2.Registros.RRenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel" style="background-color: black">
        <div class="panel-heading" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: medium; color: #000000; background-color: #2ecc71;">Registro de Rentas</div>
    </div>
    <div class="panel-body">
        <div class="form-horizontal col-md-12" role="form">
            <div class="form-group">
                <label for="RentaIdTextBox" class="col-md-1 control-label input-sm" style="font-size: large">Renta Id</label>
                <div class="col-md-2 col-sm-2 col-xs-4">
                    <asp:TextBox ID="RentaIdTextBox" runat="server" placeholder="0" class="form-control input-sm" Style="font-size: large" TextMode="Number"></asp:TextBox>
                </div>
                <asp:RegularExpressionValidator ID="ValidaID" runat="server" ErrorMessage='El Campo &quot;ID&quot; solo acepta numeros' ControlToValidate="RentaIdTextBox" ValidationExpression="^[0-9]*$" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-info btn-sm" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-7">
                    <label for="MiembroDropDownList" class="col-md-2 control-label input-sm" style="font-size: large">Miembro</label>
                    <asp:DropDownList ID="MiembroDropDownList" runat="server" class="col-md-2 btn-info btn-sm"></asp:DropDownList>
                </div>
                <div class="col-md-7">
                    <label for="FechaDevueltaTextBox" class="col-md-4 control-label input-sm" style="font-size: large">Fecha de devuelta</label>
                    <asp:TextBox ID="FechaDevueltaTextBox" runat="server" class="form-control input-sm" Style="font-size: large" TextMode="Date" ReadOnly="true"></asp:TextBox>

                </div>
            </div>

            <div class="form-group col-md-7">
                <div>
                    <label for="JuegoDropDownList" class="col-md-4 control-label input-sm" style="font-size: large">VideoJuego</label>
                    <asp:DropDownList ID="JuegoDropDownList" runat="server" class="col-md-7 btn-info btn-sm"></asp:DropDownList>
                    <asp:Button ID="AgregarButton" runat="server" Text="Agregar" class="btn btn-info btn-sm" OnClick="AgregarButton_Click" />
                </div>

            </div>
            <div class="row form-group col-md-8">
                <asp:GridView ID="DetalleGridView" CssClass=" col-md-offset-4 col-sm-offset-4" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="244px" AutoGenerateColumns="true">
                    <AlternatingRowStyle BackColor="White" />

                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>

            <div class="col-md-7">
                <label for="PagoTextBox" class="col-md-2 control-label input-sm" style="font-size: large">Pago</label>
                <asp:TextBox ID="PagoTextBox" runat="server" class="form-control input-sm" Style="font-size: large" TextMode="Number"></asp:TextBox>

            </div>

            <div class="col-md-7">
                <label for="ImporteTextBox" class="col-md-2 control-label input-sm" style="font-size: large">Importe</label>
                <asp:TextBox ID="ImporteTextBox" runat="server" class="form-control input-sm" Style="font-size: large" TextMode="Number"></asp:TextBox>
            </div>
            <div class="col-md-7">
                <label for="DevueltaTextBox" class="col-md-2 control-label input-sm" style="font-size: large">Devuelta</label>
                <asp:TextBox ID="DevueltaTextBox" runat="server" class="form-control input-sm" Style="font-size: large" TextMode="Number"></asp:TextBox>
            </div>
            <div class="form-group">
                <div class="col-md-8">
                    <asp:TextBox ID="FechaTextBox" TextMode="Date" runat="server" class="form-control input-sm" Style="font-size: large" Visible="false"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group">
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
    </div>
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="FinalProject2.LogIn" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Iniciar Sesión</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
</head>
<body>

    <h2>Login</h2>

    <form runat="server">
        <div class="container form">
            <label for="UsuarioTextBox"><b>Username</b></label>
            <asp:TextBox ID="UsuarioTextBox" runat="server"></asp:TextBox>
            <label for="PasswordTextBox"><b>Password</b></label>
            <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
            <br>
            <asp:Button ID="LogInButton" Text="Log in" OnClick="LogInButton_Click" runat="server" />
        </div>

    </form>

</body>

</html>

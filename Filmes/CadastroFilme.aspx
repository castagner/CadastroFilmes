<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroFilme.aspx.cs" Inherits="Filmes.CadastroFilme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Nome:</div>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        <br />
        Genero<p>
            <asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
        </p>
        <p>
            Ano Lancamento</p>
        <asp:TextBox ID="txtAnoLancamento" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="SALVAR" />
        </p>
        <p>
            <asp:Label ID="lblOK" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

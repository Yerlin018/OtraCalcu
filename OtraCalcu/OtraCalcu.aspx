<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtraCalcu.aspx.cs" Inherits="OtraCalcu.OtraCalcu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Calculadora</div>
        <asp:Button ID="Braiz3" runat="server" Text="raiz3" OnClick="Braiz3_Click" />
        <asp:Button ID="BLimpliar" runat="server" Text="C" OnClick="BLimpliar_Click" />
        <asp:Button ID="Batras" runat="server" Text="&lt;-" />
        <asp:Button ID="Bfactorial" runat="server" Text="n!" OnClick="Bfactorial_Click" />
        <asp:Button ID="Bdivision" runat="server" Text="/" Width="26px" OnClick="Bdivision_Click" />
        <br />
        <asp:Button ID="Bxalay" runat="server" Text="x^y" Width="59px" OnClick="Bxalay_Click" />
        <asp:Button ID="Bnum7" runat="server" Text="7" Width="30px" ButtonClick="Bnum7_Click" OnClick="Bnum7_Click" />
        <asp:Button ID="Bnum8" runat="server" Text="8" Width="35px"  ButtonClick="Bnum8_Click" OnClick="Bnum8_Click" />
        <asp:Button ID="Bnum9" runat="server" Text="9" Width="28px"  ButtonClick="Bnum9_Click" OnClick="Bnum9_Click" />
        <asp:Button ID="Bmultiplicacion" runat="server" Text="x" Width="26px" OnClick="Bmultiplicacion_Click" />
        <br />
        <asp:Button ID="diezalax" runat="server" Text="10^x" OnClick="diezalax_Click" />
        <asp:Button ID="Bnum4" runat="server" Text="4" Width="31px" ButtonClick="Bnum4_Click" OnClick="Bnum4_Click" />
        <asp:Button ID="Bnum5" runat="server" Text="5" Width="34px" ButtonClick="Bnum5_Click" OnClick="Bnum5_Click" />
        <asp:Button ID="Bnum6" runat="server" Text="6" Width="30px" ButtonClick="Bnum6_Click" OnClick="Bnum6_Click" />
        <asp:Button ID="Bresta" runat="server" Text="-" Width="28px" OnClick="Bresta_Click" />
        <br />
        <asp:Button ID="Blogaritmo" runat="server" Text="log" Width="58px" OnClick="Blogaritmo_Click" />
        <asp:Button ID="Bnum1" runat="server" Text="1" Width="31px" ButtonClick="Bnum1_Click" OnClick="Bnum1_Click" />
        <asp:Button ID="Bnum2" runat="server" Text="2" Width="35px" ButtonClick="Bnum2_Click" OnClick="Bnum2_Click" />
        <asp:Button ID="Bnum3" runat="server" Text="3" ButtonClick="Bnum3_Click" OnClick="Bnum3_Click" />
        <asp:Button ID="Bsuma" runat="server" Text="+" Width="29px" ButtonClick="Bsuma_Click" OnClick="Bsuma_Click" />
        <br />
        <asp:Button ID="Bala2" runat="server" Text="X^2" Width="56px" OnClick="Bala2_Click" />
        <asp:Button ID="Bmasmenos" runat="server" Text="+/-" OnClick="Bmasmenos_Click" />
        <asp:Button ID="Bnum0" runat="server" Text="0" Width="27px" OnClick="Bnum0_Click" />
        <asp:Button ID="Bpunto" runat="server" Text="." Width="28px" OnClick="Bpunto_Click" />
        <asp:Button ID="Bigual" runat="server" ButtonClick="Button25_Click" Text="=" OnClick="Bigual_Click" />
        <p>
            Resultado: <asp:Label ID="Lresultado" runat="server" Font-Size="10pt" Text="0"></asp:Label>
        </p>
    </form>
</body>
</html>

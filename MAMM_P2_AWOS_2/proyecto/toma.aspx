<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="toma.aspx.cs" Inherits="MAMM_P2_AWOS_2.proyecto.toma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario | Nuevo</title>
    <link rel="stylesheet" href="EstilosNuevoForm.css"/>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtid" runat="server" Visible="false" placeholder="escribe la marca" ></asp:TextBox>
             <asp:TextBox ID="marca" runat="server" placeholder="escribe la marca" ></asp:TextBox>
            <asp:TextBox ID="modelo" runat="server" placeholder="escribe la modelo"></asp:TextBox>
            <asp:TextBox ID="tamano" runat="server" placeholder="escribe el tamaño"></asp:TextBox>
             <asp:TextBox ID="memoriaRAM" runat="server" placeholder="escribe la memoria ram"></asp:TextBox>
             <asp:TextBox ID="memoriaROM" runat="server" placeholder="escribe la memoria rom"></asp:TextBox>
             <asp:TextBox ID="SO" runat="server" placeholder="escribe el sistema operativo"></asp:TextBox>
             <asp:TextBox ID="procesador" runat="server" placeholder="escribe el procesador"></asp:TextBox>
        </div>
        <div>
            <asp:Button runat="server" Text="conexion" OnClick="Unnamed1_Click" />
            <asp:Button ID="alta1" runat="server" Text="Alta Todo" OnClick="alta1_Click"  />
            <asp:Button ID="boton2" runat="server" Text="Alta procedimiento almacenado" OnClick="boton2_Click"   />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>


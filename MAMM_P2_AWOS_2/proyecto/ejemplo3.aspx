<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejemplo3.aspx.cs" Inherits="MAMM_P2_AWOS_2.proyecto.ejemplo3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="EstilosNuevoForm.css"/>
</head>
<body>
    <h1>Datos de la base de datos </h1>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
        <div>
            <asp:Button ID="Agrega" runat="server" Text="Agregar computadora" OnClick="Agrega_Click"  />
            <asp:Button ID="Elimina" runat="server" Text="Eliminar computadora" OnClick="Elimina_Click"  />
            <asp:Button ID="Busca" runat="server" Text="Buscar" OnClick="Busca_Click"  />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FiftyOne.Demo.WebSite.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>51Degrees C# / C Device Detection Demo</title>
    <link rel="stylesheet" type="text/css" href="https://51degrees.com/Demos/examples.css" class="inline"/>
</head>
<body>
    <form id="formMain" runat="server">
    <p><img src="https://51degrees.com/DesktopModules/FiftyOne/Distributor/Logo.ashx?utm_source=github&utm_medium=repository&utm_content=server&utm_campaign=MSVC-open-source" alt="51Degrees"/></p>
    <div class="content">
        <asp:Literal runat="server" ID="Results" />
    </div>
    </form>
</body>
</html>
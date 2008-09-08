<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aspajaxdemo._Default" %>

<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
      <Scripts>
       <asp:ScriptReference Path="~/ajax.js" />
      </Scripts>
      <Services>
          <asp:ServiceReference Path="~/SayHelloService.asmx" />
      </Services>
     </asp:ScriptManager>
    <div>
    <input id="btnSayHello" type="button" value="SayHello" onclick="btnSayHello_onClick()" />
           <div id="result"></div>
    </div>
    </form>
</body>
</html>--%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>复杂类型自动转换测试</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Path="~/ajax.js" />
            </Scripts>
            <Services>
                <asp:ServiceReference Path="~/StudentService.asmx" />
            </Services>
        </asp:ScriptManager>
        <div>
            <input id="btnShowStudentInfo" type="button" value="ShowStudentInfo" onclick="btnShowStudentInfo_onClick()" />
            <div id="result"></div>
        </div>
    </form>
</body>
</html>
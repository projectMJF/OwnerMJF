<%@ Page Language="C#" Debug="true" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Manage_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Inventory Login</title>
    <style >
   body {margin-top:0px}
   </style> 
</head>
<body  oncontextmenu=self.event.returnValue=false onselectstart="return false" style="text-align: left; background-color:#eaf0f2;">
    <form id="form1" runat="server">
    
    <div style="margin:auto;  width:auto; height:20px;"></div>
    
    <div style="width:448px;  margin-top:50px; height:315px; background-image: url(../pt/lo.png); margin:auto;" 
      align ="center" >
    <br />
        <br />
        <br />
        <br />
    <table style="width: 402px; height:86px; font-size: 9pt;" border="0" cellpadding="0" cellspacing="0" align="center" >
            <tr style ="width: 152px;height: 18px;" valign =top >
                <td style="width: 263px" align =right>
                    Name：</td>
                <td style="width: 113px">
                    <asp:TextBox ID="txtAdminName" runat="server" Height="20px" Width="200px"></asp:TextBox></td>
                        
                        
                <td style="width: 51px">
                    </td>
            </tr>
            <tr style="color: #000000">
                <td style="width: 263px;" valign="top" align =right>
                    Password：</td>
                    
                    
                <td style="width: 113px; " valign="top">
                    <asp:TextBox ID="txtAdminPwd" runat="server" TextMode="Password" Width="200px" Height="20px"></asp:TextBox></td>
                <td style="width: 51px;" valign="top">
                
                
                
                
                    </td>
            </tr>
            
              <tr>
                <td colspan="3" style="text-align: center; height: 30px;" align =center >
          </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center; height: 30px;" align =center >
          
                   &nbsp;  &nbsp;  &nbsp;  &nbsp;<asp:Button ID="btnLogin" runat="server" Text="Login" 
                        OnClick="btnLogin_Click" Width="100px"/>
                    &nbsp;&nbsp; &nbsp;&nbsp;
                   <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" 
                        CausesValidation="False" Width="100px"/>
            </tr>
        </table>
    <br />
        <br />
        <br />
    <br />
        <br />
    </div>
    
    </form>
</body>
</html>

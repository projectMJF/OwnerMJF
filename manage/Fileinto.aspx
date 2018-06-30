<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Fileinto.aspx.cs" Inherits="manage_Fileinto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inventory File</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
    <table align="center" border="0" class="css" style="width: 536px; height: 1px" cellpadding="0" cellspacing="0">
            <tr>
                <td align="center" class="csstitle" colspan="3" style="height: 1px">
                    Inventory Files List</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:DataList ID="DataList1" runat="server" CellPadding="4" 
                        OnEditCommand="DataList1_EditCommand" Width="800px" 
                        onselectedindexchanged="DataList1_SelectedIndexChanged" 
                        ForeColor="#333333">
                        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <ItemTemplate>
                            <table border="0" style="width: 631px; height: 1px" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td align="center" style="width: 63px; height: 18px;">
                                        Inventory File：</td>
                                        
                                        
                                        
                                    <td align="center" style="width: 237px; height: 18px;">
                                        <%#DataBinder.Eval(Container.DataItem, "filename")%>
                                        
                                        
                                        <a href='<%#DataBinder.Eval(Container.DataItem, "path")%>'>下载</a>
                                        
                                        
                                        
                                        
                                        
                                    </td>
                                    <td style="height: 18px">
                                        时间：<%#DataBinder.Eval(Container.DataItem, "filetime", "{0:yyyy-MM-dd}")%></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <AlternatingItemStyle BackColor="White" />
                        <ItemStyle BackColor="#EFF3FB" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    </asp:DataList></td>
            </tr>
            </table>
    
    
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileIncept.aspx.cs" Inherits="fileManage_FileIncept" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="../CSS/CSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            height: 11px;
            width: 124px;
        }
        .style2
        {
            height: 13px;
            width: 124px;
        }
        .style3
        {
            height: 35px;
            width: 124px;
        }
        .style4
        {
            height: 18px;
            width: 124px;
        }
    </style>
</head>
<body  style="background-color:#e2f6f1;">

<div style="width:auto; height:40px; font-family:Arial, Helvetica, sans-serif; font-size:14px; background-color: #d0d7eb; margin:auto; margin-top:5px; text-align:left;  color: #000000;">

<br/>&nbsp; &nbsp; &nbsp;  Lileds Inventory Document </div>

    <form id="form1" runat="server">
    <div style="margin-top:20px;">
        <table align="center"  style="width: 536px; height: 1px; background-color:#c5c3ec; border: #000000 dotted 1px; color: Blue; " cellpadding="0" cellspacing="0">
            <tr>
                <td align="left"  colspan="3" style="height:30px">
                &nbsp;&nbsp;Download following files , then open it. Please don't repeat to download!
                    </td>
            </tr>
            <tr>
               <%-- <td align="right" colspan="3" style="height: 1px">
                    <asp:RadioButton ID="rdoBtnInpceptFalse" runat="server" AutoPostBack="true" Checked="true"
                        GroupName="file" Text="显示未接受" />
                    <asp:RadioButton ID="rdoBtnInpceptTrue" runat="server" AutoPostBack="true" GroupName="file"
                        Text="显示已接收" />&nbsp;
                </td>--%>
            </tr>
            <tr>
                <td colspan="3" rowspan="10">
                    <asp:DataList ID="DataList1" runat="server" 
                        OnEditCommand="DataList1_EditCommand" Width="526px" CellPadding="2" 
                        ForeColor="#333333">
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <AlternatingItemStyle BackColor="White" />
                        <ItemStyle BackColor="#EFF3FB" />
                        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <ItemTemplate>
                            <table border="1" style="width: 600px; height: 20px" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td align="center" class="style1">
                                        File Title：</td>
                                    <td align="left"  colspan="2" style="height: 11px">
                                        <%# DataBinder.Eval(Container.DataItem, "filetitle")%>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style2">
                                        From：</td>
                                    <td style="width: 237px">
                                        <%# DataBinder.Eval(Container.DataItem, "filesender")%>
                                    </td>
                                   <%-- <td align="center">
                                        接收状态：<%#DataBinder.Eval(Container.DataItem, "examine")%>&nbsp;
                                        <asp:LinkButton ID="linkbutton1" runat="server" CommandName="edit" >确认接收</asp:LinkButton></td>--%>
                                </tr>
                                <tr>
                                    <td align="center" class="style3">
                                        File Content：</td>
                                    <td colspan="0" style="height: 35px">
                                        <%#DataBinder.Eval(Container.DataItem, "filecontent")%>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style4">
                                        FILE：</td>
                                    <td align="center" style="width: 237px; height: 18px;">
                                        <%#DataBinder.Eval(Container.DataItem, "filename")%>
                                        <a href='<%#DataBinder.Eval(Container.DataItem, "path")%>'>Download</a>
                                    </td>
                                    <td style="height: 18px">
                                       TIME：<%#DataBinder.Eval(Container.DataItem, "filetime", "{0:yyyy-MM-dd}")%></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList></td>
            </tr>
            </table>
        
        
        
    
    </div>
    
    <div style="width:auto; height:30px; font-family:Arial, Helvetica, sans-serif; font-size:12px; background-color: #90ccd3; margin-top:20px; text-align:left;  color: #FFFFFFF; margin-left: auto; margin-right: auto; margin-bottom: 0px;"> 
    
          
        
        
       <a href="pdt.aspx"; >  Back Inventory </a>
    
    
    
    
        </div>
    
    <div style="width:auto; height:200px; font-family:Arial, Helvetica, sans-serif; font-size:12px; background-color: #d0d7eb; margin:auto; margin-top:80px; text-align:center;  color: #000000;"><br/>Copyright &copy; LiLEDs All rights Reserved&nbsp;&nbsp;LiLEDs (Shanghai) Company. Add: 628 Xinmiaosan Road, Songjiang, Shanghai, China. Tel: +86(21)37787347 </div>
    </form>
</body>
</html>

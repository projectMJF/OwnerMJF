<%@ Page Language="C#" AutoEventWireup="true" CodeFile="USInventory.aspx.cs" Inherits="manage_USInventory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>USInventory</title>
</head>
<body  style="background-color:Menu;">
    <form id="form1" runat="server">
    
    <div style="margin-top:5px; width:auto; height:50px; background-color:#dadff3; color:#000000; font-size:16px;  ">
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Lileds USA Inventory 
        
    </div>
    <div style="margin-top:10px;">
    
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
            DataKeyNames="Product_name" DataSourceID="SqlDataSource1" ForeColor="#333333" 
            GridLines="None" HorizontalAlign="Center" PageSize="5" Width="1000px">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" HorizontalAlign="Center" Width="100px" 
                VerticalAlign="Middle" />
            <Columns>
                <asp:CommandField HeaderText="Pick" SelectText="Choose" 
                    ShowSelectButton="True" />
                <asp:BoundField DataField="OrderNumber" HeaderText="OrderNumber" 
                    InsertVisible="False" ReadOnly="True" SortExpression="OrderNumber" />
                <asp:BoundField DataField="Product_name" HeaderText="Product_name" 
                    ReadOnly="True" SortExpression="Product_name" />
                <asp:BoundField DataField="Unit_d" HeaderText="Unit_d" 
                    SortExpression="Unit_d" />
                <asp:BoundField DataField="Last_m" HeaderText="Last_m" 
                    SortExpression="Last_m" />
                <asp:BoundField DataField="Total_In" HeaderText="Total_In" 
                    SortExpression="Total_In" />
                <asp:BoundField DataField="Out_total" HeaderText="Out_total" 
                    SortExpression="Out_total" />
                <asp:BoundField DataField="In_total" HeaderText="In_total" 
                    SortExpression="In_total" />
                <asp:BoundField DataField="Recognition" HeaderText="Recognition" 
                    SortExpression="Recognition" />
                <asp:BoundField DataField="Status_In" HeaderText="Status_In" 
                    SortExpression="Status_In" />
                <asp:BoundField DataField="Date_Id" HeaderText="Date_Id"  
                DataFormatString="{0:MM/dd/yyyy}" 
                    SortExpression="Date_Id" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    
    
    
    
    
    
    
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:liledsConnectionString2 %>" 
            SelectCommand="SELECT * FROM [tb_USinventory]"></asp:SqlDataSource>
    
    
    
    
    
    
    
    
    </div>
    <div style="width:auto; height:200px; font-family:Arial, Helvetica, sans-serif; font-size:12px; background-color: #d0d7eb; margin:auto; margin-top:230px; text-align:center;  color: #000000;"><br/>Copyright &copy; LiLEDs All rights Reserved&nbsp;&nbsp;LiLEDs (Shanghai) Company. Add: 628 Xinmiaosan Road, Songjiang, Shanghai, China. Tel: +86(21)37787347 
  </div>
    </form>
</body>
</html>

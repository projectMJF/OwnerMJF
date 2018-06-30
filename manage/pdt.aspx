<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pdt.aspx.cs" Inherits="manage_pdt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inventory list</title>
</head>

<body style="background-color:Menu;">
    <form id="form1" runat="server">
    
    
    <div style="margin-top:5px; width:auto; height:50px; background-color:#dadff3; color:#000000; font-size:16px;  ">
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Lileds Shanghai Inventory 
    
    
    </div>
    
    
    
    
    <div style="margin-top:10px;">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" 
            HorizontalAlign="Center" GridLines="None" ForeColor="#333333" 
            style="margin-bottom: 0px" AllowSorting="True" Width="900px">
            
            
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
            
            
            <Columns>
                <asp:CommandField ShowSelectButton="True" HeaderText="Pick" 
                    SelectText="Choose" />
                
                
                <asp:BoundField  DataField="OrderNumber" HeaderText="OrderNumber" 
                    InsertVisible="False" ReadOnly="True" SortExpression="OrderNumber"/>
                    
                 <asp:BoundField  DataField="Product_name" HeaderText="Product_name" 
                    SortExpression="Product_name"/>
                    
                  <asp:BoundField  DataField="Unit_d" HeaderText="Unit_d" 
                    SortExpression="Unit_d"/>
                    
                   <asp:BoundField  DataField="Last_m" HeaderText="Last_m" 
                    SortExpression="Last_m"/>
                    
                    <asp:BoundField  DataField="Out_total" HeaderText="Out_total" 
                    SortExpression="Out_total"/>
                    
                     <asp:BoundField  DataField="In_total" HeaderText="In_total" 
                    SortExpression="In_total"/>
                    
                      <asp:BoundField  DataField="Recognition" HeaderText="Recognition" 
                    SortExpression="Recognition"/>
                    
                       <asp:BoundField  DataField="Status_In" HeaderText="Status_In" 
                    SortExpression="Status_In"/>
                    
                          <asp:BoundField  DataField="Date_Id" HeaderText="Date_Id" 
                         DataFormatString="{0:MM/dd/yyyy}"
                    SortExpression="Date_Id"/>
                    
                    
           
            </Columns>
        
    
    
    
    
    
    
    
    
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
        
    
    
    
    
    
    
    
    
            <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle HorizontalAlign="Center" BackColor="#5D7B9D" Font-Bold="True" 
                ForeColor="White" />
            <EditRowStyle HorizontalAlign="Center" BackColor="#999999" />
        
    
    
    
    
    
    
    
    
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        
    
    
    
    
    
    
    
    
    </asp:GridView>
    
    
     
            
            
              <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:liledsConnectionString2 %>" 
            SelectCommand="SELECT * FROM [tb_proinfo]">
            </asp:SqlDataSource>
            
            
            
    
    
    </div>
    
  <div style="margin-top:20px; height:35px; background-color:#dadff3; color:#000000; font-size:16px;  ">
  
  
  
   &nbsp;&nbsp; &nbsp;&nbsp;
   
      <asp:Button ID="Button1" runat="server" Text="ADD Inventory " Width="108px" 
          OnClick="btnin_Click" Height="30px" />
  &nbsp;&nbsp; &nbsp;&nbsp; 
      <asp:Button ID="Button2" runat="server" Text="OUT Inventory" Width="108px"  
          OnClick="btnout_Click" Height="30px" />
  
  </div>
  
  
  
  <div style="width:auto; height:200px; font-family:Arial, Helvetica, sans-serif; font-size:12px; background-color: #d0d7eb; margin:auto; margin-top:230px; text-align:center;  color: #000000;"><br/>Copyright &copy; LiLEDs All rights Reserved&nbsp;&nbsp;LiLEDs (Shanghai) Company. Add: 628 Xinmiaosan Road, Songjiang, Shanghai, China. Tel: +86(21)37787347 >
  </div>
    
    
    
    
    
    </form>
</body>
</html>

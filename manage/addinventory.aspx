<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addinventory.aspx.cs" Inherits="manage_addinventory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADD Inventory</title>
</head>
<body style="background-color:#eaf0f2;">
    <form id="form1" runat="server">
    <div>
    
    <div style="width:auto; height:40px; font-family:Arial, Helvetica, sans-serif; font-size:14px; background-color: #d0d7eb; margin:auto; margin-top:5px; text-align:left;  color: #000000;">

<br/>&nbsp; &nbsp; &nbsp;  Lileds Inventory Input Document </div>
    
<table   cellSpacing="0" cellPadding="0" width="480" align="center" border="0">
				<tr>
					<td  align="left" height="35" colspan="2">
						 Input Inventory Infomation
						 
						 
						 &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
						 
						 
                             
                             
                        
                             
                             
                             
                             
					</td>
					
					 <br/>
					 
					 
				</table> 
			<table    cellSpacing="1" cellPadding="1" width="480" align="center" border="1" id="tabAddProduct" >
				<tr>
    
    <td style="width: 478px">
    
						<table  cellSpacing="0" cellPadding="0" width="95%" align="center" border="0">
							<tr>
							
								<td align="left">
                                    ProductName：
								</td>
								<td style="width: 359px">
									<asp:DropDownList id="ddlCategory" runat="server" AutoPostBack="True" 
                                        DataSourceID="SqlDataSource1" DataTextField="Product_name" 
                                        DataValueField="Product_name"></asp:DropDownList>
								    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:liledsConnectionString2 %>" 
                                        SelectCommand="SELECT [Product_name] FROM [tb_proinfo]"></asp:SqlDataSource>
								</td>
							</tr>
							<tr>
								<td align="left" width="80">
                                    Unit_d：</td>
								
								<td style="width: 359px"><asp:textbox id="txtunit" runat="server"></asp:textbox><FONT color="red"><asp:RequiredFieldValidator
                                        ID="rfvunit" runat="server" ControlToValidate="txtunit" Font-Size="9pt"
                                        Height="1px" Width="14px">**</asp:RequiredFieldValidator></FONT></td>	
							</tr>
							<tr>
								<td align="left" style="height: 24px">
                                    Last_m：
								</td>
								<td style="width: 359px; height: 24px;"><asp:textbox id="txtlast" runat="server"></asp:textbox><FONT color="red"><asp:RequiredFieldValidator
                                        ID="rfvlast" runat="server" ControlToValidate="txtlast" Font-Size="9pt"
                                        Height="1px" Width="14px">**</asp:RequiredFieldValidator>
                                        </FONT></td>
							</tr>
							
							<tr>
								<td align="left">Total_In：
								</td>
								<td style="width: 359px"><asp:textbox id="txttotalIn" runat="server"></asp:textbox><FONT color="red"><asp:RequiredFieldValidator
                                        ID="rfvtotalIn" runat="server" ControlToValidate="txttotalIn" Font-Size="9pt"
                                        Height="1px" Width="14px">**</asp:RequiredFieldValidator></FONT></td>
							</tr>
							<tr>
								<td align="left" height="19">Out_total：
								</td>
								<td colSpan="3" height="19"><asp:textbox id="txtout" runat="server">0</asp:textbox><FONT color="red">*<asp:RegularExpressionValidator
                                        ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtout"
                                        ErrorMessage="请输入正整数" ValidationExpression="^[0-9]+(.[0-9]{0})?$"></asp:RegularExpressionValidator>
                                        <asp:RequiredFieldValidator
                                        ID="rfv" runat="server" ControlToValidate="txtout" Font-Size="9pt"
                                        Height="1px" Width="14px">*</asp:RequiredFieldValidator></FONT>
                                        </td>
							</tr>
							<tr>
								<td align="left">In_total：
								</td>
								<td colSpan="3"><asp:textbox id="txtintotal" runat="server">0</asp:textbox><FONT color="red">*<asp:RegularExpressionValidator
                                        ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtintotal"
                                        ErrorMessage="请输入正整数" ValidationExpression="^[0-9]+(.[0-9]{0})?$"></asp:RegularExpressionValidator>
                                        <asp:RequiredFieldValidator
                                        ID="rfvintotal" runat="server" ControlToValidate="txtintotal" Font-Size="9pt"
                                        Height="1px" Width="14px">*</asp:RequiredFieldValidator>
                                        </FONT></td>
							</tr>
							
								<tr>
								<td align="left" style="height: 24px">
                                    Status_In：
								</td>
								<td style="width: 359px; height: 24px;"><asp:textbox id="txtstatus" runat="server"></asp:textbox><FONT color="red">*<asp:RequiredFieldValidator
                                        ID="rfvsta" runat="server" ControlToValidate="txtstatus" Font-Size="9pt"
                                        Height="1px" Width="14px">*</asp:RequiredFieldValidator>
                                        &nbsp;</FONT></td>
							</tr>
							<tr>
								<td style="width: 359px; height: 24px;"align="left"></td>
                                  
							</tr>
							<tr>
                                
								<td align="center" colSpan="4">
								<br/>
								
                                  
                                    <%--<asp:Button ID="ADDInto" runat="server" Text="ADDInto" Width="150px" 
                                        onclick="ADDInto_Click" />--%>
                                        
                                    <asp:FileUpload ID="FileUpload1" runat="server" Width="397px" />
                                        
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        
                                                                            
                                        
                                        
								
									</td>
							</tr>
						</table>
					</td>
					</table>
					
					
					</div>
    
    <div style="width:auto; height:50px; font-family:Arial, Helvetica, sans-serif; font-size:12px; background-color: #d0d7eb; margin:auto; margin-top:20px; text-align:center;  color: #000000;"> 
    
      
           <asp:Button ID="ADDbtn" runat="server" Text="ADD" Width="200px" 
                onclick="btnADD_Click" style="height: 30px" />
                                                       
                                        
              
                
            <asp:Button ID="Button1" runat="server" Text="Clear" Width="200px" 
                onclick="btnrel_Click1" style="height: 30px" />
        
    
      &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; 
     
        
        
       <a href="pdt.aspx"; >  Back Inventory </a>
    
    <div  style="width:auto; height:auto; "></div>
    
    
        </div>
        
        </div>
    
     
     

     
     
     <div style="width:auto; height:200px; font-family:Arial, Helvetica, sans-serif; font-size:12px; background-color: #d0d7eb; margin:auto; margin-top:230px; text-align:center;  color: #000000;"><br/>Copyright &copy; LiLEDs All rights Reserved&nbsp;&nbsp;LiLEDs (Shanghai) Company. Add: 628 Xinmiaosan Road, Songjiang, Shanghai, China. Tel: +86(21)37787347 </div>
     
     
     
     
     
    
    
    </form>
</body>
</html>

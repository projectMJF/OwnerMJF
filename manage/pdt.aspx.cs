using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class manage_pdt : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
       if (Session["loginName"] == null)  
       {
           
           Response.Redirect("~//manage/Login.aspx");
    }



        if (!this.IsPostBack)
        { 
        
                  
        
        }

    }



   protected void btnin_Click(object sender, EventArgs e)
   {
               

      
     //   Response.Write(ccObj.MessageBox("抱歉，您无此权限！"));
    //   Response.Write("<script language=javascript>window.open('~/fileManage/FileSend.aspx');window.close();</script>");
       Response.Redirect("~//fileManage/FileSend.aspx");

     }
  


    protected void btnout_Click(object sender, EventArgs e)
   {
      //   Response.Write(ccObj.MessageBox("抱歉，您无此权限！"));

      // Response.Write("<script language=javascript>window.open('~//fileManage/FileIncept.aspx');window.close();</script>");
       Response.Redirect("~//fileManage/FileIncept.aspx");
    
    }



















    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>window.open('USInventory.aspx');window.close();</script>");
    }
}

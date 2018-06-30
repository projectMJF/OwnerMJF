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
using System.IO;


public partial class manage_adpro : System.Web.UI.Page
{

    CommonClass ccObj = new CommonClass();
    BaseClass bc = new BaseClass();
    DBClass dbObj = new DBClass();
    static string path;



    protected void Page_Load(object sender, EventArgs e)
    {
      //  if (Session["loginName"] == null)  
           //   {
              // Response.Redirect("~//manage/Login.aspx");
        //  }
    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }
    




    protected void Outinventory_Click(object sender, EventArgs e)
    {

        // SQL Updata  insert database OR


        Response.Write(ccObj.MessageBox("Sorry, please check your user power! "));
        return;

        
    }










    protected void CLEARBTN_Click(object sender, EventArgs e)
    {


        if (this.txttotalIn.Text.Trim() != "" || this.txtintotal.Text.Trim() != "" || this.txtout.Text.Trim() != "")
        {

           Response.Redirect("~//manage/adpro.aspx");
           // return;

         //    Response.Write("<script language=javascript>window.open('adpro.aspx');window.close();</script>");
            return;

        }




    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

        Response.Write("<script language=javascript>window.open('pdt.aspx');window.close();</script>");
        return;

    }
   



          protected void DataList1_SelectedIndexChanged1(object sender, EventArgs e)
          {


             
          }
}

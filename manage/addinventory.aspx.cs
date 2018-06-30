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


public partial class manage_addinventory : System.Web.UI.Page
{


    CommonClass ccObj = new CommonClass();
    DBClass dbObj = new DBClass();
    BaseClass bc = new BaseClass();
    static string path;







    protected void Page_Load(object sender, EventArgs e)
    {


     // if (Session["loginName"] == null)   
           //    {
            //    
              //  Response.Redirect("~//manage/Login.aspx");
        //   }



        if (!IsPostBack)
        
        {


        

        }

    }




    protected void btnADD_Click(object sender, EventArgs e)
    {
          string str = this.FileUpload1.FileName;
          string std = str.Substring(str.LastIndexOf(".")+1);

        if (str == string.Empty)
        {
            Response.Write("<script>alert('请添加文件!')</script>"); 
            return;
        }
            //  path = "..\\file\\" + fileName; 

        FileInfo fileInfo = new FileInfo(sad);                  //获取文件信息
        long fileSize = (fileInfo.Length / 1024) / 1024;        
       
        if (fileSize > 1)                                      
       {
            Response.Write(bc.MessageBox("文件大小不能超过1M ！"));
            return;                                             
        }

        else{
              
            FileUpload1.SaveAs(Server.MapPath("..\\loadfile/" + FileUpload1.FileName));


            Response.Write("<script>alert('上传成功!')</script>");

        
        }





        if (sad == "xls" || std == "xlsx")
       {
           FileUpload1.SaveAs(Server.MapPath("..\\loadfile/" + FileUpload1.FileName));


            Response.Write("<script>alert('上传成功!')</script>");

        }




        else {

            Response.Write("<script>alert('请上传 Excel文件!')</script>");
           return;
            
        }

        

       

    }



 
    protected void btnrel_Click1(object sender, EventArgs e)
    {

        if (this.txttotalIn.Text.Trim() != "" || this.txtintotal.Text.Trim() != "" || this.txtout.Text.Trim() != "")
        {

            Response.Redirect("~//manage/addinventory.aspx");
            return;

        }
    }


    protected void backpdt_Click(object sender, EventArgs e)
    {

        Response.Write("<script language=javascript>window.open('addinventory.aspx');window.close();</script>");
        return;


    }
}

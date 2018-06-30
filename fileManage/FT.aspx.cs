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


public partial class fileManage_FT : System.Web.UI.Page
{


   

    protected void Page_Load(object sender, EventArgs e)
    {


    }


    protected void ft_Click(object sender, EventArgs e)
    {
                   
        
      
        string str = this.FileUpload1.FileName;

        FileUpload1.SaveAs(Server.MapPath("..\\loadfile/" + FileUpload1.FileName));


       //  Response.Write(bc.MessageBox("文件大小不能超过1M ！"));
        Response.Write("good");

    }
}

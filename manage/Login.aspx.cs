using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;



public partial class Manage_Login : System.Web.UI.Page
{
   

    CommonClass ccObj = new CommonClass();

       

    protected void Page_Load(object sender, EventArgs e)
    {

     //   if (Session["loginName"] == null)   
     //   {
            
      //    Response.Write("<script>this.parent.location.href='../Login.aspx'</script>");
       //   return;
      //  }

        
        if (!this.IsPostBack)

        {

        
           
        }


    }





    protected void btnLogin_Click(object sender, EventArgs e)
    {


        if (this.txtAdminName.Text.Trim() == "" || this.txtAdminPwd.Text.Trim() == "")
        {

            Response.Write(ccObj.MessageBox("username and password not null！"));
            return;

         
        }
                        
      if(this.txtAdminName.Text.Trim() == "John" && this.txtAdminPwd.Text.Trim() == "lileds01A")
       {

           HttpContext.Current.Session.Timeout = 1;   

     //    bc.ExecSQL("update tb_userna set logintime='" + DateTime.Now + "', where userName='" + txtAdminName.Text + "'");

          Session["loginName"] = txtAdminName.Text;

           Response.Redirect("~//manage/pdt.aspx");

                }

      if (this.txtAdminName.Text.Trim() == "Kate" && this.txtAdminPwd.Text.Trim() == "lileds02A")
      {

          HttpContext.Current.Session.Timeout = 1;


          Session["loginName"] = txtAdminName.Text;

          Response.Redirect("~//manage/pdt.aspx");

      }


      if (this.txtAdminName.Text.Trim() == "Zhouzhiming" && this.txtAdminPwd.Text.Trim() == "shlileds01")
      {

          HttpContext.Current.Session.Timeout = 1;


          Session["loginName"] = txtAdminName.Text;

          Response.Redirect("~//manage/pdt.aspx");

      }



      if (this.txtAdminName.Text.Trim() == "Chengfang" && this.txtAdminPwd.Text.Trim() == "shlileds02")
      {

          HttpContext.Current.Session.Timeout = 1;


          Session["loginName"] = txtAdminName.Text;

          Response.Redirect("~//manage/pdt.aspx");

      }



      if (this.txtAdminName.Text.Trim() == "Qifengxian" && this.txtAdminPwd.Text.Trim() == "shlileds03")
      {

          HttpContext.Current.Session.Timeout = 1;


          Session["loginName"] = txtAdminName.Text;

          Response.Redirect("~//manage/pdt.aspx");

      }













      if (this.txtAdminName.Text.Trim() != "John" && this.txtAdminPwd.Text.Trim() != "lileds01A")
      {

          Response.Write(ccObj.MessageBox("username and password wrong！"));
          return;

      }



        

      if(this.txtAdminName.Text.Trim() != "Kate" && this.txtAdminPwd.Text.Trim() != "lileds02A")
        {

          Response.Write(ccObj.MessageBox("username and password wrong！"));
         return;
             
      }




      if (this.txtAdminName.Text.Trim() != "Zhouzhiming" && this.txtAdminPwd.Text.Trim() != "shlileds01")
      {

          Response.Write(ccObj.MessageBox("username and password wrong！"));
          return;

      }

      if (this.txtAdminName.Text.Trim() != "Chengfang" && this.txtAdminPwd.Text.Trim() != "shlileds02")
      {

          Response.Write(ccObj.MessageBox("username and password wrong！"));
          return;

      }


      if (this.txtAdminName.Text.Trim() != "Qifengxian" && this.txtAdminPwd.Text.Trim() != "shlileds03")
      {

          Response.Write(ccObj.MessageBox("username and password wrong！"));
          return;

      }














       //     SqlConnection con = SqlClass.SqlConBind();//创建数据库连接对象
     //       con.Open();//打开数据库连接


         //   SqlDataAdapter sda = new SqlDataAdapter();
          //  sda.SelectCommand = new SqlCommand("select  * from tb_userna where usernamea='" + txtAdminName.Text + "'and passworda='" + txtAdminPwd.Text + "'and recognitiona=1", "tb_userna");
          //  DataSet ds = new DataSet();
         //   sda.Fill(ds, "tb_userna");
         //   return ds;


        //    DataSet ds = bc.GetDataSet("select  * from tb_userna where usernamea='" + txtAdminName.Text + "'and passworda='" + txtAdminPwd.Text + "'and recognitiona=1", "tb_userna");
            
          //  if (ds.Tables[0].Rows.Count > 0)
           // {
                //登录成功后，设置登录时间和标识
              //  bc.ExecSQL("update tb_userna set logintime='" + DateTime.Now + "', where userName='" + txtAdminName.Text + "'");
                
                //存储登录用户名称
             //   Session["loginName"] = txtAdminName.Text;
                
                //登录成功后，进入系统主页
            //    Response.Redirect("~/pdt.aspx");
         


         //   if
         //   {

           //     Response.Write(ccObj.MessageBox("username and password wrong！"));
         //       return;
  //      
    
    }


    
            
      
















    protected void btnCancel_Click(object sender, EventArgs e)
    {

      txtAdminName.Text = "";
        txtAdminPwd.Text = "";

      //  Response.Redirect("~//manage/pdt.aspx");

     //   Response.Write("<script language=javascript>window.open('pdt.aspx');window.close();</script>");
      //  return;



    }
}







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

public partial class manage_Fileinto : System.Web.UI.Page
{
    BaseClass bc = new BaseClass();
    protected void Page_Load(object sender, EventArgs e)
    {
       // if (Session["loginName"] == null)　//用户非法登录，跳转的系统主页。
       // {
      //      Response.Write("<script>this.parent.location.href='..//manage/Login.aspx'</script>");
      //      return;
       // }

        if (!IsPostBack)
        {
            //如果系统登录身份为系统管理员，那么显示所有职员的文件列表
            if (Session["loginName"].ToString().Trim().ToUpper() == "Kate")
            {
                DataList1.DataSource = bc.GetDataSet("select * from tb_file order by fileTime desc", "tb_file");
                DataList1.DataKeyField = "fileid";
                DataList1.DataBind();
               // rdoBtnInpceptFalse.Enabled = false;
              //  rdoBtnInpceptTrue.Enabled = false;
                return;
            }
        
        }
      
    }
  
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

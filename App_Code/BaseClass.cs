using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Collections;
/// <summary>
/// BaseClass 的摘要说明
/// </summary>
/// 


public class BaseClass : System.Web.UI.Page
{
    public BaseClass()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    #region 显示客户端对话框
  

    public string MessageBox(string TxtMessage)
    {
        string str;
        str = "<script language=javascript> alert('" + TxtMessage + "')</script>";
        return str;
    }


    #endregion

    #region  执行SQL语句


       
    public Boolean ExecSQL(string sQueryString)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["liledsConnectionString2"]);
        con.Open();
        SqlCommand dbCommand = new SqlCommand(sQueryString, con);

        if (dbCommand.ExecuteNonQuery() > 0)
        {
            con.Close();
            return true;
        }
        else
        {
            con.Close();
            return false;
        }
    }

    



   

    public DataSet GetDataSet(string sQueryString, string TableName)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["liledsConnectionString2"]);
        SqlDataAdapter dbAdapter = new SqlDataAdapter(sQueryString, con);


       // DataSet dataset = new DataSet();
        DataSet ds = new DataSet();

        dbAdapter.Fill(ds, TableName);
        return ds;


       // dbAdapter.Fill(dataset, TableName);
      //  return dataset;
    }
    #endregion
}
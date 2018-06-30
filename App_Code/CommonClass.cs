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


public class CommonClass
{
	public CommonClass()
	{
		
	}
   
    public string MessageBox(string TxtMessage,string Url)
    {
        string str;
        str = "<script language=javascript>alert('" + TxtMessage + "');location='" + Url + "';</script>";
        return str;
    }
   


    public string MessageBox(string TxtMessage)
    {
        string str;
        str = "<script language=javascript>alert('" + TxtMessage + "')</script>";
        return str;
    }
  


    public string MessageBoxPage(string TxtMessage)
    {
        string str;
        str = "<script language=javascript>alert('" + TxtMessage + "');location='javascript:history.go(-1)';</script>";
        return str;
    }
  


    public string RandomNum(int n) //
    {
       
        string strchar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
       
        string[] VcArray = strchar.Split(',');
        string VNum = "";
            
        int temp = -1;                       
      
        Random rand = new Random();
        for (int i = 1; i < n + 1; i++)
        {
            if (temp != -1)
            {
          
                rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
            }
           
            int t = rand.Next(61);
            if (temp != -1 && temp == t)
            { 
                return RandomNum(n);
            }
            temp = t;
            VNum += VcArray[t];
        }
        return VNum;
    }
  

    public string VarStr(string sString, int nLeng)
    {
        int index = sString.IndexOf(".");
        if (index == -1 || index + nLeng >= sString.Length)
            return sString;
        else
            return sString.Substring(0, (index + nLeng + 1));
    }
  

}

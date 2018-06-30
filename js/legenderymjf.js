


function check(){
 var user = "diou", password = "chshdiou08*";
 var user = "lileds", password = "growing09%"; 
 var temUser = document.form1.username.value;
 var temPassword = document.form1.password.value;
 
 if(temUser=="diou" && temPassword=="chshdiou08*")
 
   window.location.href="http://www.lileds.com/manage/Login.aspx";
   
 else  if(temUser=="lileds" && temPassword=="growing09%")
   window.location.href="http://www.lileds.com/manage/Login.aspx";
   
 
 else alert("Pleae check your username and password!");
}


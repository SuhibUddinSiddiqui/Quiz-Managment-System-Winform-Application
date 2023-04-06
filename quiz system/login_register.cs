using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace quiz_system
{
    
   static class login_register
    {
       static string[] userdata;
        static bool login_check, email_check1, email_check2 = false;
        
       static public bool accountcreate(string category,string userName, string userEmail, string password)
        { 
                StreamWriter sw = new StreamWriter("userdata.txt", true);
                sw.WriteLine(category + "," + userName + "," + userEmail + "," + password + "," + "0" + "," + "0" + "," + "0" + "," + "0" + ",");
            sw.Close();
     
            return true;   
        }

       static public bool valid_emailcheck(string email)
        {

            if (email.Contains("@"))
            {
                email_check1 = true;
            }

            if (email.EndsWith(".com") || email.EndsWith(".co.uk") || email.EndsWith(".edu,pk") || email.EndsWith(".pk"))
            {
                email_check2 = true;
            }

            if (email_check1 && email_check2)
            {
                StreamReader sr1 = new StreamReader("userdata.txt");
                userdata = sr1.ReadToEnd().Replace("\r\n","").Split(',');
                for (int i = 0; i < userdata.Length-1; i+=8)
                {
                    
                    if (userdata[i+2]==email)
                    {
                        return false; 
                    }
                }
                sr1.Close();
                
                return true;
            }
            else
            {
                return false;
            }
        }

       static public string logincheck(string userName, string userPassword)
       {
           StreamReader sr = new StreamReader("userdata.txt");
           userdata = sr.ReadToEnd().Replace("\r\n", "").Split(',');
           string temp="";
           for (int i = 0; i < userdata.Length-1; i+=8)
           {
              
               if (userName == userdata[i+2] && userPassword == userdata[i+3])
               {
                   login_check = true;
                   if (userdata[i]=="teacher")
                   {
                       temp="teacher";
                   }
                   else if (userdata[i]=="student")
                   {
                       temp= "student";
                   }
                   
                   break;
               }
           }
           sr.Close();
           if (temp=="student")
           {
               return "student";
           }
           else if (temp=="teacher")
           {
               return "teacher";
           }
           else
           {
               return "failed";
           }
       }

      static public void remembermedata(string username, string password)
       {
           StreamWriter sw = new StreamWriter("remembermedata.txt");
           sw.Write("1" + "," + username + "," + password);
           sw.Close();

       }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WEB_HELLO_WORLD
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Result Login(string userName,string userPass)
        {
            web_testEntities db = new web_testEntities();
            USER_TABLE USER_ = new USER_TABLE();
            Result result = new Result();

            USER_ = db.USER_TABLE.Where(x => x.name_user == userName && x.numer_user == userPass).FirstOrDefault();

            if (USER_ != null)
            {
                result.ValidUser = true;
                
            }
            else
            {
                result.ValidUser = false;
            }
            return result;
        }


    }
}

using System.Web.Script.Services;
using System.Web.Services;
using aspajaxdemo.Old_App_Code;

namespace aspajaxdemo
{
    /// <summary>
    /// SayHelloService 的摘要说明
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[ToolboxItem(false)]
    //// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    //// [System.Web.Script.Services.ScriptService]
    //public class SayHelloService : System.Web.Services.WebService
    //{

    //    [WebMethod]
    //    public string HelloWorld()
    //    {
    //        return "Hello World";
    //    }
    //}
    [WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class SayHelloService : System.Web.Services.WebService
{
    public SayHelloService() { }

    [WebMethod]
    public string SayHello()
    {
        Hello myHello = new Hello();
        return myHello.SayHello();
    }
}

}

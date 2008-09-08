//using System;
//using System.Collections;
//using System.ComponentModel;
//using System.Data;
//using System.Linq;
//using System.Web;
//using System.Web.Services;
//using System.Web.Services.Protocols;
//using System.Xml.Linq;

//namespace aspajaxdemo
//{
//    /// <summary>
//    /// StudentService 的摘要说明
//    /// </summary>
//    [WebService(Namespace = "http://tempuri.org/")]
//    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
//    [ToolboxItem(false)]
//    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
//    // [System.Web.Script.Services.ScriptService]
//    public class StudentService : System.Web.Services.WebService
//    {

//        [WebMethod]
//        public string HelloWorld()
//        {
//            return "Hello World";
//        }
//    }
//}
using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Web.Script.Services;

namespace aspajaxdemo
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    [GenerateScriptType(typeof(StudentInfo))]
    public class StudentService : System.Web.Services.WebService
    {
        public StudentService() { }

        [WebMethod]
        public string ShowStudentInfo(StudentInfo student)
        {
            return "学生姓名：" + student.Name + "<br />年龄：" + student.Age + "<br />所在院系：" + student.College;
        }
    }
}
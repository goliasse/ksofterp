using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace aspajaxdemo
{
   [Serializable]
 public class StudentInfo
 {
    private string _name;
    private int _age;
    private string _college;

    public StudentInfo() { }

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public int Age
    {
        get { return this._age; }
        set { this._age = value; }
    }

    public string College
    {
        get { return this._college; }
        set { this._college = value; }
    }
 }
}

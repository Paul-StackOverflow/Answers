using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Linq;

namespace ASPXAnswers
{
    public partial class Answers : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var controls = this.head.Parent.Controls;
            var stuffWrapper = this.head.Parent.Controls[0];//("og:image");  http://stackoverflow.com/questions/40318489/read-the-tag-content-of-open-graph-from-code-behind-with-c-sharp/40319364#40319364
            var stuff = ((System.Web.UI.HtmlControls.HtmlMeta)stuffWrapper).Content;
            var stop = stuff;
            //string TargetPage = Page.AppRelativeVirtualPath;
            //if (TargetPage.ToLower().Contains("one"))
            //{
            //    link1.Attributes.Add("style", "background: red;");
            //}
            //else if (TargetPage.ToLower().Contains("two"))
            //{
            //    link2.Attributes.Add("style", "background: blue;");
            //}
            //else
            //{
            //    link1.Attributes.Add("style", "background: white;");
            //    link2.Attributes.Add("style", "background: white;");
            //}
        }
    }
}
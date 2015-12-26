using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXAnswers
{
    public partial class ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //using System.Linq;
            List<String> Items = new List<string>() { "1", "2", "3", null, null };
            Items.Where(var => var != null).ToList().ForEach(var => lbItems.Items.Add(var));
        }
    }
}
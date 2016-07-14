using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace requiredtasks
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string path;
        protected void Page_Load(object sender, EventArgs e)
        {
            Timer1.Tick += Timer1_Tick;
            path = Server.MapPath("~/");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            report rprt = new report();
            using (StreamWriter w = File.AppendText(path + @"\log.txt"))
            {
                rprt.Writetxt("Hi", w);
                //Server.MapPath("~/tmp/")
            }
        }
    }
}
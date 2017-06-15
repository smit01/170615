using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test0615_HelloASP {
    public partial class Hello : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            //if (Session["userName"] == null)
            //    Literal1.Text = "Hello! ";
            //else
                Literal1.Text = "Hello! " +
                    Session["userName"].ToString();
        }
    }
}
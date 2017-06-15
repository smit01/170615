using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test0615_HelloASP {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            //if (!this.IsPostBack) {
            //    // read data from DB Server
            //    // set values for controls.
            //    TextBox1.Text = "Keyin here";
            //}

            //Trace.Warn(
            //               "Page_Load: " +
            //               this.IsPostBack.ToString()
            //           );
        }


        protected void Button1_Click(object sender, EventArgs e) {
            // checking data
            // write into DB Server
            // prompt user to report/result page
            Trace.Warn("Button1_Click");
            // Button1.Text = "Hello! " + TextBox1.Text;
            // Response.Write("Hello! " + TextBox1.Text);
            // Literal1.Text = "<h1>Hello! " + TextBox1.Text + "</h1>";

            if (TextBox1.Text == "") {
                Literal1.Text = "Please key in your name.";
                return;
            }

            Session["userName"] = TextBox1.Text;
            Response.Redirect("hello.aspx");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime birthDate = Calendar1.SelectedDate;
        DateTime currentDate = DateTime.Now;
        TimeSpan daysBetween = birthDate - currentDate;
        lblResult.Text = "There are" + daysBetween.Days.ToString() + "days until your birthday";
    }
}
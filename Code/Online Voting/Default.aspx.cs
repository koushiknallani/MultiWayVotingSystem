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
        for (int i = 0; i < 5; i++)
        {
            TableRow tr = new TableRow();

            TableCell cl = new TableCell();
            TableCell cl2 = new TableCell();
            RadioButton raid = new RadioButton();
            raid.ID = "raid" + i;
            raid.GroupName = "a";
            Label txt = new Label();
            txt.ID = "txt" + i;
            txt.Text = "txt" + i;
            cl.Controls.Add(txt);
            cl2.Controls.Add(raid);

            tr.Controls.Add(cl);
            tr.Controls.Add(cl2);
            Table1.Controls.Add(tr);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       // MessageBox.Show("helo");
    }
}
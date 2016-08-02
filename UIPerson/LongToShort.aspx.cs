using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIPerson
{
    public partial class LongToShort : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                WcfSvcPerson.SvsPersonClient client = new WcfSvcPerson.SvsPersonClient();
                string time;
                int rows;
                int age = Convert.ToInt32(txtAge.Text);
                gvPersonL.DataSource = client.GetPersonLong(age, out time);
                txtTime.Text = time;
                gvPersonL.DataBind();
                //rows = client.SaveToPersonShort(aryPL);
                //txtRows.Text = rows.ToString();
            }
        }
    }
}
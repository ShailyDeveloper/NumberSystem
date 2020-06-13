using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NumberSystem.BusinessLayer;

namespace NumberSystem
{
    public partial class Western : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnConvert_Click(object sender, EventArgs e)
        {
            WesternNumberSystem logic = new WesternNumberSystem();
            string strNumber = txtNumber.Text;
            lblNumberAnswer.Text = logic.ReturnWordValue(strNumber);
        }
    }
}
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
        WesternNumberSystem logic = new WesternNumberSystem();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnConvert_Click(object sender, EventArgs e)
        {
            
            lblNumberAnswer.Text = "";
            lblError.Visible = false;
            if (hdnfldErrorOutput.Value != "True")
            {
                lblError.Visible = false;
                lblNumberAnswer.Text = logic.ReturnWordValue(txtNumber.Text);
                btnSave.Visible = true;
                txtNumber.Enabled = false;
                btnConvert.Enabled = false;
                lblAnswer.Visible = true;
                lblNumberAnswer.Visible = true;
            }
            else
            {
                lblError.Visible = true;
                btnSave.Visible = false;
                txtNumber.Enabled = true;
                btnConvert.Enabled = true;
                lblAnswer.Visible = false;
                lblNumberAnswer.Visible = false;

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            lblNumberAnswer.Text = logic.SaveData(txtNumber.Text, lblNumberAnswer.Text);
            if (lblNumberAnswer.Text == "Data Saved Successfully")
            {
                btnSave.Visible = false;
                btnConvert.Enabled = true;
                lblAnswer.Visible = false;
            }
            txtNumber.Text = "";
            txtNumber.Enabled = true;
        }
    }
}
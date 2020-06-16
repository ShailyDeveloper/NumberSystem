using System;
using System.Reflection;
using System.Web.UI;
using NumberSystem.BusinessLayer;
using NumberSystem.CommonFunctions;

namespace NumberSystem
{
    public partial class Western : Page
    {
        #region declaration
        WesternNumberSystem logic = new WesternNumberSystem();
        #endregion

        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Convert Button
        protected void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                MyLogger.GetInstance().Info("Entering the btnConvert_Click Method");
                if (hdnfldErrorOutput.Value != "True")
                    {
                        lblNumberAnswer.Text = logic.ReturnWordValue(txtNumber.Text);
                    }
                lblError.Visible = false;
                if (hdnfldErrorOutput.Value != "True" && lblNumberAnswer.Text != "Error in Conversion")
                {
                    lblError.Visible = false;
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
                    if (lblNumberAnswer.Text != "Error in Conversion")
                    {
                        lblNumberAnswer.Visible = false;
                    }
                    else
                    {
                        lblError.Visible = false;
                        lblNumberAnswer.Visible = true;
                    }

                }

                MyLogger.GetInstance().Info("Exiting the btnConvert_Click Method");
            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);

            }
        }
        #endregion

        #region Save
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MyLogger.GetInstance().Info("Entering the btnSave_Click Method");
                lblNumberAnswer.Text = logic.SaveData(txtNumber.Text, lblNumberAnswer.Text);
                if (lblNumberAnswer.Text == "Data Saved Successfully")
                {
                    txtNumber.Text = "";
                }
                lblAnswer.Visible = false;
                txtNumber.Enabled = true;
                btnConvert.Enabled = true;
                btnSave.Visible = false;
                MyLogger.GetInstance().Info("Exiting the btnSave_Click Method");
            }
            catch(Exception Ex)
            {
                MyLogger.GetInstance().Error("Error at " + MethodBase.GetCurrentMethod() + " with the error message " + Ex.Message);
            }
        }
        #endregion
    }
}
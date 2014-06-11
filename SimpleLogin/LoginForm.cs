using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SimpleLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.InitializeComponent();
        }

        internal bool ValidateTextBoxes()
        {
            if (this.textBoxUserName.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(this.textBoxUserName, "Please Enter User Name");
                return false;
            }
            else
            {
                this.errorProvider1.SetError(this.textBoxUserName, "");
            }
            if (this.textBoxPassword.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(this.textBoxPassword, "Please Enter the Password");
                return false;
            }
            else
            {
                // No error.
                this.errorProvider1.SetError(this.textBoxPassword, "");
            }
            return true;
        }

        internal bool ValidateUserName()
        {
            // Perform check of the UserName field here...
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateUserName() && this.ValidateTextBoxes() && this.ValidateChildren())
            {
                //SqlConnection oConn = new SqlConnection();
                //oConn.ConnectionString = "Write your Database connection string";
                //oConn.Open();
                //string strQuery = "select id from tblUser where loginName='"+ txtUserName.Text +"' and Password="+  txtPassword.Text +"";
                //object retVal;
                //SqlCommand cmd = new SqlCommand(strQuery, oConn);
                //retVal = cmd.ExecuteScalar();
                //if (retVal != null)
                //{
                //    this.DialogResult = DialogResult.OK;
                //}
                //else
                //{
                //    this.DialogResult = DialogResult.Cancel;
                //    //Authontication Failed
                //}
                // Perform login of external system here. If success return DialogResult.Ok, otherwise login failed, return DialogResult.Cancel
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Add window closing logic here...
        }
    }
}
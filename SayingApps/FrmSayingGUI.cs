using System.Windows.Forms;
using System.IO;
using System;

namespace SayingApps
{
    public partial class FrmSayingsGUI : Form
    {
        private StreamWriter fil;

        public FrmSayingsGUI()
        {
            InitializeComponent();
        }

        private void FrmSayingsGUI_Load(object sender, EventArgs e)
        {
            try
            {
                fil = new StreamWriter("saying.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                lblWarning.Text = "Invalid Directory" + exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                lblWarning.Text = exc.Message;
            }
        }

        //When button is clicked, write the characters to the text file
        private void btnStoreSaying_Click(object sender, EventArgs e)
        {
            try
            {
                fil.WriteLine(txtBoxSaying.Text);        
                txtBoxSaying.Text = "";
                txtBoxSaying.Focus();
                lblWarning.Text = "Text processed";
            }
            catch (System.IO.IOException exc)
            {
                lblWarning.Text = exc.Message;
            }
        }

        private void FrmSayingsGUI_Close(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
            }
            catch
            {
                lblWarning.Text = "File did not close properly";
            }
        }
    }
}

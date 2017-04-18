using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InputBox
{
    public partial class Form1 : Form
    {
        private static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        
        public static Form1 getInstance()
        {
            return instance;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Inputbox inputbox = new Inputbox(txtboxTitle.Text, txtboxText.Text);
            setLabelInput("awaiting input...");
        }

        public void setLabelInput(string label)
        {
            lblInput.Text = label;
        }
    }
}

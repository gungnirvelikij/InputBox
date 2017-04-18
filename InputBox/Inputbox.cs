using System;
using System.Drawing;
using System.Windows.Forms;

namespace InputBox
{
    class Inputbox : Form
    {
        
        private Button btnCancel;
        private Button btnOk;
        private Form1 form;
        private Label descriptionLabel;
        private TextBox inputTextBox;

        public Inputbox(string title, string text)
        {
            form = Form1.getInstance();

            this.Text = title;
            this.AutoSize = true;

            descriptionLabel = new Label();  // create label, set text and place
            descriptionLabel.Location = new Point(13, 13);
            descriptionLabel.Text = text;
            descriptionLabel.AutoSize = true;
            Controls.Add(descriptionLabel);

            inputTextBox = new TextBox();
            inputTextBox.Location = new Point(13, 40);
            Controls.Add(inputTextBox);

            btnOk = new Button();
            btnOk.Location = new Point(13, 67);
            btnOk.Text = "OK";
            btnOk.Click += BtnOk_Click;
            Controls.Add(btnOk);

            Button btnCancel = new Button();
            btnCancel.Location = new Point(100, 67);
            btnCancel.Text = "Cancel";
            btnCancel.Click += BtnCancel_Click;
            Controls.Add(btnCancel);

            display();
        }

        public void display()
        {
                Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs eventArgs)
        {
            form.setLabelInput(inputTextBox.Text);
            Close();
        }
    }
}

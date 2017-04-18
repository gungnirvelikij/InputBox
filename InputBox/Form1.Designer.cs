namespace InputBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtboxText = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInputDescr = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.Location = new System.Drawing.Point(113, 22);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.Size = new System.Drawing.Size(100, 20);
            this.txtboxTitle.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // txtboxText
            // 
            this.txtboxText.Location = new System.Drawing.Point(113, 61);
            this.txtboxText.Name = "txtboxText";
            this.txtboxText.Size = new System.Drawing.Size(100, 20);
            this.txtboxText.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(49, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // lblInputDescr
            // 
            this.lblInputDescr.AutoSize = true;
            this.lblInputDescr.Location = new System.Drawing.Point(49, 149);
            this.lblInputDescr.Name = "lblInputDescr";
            this.lblInputDescr.Size = new System.Drawing.Size(101, 13);
            this.lblInputDescr.TabIndex = 5;
            this.lblInputDescr.Text = "This is what we got:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(49, 64);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(60, 13);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Description";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(49, 173);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(67, 13);
            this.lblInput.TabIndex = 7;
            this.lblInput.Text = "Your input ...";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(52, 103);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(161, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "create window";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblInputDescr);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtboxText);
            this.Controls.Add(this.txtboxTitle);
            this.Name = "Form1";
            this.Text = "InputBox calling window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtboxText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInputDescr;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnCreate;
    }
}


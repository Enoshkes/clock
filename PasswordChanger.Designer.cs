namespace clock_time
{
    partial class PasswordChangerForm
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
            label1 = new Label();
            OldPasswordTextBox = new TextBox();
            NewPasswordTextBox = new TextBox();
            label2 = new Label();
            ConfirmPasswordTextBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Old Password:";
            // 
            // OldPasswordTextBox
            // 
            OldPasswordTextBox.Location = new Point(32, 71);
            OldPasswordTextBox.Name = "OldPasswordTextBox";
            OldPasswordTextBox.Size = new Size(125, 27);
            OldPasswordTextBox.TabIndex = 1;
            // 
            // NewPasswordTextBox
            // 
            NewPasswordTextBox.Location = new Point(32, 169);
            NewPasswordTextBox.Name = "NewPasswordTextBox";
            NewPasswordTextBox.Size = new Size(125, 27);
            NewPasswordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 126);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "New Password:";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(32, 266);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(125, 27);
            ConfirmPasswordTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 223);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.Location = new Point(32, 334);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnSubmit;
            // 
            // PasswordChangerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 437);
            Controls.Add(button1);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(label3);
            Controls.Add(NewPasswordTextBox);
            Controls.Add(label2);
            Controls.Add(OldPasswordTextBox);
            Controls.Add(label1);
            Name = "PasswordChangerForm";
            Text = "Shift Manager - Password Changer";
            FormClosed += OnClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox OldPasswordTextBox;
        private TextBox NewPasswordTextBox;
        private Label label2;
        private TextBox ConfirmPasswordTextBox;
        private Label label3;
        private Button button1;
    }
}
namespace clock_time
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            IdentityTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label2 = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 64);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Identity Number";
            // 
            // IdentityTextBox
            // 
            IdentityTextBox.Location = new Point(68, 105);
            IdentityTextBox.Name = "IdentityTextBox";
            IdentityTextBox.Size = new Size(125, 27);
            IdentityTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(71, 219);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(125, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 179);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter Password";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(68, 309);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(141, 36);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 410);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(IdentityTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Shift Manager - Login";
            FormClosed += OnClose;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IdentityTextBox;
        private TextBox PasswordTextBox;
        private Label label2;
        private Button LoginButton;
    }
}

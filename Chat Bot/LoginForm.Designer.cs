namespace Chat_Bot
{
    partial class LoginForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.EntryField = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.MainPanel.Controls.Add(this.ExitLabel);
            this.MainPanel.Controls.Add(this.LoginLabel);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(285, 74);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(236, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(49, 17);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "Выйти";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginLabel.Location = new System.Drawing.Point(1, 42);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(281, 44);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Введите свое имя:";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(104)))), ((int)(((byte)(14)))));
            this.panel2.Controls.Add(this.InfoLabel);
            this.panel2.Controls.Add(this.LoginButton);
            this.panel2.Controls.Add(this.EntryField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 209);
            this.panel2.TabIndex = 1;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InfoLabel.Location = new System.Drawing.Point(66, 176);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(161, 24);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "github.com/tseplyaevAF, 2020";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.FlatAppearance.BorderSize = 2;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(66, 74);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(161, 38);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Авторизоваться";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // EntryField
            // 
            this.EntryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryField.Location = new System.Drawing.Point(12, 18);
            this.EntryField.Multiline = true;
            this.EntryField.Name = "EntryField";
            this.EntryField.Size = new System.Drawing.Size(261, 31);
            this.EntryField.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 280);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox EntryField;
        private System.Windows.Forms.Label InfoLabel;
    }
}
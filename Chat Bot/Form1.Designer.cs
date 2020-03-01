namespace Chat_Bot
{
    partial class ChatForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.ChatText = new System.Windows.Forms.TextBox();
            this.QuestionText = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ClearDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatText
            // 
            this.ChatText.BackColor = System.Drawing.SystemColors.Window;
            this.ChatText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(104)))), ((int)(((byte)(14)))));
            this.ChatText.Location = new System.Drawing.Point(21, 12);
            this.ChatText.Multiline = true;
            this.ChatText.Name = "ChatText";
            this.ChatText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatText.Size = new System.Drawing.Size(381, 224);
            this.ChatText.TabIndex = 0;
            // 
            // QuestionText
            // 
            this.QuestionText.Location = new System.Drawing.Point(21, 255);
            this.QuestionText.Multiline = true;
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(258, 59);
            this.QuestionText.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SendButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SendButton.Location = new System.Drawing.Point(279, 255);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(123, 59);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Отправить (Enter)";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ClearDialogButton
            // 
            this.ClearDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.ClearDialogButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDialogButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearDialogButton.Location = new System.Drawing.Point(408, 255);
            this.ClearDialogButton.Name = "ClearDialogButton";
            this.ClearDialogButton.Size = new System.Drawing.Size(115, 31);
            this.ClearDialogButton.TabIndex = 3;
            this.ClearDialogButton.Text = "Очистить диалог";
            this.ClearDialogButton.UseVisualStyleBackColor = false;
            this.ClearDialogButton.Click += new System.EventHandler(this.ClearDialogButton_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 326);
            this.Controls.Add(this.ClearDialogButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.ChatText);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(551, 365);
            this.MinimumSize = new System.Drawing.Size(551, 365);
            this.Name = "ChatForm";
            this.Text = "Чат Бот";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatText;
        private System.Windows.Forms.TextBox QuestionText;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ClearDialogButton;
    }
}


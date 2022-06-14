namespace CourseWork1
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.NewDictionaryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deletedictionary_button = new System.Windows.Forms.Button();
            this.dictionaries_listBox = new System.Windows.Forms.ListBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome in dictionary!";
            // 
            // NewDictionaryButton
            // 
            this.NewDictionaryButton.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDictionaryButton.Location = new System.Drawing.Point(118, 338);
            this.NewDictionaryButton.Name = "NewDictionaryButton";
            this.NewDictionaryButton.Size = new System.Drawing.Size(220, 32);
            this.NewDictionaryButton.TabIndex = 1;
            this.NewDictionaryButton.Text = "create a new dictionary";
            this.NewDictionaryButton.UseVisualStyleBackColor = true;
            this.NewDictionaryButton.Click += new System.EventHandler(this.NewDictionaryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(114, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "your dictionaries:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // deletedictionary_button
            // 
            this.deletedictionary_button.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletedictionary_button.Location = new System.Drawing.Point(118, 376);
            this.deletedictionary_button.Name = "deletedictionary_button";
            this.deletedictionary_button.Size = new System.Drawing.Size(220, 35);
            this.deletedictionary_button.TabIndex = 4;
            this.deletedictionary_button.Text = "delete dictionary";
            this.deletedictionary_button.UseVisualStyleBackColor = true;
            this.deletedictionary_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dictionaries_listBox
            // 
            this.dictionaries_listBox.FormattingEnabled = true;
            this.dictionaries_listBox.ItemHeight = 16;
            this.dictionaries_listBox.Location = new System.Drawing.Point(118, 180);
            this.dictionaries_listBox.Name = "dictionaries_listBox";
            this.dictionaries_listBox.Size = new System.Drawing.Size(120, 84);
            this.dictionaries_listBox.TabIndex = 5;
            this.dictionaries_listBox.SelectedIndexChanged += new System.EventHandler(this.dictionaries_listBox_SelectedIndexChanged);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(452, 448);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(50, 23);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 508);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.dictionaries_listBox);
            this.Controls.Add(this.deletedictionary_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewDictionaryButton);
            this.Controls.Add(this.label1);
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewDictionaryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletedictionary_button;
        public System.Windows.Forms.ListBox dictionaries_listBox;
        private System.Windows.Forms.Button exit_button;
    }
}


namespace CourseWork1
{
    partial class Dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary));
            this.back_button = new System.Windows.Forms.Button();
            this.words_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewWord_button = new System.Windows.Forms.Button();
            this.DeleteWord_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(20, 17);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(62, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // words_listBox
            // 
            this.words_listBox.FormattingEnabled = true;
            this.words_listBox.ItemHeight = 16;
            this.words_listBox.Location = new System.Drawing.Point(12, 108);
            this.words_listBox.Name = "words_listBox";
            this.words_listBox.Size = new System.Drawing.Size(191, 388);
            this.words_listBox.TabIndex = 1;
            this.words_listBox.SelectedIndexChanged += new System.EventHandler(this.words_listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "your dictionary:";
            // 
            // NewWord_button
            // 
            this.NewWord_button.Location = new System.Drawing.Point(304, 473);
            this.NewWord_button.Name = "NewWord_button";
            this.NewWord_button.Size = new System.Drawing.Size(145, 23);
            this.NewWord_button.TabIndex = 3;
            this.NewWord_button.Text = "add a new word";
            this.NewWord_button.UseVisualStyleBackColor = true;
            this.NewWord_button.Click += new System.EventHandler(this.NewWord_button_Click);
            // 
            // DeleteWord_button
            // 
            this.DeleteWord_button.Location = new System.Drawing.Point(304, 444);
            this.DeleteWord_button.Name = "DeleteWord_button";
            this.DeleteWord_button.Size = new System.Drawing.Size(145, 23);
            this.DeleteWord_button.TabIndex = 4;
            this.DeleteWord_button.Text = "delete a word";
            this.DeleteWord_button.UseVisualStyleBackColor = true;
            this.DeleteWord_button.Click += new System.EventHandler(this.DeleteWord_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(479, 473);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(46, 23);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 508);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.DeleteWord_button);
            this.Controls.Add(this.NewWord_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.words_listBox);
            this.Controls.Add(this.back_button);
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Dictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ListBox words_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewWord_button;
        private System.Windows.Forms.Button DeleteWord_button;
        private System.Windows.Forms.Button exit_button;
    }
}
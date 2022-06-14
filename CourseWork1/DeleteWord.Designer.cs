namespace CourseWork1
{
    partial class DeleteWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteWord));
            this.label1 = new System.Windows.Forms.Label();
            this.words_listBox = new System.Windows.Forms.ListBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "choose a word to delete:";
            // 
            // words_listBox
            // 
            this.words_listBox.FormattingEnabled = true;
            this.words_listBox.ItemHeight = 16;
            this.words_listBox.Location = new System.Drawing.Point(42, 109);
            this.words_listBox.Name = "words_listBox";
            this.words_listBox.Size = new System.Drawing.Size(159, 388);
            this.words_listBox.TabIndex = 1;
            this.words_listBox.SelectedIndexChanged += new System.EventHandler(this.words_listBox_SelectedIndexChanged);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(207, 473);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(37, 20);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // DeleteWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 508);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.words_listBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteWord";
            this.Text = "DeleteWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox words_listBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button back_button;
    }
}
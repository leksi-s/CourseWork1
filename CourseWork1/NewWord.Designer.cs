namespace CourseWork1
{
    partial class NewWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWord));
            this.label1 = new System.Windows.Forms.Label();
            this.Word_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Translation_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewWord_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(134, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "input the word";
            // 
            // Word_textBox
            // 
            this.Word_textBox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Word_textBox.Location = new System.Drawing.Point(138, 176);
            this.Word_textBox.Name = "Word_textBox";
            this.Word_textBox.Size = new System.Drawing.Size(151, 27);
            this.Word_textBox.TabIndex = 1;
            this.Word_textBox.TextChanged += new System.EventHandler(this.Word_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(134, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "input the translation";
            // 
            // Translation_textBox
            // 
            this.Translation_textBox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Translation_textBox.Location = new System.Drawing.Point(138, 267);
            this.Translation_textBox.Name = "Translation_textBox";
            this.Translation_textBox.Size = new System.Drawing.Size(211, 27);
            this.Translation_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(126, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "to add a new word:";
            // 
            // NewWord_button
            // 
            this.NewWord_button.Location = new System.Drawing.Point(138, 313);
            this.NewWord_button.Name = "NewWord_button";
            this.NewWord_button.Size = new System.Drawing.Size(75, 23);
            this.NewWord_button.TabIndex = 5;
            this.NewWord_button.Text = "add";
            this.NewWord_button.UseVisualStyleBackColor = true;
            this.NewWord_button.Click += new System.EventHandler(this.NewWord_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(14, 20);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(58, 23);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // NewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 508);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.NewWord_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Translation_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Word_textBox);
            this.Controls.Add(this.label1);
            this.Name = "NewWord";
            this.Text = "NewWord";
            this.Load += new System.EventHandler(this.NewWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Word_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Translation_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NewWord_button;
        private System.Windows.Forms.Button back_button;
    }
}
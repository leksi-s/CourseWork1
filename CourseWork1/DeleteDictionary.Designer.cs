namespace CourseWork1
{
    partial class DeleteDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDictionary));
            this.dictionaries_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deletedictionary_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dictionaries_comboBox
            // 
            this.dictionaries_comboBox.FormattingEnabled = true;
            this.dictionaries_comboBox.Location = new System.Drawing.Point(71, 125);
            this.dictionaries_comboBox.Name = "dictionaries_comboBox";
            this.dictionaries_comboBox.Size = new System.Drawing.Size(256, 24);
            this.dictionaries_comboBox.TabIndex = 0;
            this.dictionaries_comboBox.SelectedIndexChanged += new System.EventHandler(this.dictionaries_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "select a dictionary to delete:";
            // 
            // deletedictionary_button
            // 
            this.deletedictionary_button.Location = new System.Drawing.Point(252, 191);
            this.deletedictionary_button.Name = "deletedictionary_button";
            this.deletedictionary_button.Size = new System.Drawing.Size(75, 23);
            this.deletedictionary_button.TabIndex = 2;
            this.deletedictionary_button.Text = "delete";
            this.deletedictionary_button.UseVisualStyleBackColor = true;
            this.deletedictionary_button.Click += new System.EventHandler(this.deletedictionary_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(19, 24);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // DeleteDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 508);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.deletedictionary_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dictionaries_comboBox);
            this.Name = "DeleteDictionary";
            this.Text = "DeleteDictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dictionaries_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletedictionary_button;
        private System.Windows.Forms.Button back_button;
    }
}
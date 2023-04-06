namespace quiz_system
{
    partial class questions_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Qno_label = new System.Windows.Forms.Label();
            this.question_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Qno_label
            // 
            this.Qno_label.AutoEllipsis = true;
            this.Qno_label.AutoSize = true;
            this.Qno_label.BackColor = System.Drawing.Color.Transparent;
            this.Qno_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qno_label.ForeColor = System.Drawing.Color.Silver;
            this.Qno_label.Location = new System.Drawing.Point(3, 10);
            this.Qno_label.Name = "Qno_label";
            this.Qno_label.Size = new System.Drawing.Size(22, 19);
            this.Qno_label.TabIndex = 21;
            this.Qno_label.Text = "1.";
            // 
            // question_label
            // 
            this.question_label.AutoEllipsis = true;
            this.question_label.AutoSize = true;
            this.question_label.BackColor = System.Drawing.Color.Transparent;
            this.question_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_label.ForeColor = System.Drawing.Color.Silver;
            this.question_label.Location = new System.Drawing.Point(25, 10);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(59, 17);
            this.question_label.TabIndex = 22;
            this.question_label.Text = "question";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(420, 54);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // questions_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.Qno_label);
            this.Enabled = false;
            this.Name = "questions_control";
            this.Size = new System.Drawing.Size(451, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Qno_label;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

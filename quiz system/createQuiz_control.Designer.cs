namespace quiz_system
{
    partial class createQuiz_control
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
            this.label13 = new System.Windows.Forms.Label();
            this.Sno_label = new System.Windows.Forms.Label();
            this.question_textbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(34, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "QUESTION:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sno_label
            // 
            this.Sno_label.BackColor = System.Drawing.Color.Transparent;
            this.Sno_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sno_label.ForeColor = System.Drawing.Color.Silver;
            this.Sno_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sno_label.Location = new System.Drawing.Point(-1, 14);
            this.Sno_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sno_label.Name = "Sno_label";
            this.Sno_label.Size = new System.Drawing.Size(27, 25);
            this.Sno_label.TabIndex = 26;
            this.Sno_label.Text = "1.";
            this.Sno_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // question_textbox
            // 
            this.question_textbox.Location = new System.Drawing.Point(37, 41);
            this.question_textbox.MaxLength = 5000;
            this.question_textbox.Name = "question_textbox";
            this.question_textbox.Size = new System.Drawing.Size(700, 40);
            this.question_textbox.TabIndex = 27;
            this.question_textbox.Text = "";
            // 
            // createQuiz_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.question_textbox);
            this.Controls.Add(this.Sno_label);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "createQuiz_control";
            this.Size = new System.Drawing.Size(745, 95);
            this.Load += new System.EventHandler(this.createQuiz_control_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Sno_label;
        public System.Windows.Forms.RichTextBox question_textbox;
    }
}

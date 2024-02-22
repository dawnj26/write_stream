namespace grabe_naman_yung_seatwork_andami
{
    partial class Form1
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
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richOutput
            // 
            this.richOutput.Location = new System.Drawing.Point(12, 12);
            this.richOutput.Name = "richOutput";
            this.richOutput.ReadOnly = true;
            this.richOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richOutput.Size = new System.Drawing.Size(699, 489);
            this.richOutput.TabIndex = 0;
            this.richOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 513);
            this.Controls.Add(this.richOutput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richOutput;
    }
}


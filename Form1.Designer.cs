namespace Hw2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShow = new Button();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Location = new Point(43, 382);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 31);
            btnShow.TabIndex = 0;
            btnShow.Text = "แสดงผล";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Name = "Form1";
            Text = "Form1";
            Load += btnShow_Click;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnShow;
    }
}

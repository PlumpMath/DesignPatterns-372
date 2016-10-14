namespace Bai4_Observer_Singleton
{
    partial class Form_Sub2
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
            this.btn_form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_form2
            // 
            this.btn_form2.Location = new System.Drawing.Point(47, 47);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(165, 35);
            this.btn_form2.TabIndex = 1;
            this.btn_form2.Text = "button1";
            this.btn_form2.UseVisualStyleBackColor = true;
            // 
            // Form_Sub2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.btn_form2);
            this.Name = "Form_Sub2";
            this.Text = "Form_Sub2";
            this.Load += new System.EventHandler(this.Form_Sub2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_form2;
    }
}
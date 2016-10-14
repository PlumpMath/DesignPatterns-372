namespace Bai4_Observer_Singleton
{
    partial class Form_Sub1
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
            this.btn_form1 = new System.Windows.Forms.Button();
            this.btn_detach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_form1
            // 
            this.btn_form1.Location = new System.Drawing.Point(68, 60);
            this.btn_form1.Name = "btn_form1";
            this.btn_form1.Size = new System.Drawing.Size(165, 35);
            this.btn_form1.TabIndex = 0;
            this.btn_form1.Text = "button1";
            this.btn_form1.UseVisualStyleBackColor = true;
            // 
            // btn_detach
            // 
            this.btn_detach.Location = new System.Drawing.Point(68, 112);
            this.btn_detach.Name = "btn_detach";
            this.btn_detach.Size = new System.Drawing.Size(165, 35);
            this.btn_detach.TabIndex = 1;
            this.btn_detach.Text = "Detach from Subject";
            this.btn_detach.UseVisualStyleBackColor = true;
            this.btn_detach.Click += new System.EventHandler(this.btn_detach_Click);
            // 
            // Form_Sub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.btn_detach);
            this.Controls.Add(this.btn_form1);
            this.Name = "Form_Sub1";
            this.Text = "Form_Sub1";
            this.Load += new System.EventHandler(this.Form_Sub1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_form1;
        private System.Windows.Forms.Button btn_detach;
    }
}
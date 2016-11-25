namespace Bai8_Iterator
{
    partial class IteratorApp
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
            this.btnNext = new System.Windows.Forms.Button();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_isLastItem = new System.Windows.Forms.Label();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbCountItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNext.Location = new System.Drawing.Point(315, 74);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txt_Item
            // 
            this.txt_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Item.Location = new System.Drawing.Point(202, 74);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(100, 23);
            this.txt_Item.TabIndex = 1;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFirst.Location = new System.Drawing.Point(36, 74);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(199, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tip:";
            // 
            // lb_isLastItem
            // 
            this.lb_isLastItem.AutoSize = true;
            this.lb_isLastItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_isLastItem.ForeColor = System.Drawing.Color.Red;
            this.lb_isLastItem.Location = new System.Drawing.Point(237, 112);
            this.lb_isLastItem.Name = "lb_isLastItem";
            this.lb_isLastItem.Size = new System.Drawing.Size(138, 17);
            this.lb_isLastItem.TabIndex = 4;
            this.lb_isLastItem.Text = "This is a normal item";
            // 
            // btn_Prev
            // 
            this.btn_Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Prev.Location = new System.Drawing.Point(117, 74);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(75, 23);
            this.btn_Prev.TabIndex = 5;
            this.btn_Prev.Text = "< Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(396, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Last >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbCountItem
            // 
            this.lbCountItem.AutoSize = true;
            this.lbCountItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCountItem.Location = new System.Drawing.Point(237, 129);
            this.lbCountItem.Name = "lbCountItem";
            this.lbCountItem.Size = new System.Drawing.Size(139, 17);
            this.lbCountItem.TabIndex = 7;
            this.lbCountItem.Text = "The list have 11 item";
            // 
            // IteratorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 220);
            this.Controls.Add(this.lbCountItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.lb_isLastItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txt_Item);
            this.Controls.Add(this.btnNext);
            this.Name = "IteratorApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IteratorApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_isLastItem;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbCountItem;
    }
}


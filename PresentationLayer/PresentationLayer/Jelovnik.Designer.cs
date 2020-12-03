
namespace PresentationLayer
{
    partial class Jelovnik
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxMenuItems = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxMinMax = new System.Windows.Forms.ListBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelMIN = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonMinMax = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // listBoxMenuItems
            // 
            this.listBoxMenuItems.FormattingEnabled = true;
            this.listBoxMenuItems.Location = new System.Drawing.Point(324, 12);
            this.listBoxMenuItems.Name = "listBoxMenuItems";
            this.listBoxMenuItems.Size = new System.Drawing.Size(412, 121);
            this.listBoxMenuItems.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(29, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(29, 116);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(29, 73);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description:";
            // 
            // listBoxMinMax
            // 
            this.listBoxMinMax.FormattingEnabled = true;
            this.listBoxMinMax.Location = new System.Drawing.Point(95, 207);
            this.listBoxMinMax.Name = "listBoxMinMax";
            this.listBoxMinMax.Size = new System.Drawing.Size(254, 95);
            this.listBoxMinMax.TabIndex = 7;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(441, 207);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 8;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(441, 254);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 9;
            // 
            // labelMIN
            // 
            this.labelMIN.AutoSize = true;
            this.labelMIN.Location = new System.Drawing.Point(400, 210);
            this.labelMIN.Name = "labelMIN";
            this.labelMIN.Size = new System.Drawing.Size(30, 13);
            this.labelMIN.TabIndex = 10;
            this.labelMIN.Text = "MIN:";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(400, 257);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(33, 13);
            this.labelMax.TabIndex = 11;
            this.labelMax.Text = "MAX:";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(116, 158);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(125, 23);
            this.buttonInsert.TabIndex = 12;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonMinMax
            // 
            this.buttonMinMax.Location = new System.Drawing.Point(602, 219);
            this.buttonMinMax.Name = "buttonMinMax";
            this.buttonMinMax.Size = new System.Drawing.Size(117, 35);
            this.buttonMinMax.TabIndex = 13;
            this.buttonMinMax.Text = "MIN-MAX";
            this.buttonMinMax.UseVisualStyleBackColor = true;
            this.buttonMinMax.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // Jelovnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonMinMax);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMIN);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.listBoxMinMax);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBoxMenuItems);
            this.Controls.Add(this.textBox1);
            this.Name = "Jelovnik";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxMenuItems;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ListBox listBoxMinMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelMIN;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonMinMax;
        private System.Windows.Forms.TextBox textBox4;
    }
}


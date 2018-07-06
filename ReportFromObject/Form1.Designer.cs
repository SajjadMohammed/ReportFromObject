namespace ReportFromObject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.dobText = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.PrintButton);
            this.groupBox1.Controls.Add(this.dobText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addressText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(541, 294);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الطالب";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(428, 255);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 30);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "اضف";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(244, 252);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(100, 34);
            this.PrintButton.TabIndex = 13;
            this.PrintButton.Text = "اطبع";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // dobText
            // 
            this.dobText.Location = new System.Drawing.Point(287, 140);
            this.dobText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dobText.Mask = "00/00/0000";
            this.dobText.Name = "dobText";
            this.dobText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dobText.Size = new System.Drawing.Size(157, 31);
            this.dobText.TabIndex = 5;
            this.dobText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dobText.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "العنوان:";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(208, 192);
            this.addressText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(236, 31);
            this.addressText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ت الولادة:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرقم:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم:";
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(291, 35);
            this.idText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(153, 31);
            this.idText.TabIndex = 3;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(208, 88);
            this.nameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(236, 31);
            this.nameText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 326);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معلومات الطلبة";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox dobText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button AddButton;
    }
}


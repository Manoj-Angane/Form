namespace Lab_2_1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.carpetareaLabel = new System.Windows.Forms.Label();
            this.carpetchargeLabel = new System.Windows.Forms.Label();
            this.salestaxLabel = new System.Windows.Forms.Label();
            this.laborchargeLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(93, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(182, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Carpet Calculator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(22, 104);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(104, 13);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Carpet Length (feet):";
            this.lengthLabel.Click += new System.EventHandler(this.lengthLabel_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(144, 104);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(99, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Carpet Width (feet):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(262, 104);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(108, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Carpet Price ($/ sq.ft)";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(41, 149);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(61, 20);
            this.lengthTextBox.TabIndex = 4;
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(160, 149);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(59, 20);
            this.widthTextBox.TabIndex = 5;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.widthTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(277, 149);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(66, 20);
            this.heightTextBox.TabIndex = 6;
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // carpetareaLabel
            // 
            this.carpetareaLabel.AutoSize = true;
            this.carpetareaLabel.Location = new System.Drawing.Point(70, 215);
            this.carpetareaLabel.Name = "carpetareaLabel";
            this.carpetareaLabel.Size = new System.Drawing.Size(98, 13);
            this.carpetareaLabel.TabIndex = 7;
            this.carpetareaLabel.Text = "Carpet Area (sq. ft):";
            // 
            // carpetchargeLabel
            // 
            this.carpetchargeLabel.AutoSize = true;
            this.carpetchargeLabel.Location = new System.Drawing.Point(90, 254);
            this.carpetchargeLabel.Name = "carpetchargeLabel";
            this.carpetchargeLabel.Size = new System.Drawing.Size(81, 13);
            this.carpetchargeLabel.TabIndex = 8;
            this.carpetchargeLabel.Text = "Carpet Charge: ";
            // 
            // salestaxLabel
            // 
            this.salestaxLabel.AutoSize = true;
            this.salestaxLabel.Location = new System.Drawing.Point(38, 294);
            this.salestaxLabel.Name = "salestaxLabel";
            this.salestaxLabel.Size = new System.Drawing.Size(130, 13);
            this.salestaxLabel.TabIndex = 9;
            this.salestaxLabel.Text = "Sales Tax (7.0) on Carpet:";
            // 
            // laborchargeLabel
            // 
            this.laborchargeLabel.AutoSize = true;
            this.laborchargeLabel.Location = new System.Drawing.Point(32, 333);
            this.laborchargeLabel.Name = "laborchargeLabel";
            this.laborchargeLabel.Size = new System.Drawing.Size(135, 13);
            this.laborchargeLabel.TabIndex = 10;
            this.laborchargeLabel.Text = "Labor Charge ($0.50/sq.ft);";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(80, 379);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(87, 13);
            this.orderLabel.TabIndex = 11;
            this.orderLabel.Text = "ORDER TOTAL:";
            this.orderLabel.Click += new System.EventHandler(this.orderLabel_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaLabel.Location = new System.Drawing.Point(217, 215);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(2, 15);
            this.areaLabel.TabIndex = 12;
            this.areaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 446);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.laborchargeLabel);
            this.Controls.Add(this.salestaxLabel);
            this.Controls.Add(this.carpetchargeLabel);
            this.Controls.Add(this.carpetareaLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carpet Kindgdom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label carpetareaLabel;
        private System.Windows.Forms.Label carpetchargeLabel;
        private System.Windows.Forms.Label salestaxLabel;
        private System.Windows.Forms.Label laborchargeLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


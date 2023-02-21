namespace Oil
{
    partial class OilView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oilCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moneyRBtn = new System.Windows.Forms.RadioButton();
            this.literRBtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.literLbl = new System.Windows.Forms.Label();
            this.literTxtb = new System.Windows.Forms.TextBox();
            this.moneyTxtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oil Station";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oil";
            // 
            // oilCombobox
            // 
            this.oilCombobox.FormattingEnabled = true;
            this.oilCombobox.Location = new System.Drawing.Point(135, 150);
            this.oilCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oilCombobox.Name = "oilCombobox";
            this.oilCombobox.Size = new System.Drawing.Size(105, 24);
            this.oilCombobox.TabIndex = 3;
            this.oilCombobox.SelectedIndexChanged += new System.EventHandler(this.oilCombobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(336, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "With Money";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(307, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total :";
            // 
            // moneyRBtn
            // 
            this.moneyRBtn.AutoSize = true;
            this.moneyRBtn.Location = new System.Drawing.Point(491, 154);
            this.moneyRBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moneyRBtn.Name = "moneyRBtn";
            this.moneyRBtn.Size = new System.Drawing.Size(17, 16);
            this.moneyRBtn.TabIndex = 5;
            this.moneyRBtn.TabStop = true;
            this.moneyRBtn.UseVisualStyleBackColor = true;
            this.moneyRBtn.CheckedChanged += new System.EventHandler(this.moneyRBtn_CheckedChanged);
            // 
            // literRBtn
            // 
            this.literRBtn.AutoSize = true;
            this.literRBtn.Location = new System.Drawing.Point(491, 202);
            this.literRBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.literRBtn.Name = "literRBtn";
            this.literRBtn.Size = new System.Drawing.Size(17, 16);
            this.literRBtn.TabIndex = 5;
            this.literRBtn.TabStop = true;
            this.literRBtn.UseVisualStyleBackColor = true;
            this.literRBtn.CheckedChanged += new System.EventHandler(this.literRBtn_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(46, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get Payment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.Location = new System.Drawing.Point(431, 365);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(0, 32);
            this.amountLbl.TabIndex = 7;
            // 
            // priceLbl
            // 
            this.priceLbl.BackColor = System.Drawing.Color.White;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(134, 195);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(106, 23);
            this.priceLbl.TabIndex = 8;
            this.priceLbl.TextChanged += new System.EventHandler(this.priceLbl_TextChanged);
            // 
            // literLbl
            // 
            this.literLbl.AutoSize = true;
            this.literLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.literLbl.Location = new System.Drawing.Point(336, 193);
            this.literLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.literLbl.Name = "literLbl";
            this.literLbl.Size = new System.Drawing.Size(104, 25);
            this.literLbl.TabIndex = 4;
            this.literLbl.Text = "With Liter";
            // 
            // literTxtb
            // 
            this.literTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literTxtb.Location = new System.Drawing.Point(537, 195);
            this.literTxtb.Name = "literTxtb";
            this.literTxtb.Size = new System.Drawing.Size(100, 30);
            this.literTxtb.TabIndex = 9;
            this.literTxtb.TextChanged += new System.EventHandler(this.literTxtb_TextChanged);
            // 
            // moneyTxtb
            // 
            this.moneyTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyTxtb.Location = new System.Drawing.Point(537, 148);
            this.moneyTxtb.Name = "moneyTxtb";
            this.moneyTxtb.Size = new System.Drawing.Size(100, 30);
            this.moneyTxtb.TabIndex = 9;
            this.moneyTxtb.TextChanged += new System.EventHandler(this.moneyTxtb_TextChanged);
            // 
            // OilView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 511);
            this.Controls.Add(this.moneyTxtb);
            this.Controls.Add(this.literTxtb);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.literRBtn);
            this.Controls.Add(this.moneyRBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.literLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oilCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OilView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox oilCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton moneyRBtn;
        private System.Windows.Forms.RadioButton literRBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label literLbl;
        private System.Windows.Forms.TextBox literTxtb;
        private System.Windows.Forms.TextBox moneyTxtb;
    }
}


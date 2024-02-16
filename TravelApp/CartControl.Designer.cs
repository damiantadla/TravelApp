namespace TravelApp
{
    partial class CartControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonShowPay = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.panelPay = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonExitPay = new System.Windows.Forms.Button();
            this.flowLayoutPanelTravels = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxBlik = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSumPay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(646, 360);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pictureBox1.Location = new System.Drawing.Point(29, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 5);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonShowPay
            // 
            this.buttonShowPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowPay.Location = new System.Drawing.Point(486, 384);
            this.buttonShowPay.Name = "buttonShowPay";
            this.buttonShowPay.Size = new System.Drawing.Size(130, 50);
            this.buttonShowPay.TabIndex = 2;
            this.buttonShowPay.Text = "Zapłać";
            this.buttonShowPay.UseVisualStyleBackColor = true;
            this.buttonShowPay.Click += new System.EventHandler(this.buttonShowPay_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(29, 390);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 38);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSum.Location = new System.Drawing.Point(276, 394);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(165, 29);
            this.labelSum.TabIndex = 4;
            this.labelSum.Text = "Suma: 2000 zł";
            // 
            // panelPay
            // 
            this.panelPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPay.Controls.Add(this.label5);
            this.panelPay.Controls.Add(this.label4);
            this.panelPay.Controls.Add(this.label2);
            this.panelPay.Controls.Add(this.textBoxName);
            this.panelPay.Controls.Add(this.textBoxSurname);
            this.panelPay.Controls.Add(this.textBoxPhoneNumber);
            this.panelPay.Controls.Add(this.labelSuccess);
            this.panelPay.Controls.Add(this.labelError);
            this.panelPay.Controls.Add(this.buttonExitPay);
            this.panelPay.Controls.Add(this.flowLayoutPanelTravels);
            this.panelPay.Controls.Add(this.textBoxBlik);
            this.panelPay.Controls.Add(this.buttonPay);
            this.panelPay.Controls.Add(this.label3);
            this.panelPay.Controls.Add(this.labelSumPay);
            this.panelPay.Controls.Add(this.label1);
            this.panelPay.Location = new System.Drawing.Point(151, 23);
            this.panelPay.Name = "panelPay";
            this.panelPay.Size = new System.Drawing.Size(344, 419);
            this.panelPay.TabIndex = 5;
            this.panelPay.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(62, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(62, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(62, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Imie";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(144, 191);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(144, 217);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 10;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(144, 243);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 9;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelSuccess.Location = new System.Drawing.Point(49, 110);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(257, 31);
            this.labelSuccess.TabIndex = 8;
            this.labelSuccess.Text = "Płatność wykonana!";
            this.labelSuccess.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelError.Location = new System.Drawing.Point(100, 331);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(139, 17);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "Problem z płatnością";
            this.labelError.Visible = false;
            // 
            // buttonExitPay
            // 
            this.buttonExitPay.BackgroundImage = global::TravelApp.Properties.Resources.cross;
            this.buttonExitPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExitPay.FlatAppearance.BorderSize = 0;
            this.buttonExitPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitPay.Location = new System.Drawing.Point(297, 15);
            this.buttonExitPay.Name = "buttonExitPay";
            this.buttonExitPay.Size = new System.Drawing.Size(32, 33);
            this.buttonExitPay.TabIndex = 6;
            this.buttonExitPay.UseVisualStyleBackColor = true;
            this.buttonExitPay.Click += new System.EventHandler(this.buttonExitPay_Click);
            // 
            // flowLayoutPanelTravels
            // 
            this.flowLayoutPanelTravels.Location = new System.Drawing.Point(74, 83);
            this.flowLayoutPanelTravels.Name = "flowLayoutPanelTravels";
            this.flowLayoutPanelTravels.Size = new System.Drawing.Size(191, 94);
            this.flowLayoutPanelTravels.TabIndex = 5;
            // 
            // textBoxBlik
            // 
            this.textBoxBlik.Location = new System.Drawing.Point(144, 269);
            this.textBoxBlik.Name = "textBoxBlik";
            this.textBoxBlik.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlik.TabIndex = 4;
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(105, 361);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(134, 38);
            this.buttonPay.TabIndex = 3;
            this.buttonPay.Text = "Zaplać";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(62, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kod blik";
            // 
            // labelSumPay
            // 
            this.labelSumPay.AutoSize = true;
            this.labelSumPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSumPay.Location = new System.Drawing.Point(90, 298);
            this.labelSumPay.Name = "labelSumPay";
            this.labelSumPay.Size = new System.Drawing.Size(70, 26);
            this.labelSumPay.TabIndex = 1;
            this.labelSumPay.Text = "Suma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(98, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Płatność";
            // 
            // CartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPay);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonShowPay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CartControl";
            this.Size = new System.Drawing.Size(646, 460);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPay.ResumeLayout(false);
            this.panelPay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonShowPay;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Panel panelPay;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSumPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTravels;
        private System.Windows.Forms.TextBox textBoxBlik;
        private System.Windows.Forms.Button buttonExitPay;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

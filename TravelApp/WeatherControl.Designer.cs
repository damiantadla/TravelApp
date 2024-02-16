namespace TravelApp
{
    partial class WeatherControl
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
            this.components = new System.ComponentModel.Container();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelCity = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTempMin = new System.Windows.Forms.Label();
            this.lebelTempMax = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(418, 89);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(140, 92);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(247, 20);
            this.textBoxCity.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCity.Location = new System.Drawing.Point(130, 32);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(152, 37);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "Rzeszow";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelTempMin);
            this.panel2.Controls.Add(this.lebelTempMax);
            this.panel2.Controls.Add(this.labelTemp);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Controls.Add(this.labelData);
            this.panel2.Controls.Add(this.panelLogo);
            this.panel2.Controls.Add(this.labelCity);
            this.panel2.Location = new System.Drawing.Point(42, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 241);
            this.panel2.TabIndex = 9;
            // 
            // labelTempMin
            // 
            this.labelTempMin.AutoSize = true;
            this.labelTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTempMin.Location = new System.Drawing.Point(243, 149);
            this.labelTempMin.Name = "labelTempMin";
            this.labelTempMin.Size = new System.Drawing.Size(101, 17);
            this.labelTempMin.TabIndex = 11;
            this.labelTempMin.Text = "Temperatura";
            // 
            // lebelTempMax
            // 
            this.lebelTempMax.AutoSize = true;
            this.lebelTempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lebelTempMax.Location = new System.Drawing.Point(243, 109);
            this.lebelTempMax.Name = "lebelTempMax";
            this.lebelTempMax.Size = new System.Drawing.Size(101, 17);
            this.lebelTempMax.TabIndex = 10;
            this.lebelTempMax.Text = "Temperatura";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemp.Location = new System.Drawing.Point(49, 149);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(101, 17);
            this.labelTemp.TabIndex = 9;
            this.labelTemp.Text = "Temperatura";
            // 
            // labelDescription
            // 
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(0, 208);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(563, 19);
            this.labelDescription.TabIndex = 11;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelData.Location = new System.Drawing.Point(49, 109);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(42, 17);
            this.labelData.TabIndex = 8;
            this.labelData.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(224, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prognoza pogody";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // panelLogo
            // 
            this.panelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogo.BackgroundImage = global::TravelApp.Properties.Resources.partly_cloudy_day;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogo.Location = new System.Drawing.Point(401, 22);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(64, 62);
            this.panelLogo.TabIndex = 6;
            // 
            // WeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.buttonSearch);
            this.Name = "WeatherControl";
            this.Size = new System.Drawing.Size(646, 466);
            this.Load += new System.EventHandler(this.WeatherControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTempMin;
        private System.Windows.Forms.Label lebelTempMax;
        private System.Windows.Forms.TextBox labelDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
    }
}

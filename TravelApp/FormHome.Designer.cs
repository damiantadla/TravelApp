namespace TravelApp
{
    partial class FormHome
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnWeather = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnTravels = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.LabelMain = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.homeControl = new TravelApp.HomeControl();
            this.weatherControl = new TravelApp.WeatherControl();
            this.travelsControl = new TravelApp.TravelsControl();
            this.contactControl = new TravelApp.ContactControl();
            this.cartControl = new TravelApp.CartControl();
            this.loginControl1 = new TravelApp.LoginControl();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.btnContact);
            this.panelMenu.Controls.Add(this.btnWeather);
            this.panelMenu.Controls.Add(this.btnCart);
            this.panelMenu.Controls.Add(this.btnTravels);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 556);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Image = global::TravelApp.Properties.Resources.login;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 506);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(200, 50);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "  Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnContact
            // 
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnContact.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContact.Image = global::TravelApp.Properties.Resources.book_2_svgrepo_com;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(0, 280);
            this.btnContact.Name = "btnContact";
            this.btnContact.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnContact.Size = new System.Drawing.Size(200, 50);
            this.btnContact.TabIndex = 5;
            this.btnContact.Text = "  Contact";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnWeather
            // 
            this.btnWeather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeather.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeather.FlatAppearance.BorderSize = 0;
            this.btnWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWeather.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWeather.Image = global::TravelApp.Properties.Resources.cloud_sun_2_svgrepo_com;
            this.btnWeather.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeather.Location = new System.Drawing.Point(0, 230);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnWeather.Size = new System.Drawing.Size(200, 50);
            this.btnWeather.TabIndex = 4;
            this.btnWeather.Text = "  Weather";
            this.btnWeather.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeather.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCart.Image = global::TravelApp.Properties.Resources.cart;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 180);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCart.Size = new System.Drawing.Size(200, 50);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "  Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnTravels
            // 
            this.btnTravels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravels.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTravels.FlatAppearance.BorderSize = 0;
            this.btnTravels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTravels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTravels.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTravels.Image = global::TravelApp.Properties.Resources.point_on_map_svgrepo_com;
            this.btnTravels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTravels.Location = new System.Drawing.Point(0, 130);
            this.btnTravels.Name = "btnTravels";
            this.btnTravels.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTravels.Size = new System.Drawing.Size(200, 50);
            this.btnTravels.TabIndex = 2;
            this.btnTravels.Text = "  Travels";
            this.btnTravels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTravels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTravels.UseVisualStyleBackColor = true;
            this.btnTravels.Click += new System.EventHandler(this.btnTravels_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Image = global::TravelApp.Properties.Resources.home_com;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 80);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.BackgroundImage = global::TravelApp.Properties.Resources.logo_travelapp;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitle.Controls.Add(this.LabelMain);
            this.panelTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(664, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelMain.Location = new System.Drawing.Point(276, 22);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(102, 37);
            this.LabelMain.TabIndex = 2;
            this.LabelMain.Text = "Home";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // homeControl
            // 
            this.homeControl.Location = new System.Drawing.Point(200, 80);
            this.homeControl.Name = "homeControl";
            this.homeControl.Size = new System.Drawing.Size(664, 472);
            this.homeControl.TabIndex = 101;
            // 
            // weatherControl
            // 
            this.weatherControl.Location = new System.Drawing.Point(203, 83);
            this.weatherControl.Name = "weatherControl";
            this.weatherControl.Size = new System.Drawing.Size(661, 473);
            this.weatherControl.TabIndex = 102;
            // 
            // travelsControl
            // 
            this.travelsControl.Location = new System.Drawing.Point(206, 83);
            this.travelsControl.Name = "travelsControl";
            this.travelsControl.Size = new System.Drawing.Size(658, 469);
            this.travelsControl.TabIndex = 103;
            // 
            // contactControl
            // 
            this.contactControl.BackColor = System.Drawing.Color.White;
            this.contactControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactControl.BackgroundImage")));
            this.contactControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contactControl.Location = new System.Drawing.Point(206, 86);
            this.contactControl.Name = "contactControl";
            this.contactControl.Size = new System.Drawing.Size(646, 466);
            this.contactControl.TabIndex = 4;
            this.contactControl.Visible = false;

            // 
            // cartControl
            // 
            this.cartControl.Location = new System.Drawing.Point(206, 91);
            this.cartControl.Name = "cartControl";
            this.cartControl.Size = new System.Drawing.Size(626, 447);
            this.cartControl.TabIndex = 99;

            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.Transparent;
            this.loginControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginControl1.Location = new System.Drawing.Point(200, 81);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(664, 475);
            this.loginControl1.TabIndex = 104;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 556);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.weatherControl);
            this.Controls.Add(this.travelsControl);
            this.Controls.Add(this.contactControl);
            this.Controls.Add(this.cartControl);
            this.Controls.Add(this.loginControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = "TravelApp";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }
         
        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnTravels;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Label LabelMain;
        private ContactControl contactControl;
        private HomeControl homeControl;
        private CartControl cartControl;
        private WeatherControl weatherControl;
        private TravelsControl travelsControl;
        private LoginControl loginControl1;
    }
}


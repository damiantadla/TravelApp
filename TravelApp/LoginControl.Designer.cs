namespace TravelApp
{
    partial class LoginControl
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddUserExit = new System.Windows.Forms.Button();
            this.buttonAddNewTravel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRemoveClient = new System.Windows.Forms.Button();
            this.buttonRemoveTravel = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSaveTravels = new System.Windows.Forms.Button();
            this.buttonSaveClients = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.labelLogin.Location = new System.Drawing.Point(112, 57);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(96, 37);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(44, 143);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(265, 26);
            this.textBoxLogin.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(44, 208);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(265, 26);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.Location = new System.Drawing.Point(121, 303);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 54);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelError.Location = new System.Drawing.Point(119, 261);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 20);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Error";
            this.labelError.Visible = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.labelError);
            this.panelLogin.Controls.Add(this.textBoxLogin);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Location = new System.Drawing.Point(269, 73);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(357, 385);
            this.panelLogin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(133, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(156, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login";
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.Color.White;
            this.panelEmployee.Controls.Add(this.buttonRefresh);
            this.panelEmployee.Controls.Add(this.panelAddUser);
            this.panelEmployee.Controls.Add(this.listBox2);
            this.panelEmployee.Controls.Add(this.listBox1);
            this.panelEmployee.Controls.Add(this.buttonRemoveClient);
            this.panelEmployee.Controls.Add(this.buttonRemoveTravel);
            this.panelEmployee.Controls.Add(this.buttonAddUser);
            this.panelEmployee.Controls.Add(this.label5);
            this.panelEmployee.Controls.Add(this.label4);
            this.panelEmployee.Controls.Add(this.button4);
            this.panelEmployee.Controls.Add(this.buttonSaveTravels);
            this.panelEmployee.Controls.Add(this.buttonSaveClients);
            this.panelEmployee.Controls.Add(this.buttonLogout);
            this.panelEmployee.Controls.Add(this.panel1);
            this.panelEmployee.Controls.Add(this.labelWelcome);
            this.panelEmployee.Location = new System.Drawing.Point(-1, -1);
            this.panelEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(888, 583);
            this.panelEmployee.TabIndex = 3;
            this.panelEmployee.Visible = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(675, 485);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(177, 68);
            this.buttonRefresh.TabIndex = 19;
            this.buttonRefresh.Text = "Odśwież ";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panelAddUser
            // 
            this.panelAddUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAddUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddUser.Controls.Add(this.label8);
            this.panelAddUser.Controls.Add(this.buttonAddUserExit);
            this.panelAddUser.Controls.Add(this.buttonAddNewTravel);
            this.panelAddUser.Controls.Add(this.label7);
            this.panelAddUser.Controls.Add(this.label6);
            this.panelAddUser.Controls.Add(this.label1);
            this.panelAddUser.Controls.Add(this.textBoxCountry);
            this.panelAddUser.Controls.Add(this.dateTimePicker1);
            this.panelAddUser.Controls.Add(this.textBoxPrice);
            this.panelAddUser.Controls.Add(this.textBoxRegion);
            this.panelAddUser.Location = new System.Drawing.Point(243, 62);
            this.panelAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(385, 411);
            this.panelAddUser.TabIndex = 17;
            this.panelAddUser.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(4, 313);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // buttonAddUserExit
            // 
            this.buttonAddUserExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddUserExit.BackgroundImage = global::TravelApp.Properties.Resources.cross;
            this.buttonAddUserExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddUserExit.FlatAppearance.BorderSize = 0;
            this.buttonAddUserExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUserExit.Location = new System.Drawing.Point(315, 14);
            this.buttonAddUserExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddUserExit.Name = "buttonAddUserExit";
            this.buttonAddUserExit.Size = new System.Drawing.Size(51, 50);
            this.buttonAddUserExit.TabIndex = 9;
            this.buttonAddUserExit.UseVisualStyleBackColor = false;
            this.buttonAddUserExit.Click += new System.EventHandler(this.buttonAddUserExit_Click);
            // 
            // buttonAddNewTravel
            // 
            this.buttonAddNewTravel.Location = new System.Drawing.Point(97, 338);
            this.buttonAddNewTravel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddNewTravel.Name = "buttonAddNewTravel";
            this.buttonAddNewTravel.Size = new System.Drawing.Size(195, 53);
            this.buttonAddNewTravel.TabIndex = 8;
            this.buttonAddNewTravel.Text = "Dodaj podróż";
            this.buttonAddNewTravel.UseVisualStyleBackColor = true;
            this.buttonAddNewTravel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(160, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(149, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(160, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kraj";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(109, 86);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(168, 22);
            this.textBoxCountry.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 276);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(109, 225);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(168, 22);
            this.textBoxPrice.TabIndex = 1;
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(109, 154);
            this.textBoxRegion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(168, 22);
            this.textBoxRegion.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(53, 321);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(620, 132);
            this.listBox2.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(53, 132);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(620, 132);
            this.listBox1.TabIndex = 15;
            // 
            // buttonRemoveClient
            // 
            this.buttonRemoveClient.Location = new System.Drawing.Point(717, 359);
            this.buttonRemoveClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveClient.Name = "buttonRemoveClient";
            this.buttonRemoveClient.Size = new System.Drawing.Size(135, 48);
            this.buttonRemoveClient.TabIndex = 13;
            this.buttonRemoveClient.Text = "Usuń";
            this.buttonRemoveClient.UseVisualStyleBackColor = true;
            this.buttonRemoveClient.Click += new System.EventHandler(this.buttonRemoveClient_Click);
            // 
            // buttonRemoveTravel
            // 
            this.buttonRemoveTravel.Location = new System.Drawing.Point(717, 201);
            this.buttonRemoveTravel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveTravel.Name = "buttonRemoveTravel";
            this.buttonRemoveTravel.Size = new System.Drawing.Size(135, 48);
            this.buttonRemoveTravel.TabIndex = 11;
            this.buttonRemoveTravel.Text = "Usuń";
            this.buttonRemoveTravel.UseVisualStyleBackColor = true;
            this.buttonRemoveTravel.Click += new System.EventHandler(this.buttonRemoveTravel_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(717, 137);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(135, 48);
            this.buttonAddUser.TabIndex = 10;
            this.buttonAddUser.Text = "Dodaj";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(45, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Klienci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(45, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Podróże";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(460, 485);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 68);
            this.button4.TabIndex = 7;
            this.button4.Text = "Dodaj podróże";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonSaveTravels
            // 
            this.buttonSaveTravels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveTravels.Location = new System.Drawing.Point(243, 485);
            this.buttonSaveTravels.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveTravels.Name = "buttonSaveTravels";
            this.buttonSaveTravels.Size = new System.Drawing.Size(177, 68);
            this.buttonSaveTravels.TabIndex = 6;
            this.buttonSaveTravels.Text = "Pobierz podróże";
            this.buttonSaveTravels.UseVisualStyleBackColor = true;
            this.buttonSaveTravels.Click += new System.EventHandler(this.buttonSaveTravels_Click);
            // 
            // buttonSaveClients
            // 
            this.buttonSaveClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveClients.Location = new System.Drawing.Point(34, 485);
            this.buttonSaveClients.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveClients.Name = "buttonSaveClients";
            this.buttonSaveClients.Size = new System.Drawing.Size(177, 68);
            this.buttonSaveClients.TabIndex = 5;
            this.buttonSaveClients.Text = "Pobierz klienów";
            this.buttonSaveClients.UseVisualStyleBackColor = true;
            this.buttonSaveClients.Click += new System.EventHandler(this.buttonSaveClients_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogout.Location = new System.Drawing.Point(656, 62);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 28);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TravelApp.Properties.Resources.person_round_svgrepo_com1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(776, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 84);
            this.panel1.TabIndex = 1;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.Location = new System.Drawing.Point(492, 33);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(77, 20);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Powitanie";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelEmployee);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(885, 581);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSaveClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSaveTravels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRemoveClient;
        private System.Windows.Forms.Button buttonRemoveTravel;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Button buttonAddNewTravel;
        private System.Windows.Forms.Button buttonAddUserExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

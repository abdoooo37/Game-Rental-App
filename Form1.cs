namespace GameRentalApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelGameId;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxGameId;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Button btnAddGame;

        private System.Windows.Forms.Label labelAdminId;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.TextBox textBoxAdminId;
        private System.Windows.Forms.TextBox textBoxAdminName;
        private System.Windows.Forms.Button btnAddAdmin;

        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Button btnAddClient;

        private System.Windows.Forms.Label labelVendorId;
        private System.Windows.Forms.Label labelVendorName;
        private System.Windows.Forms.TextBox textBoxVendorId;
        private System.Windows.Forms.TextBox textBoxVendorName;
        private System.Windows.Forms.Button btnAddVendor;

        private System.Windows.Forms.Label labelDeleteGameId;
        private System.Windows.Forms.TextBox textBoxDeleteGameId;
        private System.Windows.Forms.Button btnDeleteGame;

        private System.Windows.Forms.Label labelDeleteClientId;
        private System.Windows.Forms.TextBox textBoxDeleteClientId;
        private System.Windows.Forms.Button btnDeleteClient;

        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.ComboBox comboBoxDisplay;
        private System.Windows.Forms.Button btnDisplay;

        private System.Windows.Forms.DataGridView dataGridViewDisplay;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.labelGameId = new System.Windows.Forms.Label();
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxGameId = new System.Windows.Forms.TextBox();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.btnAddGame = new System.Windows.Forms.Button();

            this.labelAdminId = new System.Windows.Forms.Label();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.textBoxAdminId = new System.Windows.Forms.TextBox();
            this.textBoxAdminName = new System.Windows.Forms.TextBox();
            this.btnAddAdmin = new System.Windows.Forms.Button();

            this.labelClientId = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();

            this.labelVendorId = new System.Windows.Forms.Label();
            this.labelVendorName = new System.Windows.Forms.Label();
            this.textBoxVendorId = new System.Windows.Forms.TextBox();
            this.textBoxVendorName = new System.Windows.Forms.TextBox();
            this.btnAddVendor = new System.Windows.Forms.Button();

            this.labelDeleteGameId = new System.Windows.Forms.Label();
            this.textBoxDeleteGameId = new System.Windows.Forms.TextBox();
            this.btnDeleteGame = new System.Windows.Forms.Button();

            this.labelDeleteClientId = new System.Windows.Forms.Label();
            this.textBoxDeleteClientId = new System.Windows.Forms.TextBox();
            this.btnDeleteClient = new System.Windows.Forms.Button();

            this.labelDisplay = new System.Windows.Forms.Label();
            this.comboBoxDisplay = new System.Windows.Forms.ComboBox();
            this.btnDisplay = new System.Windows.Forms.Button();

            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();

            // 
            // labelGameId
            // 
            this.labelGameId.AutoSize = true;
            this.labelGameId.Location = new System.Drawing.Point(20, 20);
            this.labelGameId.Name = "labelGameId";
            this.labelGameId.Size = new System.Drawing.Size(52, 13);
            this.labelGameId.TabIndex = 0;
            this.labelGameId.Text = "Game ID:";
            // 
            // textBoxGameId
            // 
            this.textBoxGameId.Location = new System.Drawing.Point(100, 17);
            this.textBoxGameId.Name = "textBoxGameId";
            this.textBoxGameId.Size = new System.Drawing.Size(150, 20);
            this.textBoxGameId.TabIndex = 1;
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Location = new System.Drawing.Point(20, 50);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(69, 13);
            this.labelGameName.TabIndex = 2;
            this.labelGameName.Text = "Game Name:";
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(100, 47);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(150, 20);
            this.textBoxGameName.TabIndex = 3;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(20, 80);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Genre:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(100, 77);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(150, 20);
            this.textBoxGenre.TabIndex = 5;
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(100, 110);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(150, 23);
            this.btnAddGame.TabIndex = 6;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);

            // Admin Controls
            // labelAdminId
            this.labelAdminId.AutoSize = true;
            this.labelAdminId.Location = new System.Drawing.Point(300, 20);
            this.labelAdminId.Name = "labelAdminId";
            this.labelAdminId.Size = new System.Drawing.Size(52, 13);
            this.labelAdminId.TabIndex = 7;
            this.labelAdminId.Text = "Admin ID:";
            // textBoxAdminId
            this.textBoxAdminId.Location = new System.Drawing.Point(380, 17);
            this.textBoxAdminId.Name = "textBoxAdminId";
            this.textBoxAdminId.Size = new System.Drawing.Size(150, 20);
            this.textBoxAdminId.TabIndex = 8;
            // labelAdminName
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.Location = new System.Drawing.Point(300, 50);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(69, 13);
            this.labelAdminName.TabIndex = 9;
            this.labelAdminName.Text = "Admin Name:";
            // textBoxAdminName
            this.textBoxAdminName.Location = new System.Drawing.Point(380, 47);
            this.textBoxAdminName.Name = "textBoxAdminName";
            this.textBoxAdminName.Size = new System.Drawing.Size(150, 20);
            this.textBoxAdminName.TabIndex = 10;
            // btnAddAdmin
            this.btnAddAdmin.Location = new System.Drawing.Point(380, 80);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(150, 23);
            this.btnAddAdmin.TabIndex = 11;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);

            // Client Controls
            // labelClientId
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(20, 150);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(52, 13);
            this.labelClientId.TabIndex = 12;
            this.labelClientId.Text = "Client ID:";
            // textBoxClientId
            this.textBoxClientId.Location = new System.Drawing.Point(100, 147);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(150, 20);
            this.textBoxClientId.TabIndex = 13;
            // labelClientName
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(20, 180);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(69, 13);
            this.labelClientName.TabIndex = 14;
            this.labelClientName.Text = "Client Name:";
            // textBoxClientName
            this.textBoxClientName.Location = new System.Drawing.Point(100, 177);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(150, 20);
            this.textBoxClientName.TabIndex = 15;
            // btnAddClient
            this.btnAddClient.Location = new System.Drawing.Point(100, 210);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(150, 23);
            this.btnAddClient.TabIndex = 16;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);

            // Vendor Controls
            // labelVendorId
            this.labelVendorId.AutoSize = true;
            this.labelVendorId.Location = new System.Drawing.Point(300, 150);
            this.labelVendorId.Name = "labelVendorId";
            this.labelVendorId.Size = new System.Drawing.Size(58, 13);
            this.labelVendorId.TabIndex = 17;
            this.labelVendorId.Text = "Vendor ID:";
            // textBoxVendorId
            this.textBoxVendorId.Location = new System.Drawing.Point(380, 147);
            this.textBoxVendorId.Name = "textBoxVendorId";
            this.textBoxVendorId.Size = new System.Drawing.Size(150, 20);
            this.textBoxVendorId.TabIndex = 18;
            // labelVendorName
            this.labelVendorName.AutoSize = true;
            this.labelVendorName.Location = new System.Drawing.Point(300, 180);
            this.labelVendorName.Name = "labelVendorName";
            this.labelVendorName.Size = new System.Drawing.Size(75, 13);
            this.labelVendorName.TabIndex = 19;
            this.labelVendorName.Text = "Vendor Name:";
            // textBoxVendorName
            this.textBoxVendorName.Location = new System.Drawing.Point(380, 177);
            this.textBoxVendorName.Name = "textBoxVendorName";
            this.textBoxVendorName.Size = new System.Drawing.Size(150, 20);
            this.textBoxVendorName.TabIndex = 20;
            // btnAddVendor
            this.btnAddVendor.Location = new System.Drawing.Point(380, 210);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(150, 23);
            this.btnAddVendor.TabIndex = 21;
            this.btnAddVendor.Text = "Add Vendor";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);

            // Delete Game Controls
            this.labelDeleteGameId.AutoSize = true;
            this.labelDeleteGameId.Location = new System.Drawing.Point(20, 260);
            this.labelDeleteGameId.Name = "labelDeleteGameId";
            this.labelDeleteGameId.Size = new System.Drawing.Size(101, 13);
            this.labelDeleteGameId.TabIndex = 22;
            this.labelDeleteGameId.Text = "Delete Game by ID:";
            // textBoxDeleteGameId
            this.textBoxDeleteGameId.Location = new System.Drawing.Point(130, 257);
            this.textBoxDeleteGameId.Name = "textBoxDeleteGameId";
            this.textBoxDeleteGameId.Size = new System.Drawing.Size(120, 20);
            this.textBoxDeleteGameId.TabIndex = 23;
            // btnDelete
            // btnDeleteGame
            this.btnDeleteGame.Location = new System.Drawing.Point(260, 255);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteGame.TabIndex = 24;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);

            // Delete Client Controls
            this.labelDeleteClientId.AutoSize = true;
            this.labelDeleteClientId.Location = new System.Drawing.Point(20, 290);
            this.labelDeleteClientId.Name = "labelDeleteClientId";
            this.labelDeleteClientId.Size = new System.Drawing.Size(102, 13);
            this.labelDeleteClientId.TabIndex = 25;
            this.labelDeleteClientId.Text = "Delete Client by ID:";
            // textBoxDeleteClientId
            this.textBoxDeleteClientId.Location = new System.Drawing.Point(130, 287);
            this.textBoxDeleteClientId.Name = "textBoxDeleteClientId";
            this.textBoxDeleteClientId.Size = new System.Drawing.Size(120, 20);
            this.textBoxDeleteClientId.TabIndex = 26;
            // btnDeleteClient
            this.btnDeleteClient.Location = new System.Drawing.Point(260, 285);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteClient.TabIndex = 27;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);

            // Display Label
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.Location = new System.Drawing.Point(20, 330);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(68, 13);
            this.labelDisplay.TabIndex = 28;
            this.labelDisplay.Text = "Display Data:";
            // comboBoxDisplay
            this.comboBoxDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisplay.FormattingEnabled = true;
            this.comboBoxDisplay.Items.AddRange(new object[] {
                "Games",
                "Admins",
                "Clients",
                "Vendors"});
            this.comboBoxDisplay.Location = new System.Drawing.Point(100, 327);
            this.comboBoxDisplay.Name = "comboBoxDisplay";
            this.comboBoxDisplay.Size = new System.Drawing.Size(150, 21);
            this.comboBoxDisplay.TabIndex = 29;
            // btnDisplay
            this.btnDisplay.Location = new System.Drawing.Point(260, 325);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 23);
            this.btnDisplay.TabIndex = 30;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);

            // dataGridViewDisplay
            this.dataGridViewDisplay.AllowUserToAddRows = false;
            this.dataGridViewDisplay.AllowUserToDeleteRows = false;
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(20, 360);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.ReadOnly = true;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(510, 180);
            this.dataGridViewDisplay.TabIndex = 31;

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 560);
            this.Controls.Add(this.labelGameId);
            this.Controls.Add(this.textBoxGameId);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.btnAddGame);

            this.Controls.Add(this.labelAdminId);
            this.Controls.Add(this.textBoxAdminId);
            this.Controls.Add(this.labelAdminName);
            this.Controls.Add(this.textBoxAdminName);
            this.Controls.Add(this.btnAddAdmin);

            this.Controls.Add(this.labelClientId);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.btnAddClient);

            this.Controls.Add(this.labelVendorId);
            this.Controls.Add(this.textBoxVendorId);
            this.Controls.Add(this.labelVendorName);
            this.Controls.Add(this.textBoxVendorName);
            this.Controls.Add(this.btnAddVendor);

            this.Controls.Add(this.labelDeleteGameId);
            this.Controls.Add(this.textBoxDeleteGameId);
            this.Controls.Add(this.btnDeleteGame);

            this.Controls.Add(this.labelDeleteClientId);
            this.Controls.Add(this.textBoxDeleteClientId);
            this.Controls.Add(this.btnDeleteClient);

            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.comboBoxDisplay);
            this.Controls.Add(this.btnDisplay);

            this.Controls.Add(this.dataGridViewDisplay);

            this.Name = "Form1";
            this.Text = "Game Rental System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
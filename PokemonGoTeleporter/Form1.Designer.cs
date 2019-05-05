namespace PokemonGoTeleporter
{
    partial class appForm
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
            this.components = new System.ComponentModel.Container();
            this.teleportBtn = new System.Windows.Forms.Button();
            this.currentCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.coordListBox = new System.Windows.Forms.TextBox();
            this.coordinateListLabel = new System.Windows.Forms.Label();
            this.timeLeftToTeleport = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.despawnBtn = new System.Windows.Forms.Button();
            this.startCooldownBtn = new System.Windows.Forms.Button();
            this.stopJoystickBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.parseCoordinatesBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.paypalPic = new System.Windows.Forms.PictureBox();
            this.etheriumPic = new System.Windows.Forms.PictureBox();
            this.btcPic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paypalPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etheriumPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcPic)).BeginInit();
            this.SuspendLayout();
            // 
            // teleportBtn
            // 
            this.teleportBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.teleportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teleportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleportBtn.Location = new System.Drawing.Point(28, 170);
            this.teleportBtn.Name = "teleportBtn";
            this.teleportBtn.Size = new System.Drawing.Size(149, 42);
            this.teleportBtn.TabIndex = 0;
            this.teleportBtn.Text = "TELEPORT!";
            this.teleportBtn.UseVisualStyleBackColor = false;
            this.teleportBtn.Click += new System.EventHandler(this.teleportBtn_Click);
            // 
            // currentCoordinateTextBox
            // 
            this.currentCoordinateTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.currentCoordinateTextBox.Enabled = false;
            this.currentCoordinateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCoordinateTextBox.Location = new System.Drawing.Point(289, 50);
            this.currentCoordinateTextBox.Name = "currentCoordinateTextBox";
            this.currentCoordinateTextBox.Size = new System.Drawing.Size(149, 20);
            this.currentCoordinateTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Coordinate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Next Coordinate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextCoordinateTextBox
            // 
            this.nextCoordinateTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nextCoordinateTextBox.Enabled = false;
            this.nextCoordinateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextCoordinateTextBox.Location = new System.Drawing.Point(289, 116);
            this.nextCoordinateTextBox.Name = "nextCoordinateTextBox";
            this.nextCoordinateTextBox.Size = new System.Drawing.Size(149, 20);
            this.nextCoordinateTextBox.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(491, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(181, 173);
            this.listBox1.TabIndex = 6;
            // 
            // coordListBox
            // 
            this.coordListBox.Location = new System.Drawing.Point(35, 50);
            this.coordListBox.Multiline = true;
            this.coordListBox.Name = "coordListBox";
            this.coordListBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.coordListBox.Size = new System.Drawing.Size(192, 224);
            this.coordListBox.TabIndex = 7;
            // 
            // coordinateListLabel
            // 
            this.coordinateListLabel.AutoSize = true;
            this.coordinateListLabel.Location = new System.Drawing.Point(505, 16);
            this.coordinateListLabel.Name = "coordinateListLabel";
            this.coordinateListLabel.Size = new System.Drawing.Size(119, 13);
            this.coordinateListLabel.TabIndex = 8;
            this.coordinateListLabel.Text = "Paste Coordinates Here";
            this.coordinateListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLeftToTeleport
            // 
            this.timeLeftToTeleport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftToTeleport.Location = new System.Drawing.Point(111, 247);
            this.timeLeftToTeleport.Margin = new System.Windows.Forms.Padding(0);
            this.timeLeftToTeleport.Name = "timeLeftToTeleport";
            this.timeLeftToTeleport.Size = new System.Drawing.Size(227, 22);
            this.timeLeftToTeleport.TabIndex = 9;
            this.timeLeftToTeleport.Text = " ";
            this.timeLeftToTeleport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time Left For Safe Teleport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Remaining Coordinates";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.despawnBtn);
            this.groupBox1.Controls.Add(this.timeLeftToTeleport);
            this.groupBox1.Controls.Add(this.startCooldownBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.coordinateListLabel);
            this.groupBox1.Controls.Add(this.teleportBtn);
            this.groupBox1.Location = new System.Drawing.Point(261, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 351);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teleport Section";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Step 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Step 3";
            // 
            // despawnBtn
            // 
            this.despawnBtn.Location = new System.Drawing.Point(216, 308);
            this.despawnBtn.Name = "despawnBtn";
            this.despawnBtn.Size = new System.Drawing.Size(205, 37);
            this.despawnBtn.TabIndex = 13;
            this.despawnBtn.Text = "\'Mon Despawned";
            this.despawnBtn.UseVisualStyleBackColor = true;
            this.despawnBtn.Click += new System.EventHandler(this.despawnBtn_Click);
            // 
            // startCooldownBtn
            // 
            this.startCooldownBtn.Location = new System.Drawing.Point(7, 308);
            this.startCooldownBtn.Name = "startCooldownBtn";
            this.startCooldownBtn.Size = new System.Drawing.Size(205, 37);
            this.startCooldownBtn.TabIndex = 13;
            this.startCooldownBtn.Text = "Start Cooldown Counter";
            this.startCooldownBtn.UseVisualStyleBackColor = true;
            this.startCooldownBtn.Click += new System.EventHandler(this.startCooldownBtn_Click);
            // 
            // stopJoystickBtn
            // 
            this.stopJoystickBtn.BackColor = System.Drawing.Color.Firebrick;
            this.stopJoystickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopJoystickBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopJoystickBtn.Location = new System.Drawing.Point(605, 369);
            this.stopJoystickBtn.Name = "stopJoystickBtn";
            this.stopJoystickBtn.Size = new System.Drawing.Size(84, 36);
            this.stopJoystickBtn.TabIndex = 12;
            this.stopJoystickBtn.Text = "Stop Joystick on phone";
            this.stopJoystickBtn.UseVisualStyleBackColor = false;
            this.stopJoystickBtn.Click += new System.EventHandler(this.stopJoystickBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.parseCoordinatesBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 350);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coordinate List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Step 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Step 1";
            // 
            // parseCoordinatesBtn
            // 
            this.parseCoordinatesBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.parseCoordinatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parseCoordinatesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parseCoordinatesBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parseCoordinatesBtn.Location = new System.Drawing.Point(60, 278);
            this.parseCoordinatesBtn.Name = "parseCoordinatesBtn";
            this.parseCoordinatesBtn.Size = new System.Drawing.Size(119, 61);
            this.parseCoordinatesBtn.TabIndex = 14;
            this.parseCoordinatesBtn.Text = "Parse Coordinates";
            this.parseCoordinatesBtn.UseVisualStyleBackColor = false;
            this.parseCoordinatesBtn.Click += new System.EventHandler(this.parseCoordinatesBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Paste Coordinates Here";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(395, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hover over \"Step x\" for more information";
            // 
            // paypalPic
            // 
            this.paypalPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paypalPic.Location = new System.Drawing.Point(413, 369);
            this.paypalPic.Name = "paypalPic";
            this.paypalPic.Size = new System.Drawing.Size(97, 36);
            this.paypalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paypalPic.TabIndex = 15;
            this.paypalPic.TabStop = false;
            this.paypalPic.Click += new System.EventHandler(this.paypal_Click);
            // 
            // etheriumPic
            // 
            this.etheriumPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.etheriumPic.Location = new System.Drawing.Point(516, 369);
            this.etheriumPic.Name = "etheriumPic";
            this.etheriumPic.Size = new System.Drawing.Size(39, 36);
            this.etheriumPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etheriumPic.TabIndex = 15;
            this.etheriumPic.TabStop = false;
            this.etheriumPic.Click += new System.EventHandler(this.etheriumPic_Click);
            // 
            // btcPic
            // 
            this.btcPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btcPic.Location = new System.Drawing.Point(560, 369);
            this.btcPic.Name = "btcPic";
            this.btcPic.Size = new System.Drawing.Size(39, 36);
            this.btcPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btcPic.TabIndex = 15;
            this.btcPic.TabStop = false;
            this.btcPic.Click += new System.EventHandler(this.btcPic_Click);
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 413);
            this.Controls.Add(this.btcPic);
            this.Controls.Add(this.etheriumPic);
            this.Controls.Add(this.paypalPic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stopJoystickBtn);
            this.Controls.Add(this.coordListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nextCoordinateTextBox);
            this.Controls.Add(this.currentCoordinateTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "appForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon Go Teleporter";
            this.Load += new System.EventHandler(this.appForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paypalPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etheriumPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button teleportBtn;
        private System.Windows.Forms.TextBox currentCoordinateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nextCoordinateTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox coordListBox;
        private System.Windows.Forms.Label coordinateListLabel;
        private System.Windows.Forms.Label timeLeftToTeleport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button stopJoystickBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button parseCoordinatesBtn;
        private System.Windows.Forms.Button despawnBtn;
        private System.Windows.Forms.Button startCooldownBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox paypalPic;
        private System.Windows.Forms.PictureBox etheriumPic;
        private System.Windows.Forms.PictureBox btcPic;
    }
}


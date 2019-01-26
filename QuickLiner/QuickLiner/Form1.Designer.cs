namespace QuickLiner
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
            this.nameReserveLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneReserveLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneReserveTextBox = new System.Windows.Forms.TextBox();
            this.departureLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.PassportTextBox = new System.Windows.Forms.TextBox();
            this.passengerNumLabel = new System.Windows.Forms.Label();
            this.passportLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.luggageNumLabel = new System.Windows.Forms.Label();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.phoneRetrieveLabel = new System.Windows.Forms.Label();
            this.reservationIDtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.destinationTextbox = new System.Windows.Forms.TextBox();
            this.departureTextbox = new System.Windows.Forms.TextBox();
            this.passengerTextBox = new System.Windows.Forms.TextBox();
            this.luggageTextbox = new System.Windows.Forms.TextBox();
            this.tripTypeTextbox = new System.Windows.Forms.TextBox();
            this.ticketClasstextBox = new System.Windows.Forms.TextBox();
            this.add_saveButton = new System.Windows.Forms.Button();
            this.dgvAirlineInfo = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlineInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // nameReserveLabel
            // 
            this.nameReserveLabel.AutoSize = true;
            this.nameReserveLabel.Location = new System.Drawing.Point(38, 383);
            this.nameReserveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameReserveLabel.Name = "nameReserveLabel";
            this.nameReserveLabel.Size = new System.Drawing.Size(51, 20);
            this.nameReserveLabel.TabIndex = 0;
            this.nameReserveLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 372);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 26);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(38, 457);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 20);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-Mail";
            // 
            // phoneReserveLabel
            // 
            this.phoneReserveLabel.AutoSize = true;
            this.phoneReserveLabel.Location = new System.Drawing.Point(38, 526);
            this.phoneReserveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneReserveLabel.Name = "phoneReserveLabel";
            this.phoneReserveLabel.Size = new System.Drawing.Size(55, 20);
            this.phoneReserveLabel.TabIndex = 3;
            this.phoneReserveLabel.Text = "Phone";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(100, 446);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(148, 26);
            this.emailTextBox.TabIndex = 4;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // phoneReserveTextBox
            // 
            this.phoneReserveTextBox.Location = new System.Drawing.Point(104, 526);
            this.phoneReserveTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneReserveTextBox.Name = "phoneReserveTextBox";
            this.phoneReserveTextBox.Size = new System.Drawing.Size(148, 26);
            this.phoneReserveTextBox.TabIndex = 5;
            this.phoneReserveTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Location = new System.Drawing.Point(309, 377);
            this.departureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(122, 20);
            this.departureLabel.TabIndex = 6;
            this.departureLabel.Text = "Departure From";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(309, 426);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(112, 20);
            this.destinationLabel.TabIndex = 7;
            this.destinationLabel.Text = "Destination To";
            // 
            // PassportTextBox
            // 
            this.PassportTextBox.Location = new System.Drawing.Point(810, 438);
            this.PassportTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PassportTextBox.Name = "PassportTextBox";
            this.PassportTextBox.Size = new System.Drawing.Size(148, 26);
            this.PassportTextBox.TabIndex = 8;
            this.PassportTextBox.TextChanged += new System.EventHandler(this.PassportTextBox_TextChanged);
            // 
            // passengerNumLabel
            // 
            this.passengerNumLabel.AutoSize = true;
            this.passengerNumLabel.Location = new System.Drawing.Point(654, 383);
            this.passengerNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passengerNumLabel.Name = "passengerNumLabel";
            this.passengerNumLabel.Size = new System.Drawing.Size(131, 20);
            this.passengerNumLabel.TabIndex = 12;
            this.passengerNumLabel.Text = "No. of Passenger";
            // 
            // passportLabel
            // 
            this.passportLabel.AutoSize = true;
            this.passportLabel.Location = new System.Drawing.Point(654, 438);
            this.passportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passportLabel.Name = "passportLabel";
            this.passportLabel.Size = new System.Drawing.Size(132, 20);
            this.passportLabel.TabIndex = 14;
            this.passportLabel.Text = "Passport Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 597);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ticket Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 597);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Type of Trip";
            // 
            // luggageNumLabel
            // 
            this.luggageNumLabel.AutoSize = true;
            this.luggageNumLabel.Location = new System.Drawing.Point(819, 597);
            this.luggageNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.luggageNumLabel.Name = "luggageNumLabel";
            this.luggageNumLabel.Size = new System.Drawing.Size(118, 20);
            this.luggageNumLabel.TabIndex = 21;
            this.luggageNumLabel.Text = "No. of Luggage";
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(413, 706);
            this.Updatebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(112, 35);
            this.Updatebutton.TabIndex = 23;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(846, 706);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 25;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 306);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "NEW RESERVATION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(42, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(469, 158);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RETRIEVE";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(235, 51);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(148, 26);
            this.searchTextbox.TabIndex = 29;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Input Name/Passport Number";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(340, 114);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 35);
            this.button6.TabIndex = 26;
            this.button6.Text = "Print";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(99, 114);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 35);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // phoneRetrieveLabel
            // 
            this.phoneRetrieveLabel.AutoSize = true;
            this.phoneRetrieveLabel.Location = new System.Drawing.Point(316, 529);
            this.phoneRetrieveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneRetrieveLabel.Name = "phoneRetrieveLabel";
            this.phoneRetrieveLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneRetrieveLabel.TabIndex = 4;
            this.phoneRetrieveLabel.Text = "Reservation ID";
            // 
            // reservationIDtextBox
            // 
            this.reservationIDtextBox.Location = new System.Drawing.Point(461, 526);
            this.reservationIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reservationIDtextBox.Name = "reservationIDtextBox";
            this.reservationIDtextBox.ReadOnly = true;
            this.reservationIDtextBox.Size = new System.Drawing.Size(148, 26);
            this.reservationIDtextBox.TabIndex = 2;
            this.reservationIDtextBox.TextChanged += new System.EventHandler(this.PhoneRetrieveTexttBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "EXISTING RESERVATION";
            // 
            // destinationTextbox
            // 
            this.destinationTextbox.Location = new System.Drawing.Point(461, 426);
            this.destinationTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destinationTextbox.Name = "destinationTextbox";
            this.destinationTextbox.Size = new System.Drawing.Size(148, 26);
            this.destinationTextbox.TabIndex = 30;
            // 
            // departureTextbox
            // 
            this.departureTextbox.Location = new System.Drawing.Point(461, 374);
            this.departureTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departureTextbox.Name = "departureTextbox";
            this.departureTextbox.Size = new System.Drawing.Size(148, 26);
            this.departureTextbox.TabIndex = 31;
            // 
            // passengerTextBox
            // 
            this.passengerTextBox.Location = new System.Drawing.Point(810, 380);
            this.passengerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passengerTextBox.Name = "passengerTextBox";
            this.passengerTextBox.Size = new System.Drawing.Size(148, 26);
            this.passengerTextBox.TabIndex = 32;
            // 
            // luggageTextbox
            // 
            this.luggageTextbox.Location = new System.Drawing.Point(810, 642);
            this.luggageTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luggageTextbox.Name = "luggageTextbox";
            this.luggageTextbox.Size = new System.Drawing.Size(148, 26);
            this.luggageTextbox.TabIndex = 33;
            // 
            // tripTypeTextbox
            // 
            this.tripTypeTextbox.Location = new System.Drawing.Point(412, 642);
            this.tripTypeTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tripTypeTextbox.Name = "tripTypeTextbox";
            this.tripTypeTextbox.Size = new System.Drawing.Size(148, 26);
            this.tripTypeTextbox.TabIndex = 34;
            // 
            // ticketClasstextBox
            // 
            this.ticketClasstextBox.Location = new System.Drawing.Point(100, 642);
            this.ticketClasstextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticketClasstextBox.Name = "ticketClasstextBox";
            this.ticketClasstextBox.Size = new System.Drawing.Size(148, 26);
            this.ticketClasstextBox.TabIndex = 35;
            // 
            // add_saveButton
            // 
            this.add_saveButton.Location = new System.Drawing.Point(100, 706);
            this.add_saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_saveButton.Name = "add_saveButton";
            this.add_saveButton.Size = new System.Drawing.Size(112, 35);
            this.add_saveButton.TabIndex = 36;
            this.add_saveButton.Text = "Save";
            this.add_saveButton.UseVisualStyleBackColor = true;
            this.add_saveButton.Click += new System.EventHandler(this.add_saveButton_Click);
            // 
            // dgvAirlineInfo
            // 
            this.dgvAirlineInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirlineInfo.Location = new System.Drawing.Point(548, 31);
            this.dgvAirlineInfo.Name = "dgvAirlineInfo";
            this.dgvAirlineInfo.RowTemplate.Height = 28;
            this.dgvAirlineInfo.Size = new System.Drawing.Size(543, 227);
            this.dgvAirlineInfo.TabIndex = 37;
            this.dgvAirlineInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirlineInfo_RowHeaderMouseClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(619, 705);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 35);
            this.deleteButton.TabIndex = 38;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 754);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dgvAirlineInfo);
            this.Controls.Add(this.add_saveButton);
            this.Controls.Add(this.ticketClasstextBox);
            this.Controls.Add(this.phoneRetrieveLabel);
            this.Controls.Add(this.reservationIDtextBox);
            this.Controls.Add(this.tripTypeTextbox);
            this.Controls.Add(this.luggageTextbox);
            this.Controls.Add(this.passengerTextBox);
            this.Controls.Add(this.departureTextbox);
            this.Controls.Add(this.destinationTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.luggageNumLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passportLabel);
            this.Controls.Add(this.passengerNumLabel);
            this.Controls.Add(this.PassportTextBox);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.phoneReserveTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneReserveLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameReserveLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Quick Liner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlineInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameReserveLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneReserveLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneReserveTextBox;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TextBox PassportTextBox;
        private System.Windows.Forms.Label passengerNumLabel;
        private System.Windows.Forms.Label passportLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label luggageNumLabel;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label phoneRetrieveLabel;
        private System.Windows.Forms.TextBox reservationIDtextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox destinationTextbox;
        private System.Windows.Forms.TextBox departureTextbox;
        private System.Windows.Forms.TextBox passengerTextBox;
        private System.Windows.Forms.TextBox luggageTextbox;
        private System.Windows.Forms.TextBox tripTypeTextbox;
        private System.Windows.Forms.TextBox ticketClasstextBox;
        private System.Windows.Forms.Button add_saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.DataGridView dgvAirlineInfo;
        private System.Windows.Forms.Button deleteButton;
    }
}


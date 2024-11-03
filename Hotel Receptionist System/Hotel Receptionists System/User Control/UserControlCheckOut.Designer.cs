namespace HotelReceptionistsSystem.User_Control
{
    partial class UserControlCheckOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button buttonCheckOut;
            this.tabControlCheckOut = new System.Windows.Forms.TabControl();
            this.tabPageSearchReserve = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGuestID = new System.Windows.Forms.TextBox();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCheckOut = new System.Windows.Forms.TabPage();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.textBoxRoomType = new System.Windows.Forms.TextBox();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.textBoxGuestID1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.roomTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heavensDoorDataSet = new HotelReceptionistsSystem.HeavensDoorDataSet();
            this.room_TableTableAdapter = new HotelReceptionistsSystem.HeavensDoorDataSetTableAdapters.Room_TableTableAdapter();
            this.heavensDoorDataSet1 = new HotelReceptionistsSystem.HeavensDoorDataSet();
            this.roomTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            buttonCheckOut = new System.Windows.Forms.Button();
            this.tabControlCheckOut.SuspendLayout();
            this.tabPageSearchReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tabPageCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heavensDoorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heavensDoorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCheckOut
            // 
            buttonCheckOut.BackColor = System.Drawing.Color.Crimson;
            buttonCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCheckOut.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonCheckOut.ForeColor = System.Drawing.Color.AliceBlue;
            buttonCheckOut.Location = new System.Drawing.Point(673, 273);
            buttonCheckOut.Name = "buttonCheckOut";
            buttonCheckOut.Size = new System.Drawing.Size(107, 33);
            buttonCheckOut.TabIndex = 86;
            buttonCheckOut.Text = "Check-Out";
            buttonCheckOut.UseVisualStyleBackColor = false;
            buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // tabControlCheckOut
            // 
            this.tabControlCheckOut.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlCheckOut.Controls.Add(this.tabPageSearchReserve);
            this.tabControlCheckOut.Controls.Add(this.tabPageCheckOut);
            this.tabControlCheckOut.Location = new System.Drawing.Point(26, 33);
            this.tabControlCheckOut.Name = "tabControlCheckOut";
            this.tabControlCheckOut.SelectedIndex = 0;
            this.tabControlCheckOut.Size = new System.Drawing.Size(1044, 387);
            this.tabControlCheckOut.TabIndex = 0;
            this.tabControlCheckOut.Enter += new System.EventHandler(this.tabControlCheckOut_Enter);
            // 
            // tabPageSearchReserve
            // 
            this.tabPageSearchReserve.Controls.Add(this.label1);
            this.tabPageSearchReserve.Controls.Add(this.label2);
            this.tabPageSearchReserve.Controls.Add(this.textBoxGuestID);
            this.tabPageSearchReserve.Controls.Add(this.dataGridViewReservation);
            this.tabPageSearchReserve.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchReserve.Name = "tabPageSearchReserve";
            this.tabPageSearchReserve.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchReserve.Size = new System.Drawing.Size(1036, 349);
            this.tabPageSearchReserve.TabIndex = 0;
            this.tabPageSearchReserve.Text = "Search Reservation";
            this.tabPageSearchReserve.UseVisualStyleBackColor = true;
            this.tabPageSearchReserve.Click += new System.EventHandler(this.tabPageSearchReserve_Click);
            this.tabPageSearchReserve.Enter += new System.EventHandler(this.tabPageSearchReserve_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Guest ID:";
            // 
            // textBoxGuestID
            // 
            this.textBoxGuestID.Location = new System.Drawing.Point(317, 40);
            this.textBoxGuestID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuestID.Name = "textBoxGuestID";
            this.textBoxGuestID.Size = new System.Drawing.Size(258, 32);
            this.textBoxGuestID.TabIndex = 13;
            this.textBoxGuestID.TextChanged += new System.EventHandler(this.textBoxGuestID_TextChanged);
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            this.dataGridViewReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservation.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridViewReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewReservation.Location = new System.Drawing.Point(37, 91);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.RowHeadersWidth = 51;
            this.dataGridViewReservation.RowTemplate.Height = 24;
            this.dataGridViewReservation.Size = new System.Drawing.Size(968, 243);
            this.dataGridViewReservation.TabIndex = 12;
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellClick);
            this.dataGridViewReservation.Enter += new System.EventHandler(this.dataGridViewReservation_Enter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Reservation_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Reservation_Room_Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room Type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Reservation_Room_Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Room No.";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Reservation_Guest_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Guest ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Reservation_In";
            this.dataGridViewTextBoxColumn5.HeaderText = "In Time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Reservation_Out";
            this.dataGridViewTextBoxColumn6.HeaderText = "Out Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tabPageCheckOut
            // 
            this.tabPageCheckOut.Controls.Add(this.textBoxRoomNumber);
            this.tabPageCheckOut.Controls.Add(this.textBoxRoomType);
            this.tabPageCheckOut.Controls.Add(this.dateTimePickerOut);
            this.tabPageCheckOut.Controls.Add(this.dateTimePickerIn);
            this.tabPageCheckOut.Controls.Add(this.textBoxGuestID1);
            this.tabPageCheckOut.Controls.Add(buttonCheckOut);
            this.tabPageCheckOut.Controls.Add(this.label15);
            this.tabPageCheckOut.Controls.Add(this.label16);
            this.tabPageCheckOut.Controls.Add(this.label17);
            this.tabPageCheckOut.Controls.Add(this.label18);
            this.tabPageCheckOut.Controls.Add(this.label19);
            this.tabPageCheckOut.Controls.Add(this.label20);
            this.tabPageCheckOut.Location = new System.Drawing.Point(4, 4);
            this.tabPageCheckOut.Name = "tabPageCheckOut";
            this.tabPageCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckOut.Size = new System.Drawing.Size(1036, 349);
            this.tabPageCheckOut.TabIndex = 1;
            this.tabPageCheckOut.Text = "Check-Out";
            this.tabPageCheckOut.UseVisualStyleBackColor = true;
            this.tabPageCheckOut.Click += new System.EventHandler(this.tabPageCheckOut_Click);
            this.tabPageCheckOut.Leave += new System.EventHandler(this.tabPageCheckOut_Leave);
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(180, 204);
            this.textBoxRoomNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(93, 32);
            this.textBoxRoomNumber.TabIndex = 93;
            // 
            // textBoxRoomType
            // 
            this.textBoxRoomType.Location = new System.Drawing.Point(180, 116);
            this.textBoxRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRoomType.Name = "textBoxRoomType";
            this.textBoxRoomType.Size = new System.Drawing.Size(214, 32);
            this.textBoxRoomType.TabIndex = 92;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOut.Location = new System.Drawing.Point(588, 204);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(288, 30);
            this.dateTimePickerOut.TabIndex = 91;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIn.Location = new System.Drawing.Point(588, 115);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(288, 30);
            this.dateTimePickerIn.TabIndex = 90;
            // 
            // textBoxGuestID1
            // 
            this.textBoxGuestID1.Location = new System.Drawing.Point(180, 278);
            this.textBoxGuestID1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuestID1.Name = "textBoxGuestID1";
            this.textBoxGuestID1.Size = new System.Drawing.Size(214, 32);
            this.textBoxGuestID1.TabIndex = 87;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(584, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 21);
            this.label15.TabIndex = 85;
            this.label15.Text = "Check-Out Time:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(176, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 21);
            this.label16.TabIndex = 84;
            this.label16.Text = "Room No:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(584, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 21);
            this.label17.TabIndex = 83;
            this.label17.Text = "Check-In Time:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(176, 254);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 21);
            this.label18.TabIndex = 82;
            this.label18.Text = "Guest ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(176, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 21);
            this.label19.TabIndex = 81;
            this.label19.Text = "Room Type:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(216, 22);
            this.label20.TabIndex = 80;
            this.label20.Text = "Select Room and Date:";
            // 
            // roomTableBindingSource
            // 
            this.roomTableBindingSource.DataMember = "Room_Table";
            this.roomTableBindingSource.DataSource = this.heavensDoorDataSet;
            // 
            // heavensDoorDataSet
            // 
            this.heavensDoorDataSet.DataSetName = "HeavensDoorDataSet";
            this.heavensDoorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // room_TableTableAdapter
            // 
            this.room_TableTableAdapter.ClearBeforeFill = true;
            // 
            // heavensDoorDataSet1
            // 
            this.heavensDoorDataSet1.DataSetName = "HeavensDoorDataSet";
            this.heavensDoorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableBindingSource1
            // 
            this.roomTableBindingSource1.DataMember = "Room_Table";
            this.roomTableBindingSource1.DataSource = this.heavensDoorDataSet1;
            // 
            // UserControlCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlCheckOut);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlCheckOut";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlCheckOut_Load);
            this.tabControlCheckOut.ResumeLayout(false);
            this.tabPageSearchReserve.ResumeLayout(false);
            this.tabPageSearchReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tabPageCheckOut.ResumeLayout(false);
            this.tabPageCheckOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heavensDoorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heavensDoorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCheckOut;
        private System.Windows.Forms.TabPage tabPageSearchReserve;
        private System.Windows.Forms.TabPage tabPageCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGuestID;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.TextBox textBoxGuestID1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBoxRoomType;
        private System.Windows.Forms.BindingSource roomTableBindingSource;
        private HeavensDoorDataSet heavensDoorDataSet;
        private HeavensDoorDataSetTableAdapters.Room_TableTableAdapter room_TableTableAdapter;
        private System.Windows.Forms.BindingSource roomTableBindingSource1;
        private HeavensDoorDataSet heavensDoorDataSet1;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
    }
}

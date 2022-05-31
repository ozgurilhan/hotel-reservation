namespace Reservation
{
    partial class frmHotels
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
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAdminHotels = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbHotels = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.gbAdminRooms = new System.Windows.Forms.GroupBox();
            this.bnUpdateRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.lbRooms = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.gbAdminHotels.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAdminRooms.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHotel
            // 
            this.txtHotel.Location = new System.Drawing.Point(156, 49);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(260, 26);
            this.txtHotel.TabIndex = 0;
            this.txtHotel.TextChanged += new System.EventHandler(this.txtHotel_TextChanged);
            this.txtHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHotel_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbAdminHotels);
            this.groupBox1.Controls.Add(this.lbHotels);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHotel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 348);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotels";
            // 
            // gbAdminHotels
            // 
            this.gbAdminHotels.Controls.Add(this.btnUpdate);
            this.gbAdminHotels.Controls.Add(this.btnDelete);
            this.gbAdminHotels.Controls.Add(this.btnAdd);
            this.gbAdminHotels.Location = new System.Drawing.Point(23, 300);
            this.gbAdminHotels.Name = "gbAdminHotels";
            this.gbAdminHotels.Size = new System.Drawing.Size(393, 50);
            this.gbAdminHotels.TabIndex = 6;
            this.gbAdminHotels.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(155, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(254, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(56, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // lbHotels
            // 
            this.lbHotels.FormattingEnabled = true;
            this.lbHotels.ItemHeight = 20;
            this.lbHotels.Location = new System.Drawing.Point(23, 90);
            this.lbHotels.Name = "lbHotels";
            this.lbHotels.Size = new System.Drawing.Size(393, 204);
            this.lbHotels.TabIndex = 5;
            this.lbHotels.SelectedIndexChanged += new System.EventHandler(this.lbHotels_SelectedIndexChanged);
            this.lbHotels.DoubleClick += new System.EventHandler(this.lbHotels_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotel Search : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.calendar);
            this.groupBox2.Controls.Add(this.gbAdminRooms);
            this.groupBox2.Controls.Add(this.btnBook);
            this.groupBox2.Controls.Add(this.lbRooms);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(449, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 364);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rooms";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(144, 46);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 3;
            // 
            // gbAdminRooms
            // 
            this.gbAdminRooms.Controls.Add(this.bnUpdateRoom);
            this.gbAdminRooms.Controls.Add(this.btnDeleteRoom);
            this.gbAdminRooms.Controls.Add(this.btnAddRoom);
            this.gbAdminRooms.Location = new System.Drawing.Point(6, 300);
            this.gbAdminRooms.Name = "gbAdminRooms";
            this.gbAdminRooms.Size = new System.Drawing.Size(386, 50);
            this.gbAdminRooms.TabIndex = 6;
            this.gbAdminRooms.TabStop = false;
            // 
            // bnUpdateRoom
            // 
            this.bnUpdateRoom.Location = new System.Drawing.Point(143, 14);
            this.bnUpdateRoom.Name = "bnUpdateRoom";
            this.bnUpdateRoom.Size = new System.Drawing.Size(93, 32);
            this.bnUpdateRoom.TabIndex = 2;
            this.bnUpdateRoom.Text = "Update";
            this.bnUpdateRoom.UseVisualStyleBackColor = true;
            this.bnUpdateRoom.Click += new System.EventHandler(this.bnUpdateRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(242, 14);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(93, 32);
            this.btnDeleteRoom.TabIndex = 2;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(44, 15);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(93, 32);
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(144, 218);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(227, 32);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lbRooms
            // 
            this.lbRooms.FormattingEnabled = true;
            this.lbRooms.ItemHeight = 20;
            this.lbRooms.Location = new System.Drawing.Point(6, 46);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(126, 204);
            this.lbRooms.TabIndex = 5;
            this.lbRooms.SelectedIndexChanged += new System.EventHandler(this.lbRooms_SelectedIndexChanged);
            this.lbRooms.DoubleClick += new System.EventHandler(this.lbHotels_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBookingsToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // showBookingsToolStripMenuItem
            // 
            this.showBookingsToolStripMenuItem.Name = "showBookingsToolStripMenuItem";
            this.showBookingsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showBookingsToolStripMenuItem.Text = "Show Bookings";
            this.showBookingsToolStripMenuItem.Click += new System.EventHandler(this.showBookingsToolStripMenuItem_Click);
            // 
            // frmHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHotels";
            this.Text = "frmHotels";
            this.Load += new System.EventHandler(this.frmHotels_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAdminHotels.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbAdminRooms.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbHotels;
        private System.Windows.Forms.GroupBox gbAdminHotels;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbAdminRooms;
        private System.Windows.Forms.Button bnUpdateRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.ListBox lbRooms;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBookingsToolStripMenuItem;
    }
}
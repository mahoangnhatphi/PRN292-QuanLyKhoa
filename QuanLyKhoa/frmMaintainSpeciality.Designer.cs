namespace QuanLyKhoa
{
    partial class frmMaintainSpeciality
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumberStudent = new System.Windows.Forms.Label();
            this.btnPhysicalDelete = new System.Windows.Forms.Button();
            this.btnReopen = new System.Windows.Forms.Button();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSpecialistName = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.dgvSpeciality = new System.Windows.Forms.DataGridView();
            this.cbSpeciality = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaĐãNgưngĐàoTạoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblLoginedUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeciality)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLoginedUser);
            this.panel1.Controls.Add(this.pbAvatar);
            this.panel1.Controls.Add(this.lblNumberStudent);
            this.panel1.Controls.Add(this.btnPhysicalDelete);
            this.panel1.Controls.Add(this.btnReopen);
            this.panel1.Controls.Add(this.lblMaKhoa);
            this.panel1.Controls.Add(this.lblSpeciality);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtSpecialistName);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.dgvSpeciality);
            this.panel1.Controls.Add(this.cbSpeciality);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 396);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNumberStudent
            // 
            this.lblNumberStudent.AutoSize = true;
            this.lblNumberStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberStudent.Location = new System.Drawing.Point(441, 295);
            this.lblNumberStudent.Name = "lblNumberStudent";
            this.lblNumberStudent.Size = new System.Drawing.Size(40, 20);
            this.lblNumberStudent.TabIndex = 13;
            this.lblNumberStudent.Text = "NaN";
            // 
            // btnPhysicalDelete
            // 
            this.btnPhysicalDelete.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnPhysicalDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhysicalDelete.Location = new System.Drawing.Point(595, 228);
            this.btnPhysicalDelete.Name = "btnPhysicalDelete";
            this.btnPhysicalDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPhysicalDelete.TabIndex = 12;
            this.btnPhysicalDelete.Text = "Xóa Hẳn";
            this.btnPhysicalDelete.UseVisualStyleBackColor = true;
            this.btnPhysicalDelete.Visible = false;
            this.btnPhysicalDelete.Click += new System.EventHandler(this.btnPhysicalDelete_Click);
            // 
            // btnReopen
            // 
            this.btnReopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReopen.Location = new System.Drawing.Point(501, 228);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(75, 23);
            this.btnReopen.TabIndex = 11;
            this.btnReopen.Text = "Mở lại";
            this.btnReopen.UseVisualStyleBackColor = true;
            this.btnReopen.Visible = false;
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(477, 9);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(0, 13);
            this.lblMaKhoa.TabIndex = 1;
            this.lblMaKhoa.Visible = false;
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.AutoSize = true;
            this.lblSpeciality.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeciality.Location = new System.Drawing.Point(48, 78);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(63, 24);
            this.lblSpeciality.TabIndex = 9;
            this.lblSpeciality.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(740, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(641, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(544, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(444, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSpecialistName
            // 
            this.txtSpecialistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialistName.Location = new System.Drawing.Point(444, 162);
            this.txtSpecialistName.Name = "txtSpecialistName";
            this.txtSpecialistName.Size = new System.Drawing.Size(240, 26);
            this.txtSpecialistName.TabIndex = 4;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(441, 82);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(65, 20);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Number";
            // 
            // dgvSpeciality
            // 
            this.dgvSpeciality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeciality.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvSpeciality.Location = new System.Drawing.Point(12, 27);
            this.dgvSpeciality.MultiSelect = false;
            this.dgvSpeciality.Name = "dgvSpeciality";
            this.dgvSpeciality.Size = new System.Drawing.Size(401, 322);
            this.dgvSpeciality.TabIndex = 2;
            this.dgvSpeciality.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpeciality_CellContentClick);
            this.dgvSpeciality.SelectionChanged += new System.EventHandler(this.dgvSpeciality_SelectionChanged);
            this.dgvSpeciality.CursorChanged += new System.EventHandler(this.dgvSpeciality_CursorChanged);
            // 
            // cbSpeciality
            // 
            this.cbSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpeciality.FormattingEnabled = true;
            this.cbSpeciality.Location = new System.Drawing.Point(444, 109);
            this.cbSpeciality.Name = "cbSpeciality";
            this.cbSpeciality.Size = new System.Drawing.Size(121, 28);
            this.cbSpeciality.TabIndex = 0;
            this.cbSpeciality.SelectedIndexChanged += new System.EventHandler(this.cbSpeciality_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhoaToolStripMenuItem,
            this.khoaĐãNgưngĐàoTạoToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 20);
            this.toolStripMenuItem1.Text = "Chương trình quản lý khoa";
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            this.quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            this.quảnLýKhoaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.quảnLýKhoaToolStripMenuItem.Text = "Quản lý Khoa";
            this.quảnLýKhoaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhoaToolStripMenuItem_Click);
            // 
            // khoaĐãNgưngĐàoTạoToolStripMenuItem
            // 
            this.khoaĐãNgưngĐàoTạoToolStripMenuItem.Name = "khoaĐãNgưngĐàoTạoToolStripMenuItem";
            this.khoaĐãNgưngĐàoTạoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.khoaĐãNgưngĐàoTạoToolStripMenuItem.Text = "Khoa đã ngưng đào tạo";
            this.khoaĐãNgưngĐàoTạoToolStripMenuItem.Click += new System.EventHandler(this.khoaĐãNgưngĐàoTạoToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(595, 27);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(50, 50);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 14;
            this.pbAvatar.TabStop = false;
            // 
            // lblLoginedUser
            // 
            this.lblLoginedUser.AutoSize = true;
            this.lblLoginedUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginedUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLoginedUser.Location = new System.Drawing.Point(652, 28);
            this.lblLoginedUser.Name = "lblLoginedUser";
            this.lblLoginedUser.Size = new System.Drawing.Size(45, 19);
            this.lblLoginedUser.TabIndex = 15;
            this.lblLoginedUser.Text = "label1";
            // 
            // frmMaintainSpeciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 388);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMaintainSpeciality";
            this.Text = "Quản Lý Khoa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMaintainSpeciality_FormClosed);
            this.Load += new System.EventHandler(this.frmMaintainSpeciality_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeciality)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSpeciality;
        private System.Windows.Forms.DataGridView dgvSpeciality;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtSpecialistName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSpeciality;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaĐãNgưngĐàoTạoToolStripMenuItem;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Button btnReopen;
        private System.Windows.Forms.Button btnPhysicalDelete;
        private System.Windows.Forms.Label lblNumberStudent;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblLoginedUser;
    }
}


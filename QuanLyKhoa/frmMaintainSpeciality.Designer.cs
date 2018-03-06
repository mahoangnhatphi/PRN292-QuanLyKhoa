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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSpecialistName = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.dgvSpeciality = new System.Windows.Forms.DataGridView();
            this.cbSpeciality = new System.Windows.Forms.ComboBox();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeciality)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSpeciality);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtSpecialistName);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.dgvSpeciality);
            this.panel1.Controls.Add(this.cbSpeciality);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 354);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(743, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(644, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(547, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(447, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSpecialistName
            // 
            this.txtSpecialistName.Location = new System.Drawing.Point(447, 101);
            this.txtSpecialistName.Name = "txtSpecialistName";
            this.txtSpecialistName.Size = new System.Drawing.Size(240, 20);
            this.txtSpecialistName.TabIndex = 4;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(444, 21);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Number";
            // 
            // dgvSpeciality
            // 
            this.dgvSpeciality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeciality.Location = new System.Drawing.Point(32, 12);
            this.dgvSpeciality.Name = "dgvSpeciality";
            this.dgvSpeciality.Size = new System.Drawing.Size(401, 322);
            this.dgvSpeciality.TabIndex = 2;
            this.dgvSpeciality.SelectionChanged += new System.EventHandler(this.dgvSpeciality_SelectionChanged);
            this.dgvSpeciality.CursorChanged += new System.EventHandler(this.dgvSpeciality_CursorChanged);
            // 
            // cbSpeciality
            // 
            this.cbSpeciality.FormattingEnabled = true;
            this.cbSpeciality.Location = new System.Drawing.Point(447, 48);
            this.cbSpeciality.Name = "cbSpeciality";
            this.cbSpeciality.Size = new System.Drawing.Size(121, 21);
            this.cbSpeciality.TabIndex = 0;
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
            // frmMaintainSpeciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 355);
            this.Controls.Add(this.panel1);
            this.Name = "frmMaintainSpeciality";
            this.Text = "Maintain Speciality";
            this.Load += new System.EventHandler(this.frmMaintainSpeciality_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeciality)).EndInit();
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
    }
}


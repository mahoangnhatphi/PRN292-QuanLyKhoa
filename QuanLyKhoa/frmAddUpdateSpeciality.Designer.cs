namespace QuanLyKhoa
{
    partial class frmAddUpdateSpeciality
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
            this.txtSpecialityCode = new System.Windows.Forms.TextBox();
            this.txtSpecialityName = new System.Windows.Forms.TextBox();
            this.txtSpecialtityFoundedYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.errSpeciality = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblInvalid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errSpeciality)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSpecialityCode
            // 
            this.txtSpecialityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialityCode.Location = new System.Drawing.Point(122, 36);
            this.txtSpecialityCode.Name = "txtSpecialityCode";
            this.txtSpecialityCode.Size = new System.Drawing.Size(135, 22);
            this.txtSpecialityCode.TabIndex = 0;
            this.txtSpecialityCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtSpecialityCode_Validating);
            // 
            // txtSpecialityName
            // 
            this.txtSpecialityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialityName.Location = new System.Drawing.Point(122, 81);
            this.txtSpecialityName.Name = "txtSpecialityName";
            this.txtSpecialityName.Size = new System.Drawing.Size(315, 22);
            this.txtSpecialityName.TabIndex = 1;
            this.txtSpecialityName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSpecialityName_Validating);
            // 
            // txtSpecialtityFoundedYear
            // 
            this.txtSpecialtityFoundedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialtityFoundedYear.Location = new System.Drawing.Point(122, 121);
            this.txtSpecialtityFoundedYear.Name = "txtSpecialtityFoundedYear";
            this.txtSpecialtityFoundedYear.Size = new System.Drawing.Size(100, 22);
            this.txtSpecialtityFoundedYear.TabIndex = 2;
            this.txtSpecialtityFoundedYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtSpecialtityFoundedYear_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Khoa";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(12, 124);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(104, 16);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Năm Thành Lập";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(194, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(72, 167);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(92, 33);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Đồng ý";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // errSpeciality
            // 
            this.errSpeciality.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errSpeciality.ContainerControl = this;
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(12, 214);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(284, 20);
            this.lblInvalid.TabIndex = 8;
            this.lblInvalid.Text = "Một số trường chưa hợp lệ. Xin kiểm tra";
            this.lblInvalid.Visible = false;
            // 
            // frmAddUpdateSpeciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 265);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpecialtityFoundedYear);
            this.Controls.Add(this.txtSpecialityName);
            this.Controls.Add(this.txtSpecialityCode);
            this.Name = "frmAddUpdateSpeciality";
            this.Text = "frmAddUpdateKhoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddUpdateSpeciality_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddUpdateSpeciality_FormClosed);
            this.Load += new System.EventHandler(this.frmAddUpdateSpeciality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errSpeciality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpecialityCode;
        private System.Windows.Forms.TextBox txtSpecialityName;
        private System.Windows.Forms.TextBox txtSpecialtityFoundedYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ErrorProvider errSpeciality;
        private System.Windows.Forms.Label lblInvalid;
    }
}
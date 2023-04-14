namespace Student_Manager_System_FIT.UTEHY
{
    partial class ScheduleGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleGUI));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSchedule = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblErrorName = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbSemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.submitDelete = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errSubject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errClass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errTeacher = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errSemester = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbTeacher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblErName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberStudent = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.lblErrorName.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvSchedule);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 54);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(579, 445);
            this.guna2Panel2.TabIndex = 18;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchedule.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchedule.EnableHeadersVisualStyles = false;
            this.dgvSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.Location = new System.Drawing.Point(3, 0);
            this.dgvSchedule.Name = "dgvSchedule";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.DividerHeight = 5;
            this.dgvSchedule.RowTemplate.Height = 40;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(571, 442);
            this.dgvSchedule.TabIndex = 4;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSchedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSchedule.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSchedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSchedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvSchedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvSchedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSchedule.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSchedule.ThemeStyle.ReadOnly = false;
            this.dgvSchedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSchedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSchedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSchedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSchedule.ThemeStyle.RowsStyle.Height = 40;
            this.dgvSchedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvSchedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellClick);
            this.dgvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellContentClick);
            // 
            // lblErrorName
            // 
            this.lblErrorName.BorderColor = System.Drawing.Color.SlateGray;
            this.lblErrorName.Controls.Add(this.cbbSubject);
            this.lblErrorName.Controls.Add(this.cbbSemester);
            this.lblErrorName.Controls.Add(this.cbbClass);
            this.lblErrorName.Controls.Add(this.submitDelete);
            this.lblErrorName.Controls.Add(this.errSubject);
            this.lblErrorName.Controls.Add(this.errClass);
            this.lblErrorName.Controls.Add(this.errTeacher);
            this.lblErrorName.Controls.Add(this.errSemester);
            this.lblErrorName.Controls.Add(this.cbbTeacher);
            this.lblErrorName.Controls.Add(this.label8);
            this.lblErrorName.Controls.Add(this.label6);
            this.lblErrorName.Controls.Add(this.label5);
            this.lblErrorName.Controls.Add(this.lblDelete);
            this.lblErrorName.Controls.Add(this.lblErName);
            this.lblErrorName.Controls.Add(this.lblStatus);
            this.lblErrorName.Controls.Add(this.label7);
            this.lblErrorName.Controls.Add(this.btnSubmit);
            this.lblErrorName.Controls.Add(this.label4);
            this.lblErrorName.CustomBorderColor = System.Drawing.Color.Silver;
            this.lblErrorName.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblErrorName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblErrorName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.Location = new System.Drawing.Point(579, 54);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(314, 445);
            this.lblErrorName.TabIndex = 17;
            // 
            // cbbSubject
            // 
            this.cbbSubject.BackColor = System.Drawing.Color.Transparent;
            this.cbbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSubject.ItemHeight = 30;
            this.cbbSubject.Location = new System.Drawing.Point(103, 177);
            this.cbbSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(186, 36);
            this.cbbSubject.TabIndex = 45;
            // 
            // cbbSemester
            // 
            this.cbbSemester.BackColor = System.Drawing.Color.Transparent;
            this.cbbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSemester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSemester.ItemHeight = 30;
            this.cbbSemester.Location = new System.Drawing.Point(103, 115);
            this.cbbSemester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(186, 36);
            this.cbbSemester.TabIndex = 44;
            // 
            // cbbClass
            // 
            this.cbbClass.BackColor = System.Drawing.Color.Transparent;
            this.cbbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbClass.ItemHeight = 30;
            this.cbbClass.Location = new System.Drawing.Point(103, 60);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(186, 36);
            this.cbbClass.TabIndex = 43;
            // 
            // submitDelete
            // 
            this.submitDelete.BackColor = System.Drawing.Color.Transparent;
            this.submitDelete.ForeColor = System.Drawing.Color.Red;
            this.submitDelete.Location = new System.Drawing.Point(55, 306);
            this.submitDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitDelete.Name = "submitDelete";
            this.submitDelete.Size = new System.Drawing.Size(119, 15);
            this.submitDelete.TabIndex = 42;
            this.submitDelete.Text = "Bạn có chắc muốn xóa?";
            // 
            // errSubject
            // 
            this.errSubject.BackColor = System.Drawing.Color.Transparent;
            this.errSubject.ForeColor = System.Drawing.Color.Red;
            this.errSubject.Location = new System.Drawing.Point(52, 217);
            this.errSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errSubject.Name = "errSubject";
            this.errSubject.Size = new System.Drawing.Size(51, 15);
            this.errSubject.TabIndex = 41;
            this.errSubject.Text = "errSubject";
            // 
            // errClass
            // 
            this.errClass.BackColor = System.Drawing.Color.Transparent;
            this.errClass.ForeColor = System.Drawing.Color.Red;
            this.errClass.Location = new System.Drawing.Point(45, 94);
            this.errClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errClass.Name = "errClass";
            this.errClass.Size = new System.Drawing.Size(40, 15);
            this.errClass.TabIndex = 40;
            this.errClass.Text = "errClass";
            // 
            // errTeacher
            // 
            this.errTeacher.BackColor = System.Drawing.Color.Transparent;
            this.errTeacher.ForeColor = System.Drawing.Color.Red;
            this.errTeacher.Location = new System.Drawing.Point(55, 278);
            this.errTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errTeacher.Name = "errTeacher";
            this.errTeacher.Size = new System.Drawing.Size(55, 15);
            this.errTeacher.TabIndex = 39;
            this.errTeacher.Text = "errTeacher";
            // 
            // errSemester
            // 
            this.errSemester.BackColor = System.Drawing.Color.Transparent;
            this.errSemester.ForeColor = System.Drawing.Color.Red;
            this.errSemester.Location = new System.Drawing.Point(55, 153);
            this.errSemester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errSemester.Name = "errSemester";
            this.errSemester.Size = new System.Drawing.Size(59, 15);
            this.errSemester.TabIndex = 38;
            this.errSemester.Text = "errSemester";
            // 
            // cbbTeacher
            // 
            this.cbbTeacher.BackColor = System.Drawing.Color.Transparent;
            this.cbbTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTeacher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTeacher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTeacher.ItemHeight = 30;
            this.cbbTeacher.Location = new System.Drawing.Point(103, 236);
            this.cbbTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTeacher.Name = "cbbTeacher";
            this.cbbTeacher.Size = new System.Drawing.Size(186, 36);
            this.cbbTeacher.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Giáo viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Kỳ học";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.Red;
            this.lblDelete.Location = new System.Drawing.Point(7, 236);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(0, 19);
            this.lblDelete.TabIndex = 23;
            // 
            // lblErName
            // 
            this.lblErName.AutoSize = true;
            this.lblErName.ForeColor = System.Drawing.Color.Red;
            this.lblErName.Location = new System.Drawing.Point(17, 135);
            this.lblErName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErName.Name = "lblErName";
            this.lblErName.Size = new System.Drawing.Size(0, 15);
            this.lblErName.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblStatus.Location = new System.Drawing.Point(114, 315);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(150, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 20;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderRadius = 15;
            this.btnSubmit.BorderThickness = 1;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSubmit.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.btnSubmit.Location = new System.Drawing.Point(194, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 33);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lớp học";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnNew);
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.btnAdd);
            this.panelBottom.Controls.Add(this.editBtn);
            this.panelBottom.Controls.Add(this.deleteBtn);
            this.panelBottom.CustomBorderColor = System.Drawing.Color.Silver;
            this.panelBottom.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panelBottom.Location = new System.Drawing.Point(0, 499);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(893, 54);
            this.panelBottom.TabIndex = 16;
            // 
            // btnNew
            // 
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew.BorderRadius = 5;
            this.btnNew.BorderThickness = 1;
            this.btnNew.FillColor = System.Drawing.Color.Transparent;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(208, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 30);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(733, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(742, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(298, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // editBtn
            // 
            this.editBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editBtn.BorderRadius = 5;
            this.editBtn.BorderThickness = 1;
            this.editBtn.FillColor = System.Drawing.Color.Transparent;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(388, 13);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(84, 30);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Sửa";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteBtn.BorderRadius = 5;
            this.deleteBtn.BorderThickness = 1;
            this.deleteBtn.FillColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(478, 13);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(84, 30);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.guna2Button3);
            this.panelTop.Controls.Add(this.guna2Button2);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.numberStudent);
            this.panelTop.CustomBorderColor = System.Drawing.Color.Silver;
            this.panelTop.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(893, 54);
            this.panelTop.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 13;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtSearch.Location = new System.Drawing.Point(682, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(200, 28);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageSize = new System.Drawing.Size(14, 14);
            this.guna2Button3.Location = new System.Drawing.Point(362, 14);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(36, 28);
            this.guna2Button3.TabIndex = 6;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(12, 12);
            this.guna2Button2.Location = new System.Drawing.Point(419, 14);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(99, 28);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Lọc kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.Location = new System.Drawing.Point(70, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lịch học";
            // 
            // numberStudent
            // 
            this.numberStudent.AutoSize = true;
            this.numberStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.numberStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.numberStudent.Location = new System.Drawing.Point(17, 7);
            this.numberStudent.Name = "numberStudent";
            this.numberStudent.Size = new System.Drawing.Size(51, 36);
            this.numberStudent.TabIndex = 0;
            this.numberStudent.Text = "12";
            // 
            // ScheduleGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(893, 553);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ScheduleGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch học";
            this.Load += new System.EventHandler(this.ScheduleGUI_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.lblErrorName.ResumeLayout(false);
            this.lblErrorName.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSchedule;
        private Guna.UI2.WinForms.Guna2Panel lblErrorName;
        private Guna.UI2.WinForms.Guna2HtmlLabel submitDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel errSubject;
        private Guna.UI2.WinForms.Guna2HtmlLabel errClass;
        private Guna.UI2.WinForms.Guna2HtmlLabel errTeacher;
        private Guna.UI2.WinForms.Guna2HtmlLabel errSemester;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTeacher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblErName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberStudent;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSubject;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSemester;
        private Guna.UI2.WinForms.Guna2ComboBox cbbClass;
    }
}
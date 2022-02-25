namespace Medicine_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.修改 = new System.Windows.Forms.Button();
            this.员工信息维护_添加 = new System.Windows.Forms.Button();
            this.查询 = new System.Windows.Forms.Button();
            this.员工简介 = new System.Windows.Forms.RichTextBox();
            this.排班编号 = new System.Windows.Forms.TextBox();
            this.密码 = new System.Windows.Forms.TextBox();
            this.职称 = new System.Windows.Forms.TextBox();
            this.工作号 = new System.Windows.Forms.TextBox();
            this.所属科室 = new System.Windows.Forms.TextBox();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.查询排班 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label密码 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.排班表 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.排班表)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.BackgroundImage = global::Medicine_System.Properties.Resources.backimage2;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.修改);
            this.tabPage1.Controls.Add(this.员工信息维护_添加);
            this.tabPage1.Controls.Add(this.查询);
            this.tabPage1.Controls.Add(this.员工简介);
            this.tabPage1.Controls.Add(this.排班编号);
            this.tabPage1.Controls.Add(this.密码);
            this.tabPage1.Controls.Add(this.职称);
            this.tabPage1.Controls.Add(this.工作号);
            this.tabPage1.Controls.Add(this.所属科室);
            this.tabPage1.Controls.Add(this.姓名);
            this.tabPage1.Controls.Add(this.查询排班);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label密码);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.排班表);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1492, 752);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "员工信息维护";
            // 
            // 修改
            // 
            this.修改.Location = new System.Drawing.Point(485, 365);
            this.修改.Margin = new System.Windows.Forms.Padding(4);
            this.修改.Name = "修改";
            this.修改.Size = new System.Drawing.Size(159, 40);
            this.修改.TabIndex = 23;
            this.修改.Text = "修改信息";
            this.修改.UseVisualStyleBackColor = true;
            this.修改.Click += new System.EventHandler(this.修改_Click);
            // 
            // 员工信息维护_添加
            // 
            this.员工信息维护_添加.Location = new System.Drawing.Point(485, 160);
            this.员工信息维护_添加.Margin = new System.Windows.Forms.Padding(4);
            this.员工信息维护_添加.Name = "员工信息维护_添加";
            this.员工信息维护_添加.Size = new System.Drawing.Size(159, 43);
            this.员工信息维护_添加.TabIndex = 22;
            this.员工信息维护_添加.Text = "添加员工";
            this.员工信息维护_添加.UseVisualStyleBackColor = true;
            this.员工信息维护_添加.Click += new System.EventHandler(this.员工信息维护_添加_Click);
            // 
            // 查询
            // 
            this.查询.Location = new System.Drawing.Point(485, 264);
            this.查询.Margin = new System.Windows.Forms.Padding(4);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(159, 40);
            this.查询.TabIndex = 22;
            this.查询.Text = "查询员工";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // 员工简介
            // 
            this.员工简介.Location = new System.Drawing.Point(688, 53);
            this.员工简介.Margin = new System.Windows.Forms.Padding(4);
            this.员工简介.Name = "员工简介";
            this.员工简介.Size = new System.Drawing.Size(764, 444);
            this.员工简介.TabIndex = 16;
            this.员工简介.Text = resources.GetString("员工简介.Text");
            this.员工简介.TextChanged += new System.EventHandler(this.员工简介_TextChanged);
            // 
            // 排班编号
            // 
            this.排班编号.Location = new System.Drawing.Point(144, 463);
            this.排班编号.Margin = new System.Windows.Forms.Padding(4);
            this.排班编号.Name = "排班编号";
            this.排班编号.Size = new System.Drawing.Size(257, 34);
            this.排班编号.TabIndex = 14;
            // 
            // 密码
            // 
            this.密码.Location = new System.Drawing.Point(144, 381);
            this.密码.Margin = new System.Windows.Forms.Padding(4);
            this.密码.Name = "密码";
            this.密码.Size = new System.Drawing.Size(257, 34);
            this.密码.TabIndex = 13;
            // 
            // 职称
            // 
            this.职称.Location = new System.Drawing.Point(144, 299);
            this.职称.Margin = new System.Windows.Forms.Padding(4);
            this.职称.Name = "职称";
            this.职称.Size = new System.Drawing.Size(257, 34);
            this.职称.TabIndex = 13;
            // 
            // 工作号
            // 
            this.工作号.Location = new System.Drawing.Point(144, 53);
            this.工作号.Margin = new System.Windows.Forms.Padding(4);
            this.工作号.Name = "工作号";
            this.工作号.Size = new System.Drawing.Size(257, 34);
            this.工作号.TabIndex = 11;
            // 
            // 所属科室
            // 
            this.所属科室.Location = new System.Drawing.Point(144, 135);
            this.所属科室.Margin = new System.Windows.Forms.Padding(4);
            this.所属科室.Name = "所属科室";
            this.所属科室.Size = new System.Drawing.Size(257, 34);
            this.所属科室.TabIndex = 3;
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(144, 217);
            this.姓名.Margin = new System.Windows.Forms.Padding(4);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(257, 34);
            this.姓名.TabIndex = 2;
            // 
            // 查询排班
            // 
            this.查询排班.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询排班.Location = new System.Drawing.Point(485, 466);
            this.查询排班.Margin = new System.Windows.Forms.Padding(4);
            this.查询排班.Name = "查询排班";
            this.查询排班.Size = new System.Drawing.Size(159, 40);
            this.查询排班.TabIndex = 15;
            this.查询排班.Text = "查询排班";
            this.查询排班.UseVisualStyleBackColor = true;
            this.查询排班.Click += new System.EventHandler(this.查询排班_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(683, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "员工简介";
            // 
            // label密码
            // 
            this.label密码.AutoSize = true;
            this.label密码.BackColor = System.Drawing.Color.Transparent;
            this.label密码.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label密码.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label密码.Location = new System.Drawing.Point(71, 386);
            this.label密码.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label密码.Name = "label密码";
            this.label密码.Size = new System.Drawing.Size(64, 25);
            this.label密码.TabIndex = 6;
            this.label密码.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(19, 468);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "排班编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(71, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "职称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(71, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(19, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "所属科室";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "工作号";
            // 
            // 排班表
            // 
            this.排班表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.排班表.Location = new System.Drawing.Point(40, 524);
            this.排班表.Name = "排班表";
            this.排班表.RowTemplate.Height = 27;
            this.排班表.Size = new System.Drawing.Size(1429, 178);
            this.排班表.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 40);
            this.tabControl1.Location = new System.Drawing.Point(-3, -5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1500, 800);
            this.tabControl1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "管理员";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.排班表)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox 员工简介;
        private System.Windows.Forms.TextBox 排班编号;
        private System.Windows.Forms.TextBox 职称;
        private System.Windows.Forms.TextBox 工作号;
        private System.Windows.Forms.TextBox 所属科室;
        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.Button 查询排班;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.Button 修改;
        private System.Windows.Forms.DataGridView 排班表;
        private System.Windows.Forms.Button 员工信息维护_添加;
        private System.Windows.Forms.TextBox 密码;
        private System.Windows.Forms.Label label密码;

    }
}
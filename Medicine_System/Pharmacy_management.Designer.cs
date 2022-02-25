namespace Medicine_System
{
    partial class Pharmacy_management
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.发药 = new System.Windows.Forms.Button();
            this.门诊发药_查询 = new System.Windows.Forms.Button();
            this.数量表 = new System.Windows.Forms.DataGridView();
            this.药品名称表 = new System.Windows.Forms.DataGridView();
            this.病案号 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.备注 = new System.Windows.Forms.TextBox();
            this.基本单位名称 = new System.Windows.Forms.TextBox();
            this.单价 = new System.Windows.Forms.TextBox();
            this.库房名称 = new System.Windows.Forms.TextBox();
            this.规格 = new System.Windows.Forms.TextBox();
            this.类型 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.库房名称label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.添加 = new System.Windows.Forms.Button();
            this.查询 = new System.Windows.Forms.Button();
            this.药库表 = new System.Windows.Forms.DataGridView();
            this.数量 = new System.Windows.Forms.TextBox();
            this.药品名称 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.数量表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.药品名称表)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.药库表)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1267, 728);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Medicine_System.Properties.Resources.backimage2;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.发药);
            this.tabPage1.Controls.Add(this.门诊发药_查询);
            this.tabPage1.Controls.Add(this.数量表);
            this.tabPage1.Controls.Add(this.药品名称表);
            this.tabPage1.Controls.Add(this.病案号);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1259, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "门诊发药";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // 发药
            // 
            this.发药.Location = new System.Drawing.Point(741, 33);
            this.发药.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.发药.Name = "发药";
            this.发药.Size = new System.Drawing.Size(111, 41);
            this.发药.TabIndex = 9;
            this.发药.Text = "发药";
            this.发药.UseVisualStyleBackColor = true;
            this.发药.Click += new System.EventHandler(this.发药_Click);
            // 
            // 门诊发药_查询
            // 
            this.门诊发药_查询.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.门诊发药_查询.Location = new System.Drawing.Point(599, 33);
            this.门诊发药_查询.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.门诊发药_查询.Name = "门诊发药_查询";
            this.门诊发药_查询.Size = new System.Drawing.Size(117, 42);
            this.门诊发药_查询.TabIndex = 2;
            this.门诊发药_查询.Text = "查询";
            this.门诊发药_查询.UseVisualStyleBackColor = true;
            this.门诊发药_查询.Click += new System.EventHandler(this.门诊发药_查询_Click);
            // 
            // 数量表
            // 
            this.数量表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.数量表.Location = new System.Drawing.Point(690, 93);
            this.数量表.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.数量表.Name = "数量表";
            this.数量表.RowTemplate.Height = 27;
            this.数量表.Size = new System.Drawing.Size(319, 594);
            this.数量表.TabIndex = 8;
            // 
            // 药品名称表
            // 
            this.药品名称表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.药品名称表.Location = new System.Drawing.Point(200, 93);
            this.药品名称表.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.药品名称表.Name = "药品名称表";
            this.药品名称表.RowTemplate.Height = 27;
            this.药品名称表.Size = new System.Drawing.Size(319, 594);
            this.药品名称表.TabIndex = 8;
            // 
            // 病案号
            // 
            this.病案号.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.病案号.Location = new System.Drawing.Point(175, 37);
            this.病案号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.病案号.Name = "病案号";
            this.病案号.Size = new System.Drawing.Size(399, 34);
            this.病案号.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "病案号";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Medicine_System.Properties.Resources.backimage2;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.备注);
            this.tabPage2.Controls.Add(this.基本单位名称);
            this.tabPage2.Controls.Add(this.单价);
            this.tabPage2.Controls.Add(this.库房名称);
            this.tabPage2.Controls.Add(this.规格);
            this.tabPage2.Controls.Add(this.类型);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.库房名称label);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.添加);
            this.tabPage2.Controls.Add(this.查询);
            this.tabPage2.Controls.Add(this.药库表);
            this.tabPage2.Controls.Add(this.数量);
            this.tabPage2.Controls.Add(this.药品名称);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1259, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "库存管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // 备注
            // 
            this.备注.Location = new System.Drawing.Point(871, 95);
            this.备注.Margin = new System.Windows.Forms.Padding(4);
            this.备注.Name = "备注";
            this.备注.Size = new System.Drawing.Size(132, 34);
            this.备注.TabIndex = 8;
            // 
            // 基本单位名称
            // 
            this.基本单位名称.Location = new System.Drawing.Point(643, 95);
            this.基本单位名称.Margin = new System.Windows.Forms.Padding(4);
            this.基本单位名称.Name = "基本单位名称";
            this.基本单位名称.Size = new System.Drawing.Size(132, 34);
            this.基本单位名称.TabIndex = 6;
            // 
            // 单价
            // 
            this.单价.Location = new System.Drawing.Point(364, 95);
            this.单价.Margin = new System.Windows.Forms.Padding(4);
            this.单价.Name = "单价";
            this.单价.Size = new System.Drawing.Size(99, 34);
            this.单价.TabIndex = 4;
            // 
            // 库房名称
            // 
            this.库房名称.Location = new System.Drawing.Point(159, 95);
            this.库房名称.Margin = new System.Windows.Forms.Padding(4);
            this.库房名称.Name = "库房名称";
            this.库房名称.Size = new System.Drawing.Size(127, 34);
            this.库房名称.TabIndex = 2;
            // 
            // 规格
            // 
            this.规格.Location = new System.Drawing.Point(871, 46);
            this.规格.Margin = new System.Windows.Forms.Padding(4);
            this.规格.Name = "规格";
            this.规格.Size = new System.Drawing.Size(132, 34);
            this.规格.TabIndex = 7;
            // 
            // 类型
            // 
            this.类型.Location = new System.Drawing.Point(643, 46);
            this.类型.Margin = new System.Windows.Forms.Padding(4);
            this.类型.Name = "类型";
            this.类型.Size = new System.Drawing.Size(132, 34);
            this.类型.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(800, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(476, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "基本单位名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(293, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "单价";
            // 
            // 库房名称label
            // 
            this.库房名称label.AutoSize = true;
            this.库房名称label.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.库房名称label.Location = new System.Drawing.Point(45, 100);
            this.库房名称label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.库房名称label.Name = "库房名称label";
            this.库房名称label.Size = new System.Drawing.Size(116, 25);
            this.库房名称label.TabIndex = 8;
            this.库房名称label.Text = "库房名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(800, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "规格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(572, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "类型";
            // 
            // 添加
            // 
            this.添加.Location = new System.Drawing.Point(1112, 97);
            this.添加.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.添加.Name = "添加";
            this.添加.Size = new System.Drawing.Size(85, 31);
            this.添加.TabIndex = 10;
            this.添加.Text = "添加";
            this.添加.UseVisualStyleBackColor = true;
            this.添加.Click += new System.EventHandler(this.添加_Click);
            // 
            // 查询
            // 
            this.查询.Location = new System.Drawing.Point(1112, 48);
            this.查询.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(85, 31);
            this.查询.TabIndex = 9;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // 药库表
            // 
            this.药库表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.药库表.Location = new System.Drawing.Point(51, 149);
            this.药库表.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.药库表.Name = "药库表";
            this.药库表.RowTemplate.Height = 27;
            this.药库表.Size = new System.Drawing.Size(1140, 528);
            this.药库表.TabIndex = 11;
            // 
            // 数量
            // 
            this.数量.Location = new System.Drawing.Point(364, 46);
            this.数量.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.数量.Name = "数量";
            this.数量.Size = new System.Drawing.Size(99, 34);
            this.数量.TabIndex = 3;
            // 
            // 药品名称
            // 
            this.药品名称.Location = new System.Drawing.Point(157, 46);
            this.药品名称.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.药品名称.Name = "药品名称";
            this.药品名称.Size = new System.Drawing.Size(129, 34);
            this.药品名称.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(293, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(45, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "药品名称";
            // 
            // Pharmacy_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 721);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pharmacy_management";
            this.Text = "药房管理";
            this.Load += new System.EventHandler(this.Pharmacy_management_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.数量表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.药品名称表)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.药库表)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button 门诊发药_查询;
        private System.Windows.Forms.DataGridView 药品名称表;
        private System.Windows.Forms.TextBox 病案号;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button 添加;
        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.DataGridView 药库表;
        private System.Windows.Forms.TextBox 数量;
        private System.Windows.Forms.TextBox 药品名称;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 备注;
        private System.Windows.Forms.TextBox 基本单位名称;
        private System.Windows.Forms.TextBox 单价;
        private System.Windows.Forms.TextBox 库房名称;
        private System.Windows.Forms.TextBox 规格;
        private System.Windows.Forms.TextBox 类型;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label 库房名称label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView 数量表;
        private System.Windows.Forms.Button 发药;
    }
}


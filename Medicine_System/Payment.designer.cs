namespace Medicine_System
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.病案号 = new System.Windows.Forms.TextBox();
            this.发药表 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.支付金额 = new System.Windows.Forms.TextBox();
            this.查询 = new System.Windows.Forms.Button();
            this.确认 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.发药表)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "病案号";
            // 
            // 病案号
            // 
            this.病案号.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.病案号.Location = new System.Drawing.Point(176, 37);
            this.病案号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.病案号.Name = "病案号";
            this.病案号.Size = new System.Drawing.Size(325, 34);
            this.病案号.TabIndex = 1;
            // 
            // 发药表
            // 
            this.发药表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.发药表.Location = new System.Drawing.Point(61, 82);
            this.发药表.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.发药表.Name = "发药表";
            this.发药表.RowTemplate.Height = 27;
            this.发药表.Size = new System.Drawing.Size(1039, 378);
            this.发药表.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(843, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "需支付";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(982, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "       元";
            // 
            // 支付金额
            // 
            this.支付金额.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.支付金额.Location = new System.Drawing.Point(946, 471);
            this.支付金额.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.支付金额.Name = "支付金额";
            this.支付金额.Size = new System.Drawing.Size(100, 34);
            this.支付金额.TabIndex = 3;
            // 
            // 查询
            // 
            this.查询.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询.Location = new System.Drawing.Point(534, 34);
            this.查询.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(120, 40);
            this.查询.TabIndex = 2;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // 确认
            // 
            this.确认.Font = new System.Drawing.Font("宋体", 13.8F);
            this.确认.Location = new System.Drawing.Point(1125, 468);
            this.确认.Margin = new System.Windows.Forms.Padding(4);
            this.确认.Name = "确认";
            this.确认.Size = new System.Drawing.Size(120, 40);
            this.确认.TabIndex = 5;
            this.确认.Text = "确认";
            this.确认.UseVisualStyleBackColor = true;
            this.确认.Click += new System.EventHandler(this.确认_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Medicine_System.Properties.Resources.backimage2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 521);
            this.Controls.Add(this.确认);
            this.Controls.Add(this.查询);
            this.Controls.Add(this.支付金额);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.发药表);
            this.Controls.Add(this.病案号);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payment";
            this.Text = "收费";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.发药表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 病案号;
        private System.Windows.Forms.DataGridView 发药表;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 支付金额;
        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.Button 确认;
    }
}
namespace KN_Nhom1_PM10
{
    partial class FormMua
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
            this.btBan = new System.Windows.Forms.Button();
            this.btThemM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btXoaM = new System.Windows.Forms.Button();
            this.btSuaM = new System.Windows.Forms.Button();
            this.txtSDTM = new System.Windows.Forms.TextBox();
            this.txtDiaChiM = new System.Windows.Forms.TextBox();
            this.txtTenM = new System.Windows.Forms.TextBox();
            this.txtMaM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBan
            // 
            this.btBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBan.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBan.Location = new System.Drawing.Point(559, 305);
            this.btBan.Margin = new System.Windows.Forms.Padding(4);
            this.btBan.Name = "btBan";
            this.btBan.Size = new System.Drawing.Size(373, 98);
            this.btBan.TabIndex = 21;
            this.btBan.Text = "Ban";
            this.btBan.UseVisualStyleBackColor = false;
            this.btBan.Click += new System.EventHandler(this.btBan_Click);
            // 
            // btThemM
            // 
            this.btThemM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btThemM.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemM.Location = new System.Drawing.Point(25, 223);
            this.btThemM.Margin = new System.Windows.Forms.Padding(4);
            this.btThemM.Name = "btThemM";
            this.btThemM.Size = new System.Drawing.Size(101, 32);
            this.btThemM.TabIndex = 20;
            this.btThemM.Text = "Them";
            this.btThemM.UseVisualStyleBackColor = false;
            this.btThemM.Click += new System.EventHandler(this.btThemM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btXoaM);
            this.groupBox1.Controls.Add(this.btSuaM);
            this.groupBox1.Controls.Add(this.btThemM);
            this.groupBox1.Controls.Add(this.txtSDTM);
            this.groupBox1.Controls.Add(this.txtDiaChiM);
            this.groupBox1.Controls.Add(this.txtTenM);
            this.groupBox1.Controls.Add(this.txtMaM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(559, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 289);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "So Dien Thoai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dia Chi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ho Ten:";
            // 
            // btXoaM
            // 
            this.btXoaM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btXoaM.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaM.Location = new System.Drawing.Point(248, 223);
            this.btXoaM.Margin = new System.Windows.Forms.Padding(4);
            this.btXoaM.Name = "btXoaM";
            this.btXoaM.Size = new System.Drawing.Size(101, 32);
            this.btXoaM.TabIndex = 22;
            this.btXoaM.Text = "Xoa";
            this.btXoaM.UseVisualStyleBackColor = false;
            this.btXoaM.Click += new System.EventHandler(this.btXoaM_Click);
            // 
            // btSuaM
            // 
            this.btSuaM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btSuaM.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaM.Location = new System.Drawing.Point(139, 223);
            this.btSuaM.Margin = new System.Windows.Forms.Padding(4);
            this.btSuaM.Name = "btSuaM";
            this.btSuaM.Size = new System.Drawing.Size(101, 32);
            this.btSuaM.TabIndex = 21;
            this.btSuaM.Text = "Sua";
            this.btSuaM.UseVisualStyleBackColor = false;
            this.btSuaM.Click += new System.EventHandler(this.btSuaM_Click);
            // 
            // txtSDTM
            // 
            this.txtSDTM.Location = new System.Drawing.Point(157, 164);
            this.txtSDTM.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTM.Name = "txtSDTM";
            this.txtSDTM.Size = new System.Drawing.Size(192, 28);
            this.txtSDTM.TabIndex = 18;
            // 
            // txtDiaChiM
            // 
            this.txtDiaChiM.Location = new System.Drawing.Point(157, 119);
            this.txtDiaChiM.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiM.Name = "txtDiaChiM";
            this.txtDiaChiM.Size = new System.Drawing.Size(192, 28);
            this.txtDiaChiM.TabIndex = 17;
            // 
            // txtTenM
            // 
            this.txtTenM.Location = new System.Drawing.Point(157, 74);
            this.txtTenM.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenM.Name = "txtTenM";
            this.txtTenM.Size = new System.Drawing.Size(192, 28);
            this.txtTenM.TabIndex = 16;
            // 
            // txtMaM
            // 
            this.txtMaM.Location = new System.Drawing.Point(157, 29);
            this.txtMaM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaM.Name = "txtMaM";
            this.txtMaM.Size = new System.Drawing.Size(192, 28);
            this.txtMaM.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ma Nguoi Mua:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(530, 360);
            this.dataGridView1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nguoi Mua";
            // 
            // FormMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(940, 411);
            this.Controls.Add(this.btBan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Name = "FormMua";
            this.Text = "FormMua";
            this.Load += new System.EventHandler(this.FormMua_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBan;
        private System.Windows.Forms.Button btThemM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btXoaM;
        private System.Windows.Forms.Button btSuaM;
        private System.Windows.Forms.TextBox txtSDTM;
        private System.Windows.Forms.TextBox txtDiaChiM;
        private System.Windows.Forms.TextBox txtTenM;
        private System.Windows.Forms.TextBox txtMaM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}
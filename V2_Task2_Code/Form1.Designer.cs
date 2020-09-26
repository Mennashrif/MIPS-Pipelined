namespace archi_Template
{
    partial class Form1
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
            this.run = new System.Windows.Forms.Button();
            this.StartPCTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inializeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Memory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pipeline = new System.Windows.Forms.DataGridView();
            this.valueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MipsRegister = new System.Windows.Forms.DataGridView();
            this.UserCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipsRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(533, 465);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(145, 26);
            this.run.TabIndex = 23;
            this.run.Text = "Run 1 cycle";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // StartPCTxt
            // 
            this.StartPCTxt.Location = new System.Drawing.Point(53, 465);
            this.StartPCTxt.Name = "StartPCTxt";
            this.StartPCTxt.Size = new System.Drawing.Size(100, 20);
            this.StartPCTxt.TabIndex = 21;
            this.StartPCTxt.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "PC:";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // inializeBtn
            // 
            this.inializeBtn.Location = new System.Drawing.Point(249, 465);
            this.inializeBtn.Name = "inializeBtn";
            this.inializeBtn.Size = new System.Drawing.Size(145, 26);
            this.inializeBtn.TabIndex = 22;
            this.inializeBtn.Text = "initialization ";
            this.inializeBtn.UseVisualStyleBackColor = true;
            this.inializeBtn.Click += new System.EventHandler(this.inializeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(916, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data memory";
            // 
            // Memory
            // 
            this.Memory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Memory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.Memory.Location = new System.Drawing.Point(919, 55);
            this.Memory.Name = "Memory";
            this.Memory.ReadOnly = true;
            this.Memory.Size = new System.Drawing.Size(241, 373);
            this.Memory.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "pipeline registers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "MIPS registers";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Register";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pipeline
            // 
            this.pipeline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pipeline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.pipeline.Location = new System.Drawing.Point(646, 55);
            this.pipeline.Name = "pipeline";
            this.pipeline.ReadOnly = true;
            this.pipeline.Size = new System.Drawing.Size(241, 373);
            this.pipeline.TabIndex = 14;
            // 
            // valueCol
            // 
            this.valueCol.HeaderText = "Value";
            this.valueCol.Name = "valueCol";
            this.valueCol.ReadOnly = true;
            // 
            // registerCol
            // 
            this.registerCol.HeaderText = "Register";
            this.registerCol.Name = "registerCol";
            this.registerCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "user code";
            // 
            // MipsRegister
            // 
            this.MipsRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MipsRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerCol,
            this.valueCol});
            this.MipsRegister.Location = new System.Drawing.Point(362, 55);
            this.MipsRegister.Name = "MipsRegister";
            this.MipsRegister.ReadOnly = true;
            this.MipsRegister.Size = new System.Drawing.Size(242, 373);
            this.MipsRegister.TabIndex = 13;
            // 
            // UserCode
            // 
            this.UserCode.Location = new System.Drawing.Point(16, 55);
            this.UserCode.Multiline = true;
            this.UserCode.Name = "UserCode";
            this.UserCode.Size = new System.Drawing.Size(311, 373);
            this.UserCode.TabIndex = 12;
            this.UserCode.TextChanged += new System.EventHandler(this.UserCodetxt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 525);
            this.Controls.Add(this.run);
            this.Controls.Add(this.StartPCTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inializeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pipeline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MipsRegister);
            this.Controls.Add(this.UserCode);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipsRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox StartPCTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button inializeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Memory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView pipeline;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MipsRegister;
        private System.Windows.Forms.TextBox UserCode;
    }
}


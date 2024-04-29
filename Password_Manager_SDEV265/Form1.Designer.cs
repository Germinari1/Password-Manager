namespace Password_Manager_SDEV265
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(92, 22);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(294, 40);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Hello, Welcome!";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btn1);
            this.pnl1.Controls.Add(this.txb2);
            this.pnl1.Controls.Add(this.txb1);
            this.pnl1.Controls.Add(this.lbl3);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.lbl2);
            this.pnl1.Controls.Add(this.lbl1);
            this.pnl1.Location = new System.Drawing.Point(362, 65);
            this.pnl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(543, 411);
            this.pnl1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(218, 295);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 40);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Login";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(123, 245);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(301, 26);
            this.txb2.TabIndex = 6;
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(123, 160);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(301, 26);
            this.txb1.TabIndex = 3;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(116, 194);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(147, 36);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Password";
            this.lbl3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(116, 112);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(150, 36);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Username";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(998, 129);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(260, 294);
            this.dgv2.TabIndex = 11;
            this.dgv2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 977);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.pnl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView dgv2;
    }
}


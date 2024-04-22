namespace Password_Manager_SDEV265
{
    partial class Form4
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
            this.pnl3 = new System.Windows.Forms.Panel();
            this.lbl8 = new System.Windows.Forms.Label();
            this.btn4 = new System.Windows.Forms.Button();
            this.txb8 = new System.Windows.Forms.TextBox();
            this.txb7 = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl3
            // 
            this.pnl3.Controls.Add(this.lbl8);
            this.pnl3.Controls.Add(this.btn4);
            this.pnl3.Controls.Add(this.txb8);
            this.pnl3.Controls.Add(this.txb7);
            this.pnl3.Controls.Add(this.lbl7);
            this.pnl3.Controls.Add(this.label4);
            this.pnl3.Controls.Add(this.lbl6);
            this.pnl3.Controls.Add(this.lbl5);
            this.pnl3.Location = new System.Drawing.Point(222, 108);
            this.pnl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(480, 377);
            this.pnl3.TabIndex = 11;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(54, 57);
            this.lbl8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(305, 29);
            this.lbl8.TabIndex = 9;
            this.lbl8.Text = "accessing this password.";
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(146, 278);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(165, 40);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "Check credentials";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // txb8
            // 
            this.txb8.Location = new System.Drawing.Point(75, 225);
            this.txb8.Name = "txb8";
            this.txb8.Size = new System.Drawing.Size(331, 26);
            this.txb8.TabIndex = 6;
            // 
            // txb7
            // 
            this.txb7.Location = new System.Drawing.Point(75, 135);
            this.txb7.Name = "txb7";
            this.txb7.Size = new System.Drawing.Size(331, 26);
            this.txb7.TabIndex = 3;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(70, 198);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(89, 22);
            this.lbl7.TabIndex = 5;
            this.lbl7.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(70, 111);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(92, 22);
            this.lbl6.TabIndex = 3;
            this.lbl6.Text = "Username";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(48, 18);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(308, 29);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "Get Authentication before";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(746, 108);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(327, 171);
            this.dgv1.TabIndex = 10;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.dgv1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.TextBox txb8;
        private System.Windows.Forms.TextBox txb7;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.DataGridView dgv1;
    }
}
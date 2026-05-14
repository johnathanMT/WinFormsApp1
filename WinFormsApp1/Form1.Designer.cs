namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGreet = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radE = new System.Windows.Forms.RadioButton();
            this.radM = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGreet
            // 
            this.btnGreet.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGreet.Location = new System.Drawing.Point(286, 264);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(312, 78);
            this.btnGreet.TabIndex = 0;
            this.btnGreet.Text = "GREETING";
            this.btnGreet.UseVisualStyleBackColor = true;
            this.btnGreet.Click += new System.EventHandler(this.btnGreet_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(46, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(273, 46);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(318, 96);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(264, 51);
            this.textName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radE);
            this.groupBox1.Controls.Add(this.radM);
            this.groupBox1.Location = new System.Drawing.Point(319, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radE
            // 
            this.radE.AutoSize = true;
            this.radE.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radE.Location = new System.Drawing.Point(235, 21);
            this.radE.Name = "radE";
            this.radE.Size = new System.Drawing.Size(160, 49);
            this.radE.TabIndex = 1;
            this.radE.TabStop = true;
            this.radE.Text = "Evening";
            this.radE.UseVisualStyleBackColor = true;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radM.Location = new System.Drawing.Point(15, 21);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(170, 49);
            this.radM.TabIndex = 0;
            this.radM.TabStop = true;
            this.radM.Text = "Morning";
            this.radM.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(46, 178);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(192, 45);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Select Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGreet);
            this.Name = "Form1";
            this.Text = "First Window Application Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGreet;
        private Label lblName;
        private TextBox textName;
        private GroupBox groupBox1;
        private RadioButton radE;
        private RadioButton radM;
        private Label lblTime;
    }
}
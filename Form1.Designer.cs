namespace TemperatureConverter
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.chckbxSwitch = new System.Windows.Forms.CheckBox();
            this.pnlAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(150, 184);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(109, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlAnswer.Controls.Add(this.lblAnswer);
            this.pnlAnswer.Location = new System.Drawing.Point(479, 184);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(287, 100);
            this.pnlAnswer.TabIndex = 2;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(61, 21);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(166, 51);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "Answer";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(150, 224);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(109, 35);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(265, 184);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(61, 17);
            this.lblUnit1.TabIndex = 5;
            this.lblUnit1.Text = "°C  to °F";
            // 
            // chckbxSwitch
            // 
            this.chckbxSwitch.AutoSize = true;
            this.chckbxSwitch.Location = new System.Drawing.Point(170, 265);
            this.chckbxSwitch.Name = "chckbxSwitch";
            this.chckbxSwitch.Size = new System.Drawing.Size(70, 21);
            this.chckbxSwitch.TabIndex = 6;
            this.chckbxSwitch.Text = "Switch";
            this.chckbxSwitch.UseVisualStyleBackColor = true;
            this.chckbxSwitch.CheckedChanged += new System.EventHandler(this.chckbxSwitch_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chckbxSwitch);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.pnlAnswer);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAnswer.ResumeLayout(false);
            this.pnlAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Panel pnlAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.CheckBox chckbxSwitch;
    }
}

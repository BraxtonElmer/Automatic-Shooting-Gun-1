namespace Automatic_shooting_gun
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.shootBtn = new System.Windows.Forms.Button();
            this.emerStopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // shootBtn
            // 
            this.shootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootBtn.Location = new System.Drawing.Point(141, 120);
            this.shootBtn.Name = "shootBtn";
            this.shootBtn.Size = new System.Drawing.Size(91, 30);
            this.shootBtn.TabIndex = 0;
            this.shootBtn.Text = "SHOOT";
            this.shootBtn.UseVisualStyleBackColor = true;
            this.shootBtn.Click += new System.EventHandler(this.shootBtn_Click);
            // 
            // emerStopBtn
            // 
            this.emerStopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emerStopBtn.Location = new System.Drawing.Point(88, 176);
            this.emerStopBtn.Name = "emerStopBtn";
            this.emerStopBtn.Size = new System.Drawing.Size(208, 42);
            this.emerStopBtn.TabIndex = 1;
            this.emerStopBtn.Text = "Emergency Stop Button";
            this.emerStopBtn.UseVisualStyleBackColor = true;
            this.emerStopBtn.Click += new System.EventHandler(this.emerStopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 319);
            this.Controls.Add(this.emerStopBtn);
            this.Controls.Add(this.shootBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button shootBtn;
        private System.Windows.Forms.Button emerStopBtn;
    }
}


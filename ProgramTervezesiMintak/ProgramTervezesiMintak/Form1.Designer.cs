namespace ProgramTervezesiMintak
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBall = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBallColor = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnPresenWrappingColor = new System.Windows.Forms.Button();
            this.btnPresentRibbonColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 188);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 259);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnBall
            // 
            this.btnBall.Location = new System.Drawing.Point(0, -3);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(75, 23);
            this.btnBall.TabIndex = 1;
            this.btnBall.Text = "Ball";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.btnBall_Click);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(82, -3);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(75, 23);
            this.btnCar.TabIndex = 2;
            this.btnCar.Text = "Car";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming next:";
            // 
            // btnBallColor
            // 
            this.btnBallColor.BackColor = System.Drawing.Color.Red;
            this.btnBallColor.Location = new System.Drawing.Point(0, 27);
            this.btnBallColor.Name = "btnBallColor";
            this.btnBallColor.Size = new System.Drawing.Size(75, 23);
            this.btnBallColor.TabIndex = 4;
            this.btnBallColor.UseVisualStyleBackColor = false;
            this.btnBallColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(164, -3);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(75, 23);
            this.btnPresent.TabIndex = 5;
            this.btnPresent.Text = "Present";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btnPresenWrappingColor
            // 
            this.btnPresenWrappingColor.BackColor = System.Drawing.Color.Red;
            this.btnPresenWrappingColor.Location = new System.Drawing.Point(164, 27);
            this.btnPresenWrappingColor.Name = "btnPresenWrappingColor";
            this.btnPresenWrappingColor.Size = new System.Drawing.Size(75, 23);
            this.btnPresenWrappingColor.TabIndex = 6;
            this.btnPresenWrappingColor.UseVisualStyleBackColor = false;
            this.btnPresenWrappingColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // btnPresentRibbonColor
            // 
            this.btnPresentRibbonColor.BackColor = System.Drawing.Color.Yellow;
            this.btnPresentRibbonColor.Location = new System.Drawing.Point(164, 59);
            this.btnPresentRibbonColor.Name = "btnPresentRibbonColor";
            this.btnPresentRibbonColor.Size = new System.Drawing.Size(75, 23);
            this.btnPresentRibbonColor.TabIndex = 7;
            this.btnPresentRibbonColor.UseVisualStyleBackColor = false;
            this.btnPresentRibbonColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPresentRibbonColor);
            this.Controls.Add(this.btnPresenWrappingColor);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.btnBallColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBallColor;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnPresenWrappingColor;
        private System.Windows.Forms.Button btnPresentRibbonColor;
    }
}


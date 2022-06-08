namespace Doube_Pendulum
{
    partial class Main_window
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.a1_slider = new System.Windows.Forms.TrackBar();
            this.a2_slider = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m2_slider = new System.Windows.Forms.TrackBar();
            this.m1_slider = new System.Windows.Forms.TrackBar();
            this.r2_slider = new System.Windows.Forms.TrackBar();
            this.r1_slider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.a1_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2_slider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m2_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 15;
            this.Timer.Tick += new System.EventHandler(this.Update);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1335, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Stop);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1479, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Start);
            // 
            // a1_slider
            // 
            this.a1_slider.Location = new System.Drawing.Point(40, 26);
            this.a1_slider.Maximum = 200;
            this.a1_slider.Minimum = -200;
            this.a1_slider.Name = "a1_slider";
            this.a1_slider.Size = new System.Drawing.Size(285, 90);
            this.a1_slider.TabIndex = 2;
            this.a1_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.a1_slider.Value = 100;
            this.a1_slider.ValueChanged += new System.EventHandler(this.a1_change);
            // 
            // a2_slider
            // 
            this.a2_slider.Location = new System.Drawing.Point(40, 97);
            this.a2_slider.Maximum = 200;
            this.a2_slider.Minimum = -200;
            this.a2_slider.Name = "a2_slider";
            this.a2_slider.Size = new System.Drawing.Size(285, 90);
            this.a2_slider.TabIndex = 8;
            this.a2_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.a2_slider.Value = 150;
            this.a2_slider.ValueChanged += new System.EventHandler(this.a2_change);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m2_slider);
            this.panel1.Controls.Add(this.m1_slider);
            this.panel1.Controls.Add(this.r2_slider);
            this.panel1.Controls.Add(this.r1_slider);
            this.panel1.Controls.Add(this.a2_slider);
            this.panel1.Controls.Add(this.a1_slider);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1625, 1649);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1198, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Clear);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lenght";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Angle";
            // 
            // m2_slider
            // 
            this.m2_slider.Location = new System.Drawing.Point(639, 97);
            this.m2_slider.Maximum = 200;
            this.m2_slider.Minimum = 5;
            this.m2_slider.Name = "m2_slider";
            this.m2_slider.Size = new System.Drawing.Size(285, 90);
            this.m2_slider.TabIndex = 12;
            this.m2_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m2_slider.Value = 30;
            this.m2_slider.ValueChanged += new System.EventHandler(this.m2_Change);
            // 
            // m1_slider
            // 
            this.m1_slider.Location = new System.Drawing.Point(639, 26);
            this.m1_slider.Maximum = 200;
            this.m1_slider.Minimum = 5;
            this.m1_slider.Name = "m1_slider";
            this.m1_slider.Size = new System.Drawing.Size(285, 90);
            this.m1_slider.TabIndex = 11;
            this.m1_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m1_slider.Value = 30;
            this.m1_slider.ValueChanged += new System.EventHandler(this.m1_change);
            // 
            // r2_slider
            // 
            this.r2_slider.Location = new System.Drawing.Point(348, 97);
            this.r2_slider.Maximum = 200;
            this.r2_slider.Minimum = 1;
            this.r2_slider.Name = "r2_slider";
            this.r2_slider.Size = new System.Drawing.Size(285, 90);
            this.r2_slider.TabIndex = 10;
            this.r2_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.r2_slider.Value = 150;
            this.r2_slider.ValueChanged += new System.EventHandler(this.r2_change);
            // 
            // r1_slider
            // 
            this.r1_slider.Location = new System.Drawing.Point(348, 26);
            this.r1_slider.Maximum = 200;
            this.r1_slider.Minimum = 1;
            this.r1_slider.Name = "r1_slider";
            this.r1_slider.Size = new System.Drawing.Size(285, 90);
            this.r1_slider.TabIndex = 9;
            this.r1_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.r1_slider.Value = 150;
            this.r1_slider.ValueChanged += new System.EventHandler(this.r1_change);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 1649);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Double Pendulum";
            ((System.ComponentModel.ISupportInitialize)(this.a1_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2_slider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m2_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1_slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar a1_slider;
        private System.Windows.Forms.TrackBar a2_slider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar m2_slider;
        private System.Windows.Forms.TrackBar m1_slider;
        private System.Windows.Forms.TrackBar r2_slider;
        private System.Windows.Forms.TrackBar r1_slider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}


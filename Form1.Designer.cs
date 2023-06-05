namespace ShutdownTimer
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
            this.button1 = new System.Windows.Forms.Button();
            this.HourUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.SecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createTimer);
            // 
            // HourUpDown
            // 
            this.HourUpDown.AccessibleName = "";
            this.HourUpDown.AllowDrop = true;
            this.HourUpDown.Location = new System.Drawing.Point(95, 89);
            this.HourUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HourUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HourUpDown.Name = "HourUpDown";
            this.HourUpDown.Size = new System.Drawing.Size(149, 22);
            this.HourUpDown.TabIndex = 3;
            this.HourUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MinuteUpDown
            // 
            this.MinuteUpDown.Location = new System.Drawing.Point(95, 137);
            this.MinuteUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinuteUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinuteUpDown.Name = "MinuteUpDown";
            this.MinuteUpDown.Size = new System.Drawing.Size(149, 22);
            this.MinuteUpDown.TabIndex = 4;
            // 
            // SecondUpDown
            // 
            this.SecondUpDown.Location = new System.Drawing.Point(95, 183);
            this.SecondUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecondUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SecondUpDown.Name = "SecondUpDown";
            this.SecondUpDown.Size = new System.Drawing.Size(149, 22);
            this.SecondUpDown.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kill Timer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.killTimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hours";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seconds";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(286, 139);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Restart";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 338);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SecondUpDown);
            this.Controls.Add(this.MinuteUpDown);
            this.Controls.Add(this.HourUpDown);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "TimerUtility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown HourUpDown;
        private System.Windows.Forms.NumericUpDown MinuteUpDown;
        private System.Windows.Forms.NumericUpDown SecondUpDown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


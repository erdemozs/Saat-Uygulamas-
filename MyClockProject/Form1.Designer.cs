namespace MyClockProject
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
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.numSecond = new System.Windows.Forms.NumericUpDown();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(61, 22);
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(86, 20);
            this.numHour.TabIndex = 0;
            this.numHour.ValueChanged += new System.EventHandler(this.numHour_ValueChanged);
            // 
            // numMinute
            // 
            this.numMinute.Location = new System.Drawing.Point(153, 22);
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(86, 20);
            this.numMinute.TabIndex = 1;
            this.numMinute.ValueChanged += new System.EventHandler(this.numMinute_ValueChanged);
            // 
            // numSecond
            // 
            this.numSecond.Location = new System.Drawing.Point(245, 22);
            this.numSecond.Name = "numSecond";
            this.numSecond.Size = new System.Drawing.Size(86, 20);
            this.numSecond.TabIndex = 2;
            this.numSecond.ValueChanged += new System.EventHandler(this.numSecond_ValueChanged);
            // 
            // btnAdjust
            // 
            this.btnAdjust.Location = new System.Drawing.Point(61, 85);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust.TabIndex = 3;
            this.btnAdjust.Text = "Adjust";
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.IncreaseTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 147);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.numSecond);
            this.Controls.Add(this.numMinute);
            this.Controls.Add(this.numHour);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.NumericUpDown numSecond;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.Timer timer1;
    }
}


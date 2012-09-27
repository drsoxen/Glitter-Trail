namespace Gif
{
    partial class Manager
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
            this.numericUpDown_NumberOfFollowers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfFollowers)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_NumberOfFollowers
            // 
            this.numericUpDown_NumberOfFollowers.Location = new System.Drawing.Point(160, 12);
            this.numericUpDown_NumberOfFollowers.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_NumberOfFollowers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_NumberOfFollowers.Name = "numericUpDown_NumberOfFollowers";
            this.numericUpDown_NumberOfFollowers.Size = new System.Drawing.Size(93, 20);
            this.numericUpDown_NumberOfFollowers.TabIndex = 1;
            this.numericUpDown_NumberOfFollowers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_NumberOfFollowers.ValueChanged += new System.EventHandler(this.numericUpDown_NumberOfFollowers_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Following Images";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "Change Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 145);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_NumberOfFollowers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Manager";
            this.Text = "MouseFollow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfFollowers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_NumberOfFollowers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;

    }
}


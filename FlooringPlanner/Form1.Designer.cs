namespace FlooringPlanner
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
            this.boardLayoutControl1 = new FlooringPlanner.BoardLayoutControl();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.reverseCheckBox1 = new System.Windows.Forms.CheckBox();
            this.reverseCheckBox2 = new System.Windows.Forms.CheckBox();
            this.reverseCheckBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // boardLayoutControl1
            // 
            this.boardLayoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardLayoutControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boardLayoutControl1.Location = new System.Drawing.Point(0, 147);
            this.boardLayoutControl1.Name = "boardLayoutControl1";
            this.boardLayoutControl1.Size = new System.Drawing.Size(532, 564);
            this.boardLayoutControl1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(66, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(466, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.Location = new System.Drawing.Point(66, 49);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(466, 45);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar3.Location = new System.Drawing.Point(66, 96);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(466, 45);
            this.trackBar3.TabIndex = 5;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // reverseCheckBox1
            // 
            this.reverseCheckBox1.AutoSize = true;
            this.reverseCheckBox1.Location = new System.Drawing.Point(12, 2);
            this.reverseCheckBox1.Name = "reverseCheckBox1";
            this.reverseCheckBox1.Size = new System.Drawing.Size(48, 19);
            this.reverseCheckBox1.TabIndex = 7;
            this.reverseCheckBox1.Text = "Rev.";
            this.reverseCheckBox1.UseVisualStyleBackColor = true;
            this.reverseCheckBox1.CheckedChanged += new System.EventHandler(this.reverseCheckBox_CheckedChanged);
            // 
            // reverseCheckBox2
            // 
            this.reverseCheckBox2.AutoSize = true;
            this.reverseCheckBox2.Location = new System.Drawing.Point(12, 49);
            this.reverseCheckBox2.Name = "reverseCheckBox2";
            this.reverseCheckBox2.Size = new System.Drawing.Size(48, 19);
            this.reverseCheckBox2.TabIndex = 8;
            this.reverseCheckBox2.Text = "Rev.";
            this.reverseCheckBox2.UseVisualStyleBackColor = true;
            this.reverseCheckBox2.CheckedChanged += new System.EventHandler(this.reverseCheckBox_CheckedChanged);
            // 
            // reverseCheckBox3
            // 
            this.reverseCheckBox3.AutoSize = true;
            this.reverseCheckBox3.Location = new System.Drawing.Point(12, 96);
            this.reverseCheckBox3.Name = "reverseCheckBox3";
            this.reverseCheckBox3.Size = new System.Drawing.Size(48, 19);
            this.reverseCheckBox3.TabIndex = 9;
            this.reverseCheckBox3.Text = "Rev.";
            this.reverseCheckBox3.UseVisualStyleBackColor = true;
            this.reverseCheckBox3.CheckedChanged += new System.EventHandler(this.reverseCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 711);
            this.Controls.Add(this.reverseCheckBox3);
            this.Controls.Add(this.reverseCheckBox2);
            this.Controls.Add(this.reverseCheckBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.boardLayoutControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flooring Planner";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BoardLayoutControl boardLayoutControl1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar trackBar3;
        private CheckBox reverseCheckBox1;
        private CheckBox reverseCheckBox2;
        private CheckBox reverseCheckBox3;
    }
}
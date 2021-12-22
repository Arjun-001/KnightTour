namespace ChessAssignmentWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rich = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfTimes = new System.Windows.Forms.NumericUpDown();
            this.intelligent = new System.Windows.Forms.RadioButton();
            this.simple = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.posOn = new System.Windows.Forms.RadioButton();
            this.posOff = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.columns = new System.Windows.Forms.NumericUpDown();
            this.rows = new System.Windows.Forms.NumericUpDown();
            this.Lcols = new System.Windows.Forms.Label();
            this.Lrows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTimes)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).BeginInit();
            this.SuspendLayout();
            // 
            // rich
            // 
            this.rich.BackColor = System.Drawing.SystemColors.Window;
            this.rich.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich.Location = new System.Drawing.Point(12, 12);
            this.rich.Name = "rich";
            this.rich.Size = new System.Drawing.Size(526, 599);
            this.rich.TabIndex = 1;
            this.rich.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of times";
            // 
            // numberOfTimes
            // 
            this.numberOfTimes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numberOfTimes.Location = new System.Drawing.Point(72, 64);
            this.numberOfTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfTimes.Name = "numberOfTimes";
            this.numberOfTimes.Size = new System.Drawing.Size(54, 20);
            this.numberOfTimes.TabIndex = 1;
            this.numberOfTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // intelligent
            // 
            this.intelligent.AutoSize = true;
            this.intelligent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intelligent.Location = new System.Drawing.Point(3, 150);
            this.intelligent.Name = "intelligent";
            this.intelligent.Size = new System.Drawing.Size(89, 19);
            this.intelligent.TabIndex = 2;
            this.intelligent.Text = "Intelligent";
            this.intelligent.UseVisualStyleBackColor = true;
            // 
            // simple
            // 
            this.simple.AutoSize = true;
            this.simple.Checked = true;
            this.simple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simple.Location = new System.Drawing.Point(92, 150);
            this.simple.Name = "simple";
            this.simple.Size = new System.Drawing.Size(120, 19);
            this.simple.TabIndex = 3;
            this.simple.TabStop = true;
            this.simple.Text = "Non-Intelligent";
            this.simple.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type of method";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 95);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do you wish to provide the position of the kngiht?(If not, then the position of t" +
    "he knight will be random)";
            // 
            // posOn
            // 
            this.posOn.AutoSize = true;
            this.posOn.Location = new System.Drawing.Point(6, 19);
            this.posOn.Name = "posOn";
            this.posOn.Size = new System.Drawing.Size(43, 17);
            this.posOn.TabIndex = 6;
            this.posOn.Text = "Yes";
            this.posOn.UseVisualStyleBackColor = true;
            this.posOn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // posOff
            // 
            this.posOff.AutoSize = true;
            this.posOff.Checked = true;
            this.posOff.Location = new System.Drawing.Point(84, 19);
            this.posOff.Name = "posOff";
            this.posOff.Size = new System.Drawing.Size(39, 17);
            this.posOff.TabIndex = 7;
            this.posOff.TabStop = true;
            this.posOff.Text = "No";
            this.posOff.UseVisualStyleBackColor = true;
            this.posOff.CheckedChanged += new System.EventHandler(this.posOff_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.columns);
            this.panel1.Controls.Add(this.rows);
            this.panel1.Controls.Add(this.Lcols);
            this.panel1.Controls.Add(this.Lrows);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.simple);
            this.panel1.Controls.Add(this.intelligent);
            this.panel1.Controls.Add(this.numberOfTimes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(574, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 599);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.posOn);
            this.groupBox1.Controls.Add(this.posOff);
            this.groupBox1.Location = new System.Drawing.Point(10, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columns
            // 
            this.columns.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.columns.Location = new System.Drawing.Point(155, 342);
            this.columns.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(54, 20);
            this.columns.TabIndex = 11;
            this.columns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columns.Visible = false;
            // 
            // rows
            // 
            this.rows.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rows.Location = new System.Drawing.Point(44, 342);
            this.rows.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(54, 20);
            this.rows.TabIndex = 10;
            this.rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rows.Visible = false;
            // 
            // Lcols
            // 
            this.Lcols.AutoSize = true;
            this.Lcols.Location = new System.Drawing.Point(102, 344);
            this.Lcols.Name = "Lcols";
            this.Lcols.Size = new System.Drawing.Size(47, 13);
            this.Lcols.TabIndex = 9;
            this.Lcols.Text = "Columns";
            this.Lcols.Visible = false;
            // 
            // Lrows
            // 
            this.Lrows.AutoSize = true;
            this.Lrows.Location = new System.Drawing.Point(7, 344);
            this.Lrows.Name = "Lrows";
            this.Lrows.Size = new System.Drawing.Size(34, 13);
            this.Lrows.TabIndex = 8;
            this.Lrows.Text = "Rows";
            this.Lrows.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.rich);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTimes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfTimes;
        private System.Windows.Forms.RadioButton intelligent;
        private System.Windows.Forms.RadioButton simple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton posOn;
        private System.Windows.Forms.RadioButton posOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown columns;
        private System.Windows.Forms.NumericUpDown rows;
        private System.Windows.Forms.Label Lcols;
        private System.Windows.Forms.Label Lrows;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


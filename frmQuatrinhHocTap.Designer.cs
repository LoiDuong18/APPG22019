namespace AppG2.View
{
    partial class frmQuatrinhHocTap
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
            this.numTunam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numDennam = new System.Windows.Forms.NumericUpDown();
            this.txtNoihoc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btndongy = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTunam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDennam)).BeginInit();
            this.SuspendLayout();
            // 
            // numTunam
            // 
            this.numTunam.Location = new System.Drawing.Point(134, 36);
            this.numTunam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numTunam.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numTunam.Name = "numTunam";
            this.numTunam.Size = new System.Drawing.Size(112, 20);
            this.numTunam.TabIndex = 0;
            this.numTunam.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến năm";
            // 
            // numDennam
            // 
            this.numDennam.Location = new System.Drawing.Point(134, 101);
            this.numDennam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numDennam.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numDennam.Name = "numDennam";
            this.numDennam.Size = new System.Drawing.Size(112, 20);
            this.numDennam.TabIndex = 2;
            this.numDennam.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numDennam.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // txtNoihoc
            // 
            this.txtNoihoc.AutoSize = true;
            this.txtNoihoc.Location = new System.Drawing.Point(39, 162);
            this.txtNoihoc.Name = "txtNoihoc";
            this.txtNoihoc.Size = new System.Drawing.Size(44, 13);
            this.txtNoihoc.TabIndex = 4;
            this.txtNoihoc.Text = "Nơi học";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 162);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 172);
            this.textBox1.TabIndex = 5;
            // 
            // btndongy
            // 
            this.btndongy.Image = global::AppG2.Properties.Resources.update;
            this.btndongy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndongy.Location = new System.Drawing.Point(290, 350);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(82, 35);
            this.btndongy.TabIndex = 6;
            this.btndongy.Text = "Đồng Ý";
            this.btndongy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.Btndongy_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnboqua.Image = global::AppG2.Properties.Resources.delete;
            this.btnboqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboqua.Location = new System.Drawing.Point(392, 350);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(82, 35);
            this.btnboqua.TabIndex = 7;
            this.btnboqua.Text = "Bỏ Qua";
            this.btnboqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // frmQuatrinhHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnboqua;
            this.ClientSize = new System.Drawing.Size(483, 391);
            this.ControlBox = false;
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNoihoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDennam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTunam);
            this.Name = "frmQuatrinhHocTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm mới/Chỉnh sữa quá trình học tập";
            this.Load += new System.EventHandler(this.FrmQuatrinhHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTunam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDennam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTunam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDennam;
        private System.Windows.Forms.Label txtNoihoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.Button btnboqua;
    }
}
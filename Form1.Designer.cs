namespace GPACalculator
{
    partial class Form1
    {
        /// <summary>
        ///  จำเป็นสำหรับตัวออกแบบฟอร์ม
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  ทำลายทรัพยากรที่กำลังใช้อยู่
        /// </summary>
        /// <param name="disposing">ค่า true ถ้าต้องการกำจัดทรัพยากรที่ถูกใช้</param>
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
        ///  เมธอดสำหรับออกแบบ UI
        /// </summary>
        private void InitializeComponent()
        {
            txtGrade = new TextBox();
            btnAddGrade = new Button();
            lstGrades = new ListBox();
            lblMaxGrade = new Label();
            lblMinGrade = new Label();
            lblGPAx = new Label();
            lblStudentCount = new Label();
            ใส่เกรดเฉลี่ย = new Label();
            SuspendLayout();
            // 
            // txtGrade
            // 
            txtGrade.Font = new Font("Segoe UI", 12F);
            txtGrade.Location = new Point(232, 32);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 29);
            txtGrade.TabIndex = 0;
            // 
            // btnAddGrade
            // 
            btnAddGrade.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddGrade.Location = new Point(350, 30);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(120, 30);
            btnAddGrade.TabIndex = 1;
            btnAddGrade.Text = "เพิ่มเกรด";
            btnAddGrade.UseVisualStyleBackColor = true;
            btnAddGrade.Click += btnAddGrade_Click;
            // 
            // lstGrades
            // 
            lstGrades.Font = new Font("Segoe UI", 12F);
            lstGrades.FormattingEnabled = true;
            lstGrades.ItemHeight = 21;
            lstGrades.Location = new Point(221, 83);
            lstGrades.Name = "lstGrades";
            lstGrades.Size = new Size(120, 130);
            lstGrades.TabIndex = 2;
            // 
            // lblMaxGrade
            // 
            lblMaxGrade.AutoSize = true;
            lblMaxGrade.Font = new Font("Segoe UI", 12F);
            lblMaxGrade.Location = new Point(194, 226);
            lblMaxGrade.Name = "lblMaxGrade";
            lblMaxGrade.Size = new Size(98, 21);
            lblMaxGrade.TabIndex = 3;
            lblMaxGrade.Text = "คะแนนสูงสุด: -";
            // 
            // lblMinGrade
            // 
            lblMinGrade.AutoSize = true;
            lblMinGrade.Font = new Font("Segoe UI", 12F);
            lblMinGrade.Location = new Point(193, 256);
            lblMinGrade.Name = "lblMinGrade";
            lblMinGrade.Size = new Size(99, 21);
            lblMinGrade.TabIndex = 4;
            lblMinGrade.Text = "คะแนนต่ำสุด: -";
            // 
            // lblGPAx
            // 
            lblGPAx.AutoSize = true;
            lblGPAx.Font = new Font("Segoe UI", 12F);
            lblGPAx.Location = new Point(205, 287);
            lblGPAx.Name = "lblGPAx";
            lblGPAx.Size = new Size(59, 21);
            lblGPAx.TabIndex = 5;
            lblGPAx.Text = "GPAx: -";
            // 
            // lblStudentCount
            // 
            lblStudentCount.AutoSize = true;
            lblStudentCount.Font = new Font("Segoe UI", 12F);
            lblStudentCount.Location = new Point(193, 319);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new Size(87, 21);
            lblStudentCount.TabIndex = 6;
            lblStudentCount.Text = "จำนวนคน: 0";
            // 
            // ใส่เกรดเฉลี่ย
            // 
            ใส่เกรดเฉลี่ย.AutoSize = true;
            ใส่เกรดเฉลี่ย.Location = new Point(130, 38);
            ใส่เกรดเฉลี่ย.Name = "ใส่เกรดเฉลี่ย";
            ใส่เกรดเฉลี่ย.Size = new Size(76, 19);
            ใส่เกรดเฉลี่ย.TabIndex = 7;
            ใส่เกรดเฉลี่ย.Text = "ใส่เกรดเฉลี่ย";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 386);
            Controls.Add(ใส่เกรดเฉลี่ย);
            Controls.Add(lblStudentCount);
            Controls.Add(lblGPAx);
            Controls.Add(lblMinGrade);
            Controls.Add(lblMaxGrade);
            Controls.Add(lstGrades);
            Controls.Add(btnAddGrade);
            Controls.Add(txtGrade);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GPA Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.ListBox lstGrades;
        private System.Windows.Forms.Label lblMaxGrade;
        private System.Windows.Forms.Label lblMinGrade;
        private System.Windows.Forms.Label lblGPAx;
        private System.Windows.Forms.Label lblStudentCount;
        private Label ใส่เกรดเฉลี่ย;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class Form1 : Form
    {
        private List<double> grades = new List<double>(); // เก็บค่าคะแนน

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtGrade.Text, out double grade))
            {
                if (grade >= 0 && grade <= 4.0) // ตรวจสอบว่าคะแนนอยู่ในช่วงที่ถูกต้อง
                {
                    grades.Add(grade);
                    lstGrades.Items.Add(grade.ToString("0.00")); // แสดงคะแนนที่เพิ่ม
                    txtGrade.Clear();
                    txtGrade.Focus();
                    UpdateStatistics();
                }
                else
                {
                    MessageBox.Show("กรุณาป้อนค่าระหว่าง 0.00 - 4.00", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("กรุณาป้อนตัวเลขที่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateStatistics()
        {
            if (grades.Count > 0)
            {
                lblMaxGrade.Text = $"คะแนนสูงสุด: {grades.Max():0.00}";
                lblMinGrade.Text = $"คะแนนต่ำสุด: {grades.Min():0.00}";
                lblGPAx.Text = $"GPAx: {grades.Average():0.00}";
                lblStudentCount.Text = $"จำนวนคน: {grades.Count}";
            }
            else
            {
                lblMaxGrade.Text = "คะแนนสูงสุด: -";
                lblMinGrade.Text = "คะแนนต่ำสุด: -";
                lblGPAx.Text = "GPAx: -";
                lblStudentCount.Text = "จำนวนคน: 0";
            }
        }
    }
}

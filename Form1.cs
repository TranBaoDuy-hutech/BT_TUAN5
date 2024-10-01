using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH_B4.Models;

namespace TH_B4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentContextDB context = new StudentContextDB();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Faculty> listFalcultys = context.Faculty.ToList(); //lấy các khoa
                List<Student> listStudent = context.Student.ToList(); //lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        //Hàm binding gridView từ list sinh viên
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các control trên form
                string fullName = txtFullName.Text; // Giả sử bạn có một TextBox tên là txtFullName
                decimal averageScore = decimal.Parse(txtAverageScore.Text); // TextBox cho điểm trung bình
                int facultyID = (int)cmbFaculty.SelectedValue; // Lấy giá trị ID của khoa đã chọn

                // Tạo một sinh viên mới
                Student newStudent = new Student
                {
                    FullName = fullName,
                    AverageScore = averageScore,
                    FacultyID = facultyID
                };

                // Thêm sinh viên vào cơ sở dữ liệu
                context.Student.Add(newStudent);
                context.SaveChanges();

                // Cập nhật lại danh sách sinh viên trong DataGridView
                List<Student> listStudent = context.Student.ToList();
                BindGrid(listStudent);

                // Xóa thông tin trong các TextBox
                txtFullName.Clear();
                txtAverageScore.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy ID sinh viên từ DataGridView (giả sử người dùng đã chọn hàng)
                if (dgvStudent.SelectedRows.Count > 0)
                {
                    int studentID = (int)dgvStudent.SelectedRows[0].Cells[0].Value; // Lấy StudentID từ ô đầu tiên

                    // Tìm sinh viên trong cơ sở dữ liệu
                    Student studentToDelete = context.Student.Find(studentID);
                    if (studentToDelete != null)
                    {
                        context.Student.Remove(studentToDelete);
                        context.SaveChanges();

                        // Cập nhật lại danh sách sinh viên trong DataGridView
                        List<Student> listStudent = context.Student.ToList();
                        BindGrid(listStudent);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có sinh viên nào được chọn không
                if (dgvStudent.SelectedRows.Count > 0)
                {
                    // Lấy thông tin sinh viên từ hàng được chọn
                    int studentID = (int)dgvStudent.SelectedRows[0].Cells[0].Value; // Lấy StudentID từ ô đầu tiên
                    Student studentToEdit = context.Student.Find(studentID);

                    if (studentToEdit != null)
                    {
                        // Cập nhật thông tin sinh viên từ các control trên form
                        studentToEdit.FullName = txtFullName.Text; // TextBox cho họ tên
                        studentToEdit.AverageScore = decimal.Parse(txtAverageScore.Text); // TextBox cho điểm trung bình
                        studentToEdit.FacultyID = (int)cmbFaculty.SelectedValue; // Lấy ID của khoa đã chọn

                        // Lưu thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                        // Cập nhật lại danh sách sinh viên trong DataGridView
                        List<Student> listStudent = context.Student.ToList();
                        BindGrid(listStudent);

                        // Xóa thông tin trong các TextBox
                        txtFullName.Clear();
                        txtAverageScore.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sinh viên để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin sinh viên từ hàng được chọn
                int studentID = (int)dgvStudent.Rows[e.RowIndex].Cells[0].Value;
                Student selectedStudent = context.Student.Find(studentID);

                if (selectedStudent != null)
                {
                    // Hiển thị thông tin của sinh viên vào các TextBox
                    txtFullName.Text = selectedStudent.FullName;
                    txtAverageScore.Text = selectedStudent.AverageScore.ToString();
                    cmbFaculty.SelectedValue = selectedStudent.FacultyID; // Chọn khoa tương ứng
                }
            }
        }

    }

}

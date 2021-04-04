using Bridge.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public StudentDataManager studentManager;
        public void MainForm_Load(object sender, EventArgs e)
        {
            var students = new List<Student>
            {
                new Student
                {
                    Id=1,
                    FirstName="MUSTAFA SEMİH",
                    LastName="KARADEMİR",
                    Department="BİLGİSAYAR MÜHENDİSLİĞİ"
                },
                new Student
                {
                    Id=2,
                    FirstName="İREM",
                    LastName="GÜL",
                    Department="ORTOPEDOGOJİ"
                },
                new Student
                {
                    Id=3,
                    FirstName="GÖKHAN MERT",
                    LastName="KALELİ",
                    Department="BİLGİSAYAR MÜHENDİSLİĞİ"
                },
                new Student
                {
                    Id=4,
                    FirstName="FURKAN",
                    LastName="YILMAZ",
                    Department="BİLGİSAYAR MÜHENDİSLİĞİ"
                },

            };
            studentManager = new StudentDataManager(students);

        }

        public void button5_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = studentManager.GetAll().ToList();
        }

        public void dgvStudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvStudent.Rows[e.RowIndex];
            textId.Text = selectedRow.Cells["Id"].Value.ToString();
            textFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
            textLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
            textDepartment.Text = selectedRow.Cells["Department"].Value.ToString();
           

        }

        public void button2_Click(object sender, EventArgs e)
        {
            studentManager.AddRecord(new Student
            {
                Id = Convert.ToInt32(textId.Text),
                FirstName = textFirstName.Text.Trim(),
                LastName = textLastName.Text.Trim(),
                Department = textDepartment.Text.Trim()
            }
                );
            dgvStudent.DataSource = studentManager.GetAll().ToList();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            studentManager.DeleteRecord(new Student
            {
                Id = Convert.ToInt32(textId.Text),
                FirstName = textFirstName.Text.Trim(),
                LastName = textLastName.Text.Trim(),
                Department = textDepartment.Text.Trim()
            }
                );
            dgvStudent.DataSource = studentManager.GetAll().ToList();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = studentManager.NextRecord().ToList(); 

        }

        public void button1_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = studentManager.PriorRecord().ToList();
        }

        
    }
}

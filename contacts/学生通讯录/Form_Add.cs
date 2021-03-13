using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生通讯录
{
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void Form_Add_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            StudentInfo studentinfo = new StudentInfo();
            if (txt_studentid.Text != "")
            {
                studentinfo.StudentId = Int32.Parse(txt_studentid.Text);
                label10.Text = "";
            }
            else
            {
                label10.Text = "必填！";
                return;
            }
            if (txt_name.Text != "")
            {
                studentinfo.Name = txt_name.Text;
                label11.Text = "";
            }
            else
            {
                label11.Text = "必填！";
                return;
            }
            if (rb_man.Checked)
                studentinfo.Sex = "男";
            else if (rb_woman.Checked)
                studentinfo.Sex = "女";
            if (Int32.Parse(txt_age.Text) <= 100 && Int32.Parse(txt_age.Text)>0&& txt_age.Text!="")
            {
                studentinfo.Age = Int32.Parse(txt_age.Text);
                label13.Text = "";
            }
            else
            {
                label13.Text = "请输入正确的年龄！";
                return;
            }
            studentinfo.BirthDate = DateTime.Parse(dt_birthdate.Text);
            if (txt_phone.Text.ToString().Length == 11)
            {
                studentinfo.Phone = txt_phone.Text;
                label12.Text = "";
            }
            else
            {
                label12.Text = "请输入正确的手机号码！";
                return;
            }
            studentinfo.Email = txt_email.Text;
            studentinfo.HomeAddress = txt_homeaddress.Text;
            studentinfo.Profession = txt_profession.Text;
            if(StudentInfoBLL.AddStudentInfo(studentinfo))
            {
                MessageBox.Show("添加学生信息成功！");
                this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_studentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

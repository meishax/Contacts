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
    public partial class Form_Edit : Form
    {
        public void initControl()
        {
            //查询要编辑的学生信息并把要编辑的学生信息显示出来；
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            if(studentinfo!=null)
            {
                txt_studentid.Text = studentinfo.StudentId.ToString();
                txt_name.Text = studentinfo.Name;
                if(studentinfo.Sex=="男")
                {
                    rb_man.Checked = true;
                    rb_woman.Checked = false;
                }
                else
                {
                    rb_man.Checked = false;
                    rb_woman.Checked = true;
                }
                txt_age.Text = studentinfo.Age.ToString();
                dt_birthday.Text =studentinfo.BirthDate.ToString();
                txt_phone.Text = studentinfo.Phone;
                txt_email.Text = studentinfo.Email;
                txt_homeaddress.Text = studentinfo.HomeAddress;
                txt_profession.Text = studentinfo.Profession;
            }
        }
        public int studentid_edit = 0;
        public Form_Edit()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form_Edit_Load(object sender, EventArgs e)
        {
            initControl();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //更新学生编辑信息；
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            if (txt_studentid.Text != "")
            {
                studentinfo.StudentId = Int32.Parse(txt_studentid.Text);
                label13.Text = "";
            }
            else
            {
                label13.Text = "必填！";
                return;
            }
            if (txt_name.Text != "")
            {
                studentinfo.Name = txt_name.Text;
                label10.Text = "";
            }
            else
            {
                label10.Text = "必填！";
                return;
            }
            if (rb_man.Checked)
                studentinfo.Sex = "男";
            else if (rb_woman.Checked)
                studentinfo.Sex = "女";
            if (Int32.Parse(txt_age.Text) <= 100 && Int32.Parse(txt_age.Text) > 0)
            {
                studentinfo.Age = Int32.Parse(txt_age.Text);
                label12.Text = "";
            }
            else
            {
                label12.Text = "请输入正确的年龄！";
                return;
            }
            studentinfo.BirthDate = DateTime.Parse(dt_birthday.Text);
            if (txt_phone.Text.ToString().Length == 11)
            {
                studentinfo.Phone = txt_phone.Text;
                label11.Text = "";
            }
            else
            {
                label11.Text = "请输入正确的手机号码！";
                return;
            }
            studentinfo.Email = txt_email.Text;
            studentinfo.HomeAddress = txt_homeaddress.Text;
            studentinfo.Profession = txt_profession.Text;
            if (StudentInfoBLL.UpdateStudentInfo(studentinfo))
            {
                MessageBox.Show("修改学生信息成功！");
                this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dt_birthday_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

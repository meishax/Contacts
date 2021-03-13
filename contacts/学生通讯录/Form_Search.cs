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
    public partial class Form_Search : Form
    {
        void initHeadTitle()
        {
            //初始化数据表格Datagridview的列表；
            dataGridView1.Columns[0].HeaderText = "学生编号";
            dataGridView1.Columns[1].HeaderText = "学生姓名";
            dataGridView1.Columns[2].HeaderText = "学生性别";
            dataGridView1.Columns[3].HeaderText = "学生年龄";
            dataGridView1.Columns[4].HeaderText = "出生日期";
            dataGridView1.Columns[5].HeaderText = "手机号码";
            dataGridView1.Columns[6].HeaderText = "家庭地址";
            dataGridView1.Columns[7].HeaderText = "电子邮箱";
            dataGridView1.Columns[8].HeaderText = "专    业";
        }
        public Form_Search()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //根据所查询的信息和输入查询值进行查询，若没有则查询所有信息；
            if(cb_searchitem.Text==string.Empty)
            {
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
                initHeadTitle();
            }
            else
            {
                if (txt_searchtext.Text != string.Empty)
                {
                    StudentInfo studentsearch = new StudentInfo();
                    switch (cb_searchitem.SelectedIndex)
                    {
                        case 0: studentsearch.StudentId = Int32.Parse(txt_searchtext.Text); break;
                        case 1: studentsearch.Name = txt_searchtext.Text; break;
                    }
                    dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(studentsearch);
                    initHeadTitle();
                }
                else
                    MessageBox.Show("请输入要查询的" + cb_searchitem.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Search_Load(object sender, EventArgs e)
        {

        }

        private void cb_searchitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_searchtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

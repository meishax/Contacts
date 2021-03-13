using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生通讯录
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            initContracts();
        }
        void initContracts()
        {
            //如果存在Student.xml查询所有学生信息，如果不存在，则创建后在查询
            if (File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Student.xml"))
            {
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            else
            {
                StudentInfoBLL.CreateStudentXml();
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            //初始化数据表格dataGitlView的列标题
            dataGridView1.Columns[0].HeaderText = "学生编号";
            dataGridView1.Columns[1].HeaderText = "学生姓名";
            dataGridView1.Columns[2].HeaderText = "学生性别";
            dataGridView1.Columns[3].HeaderText = "学生年龄";
            dataGridView1.Columns[4].HeaderText = "出生日期";
            dataGridView1.Columns[5].HeaderText = "手机号码";
            dataGridView1.Columns[6].HeaderText = "家庭住址";
            dataGridView1.Columns[7].HeaderText = "电子邮箱";
            dataGridView1.Columns[8].HeaderText = "专    业";
        }
        //private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //    //打开添加学生的信息窗体
        //    Form_Add formadd = new Form_Add();
        //    formadd.ShowDialog();
        //    initContracts();
        //}
        private void toolStrip_edit_Click(object sender, EventArgs e)
        {
            //选中一个学生信息后，打开学生编辑窗体
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Form_Edit formedit = new Form_Edit();
                formedit.studentid_edit = selectrow;
                formedit.ShowDialog();
                initContracts();
            }
            else
                MessageBox.Show("请选中一行后再点击编辑按钮");
        }
        private void toolStrip_delete_Click(object sender, EventArgs e)
        {
            //选中某一个学生信息，删除学生信息
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("确定删除此学生信息？", "确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    if (StudentInfoBLL.DeleteStudentInfo(selectrow))
                        MessageBox.Show("删除学生信息成功！");
                    else
                        MessageBox.Show("删除学生信息失败，请确认是否选中学生信息");
                    initContracts();
                }
            }
            else
                MessageBox.Show("请选中一行后再点击删除！");
        }
        private void toolstrip_search_Click(object sender, EventArgs e)
        {
            Form_Search formsearch = new Form_Search();
            formsearch.ShowDialog();
        }
        private void toolStrip_add_Click(object sender, EventArgs e)
        {
            //打开添加学生的信息窗体
            Form_Add formadd = new Form_Add();
            formadd.ShowDialog();
            initContracts();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo();
            if (treeView1.SelectedNode.Text == "计算机科学与技术")
            {
                studentInfo.Profession = "计算机科学与技术";
                dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(studentInfo);
            }
            else if (treeView1.SelectedNode.Text == "电子信息科学与技术")
            {
                studentInfo.Profession = "电子信息科学与技术";
                dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(studentInfo);
            }
            else if (treeView1.SelectedNode.Text == "信息安全")
            {
                studentInfo.Profession = "信息安全";
                dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(studentInfo);
            }
            else
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
        }
        private void toolStrip_save_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/by.xml"))
            {
                File.Delete(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/by.xml");
            }
            File.Copy(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Student.xml", AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/by.xml");
            MessageBox.Show("备份成功");
        }
        private void toolStrip_back_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Student.xml"))
            {
                File.Delete(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Student.xml");
            }
            File.Copy(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/by.xml", AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Student.xml");
            MessageBox.Show("恢复成功");
            initContracts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CourseManageBLL;
using CourseManageModels;

namespace CourseManageUI
{
    public partial class FrmCourseManage : Form
    {
        private CourseCategoryManager categoryManager = new CourseCategoryManager();
        private CourseManager courseManager = new CourseManager();

        private List<Course> queryList = null; // 创建一个集合，用来缓存查询结果，便于后面修改和删除使用，从而减少数据库的访问

        public FrmCourseManage()
        {
            InitializeComponent();

            List<CourseCategory> list = categoryManager.GetCourseCategories();
            // 在集合元素第一个位置插入一个空白
            list.Insert(0, new CourseCategory { CategoryId = -1, CategoryName="--请选择--"});

            // 动态填充课程分类下拉框
            this.cbbCategory.DataSource = list;
            // 我们在UI中看到的
            this.cbbCategory.DisplayMember = "CategoryName";
            // 保存到数据库使用的外键值
            this.cbbCategory.ValueMember = "CategoryId";
            this.cbbCategory.SelectedIndex = -1;

            // 禁止自动生成列
            this.dgvCourseList.AutoGenerateColumns = false;

            // 隐藏修改面板
            this.panelModify.Visible = false;

            // 禁用修改和删除按钮（提高用户体验）
            this.btnModifyCourse.Enabled = this.btnDelCourse.Enabled = false;

            // 绑定修改用的课程分类
            //this.cbbCategory_Modify.DataSource = list; // 如果直接使用前面的集合，会造成俩个下拉框联动
            this.cbbCategory_Modify.DataSource = new List<CourseCategory>(list); // 将前面的集合重新复制后再做数据源
            // 我们在UI中看到的
            this.cbbCategory_Modify.DisplayMember = "CategoryName";
            // 保存到数据库使用的外键值
            this.cbbCategory_Modify.ValueMember = "CategoryId";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 提交查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            // 【1】条件验证
            if ((this.cbbCategory.SelectedIndex == -1 || this.cbbCategory.SelectedIndex == 0) 
                && this.txtCourseName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请至少选择一个查询条件！", "查询提示");
                return;
            }
            // 【2】提交查询
            //int categoryId = 0;
            //if (this.cbbCategory.SelectedIndex == -1 || this.cbbCategory.SelectedIndex == 0)
            //{
            //    categoryId = -1;
            //}
            //else
            //{
            //    categoryId = Convert.ToInt32(this.cbbCategory.SelectedValue);
            //}
            // 请大家学会使用三元运算符
            int categoryId = this.cbbCategory.SelectedIndex == -1 ? -1 : Convert.ToInt32(this.cbbCategory.SelectedValue);
            queryList = courseManager.QueryCourse(categoryId, this.txtCourseName.Text.Trim());

            // 【3】展示查询
            if (queryList.Count == 0) // 如果没有找到结果，清空上一次查询的数据
            {
                this.dgvCourseList.DataSource = null;
                this.lblCount.Text = "0";
                this.btnModifyCourse.Enabled = this.btnDelCourse.Enabled = false;
                MessageBox.Show("没有找到查询结果！", "查询提示");
            }
            else // 重新绑定查询结果
            {
                this.dgvCourseList.DataSource = queryList;
                this.lblCount.Text = this.dgvCourseList.RowCount.ToString();
                this.btnModifyCourse.Enabled = this.btnDelCourse.Enabled = true;
            }
            this.panelModify.Visible = false; // 每次查询都要隐藏修改面板，提高用户体验
        }
        // 显示修改信息
        private void btnModifyCourse_Click(object sender, EventArgs e)
        {
            if (this.dgvCourseList.CurrentRow == null)
            {
                MessageBox.Show("请首先选择一行！！", "修改提示");
                return;
            }
            // 【1】获取当前选中行的对应的课程ID
            int courseId = (int)this.dgvCourseList.CurrentRow.Cells["CourseId"].Value;
            // 【2】根据课程ID从集合中查询课程对象
            Course currentCourse = null;
            //foreach (var item in this.queryList)
            //{
            //    if (item.CourseId.Equals(courseId))
            //    {
            //        currentCourse = item;
            //        break;
            //    }
            //}
            // 以上仅仅适合初学者理解，但是实际开发中，我们应该有更高效的方法（深入学习中讲解，今天我们会使用）
            currentCourse = (from c in this.queryList where c.CourseId.Equals(courseId) select c).First();
            //currentCourse = this.queryList.Where(c => c.CourseId.Equals(courseId)).First();

            // 【3】显示要修改的课程对象
            this.txtCoureName_Modify.Text = currentCourse.CourseName;
            this.txtCredit.Text = currentCourse.Credit.ToString();
            this.txtClassHour.Text = currentCourse.ClassHour.ToString();
            this.txtCourseContent.Text = currentCourse.CourseContent;
            this.lblCourseId.Text = currentCourse.CourseId.ToString(); // 为提交修改使用
            
            // 将当前课程分类和下拉框选择做同步
            this.cbbCategory_Modify.SelectedValue = currentCourse.CategoryId;

            this.panelModify.Visible = true;
        }
        // 关闭修改窗口
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {

        }
        // 关闭修改窗口
        private void btnCloseModify_Click(object sender, EventArgs e)
        {

        }
        // 删除课程
        private void btnDelCourse_Click(object sender, EventArgs e)
        {

        }
    }
}

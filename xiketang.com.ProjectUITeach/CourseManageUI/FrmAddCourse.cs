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
    public partial class FrmAddCourse : Form
    {
        private CourseCategoryManager categoryManager = new CourseCategoryManager();

        private CourseManager courseManager = new CourseManager();

        // 用来缓存添加的课程对象
        private List<Course> addedCourse = new List<Course>();

        public FrmAddCourse()
        {
            InitializeComponent();

            // 动态填充课程分类下拉框
            this.cbbCategory.DataSource = categoryManager.GetCourseCategories();
            // 我们在UI中看到的
            this.cbbCategory.DisplayMember = "CategoryName";
            // 保存到数据库使用的外键值
            this.cbbCategory.ValueMember = "CategoryId";
            // 禁止自动生成列
            this.dgvCourseList.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 保存到数据库
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            // 【1】数据校验（检查用户输入的数据是否符合要求...请按照项目的需求完成，适当的时候可以使用正则表达式）

            // 为空的判断请自己完成...

            // 实际开发中，还可以使用控件二次开发封装TextBox的自带验证功能...

            // 【2】封装数据：把用户输入的数据封装到实体对象中
            Course course = new Course
            {
                CourseName = this.txtCourseName.Text.Trim(),
                CourseContent = this.txtCourseContent.Text.Trim(),
                ClassHour = Convert.ToInt32(this.txtClassHour.Text.Trim()),
                Credit = Convert.ToInt32(this.txtCredit.Text.Trim()),
                CategoryId = Convert.ToInt32(this.cbbCategory.SelectedValue),
                TeacherId = Program.currentTeacher.TeacherId, // 默认登录用户Id
                CategoryName = this.cbbCategory.Text // 这个属性不是给数据库用的，是为了下面同步显示
            }; 

            // 【3】调用后台提交保存（可以追加异常信息...）
            int result = courseManager.AddCourse(course);

            // 【4】将添加成功的课程信息保存到缓存中，并设置dgv的数据源
            addedCourse.Add(course);
            this.dgvCourseList.DataSource = null; // 如果不清空，后面不会同步显示新增加的
            this.dgvCourseList.DataSource = this.addedCourse;

            // 【5】自动清除文本框（自行完成，作业）
        }
    }
}

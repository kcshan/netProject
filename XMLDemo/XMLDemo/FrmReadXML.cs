using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;//引入命名空间

namespace XMLDemo
{
    public partial class FrmReadXML : Form
    {
        public FrmReadXML()
        {
            InitializeComponent();
        }

        // 显示版本信息
        private void btnShowVersion_Click(object sender, EventArgs e)
        {
            // 创建XML读取器
            XmlTextReader tReader = new XmlTextReader("StuScore.xml");

            string info = string.Empty;

            // 循环查询
            while (tReader.Read())
            {
                if (tReader.Name == "Version")
                {
                    info = "版本:" + tReader.GetAttribute("vNo") + "发布时间：" + tReader.GetAttribute("pTime");
                    break;
                }
            }
            MessageBox.Show(info);
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            // 【1】创建xml文档操作对象
            XmlDocument objDoc = new XmlDocument();
            // 【2】加载XML文件到文档对象中
            objDoc.Load("StuScore.xml");
            // 【3】获取Xml文档根目录
            XmlNode rootNode = objDoc.DocumentElement;
            // 创建对象集合
            List<Student> list = new List<Student>();
            // 【4】遍历根节点（根节点包含所有节点）
            foreach (XmlNode stuNode in rootNode.ChildNodes)
            {
                if (stuNode.Name == "Student")
                {
                    Student objStu = new Student();
                    // 【5】遍历子节点
                    foreach (XmlNode subNode in stuNode)
                    {
                        // 根据子节点的名称封装到对象的属性
                        switch (subNode.Name)
                        {
                            case "StuName":
                                // 获取《节点名称》对应的《节点值》
                                objStu.StuName = subNode.InnerText;
                                break;
                            case "StuAge":
                                objStu.StuAge = Convert.ToInt16(subNode.InnerText);
                                break;
                            case "Gender":
                                objStu.Gender = subNode.InnerText;
                                break;
                            case "ClassName":
                                objStu.ClassName = subNode.InnerText;
                                break;
                        }
                    }
                    list.Add(objStu);
                }
            }
            this.dgvStuList.DataSource = list;
        }
       
    }
}

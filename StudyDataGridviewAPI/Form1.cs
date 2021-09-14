using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudyDataGridviewAPI
{
    public partial class Form1 : Form
    {
        List<Student> std = new List<Student>();
        List<Daegu> daegus = new List<Daegu>();
        public Form1()
        {
            InitializeComponent();

            string xmlfile = File.ReadAllText("apiexample.xml");
            XElement daegusxml = XElement.Parse(xmlfile);
            foreach(var item in daegusxml.Descendants("item")){ 
               
                string name = item.Element("atrractname").Value;
                string tel = item.Element("tel").Value;
                Daegu d = new Daegu();
                d.name = name;
                d.tel = tel;
                daegus.Add(d);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = daegus;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_add_student_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox_age.Text);

            std.Add(new Student(textBox_name.Text, age, textBox_hakbean.Text));

            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = std;
        }

        private void button_arrange_Click(object sender, EventArgs e)
        {
            std.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = std;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var item in std)
            {
                //MessageBox.Show($"이름:{item.name}, 나이:{item.age}, 학번:{item.hakbeon}");
                MessageBox.Show(item.ToString());
            }

          
    }
    }
}

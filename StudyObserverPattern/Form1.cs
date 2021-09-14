using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyObserverPattern
{
    public partial class Form1 : Form,iSubject
    {
        /*IList observers = new ArrayList();*/

        //자바로 치면 
        List<iObserver> obs = new List<iObserver>();
        Form2 frm2 = null;
        Form3 frm3 = null;
        Form4 frm4 = null;

        
        public Form1()
        {
            InitializeComponent();

            frm2 = new Form2(this);//인스턴스 생성
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm2);
            frm2.Show();

            frm3 = new Form3(this);
            frm3.TopLevel = false;
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.Dock = DockStyle.Fill;
            panel2.Controls.Add(frm3);
            frm3.Show();

            frm4 = new Form4(this,frm2,frm3);
            frm4.TopLevel = false;
            frm4.FormBorderStyle = FormBorderStyle.None;
            frm4.Dock = DockStyle.Fill;
            panel3.Controls.Add(frm4);
            frm4.Show();
        }

        public void notify()
        {   //이 함수 구현하지 않았다고 메세지 주며넛 프로그램끄게 하는 것
            //throw new NotImplementedException();
            foreach(iObserver item in obs)
            {
                item.update(textBox1.Text);
            }
        }

        public void register(iObserver o)
        {
            //throw new NotImplementedException();
            obs.Add(o);
        }

        public void remove(iObserver o)
        {
            //throw new NotImplementedException();
            obs.Remove(o);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //엔터키를 칠 때마다 notify를 호출해서 
            //iObserver 인터페이스 구현되어 있는 객체들을 일괄적 호출
            if (e.KeyCode == Keys.Enter)
                notify();
            
        }
    }
}

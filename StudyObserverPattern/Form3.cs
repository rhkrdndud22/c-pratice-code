using System;
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
    public partial class Form3 : Form,iObserver
    {
        public Form3(iSubject sub)
        {
            sub.register(this);
            InitializeComponent();
        }

        public void update(string value)
        {
            textBox1.Text = value;

           // throw new NotImplementedException();
        }
    }
}

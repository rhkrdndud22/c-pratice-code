﻿using System;
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

namespace mapAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void reacXML(string fileName)
        {
            string xmlFile = File.ReadAllText(fileName);
            XElement xml_Element = XElement.Parse(xmlFile);

        }

        private void button1_Click(object sender, EventArgs e)
        {
              string key = "nka5UJqArGL%2BTeI4C6FrpoXxRLjzb02sB3iHQucWdOGDycY%2Byvb3h9s6o4ZC852hKXey83hMKTy1Ng6u3k4gPA%3D%3D";
              string pageNo = "1";
              string numOfRows = "10";
              string url = $"https://tour.daegu.go.kr/openapi-data/service/rest/getTourKorAttract/svTourKorAttract.do?serviceKey={key}pageNo={pageNo}&numOfRows={numOfRows}&SG_APIM=2ug8Dm9qNBfD32JLZGPN64f3EoTlkpD8kSOHWfXpyrY";


              XElement api = XElement.Load(url);

            List<Daegu> daegus = new List<Daegu>();

            foreach (var item in api.Descendants("item"))
            {
                string attractname = item.Element("attractname").Value;
                string addree = item.Element("address").Value;
                string tel = item.Element("tel").Value;
                daegus.Add(new Daegu(addree,attractname
                    ,tel));
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = daegus;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}

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
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class AddedWork : Form
    {
        public AddedWork()
        {
            InitializeComponent();
        }

        private void AddedNewWork(object sender, EventArgs e)
        {
            XmlSerializer serializer =
                new XmlSerializer(typeof(Multinational.Workers));

            using (Stream reader = new FileStream(@"C:\Users\dewaf\Desktop\MultinationalCorporation2.xml", FileMode.Open))
            {

                //i = (Multinational.MultinationalCorporation)serializer.Deserialize(reader);
                Multinational.Workers workers = new Multinational.Workers { Headmen = textBox1.Text, Maindeveloper = textBox4.Text, PRAgent = textBox2.Text };
                serializer.Serialize(reader, workers);
            }
        }
    }
}

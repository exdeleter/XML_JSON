using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }
        private void M(object sender, EventArgs e)
        {
            Write();
        }
        private void Write()
        {
                XmlSerializer serializer =
                new XmlSerializer(typeof(Multinational.MultinationalCorporation));
                Multinational.MultinationalCorporation i;
            //C:\Users\dewaf\source\repos\WindowsFormsApp1\WindowsFormsApp1\MultinationalCorporation.xml
            using (Stream reader = new FileStream(@"C:\Users\dewaf\source\repos\WindowsFormsApp1\WindowsFormsApp1\MultinationalCorporation.xml", FileMode.Open))
                {
                    
                    i = (Multinational.MultinationalCorporation)serializer.Deserialize(reader);
                
                
                }
            foreach (var p in i.Staffs.Staff)
            {
                string[] row = { $"{p.Position}", $"{p.Salary}", $"{p.Workingtime}",
                $"{p.Information.Age}",$"{p.Information.EnterYear}",$"{p.Information.FamilyStatus}"};
                dataGridView1.Rows.Add(row);
            }
            foreach (var p in i.Occupations.Occupation)
            {
                string[] row = { $"{p.Id}", $"{p.Categories}", $"{p.Time}", $"{p.Volume}",
                p.Countryproduce};
                dataGridView2.Rows.Add(row);
            }
            
        }
        private void KnowAboutMarket(object sender, EventArgs e)
        {
            Markets  m = new Markets();
            m.Show();

        }
    }
}

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
    public partial class Markets : Form
    {
        public Markets()
        {
            InitializeComponent();
        }

        private void Know(object sender, EventArgs e)
        {
            XmlSerializer serializer =
                new XmlSerializer(typeof(Multinational.MultinationalCorporation));
            Multinational.MultinationalCorporation i;

            using (Stream reader = new FileStream(@"C:\Users\dewaf\source\repos\WindowsFormsApp1\WindowsFormsApp1\MultinationalCorporation.xml", FileMode.Open))
            {

                i = (Multinational.MultinationalCorporation)serializer.Deserialize(reader);
            }
            foreach (var p in i.CountryMarkets.CountryMarket)
            {
                if (p.Influence.Idoccup == 1)
                {
                    string[] rower = {
                            $"{p.Id}", "Phones", $"{p.Influence.Procent}"
                        , $"{p.Influence.Volume}" , $"{p.Namecountry}" };
                    dataGridView1.Rows.Add(rower);
                } if(p.Influence.Idoccup == 2)
                {
                    string[] rower = {
                            $"{p.Id}", "Televisors", $"{p.Influence.Procent}"
                        , $"{p.Influence.Volume}" , $"{p.Namecountry}" };
                    dataGridView1.Rows.Add(rower);
                } else
                {
                    string[] rower = {
                            $"{p.Id}", "Fridges", $"{p.Influence.Procent}"
                        , $"{p.Influence.Volume}" , $"{p.Namecountry}" };
                    dataGridView1.Rows.Add(rower);
                }

            }
            foreach (var p in i.CountryMarkets.CountryMarket)
            {
                string[] row = { $"{p.Id}", $"{p.Workers.Headmen}"
                        , $"{p.Workers.Maindeveloper}" , $"{p.Workers.PRAgent}" };
                dataGridView2.Rows.Add(row);
            }

        }

        private void AddWork(object sender, EventArgs e)
        {
            AddedWork a = new AddedWork();
            a.Show();
        }
    }
}

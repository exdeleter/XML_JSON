using Newtonsoft.Json;
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

namespace WindowsFormsApp1.JSON
{
    public partial class JSONMarkets : Form
    {
        public JSONMarkets()
        {
            InitializeComponent();
        }

        private void read(object sender, EventArgs e)
        {
            string response;
            using (StreamReader stream = new StreamReader(@"C:\Users\dewaf\Desktop\MultinationalCorporat.json"))
            {
                response = stream.ReadToEnd();
            }
            var Response = JsonConvert.DeserializeObject<MCJSON.Rootobject>(response);

            foreach (var p in Response.MultinationalCorporation.CountryMarkets.CountryMarket)
            {
                if (p.influence.idoccup == 1)
                {
                    string[] rower = {
                            $"{p.id}", "Phones", $"{p.influence.procent}"
                        , $"{p.influence.volume}" , $"{p.namecountry}" };
                    dataGridView1.Rows.Add(rower);
                }
                if (p.influence.idoccup == 2)
                {
                    string[] rower = {
                            $"{p.id}", "Televisors", $"{p.influence.procent}"
                        , $"{p.influence.volume}" , $"{p.namecountry}" };
                    dataGridView1.Rows.Add(rower);
                }
                else
                {
                    string[] rower = {
                            $"{p.id}", "Fridges", $"{p.influence.procent}"
                        , $"{p.influence.volume}" , $"{p.namecountry}" };
                    dataGridView1.Rows.Add(rower);
                }

            }
            foreach (var p in Response.MultinationalCorporation.CountryMarkets.CountryMarket)
            {
                string[] row = { $"{p.id}", $"{p.Workers.headmen}"
                        , $"{p.Workers.maindeveloper}" , $"{p.Workers.PRAgent}" };
                dataGridView2.Rows.Add(row);
            }

        }
    }
}

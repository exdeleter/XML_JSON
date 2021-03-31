using System;
using Newtonsoft.Json;
using System.Windows.Forms;
using WindowsFormsApp1.JSON;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class JSONForm : Form
    {

        

        public JSONForm()
        {
            InitializeComponent();
        }
        private void ReadJson(object sender, EventArgs e)
        {
            string response;
            using (StreamReader stream = new StreamReader(@"C:\Users\dewaf\Desktop\MultinationalCorporat.json"))
            {
                response = stream.ReadToEnd();
            }
            var Response = JsonConvert.DeserializeObject<MCJSON.Rootobject>(response);

            foreach (var p in Response.MultinationalCorporation.Staffs.Staff)
            {
                string[] row = { $"{p.position}", $"{p.salary}", $"{p.workingtime}",
                $"{p.information.age}",$"{p.information.EnterYear}",$"{p.information.familyStatus}"};
                dataGridView1.Rows.Add(row);
            }
            foreach (var p in Response.MultinationalCorporation.Occupations.Occupation)
            {
                string[] row = { $"{p.id}", $"{p.categories}", $"{p.time}", $"{p.volume}",
                p.countryproduce};
                dataGridView2.Rows.Add(row);
            }

        }

        private void OpenMarkets(object sender, EventArgs e)
        {
            JSONMarkets f = new JSONMarkets();
            f.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiFufufafa.Forms
{
    public partial class ConfigPage : UserControl
    {
        public ConfigPage()
        {
            InitializeComponent();
        }

        private void textExchangesRate_Load(object sender, EventArgs e)
        {

        }

        private async void ConfigPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            var config = await configService.getConfiguration();
            if (config != null)
            {
                textTermin1.Text = config.Termin1;
                textTermin2.Text = config.Termin2;
                textTermin3.Text = config.Termin3;
                textExchangesRate.Text = config.ExchangeRate.ToString();
                textInhouseFee.Text = config.InhouseFee.ToString();
                textAccessFee.Text = config.AccessFee.ToString();
            }
        }

        private async Task buttonUpdate_Click(object sender, EventArgs e)
        {
            decimal exchangeRate = decimal.Parse(textExchangesRate.Text);
            decimal inhouseFee = decimal.Parse(textInhouseFee.Text);
            decimal accessFee = decimal.Parse(textAccessFee.Text);

            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            await service.addorUpdate(textTermin1.Text, textTermin2.Text, textTermin3.Text, exchangeRate, inhouseFee, accessFee, configService);
            MessageBox.Show("Configuration Updated Successfully!");
        }
    }
}

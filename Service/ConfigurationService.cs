using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KoperasiFufufafa.Data;
using KoperasiFufufafa.Models;

namespace KoperasiFufufafa.Service
{
    public class ConfigurationService
    {
        private readonly AppDbContext _db;

        public ConfigurationService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Configuration?> GetConfig()
        {
            var config = await _db.Configurations.FirstOrDefaultAsync(x => x.Id == 1);
            return config;
        }

        public async Task addOrUpdate(string terminologi1, string terminologi2, string exchangeRate, decimal TransferInhouseFee, decimal TransferAcrossFee)
        {
            Boolean isNew = false;
            var config = await _db.Configurations.FirstOrDefaultAsync(x => x.Id == 1);
            if (config == null)
            {
                isNew = true;
                config = new Configuration();
                config.terminologi1 = terminologi1;
                config.terminologi2 = terminologi2;
                config.exchangeRate = decimal.Parse(exchangeRate);
                config.transferInhouseFee = TransferInhouseFee;
                config.transferAcrossFee = TransferAcrossFee;
            }

            if (isNew)
            {
                _db.Add(config);
            }
            else
            {
                _db.Update(config);
            }

            await _db.SaveChangesAsync();
        }
    }
}
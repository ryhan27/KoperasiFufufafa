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
    internal class ConfigurationService
    {
        private readonly AppDbContext _db;

        public ConfigurationService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Configuration?> GetConfig()
        {
            return await _db.Configurations.FirstOrDefaultAsync(c => c.Id == 1);
        }

        public async Task addOrUpdate(string terminolog1, string terminolog2, string terminolog3, string exchangeRate, string inhouseFee, string accrossFee)
        {
            var config = await _db.Configurations.FirstOrDefaultAsync(c => c.Id == 1);

            if (config == null)
            {
                config = new Configuration
                {
                    terminologi1 = terminolog1,
                    Terminolog2 = terminolog2,
                    Terminolog3 = terminolog3,
                    ExchangeRate = exchangeRate,
                    InhouseFee = inhouseFee,
                    AccrossFee = accrossFee
                };

                _db.Configurations.Add(config);
            }
            else
            {
                config.Terminolog1 = terminolog1;
                config.Terminolog2 = terminolog2;
                config.Terminolog3 = terminolog3;
                config.ExchangeRate = exchangeRate;
                config.InhouseFee = inhouseFee;
                config.AccrossFee = accrossFee;
            }

            await _db.SaveChangesAsync();
        }
    }
}
using KoperasiFufufafa.Data;
using KoperasiFufufafa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiFufufafa.Service
{
    public class ProductService
    {
        private AppDbContext _db;
        public ProductService(AppDbContext db)
        {
            _db = db;
        }
    public List<LoanMaster> LoadLoanGrid()
        {
            return _db.LoanMasters.OrderByDescending(x => x.UpdateOn).ToList();
        }
    public List<SavingMaster> LoadSavingGrid()
        {
            return _db.SavingMasters.OrderByDescending(x => x.UpdateOn).ToList();
        }
        public async Task SaveOrUpdateLoan(
               string id,
               string adminFee,
               string name,
               string fine,
               string interest,
               string maxAmount,
               string minAmount,
               string description)
        {
            LoanMaster lm = new LoanMaster();
            bool isNew = true;
            int idLoanMaster = 0;

            if (!string.IsNullOrWhiteSpace(id) && id.Trim() != "...")
            {
                isNew = false;
                idLoanMaster = int.Parse(id);
                lm = _db.LoanMasters.FirstOrDefault(l => l.Id == idLoanMaster);
            }

            lm.UpdateOn = DateTime.UtcNow;
            lm.Fine = decimal.Parse(fine.Replace(".", "").Replace(",", "."));
            lm.AdminFee = decimal.Parse(adminFee.Replace(".", "").Replace(",", "."));
            lm.MaxAmount = decimal.Parse(maxAmount.Replace(".", "").Replace(",", "."));
            lm.MinAmount = decimal.Parse(minAmount.Replace(".", "").Replace(",", "."));
            lm.Name = name;
            lm.Description = description;

            if (isNew)
                _db.LoanMasters.Add(lm);
            else
                _db.LoanMasters.Update(lm);

            await _db.SaveChangesAsync();
        }

        public async Task SaveOrUpdateSaving(
               string id,
               string adminFee,
               string name,
               string fine,
               string interest,
               string maxAmount,
               string minAmount)
        {
            SavingMaster sm = new SavingMaster();
            bool isNew = true;
            int idSavingMaster = 0;

            if (!string.IsNullOrWhiteSpace(id) && id.Trim() != "...")
            {
                isNew = false;
                idSavingMaster = int.Parse(id);
                sm = _db.SavingMasters.FirstOrDefault(s => s.id == idSavingMaster);
            }

            sm.UpdateOn = DateTime.UtcNow;
            sm.Fine = decimal.Parse(fine.Replace(".", "").Replace(",", "."));
            sm.AdminFee = decimal.Parse(adminFee.Replace(".", "").Replace(",", "."));
            sm.MaxAmount = decimal.Parse(maxAmount.Replace(".", "").Replace(",", "."));
            sm.MinAmount = decimal.Parse(minAmount.Replace(".", "").Replace(",", "."));
            sm.Name = name;
            sm.Description = "-";

            if (isNew)
                _db.SavingMasters.Add(sm);
            else
                _db.SavingMasters.Update(sm);

            await _db.SaveChangesAsync();
        }
        public async Task<LoanMaster?> FindLoanById(int id)
        {
            return await _db.LoanMasters.FirstOrDefaultAsync(lm => lm.Id == id);
        }

        public async Task<SavingMaster?> FindSavingById(int id)
        {
            return await _db.SavingMasters.FirstOrDefaultAsync(sm => sm.Id == id);
        }

        public object SetDropDownLoan()
        {
            var data = _db.LoanMasters
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.id,
                    DisplayName = x.Name + ", t:" + x.Tenor + " (" + x.Interest + ")"
                })
                .ToList();

            var result = new List<object>
            {
                new { Id = 0, DisplayName = "-- choose --" }
            };

            // Gabungkan data asli
            result.AddRange(data);


            return result;
        }
    }
}

   


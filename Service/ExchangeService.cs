using KoperasiFufufafa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiFufufafa.Service
{
    class ExchangeService
    {
        private readonly AppDbContext _db;
        public ExchangeService(AppDbContext db)
        {
            _db = db;
        }

        public async void Save(Exchange exchange)
        {
            _db.Exchanges.Add(exchange);
            await _db.SaveChangesAsync();
        }
    }
}

using Orders_Payments_Server.DataBase.Contexts;
using Orders_Payments_Server.DataBase.Funds.Models;
using Orders_Payments_Server.DataBase.Funds.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.DataBase.Funds.Repositories
{
    public class FundsRepository : IFundsRepository
    {
        private readonly OrdersPaymentsDBContext _context;
        public FundsRepository(OrdersPaymentsDBContext context)
        {
            _context = context;
        }

        public List<FundDB> GetFundsFromDB()
        {
            return _context.Funds.ToList();
        }

        public FundDB GetFundByIDFromDB(int id)
        {
            return _context.Funds.Find(id);
        }

        public void SaveNewFunds(IEnumerable<FundDB> fundDBs)
        {
            _context.Funds.AddRange(fundDBs);
            _context.SaveChanges();
        }
    }
}

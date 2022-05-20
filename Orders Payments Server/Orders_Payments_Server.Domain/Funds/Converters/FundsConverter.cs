using Orders_Payments_Server.DataBase.Funds.Models;
using Orders_Payments_Server.Domain.Funds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Server.Domain.Funds.Converters
{
    public static class FundsConverter
    {
        public static Fund ToFund(this FundDB fundDB)
        {
            return new Fund()
            {
                Id = fundDB.Id,
                Date = fundDB.Date,
                Sum = fundDB.Sum,
                Remain = fundDB.Remain
            };
        }

        public static IEnumerable<Fund> ToFunds(this IEnumerable<FundDB> fundDBs)
        {
            return fundDBs.Select(ToFund);
        }

        public static FundDB ToFundDB(this Fund fund)
        {
            return new FundDB()
            {
                Date = fund.Date,
                Sum = fund.Sum,
            };
        }

        public static IEnumerable<FundDB> ToFundDBs(this IEnumerable<Fund> funds)
        {
            return funds.Select(ToFundDB);
        }
    }
}

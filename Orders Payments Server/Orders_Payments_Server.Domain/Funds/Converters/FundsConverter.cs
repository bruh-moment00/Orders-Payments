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
        public static FundResponse ToFundResponse(this FundDB fundDB)
        {
            return new FundResponse()
            {
                Id = fundDB.Id,
                Date = fundDB.Date,
                Sum = fundDB.Sum,
                Remain = fundDB.Remain
            };
        }

        public static IEnumerable<FundResponse> ToFundMultipleResponse(this IEnumerable<FundDB> fundDBs)
        {
            return fundDBs.Select(ToFundResponse);
        }

        public static FundDB ToFundDB(this QueryFund queryFund)
        {
            return new FundDB()
            {
                Date = queryFund.Date,
                Sum = queryFund.Sum,
            };
        }

        public static IEnumerable<FundDB> ToFundDBs(this IEnumerable<QueryFund> funds)
        {
            return funds.Select(ToFundDB);
        }
    }
}

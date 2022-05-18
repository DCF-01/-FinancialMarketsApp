using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceMarketsApp.Infrastructure.SQL.Options
{
    public class SQLOptions
    {
        public const string Section = "SQL";
        public string ConnectionString { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class ProgrammingReportFactory : ReportFactory
    {
        public override IDisciplineReport CreateReport()
        {
            return new ProgrammingReport();
        }
    }
}

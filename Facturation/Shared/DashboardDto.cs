using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class DashboardDto
    {
        public DashboardDto()
        {

        }
        public DashboardDto(IBusinessData from)
        {
            CA = from.CA;
            MontantDus = from
                .GetFactures(DateTime.Now, null)
                .Select(f => new MontantDuDto(f));
        }

        public decimal CA { get; set; }

        public IEnumerable<MontantDuDto> MontantDus { get; set; }
    }
}

using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuoteMap : ClassMap<DeskQuote>
    {
        public DeskQuoteMap()
        {
            Map(d => d.CustomerName).Name("CustomerName");
            Map(d => d.Price).Name("Price");
            Map(d => d.DateOrdered).Name("DateOrdered");
            Map(d => d.DaysOrdered).Name("DaysOrdered");
            Map(d => d.Desk.Width).Name("Width");
            Map(d => d.Desk.Depth).Name("Depth");
            Map(d => d.Desk.NrDrawers).Name("NrDrawers");
            Map(d => d.Desk.Material).Name("Material");
        }
    }

}

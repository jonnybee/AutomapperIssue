using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoModel
{
    public class DemoDbInitializer : DropCreateDatabaseAlways<DemoContext>
    {
        protected override void Seed(DemoContext context)
        {
            context.Country.Add(new Country()
            {
                CountryCode = "AL",
                CountryName =
                    new Country.CountryNameCountryDomainLocalized()
                    {
                        ValueEn = "Albania",
                        ValueDa = "Albanien",
                        ValueDe = "Albania",
                        ValueFi = "Albania",
                        ValueNnNo = "Albania",
                        ValueNo = "Albania",
                        ValueSeNo = "Albánia",
                        ValueSv = "Albanien"
                    }
            });

            context.Country.Add(new Country()
            {
                CountryCode = "PH",
                CountryName =
                    new Country.CountryNameCountryDomainLocalized()
                    {
                        ValueEn = "Philippines",
                        ValueDa = "Filippinerne",
                        ValueDe = "Philippines",
                        ValueFi = "Filippiinit",
                        ValueNnNo = "Filippinene",
                        ValueNo = "Filippinene",
                        ValueSeNo = "Filippiinnat",
                        ValueSv = "Filippinerna"
                    }
            });

            base.Seed(context);
        }
    }
}

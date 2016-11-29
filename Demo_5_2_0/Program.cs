using System;
using System.Linq;
using System.Threading;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DemoModel;

namespace Demo_5_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(p =>
                {
                    CreateCustomMappingForLocalizedString(p);
                    p.CreateMap<Country, CountryViewModel>();

                }
            );

            var db = new DemoContext();
            var countries = db.Country.ProjectTo<CountryViewModel>(new {lang = "nb"}).ToList();


            foreach (var c in countries)
                Console.WriteLine($"{c.CountryId} : {c.CountryCode} : {c.CountryName}");

            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }



        public static void CreateCustomMappingForLocalizedString(IMapperConfigurationExpression cfg)
        {
            string lang = null;
            // Create MAP for LINQ Projections
            cfg.CreateMap<LocalizedString, string>()
                .ProjectUsing(src =>
                lang == "en"? src.ValueEn :
                lang == "da"? src.ValueDa :
                lang == "nn"? src.ValueNnNo :
                lang == "sv"? src.ValueSv :
                lang == "de" ? src.ValueDe :
                lang == "fi"? src.ValueFi :
                lang == "se"? src.ValueSeNo :
                src.ValueNo);
            cfg.CreateMap<LocalizedString, string>()
              .ConvertUsing(src =>
                Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "en" ? src.ValueEn :
                Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "da" ? src.ValueDa :
                Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "nn"? src.ValueNnNo :
                Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "sv"? src.ValueSv :
                Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "de"? src.ValueDe :
                Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "fi"? src.ValueFi :
                Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "se"? src.ValueSeNo :
                src.ValueNo);
        }
    }
}

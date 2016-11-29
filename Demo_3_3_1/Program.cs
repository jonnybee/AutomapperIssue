using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DemoModel;

namespace Demo_3_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCustomMappingForLocalizedString();
            Mapper.CreateMap<Country, CountryViewModel>();

            var db = new DemoContext();
            var countries = db.Country.Project().To<CountryViewModel>(new {lang = "nb"}).ToList();


            foreach (var c in countries)
                Console.WriteLine($"{c.CountryId} : {c.CountryCode} : {c.CountryName}");

            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }



        public static void CreateCustomMappingForLocalizedString()
        {
            string lang = null;
            // Create MAP for LINQ Projections
            var map = Mapper.CreateMap<LocalizedString, string>();
            map.ProjectUsing(src =>
                lang == "en"? src.ValueEn :
                lang == "da"? src.ValueDa :
                lang == "nn"? src.ValueNnNo :
                lang == "sv"? src.ValueSv :
                lang == "de" ? src.ValueDe :
                lang == "fi"? src.ValueFi :
                lang == "se"? src.ValueSeNo :
                src.ValueNo);
            // Create mapping for conversions of objects in memory
            map.ConvertUsing(src =>
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

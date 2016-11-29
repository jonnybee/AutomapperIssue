using System.Threading;
using AutoMapper;
using DemoModel;

namespace Demo_3_3_1
{
    public class LocalizedStringResolver : ValueResolver<LocalizedString, string>
    {
        protected override string ResolveCore(LocalizedString source)
        {
            var lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            switch (lang)
            {
                case "en":
                    return source.ValueEn;    // engelsk 
                case "da":
                    return source.ValueDa;      // dansk
                case "nn":
                    return source.ValueNnNo;    // nynorsk
                case "sv":
                    return source.ValueSv;      // svensk
                case "de":
                    return source.ValueDe;      // tysk
                case "fi":
                    return source.ValueFi;      // finsk
                case "se":
                    return source.ValueSeNo;    // samisk
                default:
                    return source.ValueNo;      // norsk
            }
        }
    }
}

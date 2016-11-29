using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Threading;

namespace DemoModel
{
    [ComplexType]
    [Serializable]
    public class LocalizedString
    {
        [NotMapped]
        public string Value
        {
            get { return (string)LanguageProperty().GetValue(this, null); }
            set { LanguageProperty().SetValue(this, value, null); }
        }

        private PropertyInfo LanguageProperty()
        {
            string currentLanguage = GetCurrentCultureLanguagePropertyName();
            return GetType().GetProperty(currentLanguage);
        }

        public static string GetCurrentCultureLanguagePropertyName()
        {
            var lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            return GetLanguagePropertyName(lang);
        }

        public static string GetLanguagePropertyName(string lang)
        {
            switch (lang)
            {
                case "en":
                    return nameof(ValueEn);    // engelsk 
                case "da":
                    return nameof(ValueDa);      // dansk
                case "nn":
                    return nameof(ValueNnNo);    // nynorsk
                case "sv":
                    return nameof(ValueSv);      // svensk
                case "de":
                    return nameof(ValueDe);      // tysk
                case "fi":
                    return nameof(ValueFi);      // finsk
                case "se":
                    return nameof(ValueSeNo);    // samisk
                default:
                    return nameof(ValueNo);      // norsk
            }
        }


        [Display(AutoGenerateField = false)]
        [ScaffoldColumn(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ValueNo { get; set; }

        [Display(AutoGenerateField = false)]
        [ScaffoldColumn(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ValueEn { get; set; }

        [Display(AutoGenerateField = false)]
        [ScaffoldColumn(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ValueDa { get; set; }

        [Display(AutoGenerateField = false)]
        [ScaffoldColumn(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ValueNnNo { get; set; }

        [Display(AutoGenerateField = false)]
        [ScaffoldColumn(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ValueSv { get; set; }

        [Display(AutoGenerateField = false)]
        [ScaffoldColumn(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ValueDe { get; set; }

        [Display(AutoGenerateField = false)]
        [ScaffoldColumn(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ValueFi { get; set; }

        [Display(AutoGenerateField = false)]
        [ScaffoldColumn(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ValueSeNo { get; set; }


        public override string ToString()
        {
            return Value;
        }

        public static explicit operator string(LocalizedString obj1)
        {
            if (obj1 == null) return null;
            return obj1.Value;
        }
    }

}

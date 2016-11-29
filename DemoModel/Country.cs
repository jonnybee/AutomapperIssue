using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoModel
{
    /// <summary>
    /// Source Table: COUNTRY
    /// </summary>
    /// <KeyProperties>
    /// CountryId
    /// </KeyProperties>
    [System.CodeDom.Compiler.GeneratedCode("WcEntityGenerator", "1.0.0.0")]
    [Serializable]
    public partial class Country
    {
        [ComplexType]
        public class CountryNameCountryDomainLocalized : LocalizedString
        {
        }

        public Country()
        {
            CountryName = new CountryNameCountryDomainLocalized();
        }

        /// <summary>
        /// Source Column: COUNTRY_ID, int64, NOT NULL
        /// </summary>
        [Key, ScaffoldColumn(false)]
        [Required()]
        public long CountryId { get; set; }

        /// <summary>
        /// Source Column: COUNTRY_NAME, VARCHAR2(50)
        /// </summary>
        //[MaxLength(50, ErrorMessage="[[[%0 must be %1 characters or less|||(((CountryName)))|||50]]]")]
        //[DisplayName("[[[CountryName]]]")]
        [ScaffoldColumn(false)]
        [Display(AutoGenerateField = false)]
        public CountryNameCountryDomainLocalized CountryName { get; set; }


        /// <summary>
        /// Source Column: COUNTRY_CODE, VARCHAR2(20)
        /// </summary>
        [MaxLength(20)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Source Column: CULTURE_NAME_ID, VARCHAR2(99)
        /// </summary>
        [MaxLength(99)]
        public string CultureNameId { get; set; }

    }
}
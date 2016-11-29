using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DemoModel
{
    [System.CodeDom.Compiler.GeneratedCode("WcEntityGenerator", "1.0.0.0")]
    [Serializable]
    public partial class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            // Table & Column Mappings
            ToTable("COUNTRY");
            HasKey(p => new { p.CountryId });
            Property(t => t.CountryId).HasColumnName("COUNTRY_ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.CountryName.ValueNo).HasColumnName("COUNTRY_NAME");
            Property(t => t.CountryCode).HasColumnName("COUNTRY_CODE");
            Property(t => t.CountryName.ValueEn).HasColumnName("EN__COUNTRY_NAME");
            Property(t => t.CountryName.ValueDa).HasColumnName("DA__COUNTRY_NAME");
            Property(t => t.CountryName.ValueNnNo).HasColumnName("NN_NO__COUNTRY_NAME");
            Property(t => t.CountryName.ValueSv).HasColumnName("SV__COUNTRY_NAME");
            Property(t => t.CountryName.ValueDe).HasColumnName("DE__COUNTRY_NAME");
            Property(t => t.CountryName.ValueFi).HasColumnName("FI__COUNTRY_NAME");
            Property(t => t.CultureNameId).HasColumnName("CULTURE_NAME_ID");
            Property(t => t.CountryName.ValueSeNo).HasColumnName("SE_NO__COUNTRY_NAME");
        }
    }

}

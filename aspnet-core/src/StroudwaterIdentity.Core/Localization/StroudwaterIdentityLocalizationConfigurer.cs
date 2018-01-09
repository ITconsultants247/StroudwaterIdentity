using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace StroudwaterIdentity.Localization
{
    public static class StroudwaterIdentityLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(StroudwaterIdentityConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(StroudwaterIdentityLocalizationConfigurer).GetAssembly(),
                        "StroudwaterIdentity.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

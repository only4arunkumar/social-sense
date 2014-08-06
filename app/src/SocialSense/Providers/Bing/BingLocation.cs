using System.Collections.Generic;
using SocialSense.Shared;

namespace SocialSense.Providers.Bing
{
    public class BingLocation : ILocation
    {
        private readonly IDictionary<Country, string> countries = new Dictionary<Country, string>
        {
            { Country.Undefined, string.Empty },
            { Country.Afghanistan, "&latitude=33.0&longitude=65.0" },
            { Country.Albania, "&latitude=41.0&longitude=20.0" },
            { Country.Algeria, "&latitude=28.0&longitude=3.0" },
            { Country.AmericanSamoa, "&latitude=-14.3333&longitude=-170.0" },
            { Country.Andorra, "&latitude=42.5&longitude=1.5" },
            { Country.Angola, "&latitude=-12.5&longitude=18.5" },
            { Country.Anguilla, "&latitude=18.25&longitude=-63.1667" },
            { Country.AntiguaandBarbuda, "&latitude=17.05&longitude=-61.8" },
            { Country.Argentina, "&latitude=-34.0&longitude=-64.0" },
            { Country.Armenia, "&latitude=40.0&longitude=45.0" },
            { Country.Aruba, "&latitude=12.5&longitude=-69.9667" },
            { Country.Australia, "&latitude=-27.0&longitude=133.0" },
            { Country.Austria, "&latitude=47.3333&longitude=13.3333" },
            { Country.Azerbaijan, "&latitude=40.5&longitude=47.5" },
            { Country.Bahamas, "&latitude=24.25&longitude=-76.0" },
            { Country.Bahrain, "&latitude=26.0&longitude=50.55" },
            { Country.Bangladesh, "&latitude=24.0&longitude=90.0" },
            { Country.Barbados, "&latitude=13.1667&longitude=-59.5333" },
            { Country.Belarus, "&latitude=53.0&longitude=28.0" },
            { Country.Belgium, "&latitude=50.8333&longitude=4.0" },
            { Country.Belize, "&latitude=17.25&longitude=-88.75" },
            { Country.Benin, "&latitude=9.5&longitude=2.25" },
            { Country.Bermuda, "&latitude=32.3333&longitude=-64.75" },
            { Country.Bhutan, "&latitude=27.5&longitude=90.5" },
            { Country.Bolivia, "&latitude=-17.0&longitude=-65.0" },
            { Country.BosniaandHerzegovina, "&latitude=44.0&longitude=18.0" },
            { Country.Botswana, "&latitude=-22.0&longitude=24.0" },
            { Country.BouvetIsland, "&latitude=-54.4333&longitude=3.4" },
            { Country.Brazil, "&latitude=-10.0&longitude=-55.0" },
            { Country.Bulgaria, "&latitude=43.0&longitude=25.0" },
            { Country.BurkinaFaso, "&latitude=13.0&longitude=-2.0" },
            { Country.Burundi, "&latitude=-3.5&longitude=30.0" },
            { Country.Cambodia, "&latitude=13.0&longitude=105.0" },
            { Country.Cameroon, "&latitude=6.0&longitude=12.0" },
            { Country.Canada, "&latitude=60.0&longitude=-95.0" },
            { Country.CapeVerde, "&latitude=16.0&longitude=-24.0" },
            { Country.CaymanIslands, "&latitude=19.5&longitude=-80.5" },
            { Country.CentralAfricanRepublic, "&latitude=7.0&longitude=21.0" },
            { Country.Chad, "&latitude=15.0&longitude=19.0" },
            { Country.Chile, "&latitude=-30.0&longitude=-71.0" },
            { Country.China, "&latitude=35.0&longitude=105.0" },
            { Country.Colombia, "&latitude=4.0&longitude=-72.0" },
            { Country.Comoros, "&latitude=-12.1667&longitude=44.25" },
            { Country.Congo, "&latitude=-1.0&longitude=15.0" },
            { Country.CookIslands, "&latitude=-21.2333&longitude=-159.7667" },
            { Country.CostaRica, "&latitude=10.0&longitude=-84.0" },
            { Country.Cuba, "&latitude=21.5&longitude=-80.0" },
            { Country.Cyprus, "&latitude=35.0&longitude=33.0" },
            { Country.CzechRepublic, "&latitude=49.75&longitude=15.5" },
            { Country.Denmark, "&latitude=56.0&longitude=10.0" },
            { Country.Djibouti, "&latitude=11.5&longitude=43.0" },
            { Country.Dominica, "&latitude=15.4167&longitude=-61.3333" },
            { Country.DominicanRepublic, "&latitude=19.0&longitude=-70.6667" },
            { Country.Ecuador, "&latitude=-2.0&longitude=-77.5" },
            { Country.Egypt, "&latitude=27.0&longitude=30.0" },
            { Country.ElSalvador, "&latitude=13.8333&longitude=-88.9167" },
            { Country.EquatorialGuinea, "&latitude=2.0&longitude=10.0" },
            { Country.Eritrea, "&latitude=15.0&longitude=39.0" },
            { Country.Estonia, "&latitude=59.0&longitude=26.0" },
            { Country.Ethiopia, "&latitude=8.0&longitude=38.0" },
            { Country.FalklandIslands, "&latitude=-51.75&longitude=-59.0" },
            { Country.Fiji, "&latitude=-18.0&longitude=175.0" },
            { Country.Finland, "&latitude=64.0&longitude=26.0" },
            { Country.France, "&latitude=46.0&longitude=2.0" },
            { Country.FrenchGuiana, "&latitude=4.0&longitude=-53.0" },
            { Country.FrenchPolynesia, "&latitude=-15.0&longitude=-140.0" },
            { Country.Gabon, "&latitude=-1.0&longitude=11.75" },
            { Country.Gambia, "&latitude=13.4667&longitude=-16.5667" },
            { Country.Georgia, "&latitude=42.0&longitude=43.5" },
            { Country.Germany, "&latitude=51.0&longitude=9.0" },
            { Country.Ghana, "&latitude=8.0&longitude=-2.0" },
            { Country.Greece, "&latitude=39.0&longitude=22.0" },
            { Country.Greenland, "&latitude=72.0&longitude=-40.0" },
            { Country.Grenada, "&latitude=12.1167&longitude=-61.6667" },
            { Country.Guadeloupe, "&latitude=16.25&longitude=-61.5833" },
            { Country.Guam, "&latitude=13.4667&longitude=144.7833" },
            { Country.Guatemala, "&latitude=15.5&longitude=-90.25" },
            { Country.Guinea, "&latitude=11.0&longitude=-10.0" },
            { Country.Guyana, "&latitude=5.0&longitude=-59.0" },
            { Country.Haiti, "&latitude=19.0&longitude=-72.4167" },
            { Country.Honduras, "&latitude=15.0&longitude=-86.5" },
            { Country.HongKong, "&latitude=22.25&longitude=114.1667" },
            { Country.Hungary, "&latitude=47.0&longitude=20.0" },
            { Country.Iceland, "&latitude=65.0&longitude=-18.0" },
            { Country.India, "&latitude=20.0&longitude=77.0" },
            { Country.Indonesia, "&latitude=-5.0&longitude=120.0" },
            { Country.Iran, "&latitude=32.0&longitude=53.0" },
            { Country.Iraq, "&latitude=33.0&longitude=44.0" },
            { Country.Ireland, "&latitude=53.0&longitude=-8.0" },
            { Country.Israel, "&latitude=31.5&longitude=34.75" },
            { Country.Italy, "&latitude=42.8333&longitude=12.8333" },
            { Country.Jamaica, "&latitude=18.25&longitude=-77.5" },
            { Country.Japan, "&latitude=36.0&longitude=138.0" },
            { Country.Jordan, "&latitude=31.0&longitude=36.0" },
            { Country.Kazakhstan, "&latitude=48.0&longitude=68.0" },
            { Country.Kenya, "&latitude=1.0&longitude=38.0" },
            { Country.Kiribati, "&latitude=1.4167&longitude=173.0" },
            { Country.RepublicofKorea, "&latitude=37.0&longitude=127.5" },
            { Country.Kuwait, "&latitude=29.3375&longitude=47.6581" },
            { Country.Kyrgyzstan, "&latitude=41.0&longitude=75.0" },
            { Country.Latvia, "&latitude=57.0&longitude=25.0" },
            { Country.Lebanon, "&latitude=33.8333&longitude=35.8333" },
            { Country.Lesotho, "&latitude=-29.5&longitude=28.5" },
            { Country.Liberia, "&latitude=6.5&longitude=-9.5" },
            { Country.Liechtenstein, "&latitude=47.1667&longitude=9.5333" },
            { Country.Lithuania, "&latitude=56.0&longitude=24.0" },
            { Country.Luxembourg, "&latitude=49.75&longitude=6.1667" },
            { Country.Madagascar, "&latitude=-20.0&longitude=47.0" },
            { Country.Malawi, "&latitude=-13.5&longitude=34.0" },
            { Country.Malaysia, "&latitude=2.5&longitude=112.5" },
            { Country.Maldives, "&latitude=3.25&longitude=73.0" },
            { Country.Mali, "&latitude=17.0&longitude=-4.0" },
            { Country.Malta, "&latitude=35.8333&longitude=14.5833" },
            { Country.Martinique, "&latitude=14.6667&longitude=-61.0" },
            { Country.Mauritania, "&latitude=20.0&longitude=-12.0" },
            { Country.Mauritius, "&latitude=-20.2833&longitude=57.55" },
            { Country.Mayotte, "&latitude=-12.8333&longitude=45.1667" },
            { Country.Mexico, "&latitude=23.0&longitude=-102.0" },
            { Country.Monaco, "&latitude=43.7333&longitude=7.4" },
            { Country.Mongolia, "&latitude=46.0&longitude=105.0" },
            { Country.Montserrat, "&latitude=16.75&longitude=-62.2" },
            { Country.Morocco, "&latitude=32.0&longitude=-5.0" },
            { Country.Mozambique, "&latitude=-18.25&longitude=35.0" },
            { Country.Myanmar, "&latitude=22.0&longitude=98.0" },
            { Country.Namibia, "&latitude=-22.0&longitude=17.0" },
            { Country.Nauru, "&latitude=-0.5333&longitude=166.9167" },
            { Country.Nepal, "&latitude=28.0&longitude=84.0" },
            { Country.Netherlands, "&latitude=52.5&longitude=5.75" },
            { Country.NewCaledonia, "&latitude=-21.5&longitude=165.5" },
            { Country.NewZealand, "&latitude=-41.0&longitude=174.0" },
            { Country.Nicaragua, "&latitude=13.0&longitude=-85.0" },
            { Country.Niger, "&latitude=16.0&longitude=8.0" },
            { Country.Nigeria, "&latitude=10.0&longitude=8.0" },
            { Country.Niue, "&latitude=-19.0333&longitude=-169.8667" },
            { Country.NorfolkIsland, "&latitude=-29.0333&longitude=167.95" },
            { Country.Norway, "&latitude=62.0&longitude=10.0" },
            { Country.Oman, "&latitude=21.0&longitude=57.0" },
            { Country.Pakistan, "&latitude=30.0&longitude=70.0" },
            { Country.Palau, "&latitude=7.5&longitude=134.5" },
            { Country.Panama, "&latitude=9.0&longitude=-80.0" },
            { Country.PapuaNewGuinea, "&latitude=-6.0&longitude=147.0" },
            { Country.Paraguay, "&latitude=-23.0&longitude=-58.0" },
            { Country.Peru, "&latitude=-10.0&longitude=-76.0" },
            { Country.Philippines, "&latitude=13.0&longitude=122.0" },
            { Country.Poland, "&latitude=52.0&longitude=20.0" },
            { Country.Portugal, "&latitude=39.5&longitude=-8.0" },
            { Country.PuertoRico, "&latitude=18.25&longitude=-66.5" },
            { Country.Qatar, "&latitude=25.5&longitude=51.25" },
            { Country.Romania, "&latitude=46.0&longitude=25.0" },
            { Country.RussianFederation, "&latitude=60.0&longitude=100.0" },
            { Country.Rwanda, "&latitude=-2.0&longitude=30.0" },
            { Country.SaintHelena, "&latitude=-15.9333&longitude=-5.7" },
            { Country.SaintKittsandNevis, "&latitude=17.3333&longitude=-62.75" },
            { Country.SaintLucia, "&latitude=13.8833&longitude=-61.1333" },
            { Country.SaintPierreandMiquelon, "&latitude=46.8333&longitude=-56.3333" },
            { Country.SaintVincentandtheGrenadines, "&latitude=13.25&longitude=-61.2" },
            { Country.Samoa, "&latitude=-13.5833&longitude=-172.3333" },
            { Country.SanMarino, "&latitude=43.7667&longitude=12.4167" },
            { Country.SaoTomeandPrincipe, "&latitude=1.0&longitude=7.0" },
            { Country.SaudiArabia, "&latitude=25.0&longitude=45.0" },
            { Country.Senegal, "&latitude=14.0&longitude=-14.0" },
            { Country.Seychelles, "&latitude=-4.5833&longitude=55.6667" },
            { Country.SierraLeone, "&latitude=8.5&longitude=-11.5" },
            { Country.Singapore, "&latitude=1.3667&longitude=103.8" },
            { Country.Slovenia, "&latitude=46.0&longitude=15.0" },
            { Country.SolomonIslands, "&latitude=-8.0&longitude=159.0" },
            { Country.Somalia, "&latitude=10.0&longitude=49.0" },
            { Country.SouthAfrica, "&latitude=-29.0&longitude=24.0" },
            { Country.Spain, "&latitude=40.0&longitude=-4.0" },
            { Country.SriLanka, "&latitude=7.0&longitude=81.0" },
            { Country.Sudan, "&latitude=15.0&longitude=30.0" },
            { Country.Suriname, "&latitude=4.0&longitude=-56.0" },
            { Country.SvalbardandJanMayenIslands, "&latitude=78.0&longitude=20.0" },
            { Country.Swaziland, "&latitude=-26.5&longitude=31.5" },
            { Country.Sweden, "&latitude=62.0&longitude=15.0" },
            { Country.Switzerland, "&latitude=47.0&longitude=8.0" },
            { Country.Taiwan, "&latitude=23.5&longitude=121.0" },
            { Country.Tajikistan, "&latitude=39.0&longitude=71.0" },
            { Country.Thailand, "&latitude=15.0&longitude=100.0" },
            { Country.Togo, "&latitude=8.0&longitude=1.1667" },
            { Country.Tokelau, "&latitude=-9.0&longitude=-172.0" },
            { Country.Tonga, "&latitude=-20.0&longitude=-175.0" },
            { Country.TrinidadandTobago, "&latitude=11.0&longitude=-61.0" },
            { Country.Tunisia, "&latitude=34.0&longitude=9.0" },
            { Country.Turkey, "&latitude=39.0&longitude=35.0" },
            { Country.Turkmenistan, "&latitude=40.0&longitude=60.0" },
            { Country.TurksandCaicosIslands, "&latitude=21.75&longitude=-71.5833" },
            { Country.Tuvalu, "&latitude=-8.0&longitude=178.0" },
            { Country.Uganda, "&latitude=1.0&longitude=32.0" },
            { Country.Ukraine, "&latitude=49.0&longitude=32.0" },
            { Country.UnitedArabEmirates, "&latitude=24.0&longitude=54.0" },
            { Country.Uruguay, "&latitude=-33.0&longitude=-56.0" },
            { Country.Uzbekistan, "&latitude=41.0&longitude=64.0" },
            { Country.Vanuatu, "&latitude=-16.0&longitude=167.0" },
            { Country.Venezuela, "&latitude=8.0&longitude=-66.0" },
            { Country.Vietnam, "&latitude=16.0&longitude=106.0" },
            { Country.WallisandFutunaIslands, "&latitude=-13.3&longitude=-176.2" },
            { Country.WesternSahara, "&latitude=24.5&longitude=-13.0" },
            { Country.Yemen, "&latitude=15.0&longitude=48.0" },
            { Country.Zambia, "&latitude=-15.0&longitude=30.0" }
        };

        private readonly IDictionary<Language, string> languages = new Dictionary<Language, string>
        {
            { Language.Undefined, string.Empty },
            { Language.Afar, string.Empty },
            { Language.Abkhazian, string.Empty },
            { Language.Avestan, string.Empty },
            { Language.Afrikaans, string.Empty },
            { Language.Akan, string.Empty },
            { Language.Amharic, string.Empty },
            { Language.Aragonese, string.Empty },
            { Language.Arabic, "ar" },
            { Language.Assamese, string.Empty },
            { Language.Avaric, string.Empty },
            { Language.Aymara, string.Empty },
            { Language.Azerbaijani, string.Empty },
            { Language.Bashkir, string.Empty },
            { Language.Belarusian, string.Empty },
            { Language.Bulgarian, "bg" },
            { Language.Bihari, string.Empty },
            { Language.Bislama, string.Empty },
            { Language.Bambara, string.Empty },
            { Language.Bengali, string.Empty },
            { Language.Tibetan, string.Empty },
            { Language.Breton, string.Empty },
            { Language.Bosnian, string.Empty },
            { Language.Catalan, "ca" },
            { Language.Chechen, string.Empty },
            { Language.Chamorro, string.Empty },
            { Language.Corsican, string.Empty },
            { Language.Cree, string.Empty },
            { Language.Czech, "cs" },
            { Language.ChurchSlavic, string.Empty },
            { Language.Chuvash, string.Empty },
            { Language.Welsh, string.Empty },
            { Language.Danish, "da" },
            { Language.German, "de" },
            { Language.Divehi, string.Empty },
            { Language.Dzongkha, string.Empty },
            { Language.Ewe, string.Empty },
            { Language.Greek, "el" },
            { Language.English, "en" },
            { Language.Esperanto, string.Empty },
            { Language.Spanish, "es" },
            { Language.Estonian, "et" },
            { Language.Basque, string.Empty },
            { Language.Persian, "fa" },
            { Language.Fulah, string.Empty },
            { Language.Finnish, "fi" },
            { Language.Fijian, string.Empty },
            { Language.Faroese, string.Empty },
            { Language.French, "fr" },
            { Language.WesternFrisian, string.Empty },
            { Language.Irish, string.Empty },
            { Language.ScottishGaelic, string.Empty },
            { Language.Galician, string.Empty },
            { Language.Guaraní, string.Empty },
            { Language.Gujarati, string.Empty },
            { Language.Manx, string.Empty },
            { Language.Hausa, string.Empty },
            { Language.Hebrew, "he" },
            { Language.Hindi, string.Empty },
            { Language.HiriMotu, string.Empty },
            { Language.Croatian, "hr" },
            { Language.Haitian, string.Empty },
            { Language.Hungarian, "hu" },
            { Language.Armenian, string.Empty },
            { Language.Herero, string.Empty },
            { Language.Interlingua, string.Empty },
            { Language.Indonesian, "id" },
            { Language.Interlingue, string.Empty },
            { Language.Igbo, string.Empty },
            { Language.SichuanYi, string.Empty },
            { Language.Inupiaq, string.Empty },
            { Language.Ido, string.Empty },
            { Language.Icelandic, "is" },
            { Language.Italian, "it" },
            { Language.Inuktitut, string.Empty },
            { Language.Japanese, "ja" },
            { Language.Javanese, string.Empty },
            { Language.Georgian, string.Empty },
            { Language.Kongo, string.Empty },
            { Language.Kikuyu, string.Empty },
            { Language.Kwanyama, string.Empty },
            { Language.Kazakh, string.Empty },
            { Language.Kalaallisut, string.Empty },
            { Language.Khmer, string.Empty },
            { Language.Kannada, string.Empty },
            { Language.Korean, "ko" },
            { Language.Kanuri, string.Empty },
            { Language.Kashmiri, string.Empty },
            { Language.Kurdish, string.Empty },
            { Language.Komi, string.Empty },
            { Language.Cornish, string.Empty },
            { Language.Kirghiz, string.Empty },
            { Language.Latin, string.Empty },
            { Language.Luxembourgish, string.Empty },
            { Language.Ganda, string.Empty },
            { Language.Limburgish, string.Empty },
            { Language.Lingala, string.Empty },
            { Language.Lao, string.Empty },
            { Language.Lithuanian, "lt" },
            { Language.LubaKatanga, string.Empty },
            { Language.Latvian, "lv" },
            { Language.Malagasy, string.Empty },
            { Language.Marshallese, string.Empty },
            { Language.Maori, string.Empty },
            { Language.Macedonian, string.Empty },
            { Language.Malayalam, "ms" },
            { Language.Mongolian, string.Empty },
            { Language.Marathi, string.Empty },
            { Language.Malay, string.Empty },
            { Language.Maltese, string.Empty },
            { Language.Burmese, string.Empty },
            { Language.Nauru, string.Empty },
            { Language.NorwegianBokmal, "nb" },
            { Language.NorthNdebele, string.Empty },
            { Language.Nepali, string.Empty },
            { Language.Ndonga, string.Empty },
            { Language.Dutch, "nl" },
            { Language.NorwegianNynors, string.Empty },
            { Language.Norwegian, string.Empty },
            { Language.SouthNdebele, string.Empty },
            { Language.Navajo, string.Empty },
            { Language.Chichewa, string.Empty },
            { Language.Occitan, string.Empty },
            { Language.Ojibwa, string.Empty },
            { Language.Oromo, string.Empty },
            { Language.Oriya, string.Empty },
            { Language.Ossetian, string.Empty },
            { Language.Panjabi, string.Empty },
            { Language.Pali, string.Empty },
            { Language.Polish, "pl" },
            { Language.Pashto, string.Empty },
            { Language.Portuguese, "pt_br" },
            { Language.Quechua, string.Empty },
            { Language.RaetoRomance, string.Empty },
            { Language.Kirundi, string.Empty },
            { Language.Romanian, "ro" },
            { Language.Russian, "ru" },
            { Language.Kinyarwanda, string.Empty },
            { Language.Sanskrit, string.Empty },
            { Language.Sardinian, string.Empty },
            { Language.Sindhi, string.Empty },
            { Language.NorthernSami, string.Empty },
            { Language.Sango, string.Empty },
            { Language.SerboCroatian, string.Empty },
            { Language.Sinhala, string.Empty },
            { Language.Slovak, "sk" },
            { Language.Slovenian, "sl" },
            { Language.Samoan, string.Empty },
            { Language.Shona, string.Empty },
            { Language.Somali, string.Empty },
            { Language.Albanian, "sq" },
            { Language.Serbian, "sr" },
            { Language.Swati, string.Empty },
            { Language.SouthernSotho, string.Empty },
            { Language.Sundanese, string.Empty },
            { Language.Swedish, "sv" },
            { Language.Swahili, string.Empty },
            { Language.Tamil, string.Empty },
            { Language.Telugu, string.Empty },
            { Language.Tajik, string.Empty },
            { Language.Thai, "th" },
            { Language.Tigrinya, string.Empty },
            { Language.Turkmen, string.Empty },
            { Language.Tagalog, string.Empty },
            { Language.Tswana, string.Empty },
            { Language.Tonga, string.Empty },
            { Language.Turkish, "tr" },
            { Language.Tsonga, string.Empty },
            { Language.Tatar, string.Empty },
            { Language.Twi, string.Empty },
            { Language.Tahitian, string.Empty },
            { Language.Uighur, string.Empty },
            { Language.Ukrainian, "uk" },
            { Language.Urdu, string.Empty },
            { Language.Uzbek, string.Empty },
            { Language.Venda, string.Empty },
            { Language.Vietnamese, "vi" },
            { Language.Volapük, string.Empty },
            { Language.Walloon, string.Empty },
            { Language.Wolof, string.Empty },
            { Language.Xhosa, string.Empty },
            { Language.Yiddish, string.Empty },
            { Language.Yoruba, string.Empty },
            { Language.Zhuang, string.Empty },
            { Language.Chinese, "zh_cht" },
            { Language.Zulu, string.Empty },
        };

        public string GetCountry(Country country)
        {
            return this.countries[country];
        }

        public string GetLanguage(Language language)
        {
            return this.languages[language];
        }
    }
}
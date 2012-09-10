﻿namespace SocialSense.UrlBuilders.Parameters
{
    using System.Collections.Generic;

    using SocialSense.Shared;

    internal class TwitterLocation : ILocation
    {
        private readonly IDictionary<Language, string> languages = new Dictionary<Language, string>
        {
            { Language.Undefined, string.Empty }, { Language.Afar, "aa" }, { Language.Abkhazian, "ab" },
            { Language.Avestan, "ae" }, { Language.Afrikaans, "af" }, { Language.Akan, "ak" },
            { Language.Amharic, "am" }, { Language.Aragonese, "an" }, { Language.Arabic, "ar" },
            { Language.Assamese, "as" }, { Language.Avaric, "av" }, { Language.Aymara, "ay" },
            { Language.Azerbaijani, "az" }, { Language.Bashkir, "ba" }, { Language.Belarusian, "be" },
            { Language.Bulgarian, "bg" }, { Language.Bihari, "bh" }, { Language.Bislama, "bi" },
            { Language.Bambara, "bm" }, { Language.Bengali, "bn" }, { Language.Tibetan, "bo" },
            { Language.Breton, "br" }, { Language.Bosnian, "bs" }, { Language.Catalan, "ca" },
            { Language.Chechen, "ce" }, { Language.Chamorro, "ch" }, { Language.Corsican, "co" },
            { Language.Cree, "cr" }, { Language.Czech, "cs" }, { Language.ChurchSlavic, "cu" },
            { Language.Chuvash, "cv" }, { Language.Welsh, "cy" }, { Language.Danish, "da" }, { Language.German, "de" },
            { Language.Divehi, "dv" }, { Language.Dzongkha, "dz" }, { Language.Ewe, "ee" }, { Language.Greek, "el" },
            { Language.English, "en" }, { Language.Esperanto, "eo" }, { Language.Spanish, "es" },
            { Language.Estonian, "et" }, { Language.Basque, "eu" }, { Language.Persian, "fa" },
            { Language.Fulah, "ff" }, { Language.Finnish, "fi" }, { Language.Fijian, "fj" },
            { Language.Faroese, "fo" }, { Language.French, "fr" }, { Language.WesternFrisian, "fy" },
            { Language.Irish, "ga" }, { Language.ScottishGaelic, "gd" }, { Language.Galician, "gl" },
            { Language.Guaraní, "gn" }, { Language.Gujarati, "gu" }, { Language.Manx, "gv" }, { Language.Hausa, "ha" },
            { Language.Hebrew, "he" }, { Language.Hindi, "hi" }, { Language.HiriMotu, "ho" },
            { Language.Croatian, "hr" }, { Language.Haitian, "ht" }, { Language.Hungarian, "hu" },
            { Language.Armenian, "hy" }, { Language.Herero, "hz" }, { Language.Interlingua, "ia" },
            { Language.Indonesian, "id" }, { Language.Interlingue, "ie" }, { Language.Igbo, "ig" },
            { Language.SichuanYi, "ii" }, { Language.Inupiaq, "ik" }, { Language.Ido, "io" },
            { Language.Icelandic, "is" }, { Language.Italian, "it" }, { Language.Inuktitut, "iu" },
            { Language.Japanese, "ja" }, { Language.Javanese, "jv" }, { Language.Georgian, "ka" },
            { Language.Kongo, "kg" }, { Language.Kikuyu, "ki" }, { Language.Kwanyama, "kj" },
            { Language.Kazakh, "kk" }, { Language.Kalaallisut, "kl" }, { Language.Khmer, "km" },
            { Language.Kannada, "kn" }, { Language.Korean, "ko" }, { Language.Kanuri, "kr" },
            { Language.Kashmiri, "ks" }, { Language.Kurdish, "ku" }, { Language.Komi, "kv" },
            { Language.Cornish, "kw" }, { Language.Kirghiz, "ky" }, { Language.Latin, "la" },
            { Language.Luxembourgish, "lb" }, { Language.Ganda, "lg" }, { Language.Limburgish, "li" },
            { Language.Lingala, "ln" }, { Language.Lao, "lo" }, { Language.Lithuanian, "lt" },
            { Language.LubaKatanga, "lu" }, { Language.Latvian, "lv" }, { Language.Malagasy, "mg" },
            { Language.Marshallese, "mh" }, { Language.Maori, "mi" }, { Language.Macedonian, "mk" },
            { Language.Malayalam, "ml" }, { Language.Mongolian, "mn" }, { Language.Marathi, "mr" },
            { Language.Malay, "ms" }, { Language.Maltese, "mt" }, { Language.Burmese, "my" }, { Language.Nauru, "na" },
            { Language.NorwegianBokmal, "nb" }, { Language.NorthNdebele, "nd" }, { Language.Nepali, "ne" },
            { Language.Ndonga, "ng" }, { Language.Dutch, "nl" }, { Language.NorwegianNynors, "nn" },
            { Language.Norwegian, "no" }, { Language.SouthNdebele, "nr" }, { Language.Navajo, "nv" },
            { Language.Chichewa, "ny" }, { Language.Occitan, "oc" }, { Language.Ojibwa, "oj" },
            { Language.Oromo, "om" }, { Language.Oriya, "or" }, { Language.Ossetian, "os" },
            { Language.Panjabi, "pa" }, { Language.Pali, "pi" }, { Language.Polish, "pl" }, { Language.Pashto, "ps" },
            { Language.Portuguese, "pt" }, { Language.Quechua, "qu" }, { Language.RaetoRomance, "rm" },
            { Language.Kirundi, "rn" }, { Language.Romanian, "ro" }, { Language.Russian, "ru" },
            { Language.Kinyarwanda, "rw" }, { Language.Sanskrit, "sa" }, { Language.Sardinian, "sc" },
            { Language.Sindhi, "sd" }, { Language.NorthernSami, "se" }, { Language.Sango, "sg" },
            { Language.SerboCroatian, "sh" }, { Language.Sinhala, "si" }, { Language.Slovak, "sk" },
            { Language.Slovenian, "sl" }, { Language.Samoan, "sm" }, { Language.Shona, "sn" },
            { Language.Somali, "so" }, { Language.Albanian, "sq" }, { Language.Serbian, "sr" },
            { Language.Swati, "ss" }, { Language.SouthernSotho, "st" }, { Language.Sundanese, "su" },
            { Language.Swedish, "sv" }, { Language.Swahili, "sw" }, { Language.Tamil, "ta" },
            { Language.Telugu, "te" }, { Language.Tajik, "tg" }, { Language.Thai, "th" }, { Language.Tigrinya, "ti" },
            { Language.Turkmen, "tk" }, { Language.Tagalog, "tl" }, { Language.Tswana, "tn" },
            { Language.Tonga, "to" }, { Language.Turkish, "tr" }, { Language.Tsonga, "ts" }, { Language.Tatar, "tt" },
            { Language.Twi, "tw" }, { Language.Tahitian, "ty" }, { Language.Uighur, "ug" },
            { Language.Ukrainian, "uk" }, { Language.Urdu, "ur" }, { Language.Uzbek, "uz" }, { Language.Venda, "ve" },
            { Language.Vietnamese, "vi" }, { Language.Volapük, "vo" }, { Language.Walloon, "wa" },
            { Language.Wolof, "wo" }, { Language.Xhosa, "xh" }, { Language.Yiddish, "yi" }, { Language.Yoruba, "yo" },
            { Language.Zhuang, "za" }, { Language.Chinese, "zh" }, { Language.Zulu, "zu" }
        };

        private readonly IDictionary<Country, string> countries = new Dictionary<Country, string>
        {
            { Country.Undefined, string.Empty },
            { Country.Afghanistan, "11.7559388,40.9586880,1000km" },
            { Country.AlandIslands, string.Empty },
            { Country.Albania, "60.1454451,16.1678403,1000km" },
            { Country.Algeria, "dz" },
            { Country.AmericanSamoa, "as" },
            { Country.Andorra, "ad" },
            { Country.Angola, "ao" },
            { Country.Anguilla, "ai" },
            { Country.AntiguaandBarbuda, "ag" },
            { Country.Argentina, "-46.8048979,-80.0082739,1000km" },
            { Country.Armenia, "am" },
            { Country.Aruba, "aw" },
            { Country.Australia, "au" },
            { Country.Austria, "at" },
            { Country.Azerbaijan, "az" },
            { Country.Bahamas, "bs" },
            { Country.Bahrain, "bh" },
            { Country.Bangladesh, "bd" },
            { Country.Barbados, "bb" },
            { Country.Belarus, "by" },
            { Country.Belgium, "be" },
            { Country.Belize, "bz" },
            { Country.Benin, "bj" },
            { Country.Bermuda, "bm" },
            { Country.Bhutan, "bt" },
            { Country.Bolivia, "-21.6896525,-71.7844540,1000km" },
            { Country.BosniaandHerzegovina, "ba" },
            { Country.Botswana, "bw" },
            { Country.Brazil, "-14.2350040,-51.9252800,1000km" },
            { Country.BritishVirginIslands, "vg" },
            { Country.BruneiDarussalam, "bn" },
            { Country.Bulgaria, "bg" },
            { Country.BurkinaFaso, "bf" },
            { Country.Burundi, "bi" },
            { Country.Cambodia, "kh" },
            { Country.Cameroon, "cm" },
            { Country.Canada, "ca" },
            { Country.CapeVerde, "cv" },
            { Country.CaymanIslands, "ky" },
            { Country.CentralAfricanRepublic, "cf" },
            { Country.Chad, "td" },
            { Country.ChannelIslands, string.Empty },
            { Country.Chile, "-51.9984098,-104.3261729,1000km" },
            { Country.China, "cn" },
            { Country.HongKongSpecialAdministrativeRegionofChina, "hk" },
            { Country.MacaoSpecialAdministrativeRegionofChina, "mo" },
            { Country.Colombia, "4.5708680,-74.2973330,1000km" },
            { Country.Comoros, "km" },
            { Country.Congo, "cg" },
            { Country.CookIslands, "ck" },
            { Country.CostaRica, "9.7489170,-83.7534280,1000km" },
            { Country.CotedIvoire, "ci" },
            { Country.Croatia, "hr" },
            { Country.Cuba, "cu" },
            { Country.Cyprus, "cy" },
            { Country.CzechRepublic, "cz" },
            { Country.DemocraticPeopleRepublicofKorea, "kp" },
            { Country.DemocraticRepublicoftheCongo, "cd" },
            { Country.Denmark, "dk" },
            { Country.Djibouti, "dj" },
            { Country.Dominica, "dm" },
            { Country.DominicanRepublic, "18.7356930,-70.1626510,1000km" },
            { Country.Ecuador, "-1.8312390,-78.1834060,1000km" },
            { Country.Egypt, "eg" },
            { Country.ElSalvador, "13.7941850,-88.8965300,1000km" },
            { Country.EquatorialGuinea, "gq" },
            { Country.Eritrea, "er" },
            { Country.Estonia, "ee" },
            { Country.Ethiopia, "et" },
            { Country.FaeroeIslands, "fo" },
            { Country.FalklandIslands, "fk" },
            { Country.Fiji, "fj" },
            { Country.Finland, "fi" },
            { Country.France, "fr" },
            { Country.FrenchGuiana, "gf" },
            { Country.FrenchPolynesia, "pf" },
            { Country.Gabon, "ga" },
            { Country.Gambia, "gm" },
            { Country.Georgia, "ge" },
            { Country.Germany, "de" },
            { Country.Ghana, "gh" },
            { Country.Gibraltar, "gi" },
            { Country.Greece, "gr" },
            { Country.Greenland, "gl" },
            { Country.Grenada, "gd" },
            { Country.Guadeloupe, "gp" },
            { Country.Guam, "gu" },
            { Country.Guatemala, "15.7834710,-90.2307590,1000km" },
            { Country.Guernsey, string.Empty },
            { Country.Guinea, "gn" },
            { Country.GuineaBissau, "gw" },
            { Country.Guyana, "gy" },
            { Country.Haiti, "ht" },
            { Country.HolySee, "va" },
            { Country.Honduras, "15.1999990,-86.2419050,1000km" },
            { Country.Hungary, "hu" },
            { Country.Iceland, "is" },
            { Country.India, "in" },
            { Country.Indonesia, "id" },
            { Country.Iran, "ir" },
            { Country.Iraq, "iq" },
            { Country.Ireland, "ie" },
            { Country.IsleofMan, "uk" },
            { Country.Israel, "il" },
            { Country.Italy, "it" },
            { Country.Jamaica, "jm" },
            { Country.Japan, "jp" },
            { Country.Jersey, string.Empty },
            { Country.Jordan, "jo" },
            { Country.Kazakhstan, "kz" },
            { Country.Kenya, "ke" },
            { Country.Kiribati, "ki" },
            { Country.Kuwait, "kw" },
            { Country.Kyrgyzstan, "kg" },
            { Country.Lao, "la" },
            { Country.Latvia, "lv" },
            { Country.Lebanon, "lb" },
            { Country.Lesotho, "ls" },
            { Country.Liberia, "lr" },
            { Country.LibyanArabJamahiriya, "ly" },
            { Country.Liechtenstein, "li" },
            { Country.Lithuania, "lt" },
            { Country.Luxembourg, "lu" },
            { Country.Madagascar, "mg" },
            { Country.Malawi, "mw" },
            { Country.Malaysia, "my" },
            { Country.Maldives, "mv" },
            { Country.Mali, "ml" },
            { Country.Malta, "mt" },
            { Country.MarshallIslands, "mh" },
            { Country.Martinique, "mq" },
            { Country.Mauritania, "mr" },
            { Country.Mauritius, "mu" },
            { Country.Mayotte, "yt" },
            { Country.Mexico, "23.6345010,-102.5527840,1000km" },
            { Country.MicronesiaFederatedStatesof, "fm" },
            { Country.Monaco, "mc" },
            { Country.Mongolia, "mn" },
            { Country.Montenegro, string.Empty },
            { Country.Montserrat, "ms" },
            { Country.Morocco, "ma" },
            { Country.Mozambique, "mz" },
            { Country.Myanmar, "mm" },
            { Country.Namibia, "na" },
            { Country.Nauru, "nr" },
            { Country.Nepal, "np" },
            { Country.Netherlands, "nl" },
            { Country.NetherlandsAntilles, "an" },
            { Country.NewCaledonia, "nc" },
            { Country.NewZealand, "nz" },
            { Country.Nicaragua, "12.8654160,-85.2072290,1000km" },
            { Country.Niger, "ne" },
            { Country.Nigeria, "ng" },
            { Country.Niue, "nu" },
            { Country.NorfolkIsland, "nf" },
            { Country.NorthernMarianaIslands, "mp" },
            { Country.Norway, "no" },
            { Country.OccupiedPalestinianTerritory, "ps" },
            { Country.Oman, "om" },
            { Country.Pakistan, "pk" },
            { Country.Palau, "pw" },
            { Country.Panama, "8.5379810,-80.7821270,1000km" },
            { Country.PapuaNewGuinea, "pg" },
            { Country.Paraguay, "-23.4425030,-58.4438320,1000km" },
            { Country.Peru, "-9.1899670,-75.0151520,1000km" },
            { Country.Philippines, "ph" },
            { Country.Pitcairn, "pn" },
            { Country.Poland, "pl" },
            { Country.Portugal, "pt" },
            { Country.PuertoRico, "18.2208330,-66.5901490,1000km" },
            { Country.Qatar, "qa" },
            { Country.RepublicofKorea, "kr" },
            { Country.RepublicofMoldova, "md" },
            { Country.Réunion, "re" },
            { Country.Romania, "ro" },
            { Country.RussianFederation, "ru" },
            { Country.Rwanda, "rw" },
            { Country.SaintBarthelemy, string.Empty },
            { Country.SaintHelena, "sh" },
            { Country.SaintKittsandNevis, "kn" },
            { Country.SaintLucia, "lc" },
            { Country.SaintMartin, string.Empty },
            { Country.SaintPierreandMiquelon, "pm" },
            { Country.SaintVincentandtheGrenadines, "vc" },
            { Country.Samoa, "ws" },
            { Country.SanMarino, "sm" },
            { Country.SaoTomeandPrincipe, "st" },
            { Country.SaudiArabia, "sa" },
            { Country.Senegal, "sn" },
            { Country.Serbia, string.Empty },
            { Country.Seychelles, "sc" },
            { Country.SierraLeone, "sl" },
            { Country.Singapore, "sg" },
            { Country.Slovakia, "sk" },
            { Country.Slovenia, "si" },
            { Country.SolomonIslands, "sb" },
            { Country.Somalia, "so" },
            { Country.SouthAfrica, "za" },
            { Country.Spain, "40.416691,-3.700345,1000km" },
            { Country.SriLanka, "lk" },
            { Country.Sudan, "sd" },
            { Country.Suriname, "sr" },
            { Country.SvalbardandJanMayenIslands, "sj" },
            { Country.Swaziland, "sz" },
            { Country.Sweden, "se" },
            { Country.Switzerland, "ch" },
            { Country.SyrianArabRepublic, "sy" },
            { Country.Tajikistan, "tj" },
            { Country.Thailand, "th" },
            { Country.TheformerYugoslavRepublicofMacedonia, "mk" },
            { Country.TimorLeste, "tp" },
            { Country.Togo, "tg" },
            { Country.Tokelau, "tk" },
            { Country.Tonga, "to" },
            { Country.TrinidadandTobago, "tt" },
            { Country.Tunisia, "tn" },
            { Country.Turkey, "tr" },
            { Country.Turkmenistan, "tm" },
            { Country.TurksandCaicosIslands, "tc" },
            { Country.Tuvalu, "tv" },
            { Country.Uganda, "ug" },
            { Country.Ukraine, "ua" },
            { Country.UnitedArabEmirates, "ae" },
            { Country.UnitedKingdomofGreatBritainandNorthernIreland, "uk" },
            { Country.UnitedRepublicofTanzania, "tz" },
            { Country.UnitedStatesOfAmerica, "us" },
            { Country.UnitedStatesVirginIslands, "vi" },
            { Country.Uruguay, "-32.5227790,-55.7658350,1000km" },
            { Country.Uzbekistan, "uz" },
            { Country.Vanuatu, "vu" },
            { Country.Venezuela, "6.4237500,-66.5897300,1000km" },
            { Country.Vietnam, "vn" },
            { Country.WallisandFutunaIslands, "wf" },
            { Country.WesternSahara, "eh" },
            { Country.Yemen, "ye" },
            { Country.Zambia, "zm" },
            { Country.Zimbabwe, string.Empty },
            { Country.BouvetIsland, "bv" },
            { Country.Taiwan, "tw" }
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
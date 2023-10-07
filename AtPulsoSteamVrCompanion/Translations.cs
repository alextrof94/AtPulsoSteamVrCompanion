using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtPulsoSteamVrCompanion
{
    public static class Translations
    {
        public static Dictionary<string, LocalizedString> Strings = new Dictionary<string, LocalizedString>{
            {"Devices", new LocalizedString(
                "Шлем|Левый контроллер|Правый контроллер",
                "HMD|Left controller|Right controller")
            },
            {"aaaaaaaaaaa", new LocalizedString(
                "aaaaaaaaaaa",
                "aaaaaaaaaaa")
            },
        };

        static CultureInfo cultureRu = new CultureInfo("ru-RU");

        public static string GetString(string key)
        {
            string res;
            if (Thread.CurrentThread.CurrentCulture.Equals(cultureRu))
                res = Strings.GetValueOrDefault(key, new LocalizedString()).ru;
            else
                res = Strings.GetValueOrDefault(key, new LocalizedString()).en;

            return res;
        }
    }

    public struct LocalizedString
    {
        public string ru { get; set; } = "Эта строка не переведена";
        public string en { get; set; } = "This line didn't translated";

        public LocalizedString() { }
        public LocalizedString(string ru, string en)
        {
            if (!string.IsNullOrEmpty(ru))
                this.ru = ru;
            if (!string.IsNullOrEmpty(en))
                this.en = en;
        }
    }
}

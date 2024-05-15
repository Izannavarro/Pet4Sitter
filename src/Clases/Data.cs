using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace piTest
{
    public class Data
    {


        public static bool IsDarkModeEnabled()
        {
            const string registryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string registryValue = "AppsUseLightTheme";

            int lightThemeValue = (int)Registry.GetValue(registryKey, registryValue, 1);

            // Si lightThemeValue es 1, significa que está activado el tema claro; si es 0, está activado el tema oscuro
            return lightThemeValue == 0;
        }

    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pet4sitter.Clases;

namespace pet4sitter
{
    public class Data
    {

        static string ginfo;

        
        public static User UserGoogle = null;
        public static User CurrentUser = null;
        //public static User CurrentUser = new User(1,null,"Pepe","ad","p@p.p",null,null,null,true,false,false,null, 39.493, -0.462143);


        public static string Ginfo { get { return ginfo; } set { ginfo = value; } }
        public static string tokenNoticias;
        public static string tokenGPT;
        static Data()
        {
            tokenNoticias = Utiles.CargarTokenNoticias();
            tokenGPT = Utiles.CargarTokenGpt();
        }

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

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pet4sitter.Clases;
using System.Drawing.Imaging;

namespace pet4sitter
{
    //Clase Data para guardar datos relevantes de la app
    public class Data
    {

        static string ginfo;

        
        public static User UserGoogle = null;
        public static User CurrentUser = null;
        public static Pedido CurrentPedido = null;
        public static Tarjeta CurrentTarjeta = null;

        public static bool DarkMode;
        public static string Ginfo { get { return ginfo; } set { ginfo = value; } }
        public static string tokenNoticias;
        public static string tokenGPT;
        public static string tokenClientId;
        public static string tokenClientSecret;
        public static string stripePublicKey;
        public static string stripePrivateKey;

        static Data()
        {
            DarkMode = IsDarkModeEnabled();
            tokenNoticias = Utiles.BuscarToken("News");//Busca tokens importantes de APIS usadas en el proyecto
            tokenGPT = Utiles.BuscarToken("ChatGPT");
            tokenClientId = Utiles.BuscarToken("ClientID");
            tokenClientSecret = Utiles.BuscarToken("ClientSecret");
            stripePublicKey = Utiles.BuscarToken("StripePub");
            stripePrivateKey = Utiles.BuscarToken("StripeSecret");
        }

        /// <summary>
        /// Método para comprobar el tema del sistema del usuario.
        /// </summary>
        /// <returns></returns>
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

using System.Globalization;
using System.Threading;

public static class ConfiguracionIdioma
{
    private static CultureInfo cultura = CultureInfo.CurrentCulture;

    public static CultureInfo Cultura
    {
        get { return cultura; }
        private set { cultura = value; }
    }

    public static void CambiarIdioma(CultureInfo cultura)
    {
        Thread.CurrentThread.CurrentUICulture = cultura;
        Cultura = cultura;
    }
}
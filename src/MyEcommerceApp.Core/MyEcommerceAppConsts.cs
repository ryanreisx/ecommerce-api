using MyEcommerceApp.Debugging;

namespace MyEcommerceApp
{
    public class MyEcommerceAppConsts
    {
        public const string LocalizationSourceName = "MyEcommerceApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "2fe282725dd04079917dae42d246721f";
    }
}

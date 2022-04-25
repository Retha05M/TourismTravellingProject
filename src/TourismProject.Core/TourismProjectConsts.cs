using TourismProject.Debugging;

namespace TourismProject
{
    public class TourismProjectConsts
    {
        public const string LocalizationSourceName = "TourismProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "59fb3c6764de468f8da8f66f7eec07da";
    }
}

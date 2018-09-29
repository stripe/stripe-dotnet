namespace Stripe.Infrastructure
{
    internal static class Urls
    {
        internal static string DefaultBaseUrl => "https://api.stripe.com/v1";

        internal static string BaseUrl => StripeConfiguration.GetApiBase();

        internal static string DefaultBaseConnectUrl => "https://connect.stripe.com";

        internal static string BaseConnectUrl => StripeConfiguration.GetConnectBase();

        internal static string DefaultBaseFilesUrl => "https://files.stripe.com/v1";

        internal static string BaseFilesUrl => StripeConfiguration.GetFilesBase();
    }
}

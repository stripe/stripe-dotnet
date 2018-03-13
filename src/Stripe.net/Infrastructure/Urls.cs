namespace Stripe.Infrastructure
{
    internal static class Urls
    {
        internal static string DefaultBaseUrl => "https://api.stripe.com/v1";

        internal static string BaseUrl => StripeConfiguration.GetApiBase();

        public static string Invoices => BaseUrl + "/invoices";

        public static string InvoiceItems => BaseUrl + "/invoiceitems";

        public static string Tokens => BaseUrl + "/tokens";

        public static string Charges => BaseUrl + "/charges";

        public static string Coupons => BaseUrl + "/coupons";

        public static string Plans => BaseUrl + "/plans";

        public static string Balance => BaseUrl + "/balance";

        public static string BalanceTransactions => BaseUrl + "/balance/history";

        public static string Customers => BaseUrl + "/customers";

        public static string CustomerSources => BaseUrl + "/customers/{0}/sources";

        public static string CountrySpecs => BaseUrl + "/country_specs";

        public static string Disputes => BaseUrl + "/disputes";

        public static string RecipientCards => BaseUrl + "/recipients/{0}/cards";

        public static string Events => BaseUrl + "/events";

        public static string ExchangeRates => BaseUrl + "/exchange_rates";

        public static string Recipients => BaseUrl + "/recipients";

        public static string Subscriptions => BaseUrl + "/subscriptions";

        public static string ApplicationFees => BaseUrl + "/application_fees";

        public static string EphemeralKeys => BaseUrl + "/ephemeral_keys";

        public static string OAuthToken => BaseConnectUrl + "/oauth/token";

        public static string OAuthDeauthorize => BaseConnectUrl + "/oauth/deauthorize";

        internal static string DefaultBaseConnectUrl => "https://connect.stripe.com";

        private static string BaseConnectUrl => StripeConfiguration.GetConnectBase();

        internal static string DefaultBaseUploadsUrl => "https://uploads.stripe.com/v1";

        private static string BaseUploadsUrl => StripeConfiguration.GetUploadsBase();

        public static string FileUploads => BaseUploadsUrl + "/files";
    }
}

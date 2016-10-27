namespace Stripe.Infrastructure
{
    internal static class Urls
    {
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

        public static string Accounts => BaseUrl + "/accounts";

        public static string Recipients => BaseUrl + "/recipients";

        public static string Subscriptions => BaseUrl + "/customers/{0}/subscriptions";

        public static string Transfers => BaseUrl + "/transfers";

        public static string ApplicationFees => BaseUrl + "/application_fees";

        internal static string BaseUrl => "https://api.stripe.com/v1";

        public static string OAuthToken => BaseConnectUrl + "/oauth/token";

        public static string OAuthDeauthorize => BaseConnectUrl + "/oauth/deauthorize";

        private static string BaseConnectUrl => "https://connect.stripe.com";

        private static string BaseUploadsUrl => "https://uploads.stripe.com/v1";

        public static string FileUploads => BaseUploadsUrl + "/files";
    }
}

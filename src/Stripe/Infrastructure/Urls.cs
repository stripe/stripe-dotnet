namespace Stripe
{
    internal static class Urls
    {
        public static string Account => BaseUrl + "/account";

        public static string ApplicationFees => BaseUrl + "/application_fees";

        public static string Balance => BaseUrl + "/balance";

        public static string BalanceTransactions => BaseUrl + "/balance/history";

        public static string Charges => BaseUrl + "/charges";

        public static string Coupons => BaseUrl + "/coupons";

        public static string Customers => BaseUrl + "/customers";

        public static string CustomerCards => BaseUrl + "/customers/{0}/sources";

        public static string Events => BaseUrl + "/events";

        public static string Invoices => BaseUrl + "/invoices";

        public static string InvoiceItems => BaseUrl + "/invoiceitems";

        public static string OAuthToken => BaseConnectUrl + "/oauth/token";

        public static string Plans => BaseUrl + "/plans";

        public static string Recipients => BaseUrl + "/recipients";

        public static string RecipientCards => BaseUrl + "/recipients/{0}/cards";

        public static string SpecificBalanceTransaction => BalanceTransactions + "/{0}";

        public static string Subscriptions => BaseUrl + "/customers/{0}/subscriptions";

        public static string Transfers => BaseUrl + "/transfers";

        public static string Tokens => BaseUrl + "/tokens";

        private static string BaseUrl => "https://api.stripe.com/v1";

        private static string BaseConnectUrl => "https://connect.stripe.com";
    }
}

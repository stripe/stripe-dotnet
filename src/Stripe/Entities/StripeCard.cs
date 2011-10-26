namespace Stripe
{
    public class StripeCard
    {
        [StripeArgument("address_country")]
        public string AddressCountry { get; set; }

        [StripeArgument("address_state")]
        public string AddressState { get; set; }

        [StripeArgument("address_zip")]
        public string AddressZip { get; set; }

        [StripeArgument("address_zip_check")]
        public string AddressZipCheck { get; set; }

        [StripeArgument("address_line1")]
        public string AddressLine1 { get; set; }

        [StripeArgument("address_line1_check")]
        public string AddressLine1Check { get; set; }

        [StripeArgument("address_line2")]
        public string AddressLine2 { get; set; }

        [StripeArgument("country")]
        public string Country { get; set; }

        [StripeArgument("cvc_check")]
        public string CvcCheck { get; set; }

        [StripeArgument("exp_month")]
        public string ExpirationMonth { get; set; }

        [StripeArgument("exp_year")]
        public string ExpirationYear { get; set; }

        [StripeArgument("last4")]
        public string Last4 { get; set; }

        [StripeArgument("name")]
        public string Name { get; set; }

        [StripeArgument("type")]
        public string Type { get; set; }
    }
}
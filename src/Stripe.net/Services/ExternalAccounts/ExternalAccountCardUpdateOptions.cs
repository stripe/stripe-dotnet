namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class ExternalAccountCardUpdateOptions : INestedOptions, ISupportMetadata
    {
        [FormProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [FormProperty("exp_month")]
        public int? ExpirationMonth { get; set; }

        [FormProperty("exp_year")]
        public int? ExpirationYear { get; set; }

        [FormProperty("address_city")]
        public string AddressCity { get; set; }

        [FormProperty("address_country")]
        public string AddressCountry { get; set; }

        [FormProperty("address_line1")]
        public string AddressLine1 { get; set; }

        [FormProperty("address_line2")]
        public string AddressLine2 { get; set; }

        [FormProperty("address_state")]
        public string AddressState { get; set; }

        [FormProperty("address_zip")]
        public string AddressZip { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("name")]
        public string Name { get; set; }
    }
}

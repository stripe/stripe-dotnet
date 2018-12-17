namespace Stripe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Billing
    {
        /// <summary>
        /// When charging automatically, Stripe will attempt to pay this invoice or subscription
        /// using the default source attached to the customer.
        /// </summary>
        [EnumMember(Value = "charge_automatically")]
        ChargeAutomatically,

        /// <summary>
        /// When sending an invoice, Stripe will email your customer an invoice with payment
        /// instructions.
        /// </summary>
        [EnumMember(Value = "send_invoice")]
        SendInvoice,
    }
}

namespace Stripe
{
    using Stripe.Infrastructure;

    public class ThreeDSecureCreateOptions : BaseOptions
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// If you pass a card id, you must also pass the customer id
        /// </summary>
        [FormProperty("card")]
        public string CardTokenOrCardId { get; set; }

        [FormProperty("customer")]
        public string CustomerId { get; set; }
    }
}

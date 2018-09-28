namespace Stripe
{
    using Stripe.Infrastructure;

    public class AccountCreateOptions : AccountSharedOptions
    {
        [FormProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// One of <see cref="AccountType"/>
        /// </summary>
        [FormProperty("type")]
        public string Type { get; set; }

        [FormProperty("from_recipient")]
        public string FromRecipient { get; set; }
    }
}

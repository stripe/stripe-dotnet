namespace Stripe.Issuing
{
    using Stripe.Infrastructure;

    public class AuthorizationListOptions : ListOptions
    {
        [FormProperty("cardholder")]
        public string CardholderId { get; set; }

        [FormProperty("card")]
        public string CardId { get; set; }

        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("status")]
        public string Status { get; set; }
    }
}

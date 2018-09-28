namespace Stripe.Issuing
{
    using Stripe.Infrastructure;

    public class CardholderListOptions : ListOptions
    {
        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("email")]
        public string Email { get; set; }

        [FormProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [FormProperty("status")]
        public string Status { get; set; }

        [FormProperty("type")]
        public string Type { get; set; }
    }
}

namespace Stripe
{
    public class StripeError
    {
        [StripeArgument("error.type")]
        public string ErrorType { get; set; }

        [StripeArgument("error.message")]
        public string Message { get; set; }

        [StripeArgument("error.code")]
        public string Code { get; set; }

        [StripeArgument("error.param")]
        public string Parameter { get; set; }
    }
}
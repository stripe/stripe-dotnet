namespace Stripe
{
    public abstract class CreditCardOptions
    {
        [StripeArgument("card[number]")]
        public string CardNumber { get; set; }

        [StripeArgument("card[exp_month]")]
        public string CardExpirationMonth { get; set; }

        [StripeArgument("card[exp_year]")]
        public string CardExpirationYear { get; set; }

        [StripeArgument("card[cvc]")]
        public string CardCvc { get; set; }

        [StripeArgument("card[name]")]
        public string CardName { get; set; }

        [StripeArgument("card[address_line1]")]
        public string CardAddressLine1 { get; set; }

        [StripeArgument("card[address_line2]")]
        public string CardAddressLine2 { get; set; }

        [StripeArgument("card[address_zip]")]
        public string CardAddressZip { get; set; }

        [StripeArgument("card[address_state]")]
        public string CardAddressState { get; set; }

        [StripeArgument("card[address_country]")]
        public string CardAddressCountry { get; set; }

        [StripeArgument("card")]
        public string TokenId { get; set; }
    }
}

namespace Stripe
{
    using Stripe.Infrastructure;

    public class CardListOptions : ListOptions
    {
        [FormProperty("object")]
        internal string Object => "card";
    }
}

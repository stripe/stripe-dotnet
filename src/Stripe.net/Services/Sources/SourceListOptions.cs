namespace Stripe
{
    using Stripe.Infrastructure;

    public class SourceListOptions : ListOptions
    {
        [FormProperty("object")]
        internal string Object => "source";

        [FormProperty("type")]
        public string Type { get; set; }
    }
}

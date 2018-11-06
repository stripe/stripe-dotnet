namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    [JsonConverter(typeof(ExpandableFieldConverter))]
    public class ExpandableField
    {
        public string Id { get; set; }

        public virtual IHasId ExpandedObject { get; set; }
    }

    public class ExpandableField<T> : ExpandableField
        where T : IHasId
    {
        public new T ExpandedObject => (T)base.ExpandedObject;
    }
}

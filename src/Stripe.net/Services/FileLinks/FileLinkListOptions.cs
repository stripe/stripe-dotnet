namespace Stripe
{
    using Stripe.Infrastructure;

    public class FileLinkListOptions : ListOptionsWithCreated
    {
        [FormProperty("expired")]
        public bool? Expired { get; set; }

        [FormProperty("file")]
        public string FileId { get; set; }
    }
}

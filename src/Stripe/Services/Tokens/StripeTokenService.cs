namespace Stripe
{
    public class StripeTokenService : StripeService
    {
        public StripeTokenService(string apiKey = null) : base(apiKey) { }

        public virtual StripeToken Create(StripeTokenCreateOptionsBase createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Tokens, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeToken>.MapFromJson(response);
        }

        public virtual StripeToken Get(string tokenId)
        {
            var url = string.Format("{0}/{1}", Urls.Tokens, tokenId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeToken>.MapFromJson(response);
        }
    }
}
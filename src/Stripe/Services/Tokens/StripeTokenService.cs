namespace Stripe
{
    public class StripeTokenService : StripeService
    {
        public StripeTokenService(string apiKey = null) : base(apiKey) { }

        public virtual StripeToken Create(StripeTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(createOptions, Urls.Tokens, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeToken>.MapFromJson(response);
        }

        public virtual StripeToken Get(string tokenId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Tokens, tokenId);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeToken>.MapFromJson(response);
        }
    }
}
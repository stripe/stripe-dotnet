namespace Stripe
{
    public class StripeTokenService
    {
        public StripeToken Create(StripeTokenCreateOptions createOptions)
        {
            var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Tokens);
            
            var response = Requestor.PostString(url);

            return PopulateStripeToken(response);
        }

        public StripeToken Get(string tokenId)
        {
            var url = string.Format("{0}/{1}", Urls.Tokens, tokenId);

            var response = Requestor.GetString(url);

            return PopulateStripeToken(response);
        }

        private StripeToken PopulateStripeToken(string json)
        {
            var stripeToken = Mapper<StripeToken>.MapFromJson(json);
            stripeToken.StripeCard = Mapper<StripeCard>.MapFromJson(json, "card.");

            return stripeToken;
        }
    }
}
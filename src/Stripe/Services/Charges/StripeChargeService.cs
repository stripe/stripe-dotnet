using System.Collections.Generic;
using System.Linq;

namespace Stripe
{
    public class StripeChargeService
    {
        public StripeCharge Create(StripeChargeCreateOptions createOptions)
        {
            var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Charges);

            var response = Requestor.PostString(url);

            return PopulateStripeCharge(response);
        }

        public StripeCharge Get(string chargeId)
        {
            var url = string.Format("{0}/{1}", Urls.Charges, chargeId);

            var response = Requestor.GetString(url);

            return PopulateStripeCharge(response);
        }

        public StripeCharge Refund(string chargeId, int? refundAmountInCents = null)
        {
            var url = string.Format("{0}/{1}/refund", Urls.Charges, chargeId);

            if(refundAmountInCents.HasValue)
                url = ParameterBuilder.ApplyParameterToUrl(url, "amount", refundAmountInCents.Value.ToString());

            var response = Requestor.PostString(url);

            return PopulateStripeCharge(response);
        }

        public IEnumerable<StripeCharge> List(int count = 10, int offset = 0, string customerId = null)
        {
            var url = Urls.Charges;
            url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
            url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

            if(!string.IsNullOrEmpty(customerId))
                url = ParameterBuilder.ApplyParameterToUrl(url, "customer", customerId);

            var response = Requestor.GetString(url);

            var json = Mapper<StripeCharge>.MapCollectionToObjectList(response);

            return json.Select(PopulateStripeCharge);
        }

        private StripeCharge PopulateStripeCharge(string json)
        {
            var stripeCharge = Mapper<StripeCharge>.MapFromJson(json);
            stripeCharge.StripeCard = Mapper<StripeCard>.MapFromJson(json, "card.");

            return stripeCharge;
        }
    }
}
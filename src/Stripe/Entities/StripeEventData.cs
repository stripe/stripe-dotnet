using Newtonsoft.Json;

namespace Stripe
{
	public class StripeEventData
	{
		[JsonProperty("previous_attributes")]
		public dynamic PreviousAttributes { get; set; }

		[JsonProperty("object")]
		public dynamic Object { get; set; }

        public object StripeType { get; private set; }

        public void ParseStripeType()
        {
            if (Object == null) return;

            Newtonsoft.Json.Linq.JObject data = (Newtonsoft.Json.Linq.JObject) Object;
            Newtonsoft.Json.Linq.JToken value;  
            if (data.TryGetValue("object", out value))
            {
                switch (value.ToString())
                {
                    case "charge":
                        StripeType = Mapper<StripeCharge>.MapFromJson(Object.ToString());
                        break;
                    case "coupon":
                        StripeType = Mapper<StripeCoupon>.MapFromJson(Object.ToString());
                        break;
                    case "customer":
                        StripeType = Mapper<StripeCustomer>.MapFromJson(Object.ToString());
                        break;
                    case "event":
                        StripeType = Mapper<StripeEvent>.MapFromJson(Object.ToString());
                        break;
                    case "invoice":
                        StripeType = Mapper<StripeInvoice>.MapFromJson(Object.ToString());
                        break;
                    case "subscription":
                        StripeType = Mapper<StripeSubscription>.MapFromJson(Object.ToString());
                        break;
                    case "transfer":
                        StripeType = Mapper<StripeTransfer>.MapFromJson(Object.ToString());
                        break;
                }
            }
        }
	}
}
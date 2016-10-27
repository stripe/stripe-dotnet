using System.IO;
using System.Web;

namespace Stripe.Tests
{
    public class event_hooks_handler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }
        
        public void ProcessRequest(HttpContext context)
        {
            var json = new StreamReader(context.Request.InputStream).ReadToEnd();

            var stripeEvent = StripeEventUtility.ParseEvent(json);

            switch (stripeEvent.Type)
            {
                case StripeEvents.ChargeRefunded:
                    var stripeCharge = Stripe.Mapper<StripeCharge>.MapFromJson(stripeEvent.Data.Object.ToString());
                    break;
                case StripeEvents.ChargeDisputeCreated:
                    var stripeDispute = Stripe.Mapper<StripeDispute>.MapFromJson(stripeEvent.Data.Object.ToString());
                    break;
            }
        }
    }
}
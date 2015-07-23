using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
   public class StripeUpcomingInvoiceOptions
   {
      [JsonProperty( "subscription" )]
      public string SubscriptionId { get; set; }

      [JsonProperty( "subscription_plan" )]
      public string PlanId { get; set; }

      [JsonProperty( "subscription_quantity" )]
      public int? Quantity { get; set; }

      public DateTime? TrialEnd { get; set; }

      [JsonProperty( "subscription_trial_end" )]
      internal long? TrialEndInternal
      {
         get
         {
            if ( !TrialEnd.HasValue )
               return null;

            return EpochTime.ConvertDateTimeToEpoch( TrialEnd.Value );
         }
      }

      [JsonProperty( "subscription_prorate" )]
      public bool? Prorate { get; set; }

      public DateTime? ProrationDate { get; set; }

      [JsonProperty( "subscription_proration_date" )]
      internal long? ProrationDateInternal
      {
         get
         {
            if ( !ProrationDate.HasValue )
               return null;

            return EpochTime.ConvertDateTimeToEpoch( ProrationDate.Value );
         }
      }
   }
}

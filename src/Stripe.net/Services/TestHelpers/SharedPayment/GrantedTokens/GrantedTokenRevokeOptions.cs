// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GrantedTokenRevokeOptions : BaseOptions
    {
    }
}

using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    // ******** this test was used to try and get the response from three3secure. it would work, but it would have to be a test source id

    //public class creating_three_d_secure_source
    //{
    //    private StripeSource Source { get; set; }

    //    public creating_three_d_secure_source()
    //    {
    //        var options = new StripeSourceCreateOptions
    //        {
    //            Type = StripeSourceType.ThreeDSecure,
    //            ThreeDSecureId = "4000000000003063",
    //            Amount = 1,
    //            Currency = "eur",
    //            RedirectReturnUrl = "http://no.where/webhooks"
    //        };

    //        Source = new StripeSourceService(Cache.ApiKey).Create(options);
    //    }

    //    [Fact]
    //    public void source_should_not_be_null()
    //    {
    //        Source.Should().NotBeNull();
    //    }
    //}
}

namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ReviewServiceTest : BaseStripeTest
    {
        private const string ReviewId = "prv_123";

        private readonly ReviewService service;
        private readonly ReviewApproveOptions approveOptions;
        private readonly ReviewListOptions listOptions;

        public ReviewServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new ReviewService(this.StripeClient);

            this.approveOptions = new ReviewApproveOptions
            {
            };

            this.listOptions = new ReviewListOptions
            {
            };
        }

        [Fact]
        public void Approve()
        {
            var review = this.service.Approve(ReviewId, this.approveOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/reviews/prv_123/approve");
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public async Task ApproveAsync()
        {
            var review = await this.service.ApproveAsync(ReviewId, this.approveOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/reviews/prv_123/approve");
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public void Get()
        {
            var review = this.service.Get(ReviewId);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews/prv_123");
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var review = await this.service.GetAsync(ReviewId);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews/prv_123");
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public void List()
        {
            var reviews = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews");
            Assert.NotNull(reviews);
            Assert.Equal("list", reviews.Object);
            Assert.Single(reviews.Data);
            Assert.Equal("review", reviews.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var reviews = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews");
            Assert.NotNull(reviews);
            Assert.Equal("list", reviews.Object);
            Assert.Single(reviews.Data);
            Assert.Equal("review", reviews.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var review = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var review = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }
    }
}

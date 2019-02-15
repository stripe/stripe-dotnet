namespace StripeTests
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq.Protected;
    using Stripe;
    using Xunit;

    public class NetworkRetriesTest : BaseStripeTest, IDisposable
    {
        public NetworkRetriesTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            StripeConfiguration.MaxNetworkRetries = 2;
            StripeConfiguration.NetworkRetriesSleep = false;
        }

        public void Dispose()
        {
            StripeConfiguration.MaxNetworkRetries = 0;
            StripeConfiguration.NetworkRetriesSleep = true;
            this.MockHttpClientFixture.Reset();
        }

        [Fact]
        public void RetryOnConflict()
        {
            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.Conflict)
                    {
                        Content = new StringContent("{}", Encoding.UTF8),
                    }))
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent("{}", Encoding.UTF8),
                    }))
                .Throws(new StripeTestException("Unexpected invocation"));

            var service = new BalanceService();
            var balance = service.Get();

            Assert.NotNull(balance);
            Assert.Equal(1, balance.StripeResponse.NumRetries);
        }

        [Fact]
        public void RetryOnServiceUnavailable()
        {
            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.ServiceUnavailable)
                    {
                        Content = new StringContent("{}", Encoding.UTF8),
                    }))
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent("{}", Encoding.UTF8),
                    }))
                .Throws(new StripeTestException("Unexpected invocation"));

            var service = new BalanceService();
            var balance = service.Get();

            Assert.NotNull(balance);
            Assert.Equal(1, balance.StripeResponse.NumRetries);
        }

        [Fact]
        public void RetryOnInternalServerErrorIfNotPost()
        {
            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.InternalServerError)
                    {
                        Content = new StringContent("{}", Encoding.UTF8),
                    }))
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent("{}", Encoding.UTF8),
                    }))
                .Throws(new StripeTestException("Unexpected invocation"));

            var service = new BalanceService();
            var balance = service.Get();

            Assert.NotNull(balance);
            Assert.Equal(1, balance.StripeResponse.NumRetries);
        }

        [Fact]
        public void DoNotRetryOnInternalServerErrorIfPost()
        {
            var requestCount = 0;
            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(() =>
                    {
                        requestCount += 1;
                        return Task.FromResult(
                            new HttpResponseMessage(HttpStatusCode.InternalServerError)
                            {
                                Content = new StringContent("{}", Encoding.UTF8),
                            });
                    })
                .Throws(new StripeTestException("Unexpected invocation"));

            var service = new CustomerService();
            Assert.Throws<StripeException>(() => service.Create(null));

            Assert.Equal(1, requestCount);
        }

        [Fact]
        public void RetryOnHttpRequestException()
        {
            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Throws(new HttpRequestException("Connection error"))
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent("{}", Encoding.UTF8),
                    }))
                .Throws(new StripeTestException("Unexpected invocation"));

            var service = new BalanceService();
            var balance = service.Get();

            Assert.NotNull(balance);
            Assert.Equal(1, balance.StripeResponse.NumRetries);
        }

        [Fact]
        public void RethrowHttpRequestExceptionAfterAllAttempts()
        {
            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Throws(new HttpRequestException("Connection error 1"))
                .Throws(new HttpRequestException("Connection error 2"))
                .Throws(new HttpRequestException("Connection error 3"))
                .Throws(new StripeTestException("Unexpected invocation"));

            var service = new BalanceService();
            var exception = Assert.Throws<HttpRequestException>(() => service.Get());

            Assert.NotNull(exception);
            Assert.Equal("Connection error 3", exception.Message);
        }

        [Fact]
        public void RetryOnTimeout()
        {
            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Throws(new OperationCanceledException("Timeout"))
                .Returns(Task.FromResult(
                    new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent("{}", Encoding.UTF8),
                    }))
                .Throws(new StripeTestException("Unexpected invocation"));

            var service = new BalanceService();
            var balance = service.Get();

            Assert.NotNull(balance);
            Assert.Equal(1, balance.StripeResponse.NumRetries);
        }

        [Fact]
        public void RethrowTimeoutExceptionAfterAllAttempts()
        {
            this.MockHttpClientFixture.MockHandler.Protected()
                .SetupSequence<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Throws(new TaskCanceledException("Timeout 1"))
                .Throws(new TaskCanceledException("Timeout 2"))
                .Throws(new TaskCanceledException("Timeout 3"))
                .Throws(new StripeTestException("Unexpected invocation"));

            var service = new BalanceService();
            var exception = Assert.Throws<TaskCanceledException>(() => service.Get());

            Assert.NotNull(exception);
            Assert.Equal("Timeout 3", exception.Message);
        }

        [Fact]
        public async Task DoNotRetryOnCancel()
        {
            var requestCount = 0;
            this.MockHttpClientFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns<HttpRequestMessage, CancellationToken>(async (_, t) =>
                    {
                        requestCount += 1;
                        await Task.Delay(TimeSpan.FromSeconds(1), t);
                        return new HttpResponseMessage(HttpStatusCode.OK)
                        {
                            Content = new StringContent("{}", Encoding.UTF8),
                        };
                    });

            var service = new BalanceService();
            var source = new CancellationTokenSource();
            source.CancelAfter(TimeSpan.FromMilliseconds(10));
            await Assert.ThrowsAsync<TaskCanceledException>(async () =>
                await service.GetAsync(null, source.Token));

            Assert.Equal(1, requestCount);
        }
    }
}

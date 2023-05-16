namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeClientTest : BaseStripeTest
    {
        private readonly DummyHttpClient httpClient;
        private readonly StripeClient stripeClient;
        private readonly BaseOptions options;
        private readonly RequestOptions requestOptions;

        public StripeClientTest()
        {
            this.httpClient = new DummyHttpClient();
            this.stripeClient = new StripeClient(
                "sk_test_123",
                httpClient: this.httpClient);
            this.options = new ChargeCreateOptions
            {
                Amount = 123,
                Currency = "usd",
                Source = "tok_visa",
            };
            this.requestOptions = new RequestOptions();
        }

        [Fact]
        public void Ctor_DoesNotThrowsIfApiKeyIsNull()
        {
            var client = new StripeClient(null);
            Assert.NotNull(client);
            Assert.Null(client.ApiKey);
        }

        [Fact]
        public void Ctor_ThrowsIfApiKeyIsEmpty()
        {
            var exception = Assert.Throws<ArgumentException>(() => new StripeClient(string.Empty));
            Assert.Contains("API key cannot be the empty string.", exception.Message);
        }

        [Fact]
        public void Ctor_ThrowsIfApiKeyContainsWhitespace()
        {
            var exception = Assert.Throws<ArgumentException>(() => new StripeClient("sk_test_123\n"));
            Assert.Contains("API key cannot contain whitespace.", exception.Message);
        }

        [Fact]
        public async Task RequestAsync_OkResponse()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            this.httpClient.Response = response;

            var charge = await this.stripeClient.RequestAsync<Charge>(
                HttpMethod.Post,
                "/v1/charges",
                this.options,
                this.requestOptions);

            Assert.NotNull(charge);
            Assert.Equal("ch_123", charge.Id);
            Assert.Equal(response, charge.StripeResponse);
        }

        [Fact]
        public async Task RequestAsync_OkResponse_InvalidJson()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "this isn't JSON");
            this.httpClient.Response = response;

            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await this.stripeClient.RequestAsync<Charge>(
                    HttpMethod.Post,
                    "/v1/charges",
                    this.options,
                    this.requestOptions));

            Assert.NotNull(exception);
            Assert.Equal(HttpStatusCode.OK, exception.HttpStatusCode);
            Assert.Equal("Invalid response object from API: \"this isn't JSON\"", exception.Message);
            Assert.Equal(response, exception.StripeResponse);
        }

        [Fact]
        public async Task RequestAsync_ApiError()
        {
            var response = new StripeResponse(
                HttpStatusCode.PaymentRequired,
                null,
                "{\"error\": {\"type\": \"card_error\"}}");
            this.httpClient.Response = response;

            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await this.stripeClient.RequestAsync<Charge>(
                    HttpMethod.Post,
                    "/v1/charges",
                    this.options,
                    this.requestOptions));

            Assert.NotNull(exception);
            Assert.Equal(HttpStatusCode.PaymentRequired, exception.HttpStatusCode);
            Assert.Equal("card_error", exception.StripeError.Type);
            Assert.Equal(response, exception.StripeResponse);
        }

        [Fact]
        public async Task RequestAsync_OAuthError()
        {
            var response = new StripeResponse(
                HttpStatusCode.BadRequest,
                null,
                "{\"error\": \"invalid_request\"}");
            this.httpClient.Response = response;

            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await this.stripeClient.RequestAsync<OAuthToken>(
                    HttpMethod.Post,
                    "/oauth/token",
                    this.options,
                    this.requestOptions));

            Assert.NotNull(exception);
            Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
            Assert.Equal("invalid_request", exception.StripeError.Error);
            Assert.Equal(response, exception.StripeResponse);
        }

        [Fact]
        public async Task RequestAsync_Error_InvalidJson()
        {
            var response = new StripeResponse(
                HttpStatusCode.InternalServerError,
                null,
                "this isn't JSON");
            this.httpClient.Response = response;

            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await this.stripeClient.RequestAsync<Charge>(
                    HttpMethod.Post,
                    "/v1/charges",
                    this.options,
                    this.requestOptions));

            Assert.NotNull(exception);
            Assert.Equal(HttpStatusCode.InternalServerError, exception.HttpStatusCode);
            Assert.Equal("Invalid response object from API: \"this isn't JSON\"", exception.Message);
            Assert.Equal(response, exception.StripeResponse);
        }

        [Fact]
        public async Task RequestAsync_Error_InvalidErrorObject()
        {
            var response = new StripeResponse(
                HttpStatusCode.InternalServerError,
                null,
                "{}");
            this.httpClient.Response = response;

            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await this.stripeClient.RequestAsync<Charge>(
                    HttpMethod.Post,
                    "/v1/charges",
                    this.options,
                    this.requestOptions));

            Assert.NotNull(exception);
            Assert.Equal(HttpStatusCode.InternalServerError, exception.HttpStatusCode);
            Assert.Equal("Invalid response object from API: \"{}\"", exception.Message);
            Assert.Equal(response, exception.StripeResponse);
        }

        [Fact]
        public async Task RawRequestAsync_Form()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            this.httpClient.Response = response;

            var rawresponse = await this.stripeClient.RawRequestAsync(
                HttpMethod.Post,
                "/v1/charges",
                "foo=bar");

            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal("{\"id\": \"ch_123\"}", rawresponse.Content);
            Assert.Equal("application/x-www-form-urlencoded; charset=utf-8", lastRequest.Content.Headers.GetValues("Content-Type").First());
            Assert.Equal("foo=bar", await lastRequest.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task RawRequest_Form()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            this.httpClient.Response = response;

            var rawresponse = this.stripeClient.RawRequest(
                HttpMethod.Post,
                "/v1/charges",
                "foo=bar");

            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal("{\"id\": \"ch_123\"}", rawresponse.Content);
            Assert.Equal("application/x-www-form-urlencoded; charset=utf-8", lastRequest.Content.Headers.GetValues("Content-Type").First());
            Assert.Equal("foo=bar", await lastRequest.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task RawRequestAsync_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = await this.stripeClient.RawRequestAsync(
                HttpMethod.Post,
                "/v1/charges",
                "{\"foo\":\"bar\"}",
                new RawRequestOptions
                {
                    ApiMode = ApiMode.Preview,
                    AdditionalHeaders =
                    {
                        { "foo", "bar" },
                    },
                });

            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(content, rawResponse.Content);
            Assert.Equal("application/json", lastRequest.Content.Headers.GetValues("Content-Type").First());
            Assert.Equal("{\"foo\":\"bar\"}", await lastRequest.Content.ReadAsStringAsync());
            Assert.Equal(ApiVersion.CurrentPreview, lastRequest.StripeHeaders["Stripe-Version"]);
            Assert.Equal("bar", lastRequest.StripeHeaders["foo"]);
        }

        [Fact]
        public async Task PreviewGetAsync_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = await this.stripeClient.Preview.Get("/v1/charges/ch_123");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Get, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Null(lastRequest.Content);
            Assert.Equal(ApiVersion.CurrentPreview, lastRequest.StripeHeaders["Stripe-Version"]);
        }

        [Fact]
        public async Task PreviewPostAsync_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = await this.stripeClient.Preview.Post("/v1/charges/ch_123", "{\"foo\":\"bar\"}");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Post, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Equal("application/json", lastRequest.Content.Headers.GetValues("Content-Type").First());
            Assert.Equal("{\"foo\":\"bar\"}", await lastRequest.Content.ReadAsStringAsync());
            Assert.Equal(ApiVersion.CurrentPreview, lastRequest.StripeHeaders["Stripe-Version"]);
            Assert.Equal("application/json", lastRequest.Content.Headers.GetValues("Content-Type").First());
            Assert.Equal("{\"foo\":\"bar\"}", await lastRequest.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task PreviewDeleteAsync_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = await this.stripeClient.Preview.Delete("/v1/charges/ch_123");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Delete, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Null(lastRequest.Content);
            Assert.Equal(ApiVersion.CurrentPreview, lastRequest.StripeHeaders["Stripe-Version"]);
        }

        [Fact]
        public void RawRequestThrowsForNonPostOptions()
        {
            Assert.Throws<InvalidOperationException>(() => this.stripeClient.RawRequest(HttpMethod.Get, "/", "abc"));
        }

        [Fact]
        public void Deserialize()
        {
            var content = "{\"bar\": \"baz\"}";
            var deserialized = this.stripeClient.Deserialize<Foo>(content);

            Assert.Equal(typeof(Foo), deserialized.GetType());
        }

        [Fact]
        public async Task RequestStreamingAsync_OkResponse_InvalidJson()
        {
            var streamedResponse = new StripeStreamedResponse(
                HttpStatusCode.OK,
                null,
                StringToStream("this isn't JSON"));
            this.httpClient.StreamedResponse = streamedResponse;

            var stream = await this.stripeClient.RequestStreamingAsync(
                HttpMethod.Post,
                "/v1/charges",
                this.options,
                this.requestOptions);

            Assert.NotNull(stream);
            Assert.Equal("this isn't JSON", StreamToString(stream));
        }

        [Fact]
        public async Task RequestStreamingAsync_ApiError()
        {
            var streamedResponse = new StripeStreamedResponse(
                HttpStatusCode.PaymentRequired,
                null,
                StringToStream("{\"error\": {\"type\": \"card_error\"}}"));
            this.httpClient.StreamedResponse = streamedResponse;

            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await this.stripeClient.RequestStreamingAsync(
                    HttpMethod.Post,
                    "/v1/charges",
                    this.options,
                    this.requestOptions));

            Assert.NotNull(exception);
            Assert.Equal(HttpStatusCode.PaymentRequired, exception.HttpStatusCode);
            Assert.Equal("card_error", exception.StripeError.Type);
            Assert.Equal(await streamedResponse.ToStripeResponseAsync(), exception.StripeResponse);
        }

        [Fact]
        public async Task RequestStreamingAsync_OAuthError()
        {
            var streamedResponse = new StripeStreamedResponse(
                HttpStatusCode.BadRequest,
                null,
                StringToStream("{\"error\": \"invalid_request\"}"));
            this.httpClient.StreamedResponse = streamedResponse;

            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await this.stripeClient.RequestStreamingAsync(
                    HttpMethod.Post,
                    "/oauth/token",
                    this.options,
                    this.requestOptions));

            Assert.NotNull(exception);
            Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
            Assert.Equal("invalid_request", exception.StripeError.Error);
            Assert.Equal(await streamedResponse.ToStripeResponseAsync(), exception.StripeResponse);
        }

        [Fact]
        public async Task RequestStreamingAsync_Error_InvalidErrorObject()
        {
            var streamedResponse = new StripeStreamedResponse(
                HttpStatusCode.InternalServerError,
                null,
                StringToStream("{}"));
            this.httpClient.StreamedResponse = streamedResponse;

            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await this.stripeClient.RequestStreamingAsync(
                    HttpMethod.Post,
                    "/v1/charges",
                    this.options,
                    this.requestOptions));

            Assert.NotNull(exception);
            Assert.Equal(HttpStatusCode.InternalServerError, exception.HttpStatusCode);
            Assert.Equal("Invalid response object from API: \"{}\"", exception.Message);
            Assert.Equal(await streamedResponse.ToStripeResponseAsync(), exception.StripeResponse);
        }

        private static Stream StringToStream(string content)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(content));
        }

        private static string StreamToString(Stream stream)
        {
            return new StreamReader(stream, Encoding.UTF8).ReadToEnd();
        }

        private class DummyHttpClient : IHttpClient
        {
            public StripeResponse Response { get; set; }

            public StripeStreamedResponse StreamedResponse { get; set; }

            public StripeRequest LastRequest { get; set; }

            public Task<StripeResponse> MakeRequestAsync(
                StripeRequest request,
                CancellationToken cancellationToken = default)
            {
                this.LastRequest = request;

                if (this.Response == null)
                {
                    throw new StripeTestException("Response is null");
                }

                return Task.FromResult<StripeResponse>(this.Response);
            }

            public Task<StripeStreamedResponse> MakeStreamingRequestAsync(
                StripeRequest request,
                CancellationToken cancellationToken = default)
            {
                this.LastRequest = request;

                if (this.StreamedResponse == null)
                {
                    throw new StripeTestException("StreamedResponse is null");
                }

                return Task.FromResult(this.StreamedResponse);
            }
        }

        private class Foo : StripeEntity<Foo>
        {
            [JsonProperty("bar")]
            public string Bar { get; set; }
        }
    }
}

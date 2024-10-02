namespace StripeTests
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
    using Xunit;

    public class StripeClientTest : BaseStripeTest
    {
        private StripeClient stripeClient;

        public StripeClientTest(StripeMockFixture stripeMockFixture, MockHttpClientFixture mockHttpClient)
            : base(stripeMockFixture, mockHttpClient)
        {
            this.stripeClient = this.StripeClient as StripeClient;
        }

        [Fact]
        public void Ctr_StripeClientOptions()
        {
            var options = new StripeClientOptions
            {
                ApiKey = "ak_123",
                ClientId = "ci_456",
                ApiBase = "localhost:8086",
                ConnectBase = "localhost:8087",
                MeterEventsBase = "localhost:6502",
                FilesBase = "localhost:555",
                HttpClient = new TestHttpClient(),
            };

            var client = new StripeClient(options);
            Assert.Equal(options.ApiKey, client.ApiKey);
            Assert.Equal(options.ClientId, client.ClientId);
            Assert.Equal(options.ApiBase, client.ApiBase);
            Assert.Equal(options.ConnectBase, client.ConnectBase);
            Assert.Equal(options.MeterEventsBase, client.MeterEventsBase);
            Assert.Equal(options.FilesBase, client.FilesBase);
            Assert.Equal(options.HttpClient, client.HttpClient);
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
        public async Task RawRequestAsync_Telemetry()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "{}");
            this.httpClient.Response = response;

            var rawresponse = await this.stripeClient.RawRequestAsync(
                HttpMethod.Post,
                "/v1/charges",
                "foo=bar");
            var lastRequest = this.httpClient.LastRequest;
            Assert.Equal(new List<string> { "raw_request" }, lastRequest.Usage);
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
        public async Task RawRequestAsync_StripeContext()
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
                    StripeContext = "ctx_123",
                });

            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal("ctx_123", lastRequest.StripeHeaders["Stripe-Context"]);
        }

        [Fact]
        public void RawRequest_StripeContext()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = this.stripeClient.RawRequest(
                HttpMethod.Post,
                "/v1/charges",
                "{\"foo\":\"bar\"}",
                new RawRequestOptions
                {
                    StripeContext = "ctx_123",
                });

            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal("ctx_123", lastRequest.StripeHeaders["Stripe-Context"]);
        }

        [Fact]
        public async Task PreviewGetAsync_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = await this.stripeClient.Preview.GetAsync("/v1/charges/ch_123");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Get, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Null(lastRequest.Content);
            Assert.Equal(ApiVersion.CurrentPreview, lastRequest.StripeHeaders["Stripe-Version"]);
        }

        [Fact]
        public void PreviewGet_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = this.stripeClient.Preview.Get("/v1/charges/ch_123");
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

            var rawResponse = await this.stripeClient.Preview.PostAsync("/v1/charges/ch_123", "{\"foo\":\"bar\"}");
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
        public async Task PreviewPost_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = this.stripeClient.Preview.Post("/v1/charges/ch_123", "{\"foo\":\"bar\"}");
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

            var rawResponse = await this.stripeClient.Preview.DeleteAsync("/v1/charges/ch_123");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Delete, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Null(lastRequest.Content);
            Assert.Equal(ApiVersion.CurrentPreview, lastRequest.StripeHeaders["Stripe-Version"]);
        }

        [Fact]
        public void PreviewDelete_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = this.stripeClient.Preview.Delete("/v1/charges/ch_123");
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

                // This test is designed to ensure StripeClient properly consumes all options.  If any are
                // missing, this will fail which means we added a new option but did not add it to the
                // test.
                foreach (var pinfo in options.GetType().GetProperties())
                {
                    Assert.NotNull(pinfo.GetValue(options));
                }

                var client = new StripeClient(options);
                Assert.Equal(options.ApiKey, client.ApiKey);
                Assert.Equal(options.ClientId, client.ClientId);
                Assert.Equal(options.ApiBase, client.ApiBase);
                Assert.Equal(options.ConnectBase, client.ConnectBase);
                Assert.Equal(options.MeterEventsBase, client.MeterEventsBase);
                Assert.Equal(options.FilesBase, client.FilesBase);
                Assert.Equal(options.HttpClient, client.HttpClient);
            }

            [Fact]
            public void Ctr_StripeClientOptions_ChangesAfterConstruction()
            {
                var options = new StripeClientOptions
                {
                    ApiKey = "ak_123",
                };

                var client = new StripeClient(options);

                Assert.Equal(options.ApiKey, client.ApiKey);
                var goodApiKey = options.ApiKey;
                options.ApiKey = "wrong_key_456";
                Assert.NotEqual(options.ApiKey, client.ApiKey);
                Assert.Equal(goodApiKey, client.ApiKey);
            }

            [Fact]
            public async Task RawRequestAsync_Json()
            {
                // Stub a request as stripe-mock does not support v2
                this.MockHttpClientFixture.StubRequest(
                        HttpMethod.Post,
                        "/v2/billing/meter_event_session",
                        System.Net.HttpStatusCode.OK,
                        "{\"id\": \"mes_123\",\"object\":\"billing.meter_event_session\"}");

                var rawResponse = await this.stripeClient.RawRequestAsync(
                    HttpMethod.Post,
                    "/v2/billing/meter_event_session",
                    "{}",
                    new RawRequestOptions
                    {
                        AdditionalHeaders =
                        {
                        { "foo", "bar" },
                        },
                    });

                this.MockHttpClientFixture.MockHandler.Protected()
                    .Verify(
                            "SendAsync",
                            Times.Once(),
                            ItExpr.Is<HttpRequestMessage>(m =>
                                m.Headers.GetValues("Stripe-Version").First() == ApiVersion.Current &&
                                m.Headers.GetValues("foo").First() == "bar"),
                            ItExpr.IsAny<CancellationToken>());

                var obj = this.stripeClient.Deserialize<Stripe.V2.Billing.MeterEventSession>(rawResponse.Content);
                Assert.Equal("mes_123", obj.Id);
            }

            [Fact]
            public void ConstructThinEvent()
            {
                string payload = @"{
                ""object"": ""event"",
                ""type"": ""unknown"",
                ""data"": {},
                ""relatedObject"": {
                    ""id"": ""acct_123"",
                    ""type"": ""account"",
                    ""url"": ""/v2/accounts""
                }
            }";
                var evt = this.stripeClient.ParseThinEvent(
                    payload,
                    V2.EventTest.GenerateSigHeader(payload),
                    V2.EventTest.WebhookSecret);

                Assert.NotNull(evt);
            }

            [Fact]
            public void ConstructSnapshotEvent()
            {
                var json = GetResourceAsString("event_test_signature.json");
                var eventUtilityEvent = EventUtility.ConstructEvent(
                    json,
                    V2.EventTest.GenerateSigHeader(json),
                    V2.EventTest.WebhookSecret,
                    throwOnApiVersionMismatch: false);

                Assert.NotNull(eventUtilityEvent);
                Assert.Equal("acct_123", eventUtilityEvent.Account);
                Assert.Equal("req_123", eventUtilityEvent.Request.Id);
                Assert.Equal("idempotency-key-123", eventUtilityEvent.Request.IdempotencyKey);
            }

            [Fact]
            public async Task RawRequestAsync_Form()
            {
                // Don't stub, we can use stripe-mock
                var rawResponse = await this.stripeClient.RawRequestAsync(
                    HttpMethod.Post,
                    "/v1/customers",
                    "description=hello",
                    new RawRequestOptions
                    {
                        AdditionalHeaders =
                        {
                        { "foo", "bar" },
                        },
                        ApiMode = ApiMode.V1,
                    });

                this.MockHttpClientFixture.MockHandler.Protected()
                    .Verify(
                            "SendAsync",
                            Times.Once(),
                            ItExpr.Is<HttpRequestMessage>(m =>
                                m.Headers.GetValues("Stripe-Version").First() == ApiVersion.Current &&
                                m.Headers.GetValues("foo").First() == "bar"),
                            ItExpr.IsAny<CancellationToken>());

                var cus = this.stripeClient.Deserialize<Stripe.Customer>(rawResponse.Content);
                Assert.Equal("customer", cus.Object);
            }

            // NOTE: This doesn't need to do anything except be a type we can instantiate
            private class TestHttpClient : IHttpClient
            {
                public Task<StripeResponse> MakeRequestAsync(StripeRequest request, CancellationToken cancellationToken = default)
                {
                    throw new System.NotImplementedException();
                }

                public Task<StripeStreamedResponse> MakeStreamingRequestAsync(StripeRequest request, CancellationToken cancellationToken = default)
                {
                    throw new System.NotImplementedException();
                }
            }

            private class Foo : StripeEntity<Foo>
            {
                [JsonProperty("bar")]
                public string Bar { get; set; }
            }
        }
    }

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
    using Stripe.V2;
    using Stripe.V2.Billing;
    using Xunit;

    public class LiveApiRequestorTest : BaseStripeTest
    {
        private readonly DummyHttpClient httpClient;
        private readonly LiveApiRequestor apiRequestor;
        private readonly BaseOptions options;
        private readonly RequestOptions requestOptions;

        public LiveApiRequestorTest()
        {
            this.httpClient = new DummyHttpClient();
            this.apiRequestor = new LiveApiRequestor(new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                HttpClient = this.httpClient,
            });
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
            var client = new LiveApiRequestor(null);
            Assert.NotNull(client);
            Assert.Null(client.ApiKey);
        }

        [Fact]
        public void Ctor_ThrowsIfApiKeyIsEmpty()
        {
            var exception = Assert.Throws<ArgumentException>(() => new LiveApiRequestor(new StripeClientOptions { ApiKey = string.Empty }));
            Assert.Contains("API key cannot be the empty string.", exception.Message);
        }

        [Fact]
        public void Ctor_ThrowsIfApiKeyContainsWhitespace()
        {
            var exception = Assert.Throws<ArgumentException>(() => new LiveApiRequestor(new StripeClientOptions { ApiKey = "sk_test_123\n" }));
            Assert.Contains("API key cannot contain whitespace.", exception.Message);
        }

        [Fact]
        public async Task RequestAsync_OkResponse()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            this.httpClient.Response = response;

            var charge = await this.apiRequestor.RequestAsync<Charge>(
                BaseAddress.Api,
                HttpMethod.Post,
                "/v1/charges",
                this.options,
                this.requestOptions);

            Assert.NotNull(charge);
            Assert.Equal("ch_123", charge.Id);
            Assert.Equal(response, charge.StripeResponse);
        }

        [Fact]
        public async Task RequestAsync_OkResponse_StripeAccount_RequestOptions()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            this.httpClient.Response = response;

            var testRequestOptions = new RequestOptions
            {
                StripeAccount = "acct_456",
            };

            var charge = await this.apiRequestor.RequestAsync<Charge>(
                BaseAddress.Api,
                HttpMethod.Post,
                "/v1/charges",
                this.options,
                testRequestOptions);

            Assert.NotNull(charge);
            Assert.Equal("acct_456", this.httpClient.LastRequest.StripeHeaders["Stripe-Account"]);
        }

        [Fact]
        public async Task RequestAsync_OkResponse_StripeContext_RequestOptions()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            this.httpClient.Response = response;

            var testRequestOptions = new RequestOptions
            {
                StripeContext = "ctx_123",
            };

            var charge = await this.apiRequestor.RequestAsync<Charge>(
                BaseAddress.Api,
                HttpMethod.Post,
                "/v1/charges",
                this.options,
                testRequestOptions);

            Assert.NotNull(charge);
            Assert.Equal("ctx_123", this.httpClient.LastRequest.StripeHeaders["Stripe-Context"]);
        }

        [Fact]
        public async Task RequestAsync_OkResponse_InvalidJson()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "this isn't JSON");
            this.httpClient.Response = response;

            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await this.apiRequestor.RequestAsync<Charge>(
                    BaseAddress.Api,
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
                await this.apiRequestor.RequestAsync<Charge>(
                    BaseAddress.Api,
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
                await this.apiRequestor.RequestAsync<OAuthToken>(
                    BaseAddress.Connect,
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
                await this.apiRequestor.RequestAsync<Charge>(
                    BaseAddress.Api,
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
                await this.apiRequestor.RequestAsync<Charge>(
                    BaseAddress.Api,
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
        public async Task RequestAsync_V2_Error()
        {
            var body = @"
                {
                  ""error"": {
                    ""type"": ""temporary_session_expired"",
                    ""code"": ""billing_meter_event_session_expired"",
                    ""message"": ""your session is expired""
                  }
                }
            ";
            var response = new StripeResponse(HttpStatusCode.BadRequest, null, body);
            this.httpClient.Response = response;

            var exception = await Assert.ThrowsAsync<TemporarySessionExpiredException>(async () =>
                await this.apiRequestor.RequestAsync<EmptyStripeEntity>(
                    BaseAddress.Api,
                    HttpMethod.Post,
                    "/v2/meter_event_stream",
                    this.options,
                    this.requestOptions));

            Assert.NotNull(exception);
            Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
            Assert.Equal("your session is expired", exception.Message);
            Assert.Equal(response, exception.StripeResponse);
        }

        /* TODO(jar) this test is not relevant for now, but it will be when we re-enable these resources
                [Fact]
                public async Task RequestAsync_V2_Error_With_Field()
                {
                    var body = @"
                        {
                          ""error"": {
                            ""type"": ""invalid_payment_method"",
                            ""code"": ""invalid_payment_method"",
                            ""message"": ""Republic credits are no good out here, I need something more real"",
                            ""invalid_param"": ""currency""
                          }
                        }
                    ";
                    var response = new StripeResponse(HttpStatusCode.BadRequest, null, body);
                    this.httpClient.Response = response;

                    var exception = await Assert.ThrowsAsync<InvalidPaymentMethodException>(async () =>
                        await this.apiRequestor.RequestAsync<Stripe.V2.PaymentMethods.UsBankAccount>(
                            BaseAddress.Api,
                            HttpMethod.Post,
                            "/v2/payment_methods/us_bank_accounts",
                            this.options,
                            this.requestOptions));

                    Assert.NotNull(exception);
                    Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
                    Assert.Equal("Republic credits are no good out here, I need something more real", exception.Message);
                    Assert.Equal(response, exception.StripeResponse);
                    Assert.Equal("currency", exception.InvalidParam);
                    Assert.Equal("currency", (exception.StripeError as InvalidPaymentMethodError).InvalidParam);
                }
        */
        [Fact]
        public async Task RequestStreamingAsync_OkResponse_InvalidJson()
        {
            var streamedResponse = new StripeStreamedResponse(
                HttpStatusCode.OK,
                null,
                StringToStream("this isn't JSON"));
            this.httpClient.StreamedResponse = streamedResponse;

            var stream = await this.apiRequestor.RequestStreamingAsync(
                BaseAddress.Api,
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
                await this.apiRequestor.RequestStreamingAsync(
                    BaseAddress.Api,
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
                await this.apiRequestor.RequestStreamingAsync(
                    BaseAddress.Api,
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
                await this.apiRequestor.RequestStreamingAsync(
                    BaseAddress.Api,
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

        [Fact]
        public async Task RequestAsync_V2_ContentType()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"fa_123\"}");
            this.httpClient.Response = response;

            var options = new Stripe.V2.Billing.MeterEventSessionCreateOptions
            {
            };
            var rawresponse = await this.apiRequestor.RequestAsync<Stripe.V2.Billing.MeterEventSession>(
                BaseAddress.Api,
                HttpMethod.Post,
                "/v2/meter_event_session",
                options,
                this.requestOptions);

            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal("application/json; charset=utf-8", lastRequest.Content.Headers.GetValues("Content-Type").First());
            Assert.Equal("{}", await lastRequest.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task RawRequestAsync_Form()
        {
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            this.httpClient.Response = response;

            var rawresponse = await this.apiRequestor.RawRequestAsync(
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

            var rawresponse = await this.apiRequestor.RawRequestAsync(
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

            var rawresponse = this.apiRequestor.RawRequest(
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

            var rawResponse = await this.apiRequestor.RawRequestAsync(
                HttpMethod.Post,
                "/v2/charges",
                "{\"foo\":\"bar\"}",
                new RawRequestOptions
                {
                    AdditionalHeaders =
                    {
                        { "foo", "bar" },
                    },
                });

            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(content, rawResponse.Content);
            Assert.Equal("application/json; charset=utf-8", lastRequest.Content.Headers.GetValues("Content-Type").First());
            Assert.Equal("{\"foo\":\"bar\"}", await lastRequest.Content.ReadAsStringAsync());
            Assert.Equal("bar", lastRequest.StripeHeaders["foo"]);
        }

        [Fact]
        public async Task RawRequestAsync_StripeContext()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = await this.apiRequestor.RawRequestAsync(
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

            var rawResponse = this.apiRequestor.RawRequest(
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
        public async Task RawRequest_GetAsync_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = await this.apiRequestor.RawRequestAsync(HttpMethod.Get, "/v1/charges/ch_123");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Get, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Null(lastRequest.Content);
        }

        [Fact]
        public void RawRequest_Get_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = this.apiRequestor.RawRequest(HttpMethod.Get, "/v1/charges/ch_123");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Get, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Null(lastRequest.Content);
        }

        [Fact]
        public async Task RawRequest_PostAsync_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = await this.apiRequestor.RawRequestAsync(HttpMethod.Post, "/v1/charges/ch_123", "{\"foo\":\"bar\"}");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Post, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Equal("{\"foo\":\"bar\"}", await lastRequest.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task RawRequest_Post_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = this.apiRequestor.RawRequest(HttpMethod.Post, "/v1/charges/ch_123", "{\"foo\":\"bar\"}");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Post, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Equal("{\"foo\":\"bar\"}", await lastRequest.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task RawRequest_DeleteAsync_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = await this.apiRequestor.RawRequestAsync(HttpMethod.Delete, "/v1/charges/ch_123");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Delete, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Null(lastRequest.Content);
        }

        [Fact]
        public void RawRequest_Delete_Json()
        {
            var content = "{\"id\": \"ch_123\", \"object\": \"charge\"}";
            var response = new StripeResponse(HttpStatusCode.OK, null, content);
            this.httpClient.Response = response;

            var rawResponse = this.apiRequestor.RawRequest(HttpMethod.Delete, "/v1/charges/ch_123");
            var lastRequest = this.httpClient.LastRequest;

            Assert.Equal(HttpMethod.Delete, lastRequest.Method);
            Assert.Equal(content, rawResponse.Content);
            Assert.Null(lastRequest.Content);
        }

        [Fact]
        public void RawRequestThrowsForNonPostOptions()
        {
            Assert.Throws<InvalidOperationException>(() => this.apiRequestor.RawRequest(HttpMethod.Get, "/", "abc"));
        }

        [Fact]
        public void Deserialize()
        {
            var content = "{\"bar\": \"baz\"}";
            var deserialized = new StripeClient().Deserialize<Foo>(content);

            Assert.Equal(typeof(Foo), deserialized.GetType());
        }

        [Fact]
        public async Task StripeContextHeaderSet()
        {
            var apiRequestorWithContext = new LiveApiRequestor(new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                HttpClient = this.httpClient,
                StripeContext = "ctx_1234",
            });
            var response = new StripeResponse(HttpStatusCode.OK, null, "{}");
            this.httpClient.Response = response;

            var service = new CustomerService(apiRequestorWithContext);

            await service.CreateAsync(new CustomerCreateOptions() { });
            var lastRequest = this.httpClient.LastRequest;
            Assert.Equal("ctx_1234", lastRequest.StripeHeaders["Stripe-Context"]);
        }

        [Fact]
        public async Task StripeAccountHeaderSet()
        {
            var apiRequestorWithContext = new LiveApiRequestor(new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                HttpClient = this.httpClient,
                StripeAccount = "acct_1234",
            });

            var response = new StripeResponse(HttpStatusCode.OK, null, "{}");
            this.httpClient.Response = response;

            var service = new CustomerService(apiRequestorWithContext);

            await service.CreateAsync(new CustomerCreateOptions() { });
            var lastRequest = this.httpClient.LastRequest;
            Assert.Equal("acct_1234", lastRequest.StripeHeaders["Stripe-Account"]);
        }

        private class Foo : StripeEntity<Foo>
        {
            [JsonProperty("bar")]
            public string Bar { get; set; }
        }
    }
}

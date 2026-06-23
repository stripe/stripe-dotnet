namespace Stripe.Infrastructure
{
    using System;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Nodes;
    using System.Text.Json.Serialization;

    /// <summary>
    /// STJ converter for Event objects. Handles legacy API version patching
    /// (converting string `request` field to object format for API versions
    /// before 2017-05-25).
    ///
    /// This converter extends <see cref="STJDefaultConverter{T}"/> and uses
    /// <see cref="STJDefaultConverter{T}.ReadFullObject"/> directly, avoiding
    /// pipeline re-entry and the need for self-removal recursion.
    /// </summary>
    internal class STJEventConverter : STJDefaultConverter<Event>
    {
        public override Event Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            // Parse into a mutable JsonNode for potential patching
            var jsonNode = JsonNode.Parse(ref reader);

            // Handle breaking change in API version 2017-05-25:
            // If `request` is a string, convert it to an object
            var requestNode = jsonNode["request"];
            if (requestNode != null && requestNode is JsonValue)
            {
                var requestId = requestNode.GetValue<string>();
                if (requestId != null)
                {
                    var requestObject = new JsonObject
                    {
                        ["id"] = requestId,
                        ["idempotency_key"] = null,
                    };
                    jsonNode["request"] = requestObject;
                }
            }

            // Deserialize the (possibly patched) JSON via ReadFullObject
            var patchedJson = jsonNode.ToJsonString();
            var bytes = Encoding.UTF8.GetBytes(patchedJson);
            var newReader = new Utf8JsonReader(bytes, new JsonReaderOptions
            {
                AllowTrailingCommas = options.AllowTrailingCommas,
                CommentHandling = options.ReadCommentHandling,
                MaxDepth = options.MaxDepth,
            });
            newReader.Read();

            var entity = this.ReadFullObject(ref newReader, typeToConvert, options);

            // Store raw JSON so RawJObject and RawJsonElement are available,
            // matching the behavior of STJStripeEntityConverter.
            entity.SetRawJsonString(patchedJson);

            return entity;
        }
    }
}

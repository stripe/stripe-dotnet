namespace Stripe.Infrastructure
{
    using System;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// STJ converter for EventData objects. Captures raw JSON strings for
    /// <c>data.object</c> and <c>data.previous_attributes</c> so they can
    /// be lazily accessed via <see cref="EventData.RawObject"/> and
    /// <see cref="EventData.PreviousAttributes"/>.
    /// </summary>
    internal class STJEventDataConverter : STJDefaultConverter<EventData>
    {
        public override EventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            // Buffer the entire EventData JSON so we can extract raw strings
            // before deserializing properties.
            var element = JsonElement.ParseValue(ref reader);

            // Extract raw JSON strings for lazy parsing
            string rawObject = null;
            string rawPreviousAttributes = null;

            if (element.TryGetProperty("object", out var objProp))
            {
                rawObject = objProp.GetRawText();
            }

            if (element.TryGetProperty("previous_attributes", out var prevProp))
            {
                rawPreviousAttributes = prevProp.GetRawText();
            }

            // Deserialize via ReadFullObject (no pipeline re-entry)
            var bytes = Encoding.UTF8.GetBytes(element.GetRawText());
            var newReader = new Utf8JsonReader(bytes, new JsonReaderOptions
            {
                AllowTrailingCommas = options.AllowTrailingCommas,
                CommentHandling = options.ReadCommentHandling,
                MaxDepth = options.MaxDepth,
            });
            newReader.Read();

            var data = this.ReadFullObject(ref newReader, typeToConvert, options);

            // Set raw JSON strings for lazy parsing by EventData properties
            if (rawObject != null)
            {
                data.SetRawObjectJson(rawObject);
            }

            if (rawPreviousAttributes != null)
            {
                data.SetPreviousAttributesJson(rawPreviousAttributes);
            }

            return data;
        }
    }
}

using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Groups.Item.Sites.Item.Lists.Item.ContentTypes.Item.MicrosoftGraphCopyToDefaultContentLocation {
    public class CopyToDefaultContentLocationPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The destinationFileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationFileName { get; set; }
#nullable restore
#else
        public string DestinationFileName { get; set; }
#endif
        /// <summary>The sourceFile property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemReference? SourceFile { get; set; }
#nullable restore
#else
        public ItemReference SourceFile { get; set; }
#endif
        /// <summary>
        /// Instantiates a new copyToDefaultContentLocationPostRequestBody and sets the default values.
        /// </summary>
        public CopyToDefaultContentLocationPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CopyToDefaultContentLocationPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyToDefaultContentLocationPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"destinationFileName", n => { DestinationFileName = n.GetStringValue(); } },
                {"sourceFile", n => { SourceFile = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("destinationFileName", DestinationFileName);
            writer.WriteObjectValue<ItemReference>("sourceFile", SourceFile);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
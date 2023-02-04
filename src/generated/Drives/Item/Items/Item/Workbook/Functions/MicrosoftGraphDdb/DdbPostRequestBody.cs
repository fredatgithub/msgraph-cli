using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphDdb {
    public class DdbPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Cost { get; set; }
#nullable restore
#else
        public Json Cost { get; set; }
#endif
        /// <summary>The factor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Factor { get; set; }
#nullable restore
#else
        public Json Factor { get; set; }
#endif
        /// <summary>The life property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Life { get; set; }
#nullable restore
#else
        public Json Life { get; set; }
#endif
        /// <summary>The period property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Period { get; set; }
#nullable restore
#else
        public Json Period { get; set; }
#endif
        /// <summary>The salvage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Salvage { get; set; }
#nullable restore
#else
        public Json Salvage { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ddbPostRequestBody and sets the default values.
        /// </summary>
        public DdbPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DdbPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DdbPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cost", n => { Cost = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"factor", n => { Factor = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"life", n => { Life = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"period", n => { Period = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"salvage", n => { Salvage = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("factor", Factor);
            writer.WriteObjectValue<Json>("life", Life);
            writer.WriteObjectValue<Json>("period", Period);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

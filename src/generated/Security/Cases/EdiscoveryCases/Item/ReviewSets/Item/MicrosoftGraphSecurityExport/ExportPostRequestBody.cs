// <auto-generated/>
using ApiSdk.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Security.Cases.EdiscoveryCases.Item.ReviewSets.Item.MicrosoftGraphSecurityExport {
    public class ExportPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The exportOptions property</summary>
        public ApiSdk.Models.Security.ExportOptions? ExportOptions { get; set; }
        /// <summary>The exportStructure property</summary>
        public ExportFileStructure? ExportStructure { get; set; }
        /// <summary>The outputName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputName { get; set; }
#nullable restore
#else
        public string OutputName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new exportPostRequestBody and sets the default values.
        /// </summary>
        public ExportPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"exportOptions", n => { ExportOptions = n.GetEnumValue<ExportOptions>(); } },
                {"exportStructure", n => { ExportStructure = n.GetEnumValue<ExportFileStructure>(); } },
                {"outputName", n => { OutputName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<ExportOptions>("exportOptions", ExportOptions);
            writer.WriteEnumValue<ExportFileStructure>("exportStructure", ExportStructure);
            writer.WriteStringValue("outputName", OutputName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SubscribedSku : Entity, IParsable {
        /// <summary>The unique ID of the account this SKU belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId { get; set; }
#nullable restore
#else
        public string AccountId { get; set; }
#endif
        /// <summary>The name of the account this SKU belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName { get; set; }
#nullable restore
#else
        public string AccountName { get; set; }
#endif
        /// <summary>The target class for this SKU. Only SKUs with target class User are assignable. Possible values are: &apos;User&apos;, &apos;Company&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppliesTo { get; set; }
#nullable restore
#else
        public string AppliesTo { get; set; }
#endif
        /// <summary>Enabled indicates that the prepaidUnits property has at least one unit that is enabled. LockedOut indicates that the customer canceled their subscription. Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CapabilityStatus { get; set; }
#nullable restore
#else
        public string CapabilityStatus { get; set; }
#endif
        /// <summary>The number of licenses that have been assigned.</summary>
        public int? ConsumedUnits { get; set; }
        /// <summary>Information about the number and status of prepaid licenses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LicenseUnitsDetail? PrepaidUnits { get; set; }
#nullable restore
#else
        public LicenseUnitsDetail PrepaidUnits { get; set; }
#endif
        /// <summary>Information about the service plans that are available with the SKU. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServicePlanInfo>? ServicePlans { get; set; }
#nullable restore
#else
        public List<ServicePlanInfo> ServicePlans { get; set; }
#endif
        /// <summary>The unique identifier (GUID) for the service SKU.</summary>
        public Guid? SkuId { get; set; }
        /// <summary>The SKU part number; for example: &apos;AAD_PREMIUM&apos; or &apos;RMSBASIC&apos;. To get a list of commercial subscriptions that an organization has acquired, see List subscribedSkus.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuPartNumber { get; set; }
#nullable restore
#else
        public string SkuPartNumber { get; set; }
#endif
        /// <summary>The subscriptionIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SubscriptionIds { get; set; }
#nullable restore
#else
        public List<string> SubscriptionIds { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="SubscribedSku"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SubscribedSku CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubscribedSku();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountId", n => { AccountId = n.GetStringValue(); } },
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"appliesTo", n => { AppliesTo = n.GetStringValue(); } },
                {"capabilityStatus", n => { CapabilityStatus = n.GetStringValue(); } },
                {"consumedUnits", n => { ConsumedUnits = n.GetIntValue(); } },
                {"prepaidUnits", n => { PrepaidUnits = n.GetObjectValue<LicenseUnitsDetail>(LicenseUnitsDetail.CreateFromDiscriminatorValue); } },
                {"servicePlans", n => { ServicePlans = n.GetCollectionOfObjectValues<ServicePlanInfo>(ServicePlanInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"skuId", n => { SkuId = n.GetGuidValue(); } },
                {"skuPartNumber", n => { SkuPartNumber = n.GetStringValue(); } },
                {"subscriptionIds", n => { SubscriptionIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("appliesTo", AppliesTo);
            writer.WriteStringValue("capabilityStatus", CapabilityStatus);
            writer.WriteIntValue("consumedUnits", ConsumedUnits);
            writer.WriteObjectValue<LicenseUnitsDetail>("prepaidUnits", PrepaidUnits);
            writer.WriteCollectionOfObjectValues<ServicePlanInfo>("servicePlans", ServicePlans);
            writer.WriteGuidValue("skuId", SkuId);
            writer.WriteStringValue("skuPartNumber", SkuPartNumber);
            writer.WriteCollectionOfPrimitiveValues<string>("subscriptionIds", SubscriptionIds);
        }
    }
}

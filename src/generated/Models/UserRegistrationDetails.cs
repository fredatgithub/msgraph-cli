// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class UserRegistrationDetails : Entity, IParsable {
        /// <summary>Indicates whether the user has an admin role in the tenant. This value can be used to check the authentication methods that privileged accounts are registered for and capable of.</summary>
        public bool? IsAdmin { get; set; }
        /// <summary>Indicates whether the user has registered a strong authentication method for multifactor authentication. The method must be allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsMfaCapable { get; set; }
        /// <summary>Indicates whether the user has registered a strong authentication method for multifactor authentication. The method may not necessarily be allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsMfaRegistered { get; set; }
        /// <summary>Indicates whether the user has registered a passwordless strong authentication method (including FIDO2, Windows Hello for Business, and Microsoft Authenticator (Passwordless)) that is allowed by the authentication methods policy. Supports $filter (eq).</summary>
        public bool? IsPasswordlessCapable { get; set; }
        /// <summary>Indicates whether the user has registered the required number of authentication methods for self-service password reset and the user is allowed to perform self-service password reset by policy. Supports $filter (eq).</summary>
        public bool? IsSsprCapable { get; set; }
        /// <summary>Indicates whether the user is allowed to perform self-service password reset by policy. The user may not necessarily have registered the required number of authentication methods for self-service password reset. Supports $filter (eq).</summary>
        public bool? IsSsprEnabled { get; set; }
        /// <summary>Indicates whether the user has registered the required number of authentication methods for self-service password reset. The user may not necessarily be allowed to perform self-service password reset by policy. Supports $filter (eq).</summary>
        public bool? IsSsprRegistered { get; set; }
        /// <summary>Indicates whether system preferred authentication method is enabled. If enabled, the system dynamically determines the most secure authentication method among the methods registered by the user. Supports $filter (eq).</summary>
        public bool? IsSystemPreferredAuthenticationMethodEnabled { get; set; }
        /// <summary>The date and time (UTC) when the record was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>Collection of authentication methods registered, such as mobilePhone, email, passKeyDeviceBound. Supports $filter (any with eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MethodsRegistered { get; set; }
#nullable restore
#else
        public List<string> MethodsRegistered { get; set; }
#endif
        /// <summary>Collection of authentication methods that the system determined to be the most secure authentication methods among the registered methods for second factor authentication. Possible values are: push, oath, voiceMobile, voiceAlternateMobile, voiceOffice, sms, none, unknownFutureValue. Supports $filter (any with eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemPreferredAuthenticationMethods { get; set; }
#nullable restore
#else
        public List<string> SystemPreferredAuthenticationMethods { get; set; }
#endif
        /// <summary>The user display name, such as Adele Vance. Supports $filter (eq, startsWith) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName { get; set; }
#nullable restore
#else
        public string UserDisplayName { get; set; }
#endif
        /// <summary>The method the user selected as the default second-factor for performing multifactor authentication. Possible values are: push, oath, voiceMobile, voiceAlternateMobile, voiceOffice, sms, none, unknownFutureValue. This property is used as preferred MFA method when isSystemPreferredAuthenticationMethodEnabled is false. Supports $filter (any with eq).</summary>
        public UserDefaultAuthenticationMethod? UserPreferredMethodForSecondaryAuthentication { get; set; }
        /// <summary>The user principal name, such as AdeleV@contoso.com. Supports $filter (eq, startsWith) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>Identifies whether the user is a member or guest in the tenant. The possible values are: member, guest, unknownFutureValue.</summary>
        public SignInUserType? UserType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="UserRegistrationDetails"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserRegistrationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isAdmin", n => { IsAdmin = n.GetBoolValue(); } },
                {"isMfaCapable", n => { IsMfaCapable = n.GetBoolValue(); } },
                {"isMfaRegistered", n => { IsMfaRegistered = n.GetBoolValue(); } },
                {"isPasswordlessCapable", n => { IsPasswordlessCapable = n.GetBoolValue(); } },
                {"isSsprCapable", n => { IsSsprCapable = n.GetBoolValue(); } },
                {"isSsprEnabled", n => { IsSsprEnabled = n.GetBoolValue(); } },
                {"isSsprRegistered", n => { IsSsprRegistered = n.GetBoolValue(); } },
                {"isSystemPreferredAuthenticationMethodEnabled", n => { IsSystemPreferredAuthenticationMethodEnabled = n.GetBoolValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"methodsRegistered", n => { MethodsRegistered = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"systemPreferredAuthenticationMethods", n => { SystemPreferredAuthenticationMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userPreferredMethodForSecondaryAuthentication", n => { UserPreferredMethodForSecondaryAuthentication = n.GetEnumValue<UserDefaultAuthenticationMethod>(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<SignInUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isAdmin", IsAdmin);
            writer.WriteBoolValue("isMfaCapable", IsMfaCapable);
            writer.WriteBoolValue("isMfaRegistered", IsMfaRegistered);
            writer.WriteBoolValue("isPasswordlessCapable", IsPasswordlessCapable);
            writer.WriteBoolValue("isSsprCapable", IsSsprCapable);
            writer.WriteBoolValue("isSsprEnabled", IsSsprEnabled);
            writer.WriteBoolValue("isSsprRegistered", IsSsprRegistered);
            writer.WriteBoolValue("isSystemPreferredAuthenticationMethodEnabled", IsSystemPreferredAuthenticationMethodEnabled);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("methodsRegistered", MethodsRegistered);
            writer.WriteCollectionOfPrimitiveValues<string>("systemPreferredAuthenticationMethods", SystemPreferredAuthenticationMethods);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteEnumValue<UserDefaultAuthenticationMethod>("userPreferredMethodForSecondaryAuthentication", UserPreferredMethodForSecondaryAuthentication);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<SignInUserType>("userType", UserType);
        }
    }
}

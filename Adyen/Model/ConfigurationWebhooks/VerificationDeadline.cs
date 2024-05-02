/*
* Configuration webhooks
*
*
* The version of the OpenAPI document: 2
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.ConfigurationWebhooks
{
    /// <summary>
    /// VerificationDeadline
    /// </summary>
    [DataContract(Name = "VerificationDeadline")]
    public partial class VerificationDeadline : IEquatable<VerificationDeadline>, IValidatableObject
    {
        /// <summary>
        /// Defines Capabilities
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CapabilitiesEnum
        {
            /// <summary>
            /// Enum AcceptExternalFunding for value: acceptExternalFunding
            /// </summary>
            [EnumMember(Value = "acceptExternalFunding")]
            AcceptExternalFunding = 1,

            /// <summary>
            /// Enum AcceptPspFunding for value: acceptPspFunding
            /// </summary>
            [EnumMember(Value = "acceptPspFunding")]
            AcceptPspFunding = 2,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedCountries for value: acceptTransactionInRestrictedCountries
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedCountries")]
            AcceptTransactionInRestrictedCountries = 3,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedCountriesCommercial for value: acceptTransactionInRestrictedCountriesCommercial
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedCountriesCommercial")]
            AcceptTransactionInRestrictedCountriesCommercial = 4,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedCountriesConsumer for value: acceptTransactionInRestrictedCountriesConsumer
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedCountriesConsumer")]
            AcceptTransactionInRestrictedCountriesConsumer = 5,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedIndustries for value: acceptTransactionInRestrictedIndustries
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedIndustries")]
            AcceptTransactionInRestrictedIndustries = 6,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedIndustriesCommercial for value: acceptTransactionInRestrictedIndustriesCommercial
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedIndustriesCommercial")]
            AcceptTransactionInRestrictedIndustriesCommercial = 7,

            /// <summary>
            /// Enum AcceptTransactionInRestrictedIndustriesConsumer for value: acceptTransactionInRestrictedIndustriesConsumer
            /// </summary>
            [EnumMember(Value = "acceptTransactionInRestrictedIndustriesConsumer")]
            AcceptTransactionInRestrictedIndustriesConsumer = 8,

            /// <summary>
            /// Enum Acquiring for value: acquiring
            /// </summary>
            [EnumMember(Value = "acquiring")]
            Acquiring = 9,

            /// <summary>
            /// Enum AtmWithdrawal for value: atmWithdrawal
            /// </summary>
            [EnumMember(Value = "atmWithdrawal")]
            AtmWithdrawal = 10,

            /// <summary>
            /// Enum AtmWithdrawalCommercial for value: atmWithdrawalCommercial
            /// </summary>
            [EnumMember(Value = "atmWithdrawalCommercial")]
            AtmWithdrawalCommercial = 11,

            /// <summary>
            /// Enum AtmWithdrawalConsumer for value: atmWithdrawalConsumer
            /// </summary>
            [EnumMember(Value = "atmWithdrawalConsumer")]
            AtmWithdrawalConsumer = 12,

            /// <summary>
            /// Enum AtmWithdrawalInRestrictedCountries for value: atmWithdrawalInRestrictedCountries
            /// </summary>
            [EnumMember(Value = "atmWithdrawalInRestrictedCountries")]
            AtmWithdrawalInRestrictedCountries = 13,

            /// <summary>
            /// Enum AtmWithdrawalInRestrictedCountriesCommercial for value: atmWithdrawalInRestrictedCountriesCommercial
            /// </summary>
            [EnumMember(Value = "atmWithdrawalInRestrictedCountriesCommercial")]
            AtmWithdrawalInRestrictedCountriesCommercial = 14,

            /// <summary>
            /// Enum AtmWithdrawalInRestrictedCountriesConsumer for value: atmWithdrawalInRestrictedCountriesConsumer
            /// </summary>
            [EnumMember(Value = "atmWithdrawalInRestrictedCountriesConsumer")]
            AtmWithdrawalInRestrictedCountriesConsumer = 15,

            /// <summary>
            /// Enum AuthorisedPaymentInstrumentUser for value: authorisedPaymentInstrumentUser
            /// </summary>
            [EnumMember(Value = "authorisedPaymentInstrumentUser")]
            AuthorisedPaymentInstrumentUser = 16,

            /// <summary>
            /// Enum GetGrantOffers for value: getGrantOffers
            /// </summary>
            [EnumMember(Value = "getGrantOffers")]
            GetGrantOffers = 17,

            /// <summary>
            /// Enum IssueBankAccount for value: issueBankAccount
            /// </summary>
            [EnumMember(Value = "issueBankAccount")]
            IssueBankAccount = 18,

            /// <summary>
            /// Enum IssueCard for value: issueCard
            /// </summary>
            [EnumMember(Value = "issueCard")]
            IssueCard = 19,

            /// <summary>
            /// Enum IssueCardCommercial for value: issueCardCommercial
            /// </summary>
            [EnumMember(Value = "issueCardCommercial")]
            IssueCardCommercial = 20,

            /// <summary>
            /// Enum IssueCardConsumer for value: issueCardConsumer
            /// </summary>
            [EnumMember(Value = "issueCardConsumer")]
            IssueCardConsumer = 21,

            /// <summary>
            /// Enum LocalAcceptance for value: localAcceptance
            /// </summary>
            [EnumMember(Value = "localAcceptance")]
            LocalAcceptance = 22,

            /// <summary>
            /// Enum Payout for value: payout
            /// </summary>
            [EnumMember(Value = "payout")]
            Payout = 23,

            /// <summary>
            /// Enum PayoutToTransferInstrument for value: payoutToTransferInstrument
            /// </summary>
            [EnumMember(Value = "payoutToTransferInstrument")]
            PayoutToTransferInstrument = 24,

            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 25,

            /// <summary>
            /// Enum ReceiveFromBalanceAccount for value: receiveFromBalanceAccount
            /// </summary>
            [EnumMember(Value = "receiveFromBalanceAccount")]
            ReceiveFromBalanceAccount = 26,

            /// <summary>
            /// Enum ReceiveFromPlatformPayments for value: receiveFromPlatformPayments
            /// </summary>
            [EnumMember(Value = "receiveFromPlatformPayments")]
            ReceiveFromPlatformPayments = 27,

            /// <summary>
            /// Enum ReceiveFromThirdParty for value: receiveFromThirdParty
            /// </summary>
            [EnumMember(Value = "receiveFromThirdParty")]
            ReceiveFromThirdParty = 28,

            /// <summary>
            /// Enum ReceiveFromTransferInstrument for value: receiveFromTransferInstrument
            /// </summary>
            [EnumMember(Value = "receiveFromTransferInstrument")]
            ReceiveFromTransferInstrument = 29,

            /// <summary>
            /// Enum ReceiveGrants for value: receiveGrants
            /// </summary>
            [EnumMember(Value = "receiveGrants")]
            ReceiveGrants = 30,

            /// <summary>
            /// Enum ReceivePayments for value: receivePayments
            /// </summary>
            [EnumMember(Value = "receivePayments")]
            ReceivePayments = 31,

            /// <summary>
            /// Enum SendToBalanceAccount for value: sendToBalanceAccount
            /// </summary>
            [EnumMember(Value = "sendToBalanceAccount")]
            SendToBalanceAccount = 32,

            /// <summary>
            /// Enum SendToThirdParty for value: sendToThirdParty
            /// </summary>
            [EnumMember(Value = "sendToThirdParty")]
            SendToThirdParty = 33,

            /// <summary>
            /// Enum SendToTransferInstrument for value: sendToTransferInstrument
            /// </summary>
            [EnumMember(Value = "sendToTransferInstrument")]
            SendToTransferInstrument = 34,

            /// <summary>
            /// Enum ThirdPartyFunding for value: thirdPartyFunding
            /// </summary>
            [EnumMember(Value = "thirdPartyFunding")]
            ThirdPartyFunding = 35,

            /// <summary>
            /// Enum UseCard for value: useCard
            /// </summary>
            [EnumMember(Value = "useCard")]
            UseCard = 36,

            /// <summary>
            /// Enum UseCardCommercial for value: useCardCommercial
            /// </summary>
            [EnumMember(Value = "useCardCommercial")]
            UseCardCommercial = 37,

            /// <summary>
            /// Enum UseCardConsumer for value: useCardConsumer
            /// </summary>
            [EnumMember(Value = "useCardConsumer")]
            UseCardConsumer = 38,

            /// <summary>
            /// Enum UseCardInRestrictedCountries for value: useCardInRestrictedCountries
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedCountries")]
            UseCardInRestrictedCountries = 39,

            /// <summary>
            /// Enum UseCardInRestrictedCountriesCommercial for value: useCardInRestrictedCountriesCommercial
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedCountriesCommercial")]
            UseCardInRestrictedCountriesCommercial = 40,

            /// <summary>
            /// Enum UseCardInRestrictedCountriesConsumer for value: useCardInRestrictedCountriesConsumer
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedCountriesConsumer")]
            UseCardInRestrictedCountriesConsumer = 41,

            /// <summary>
            /// Enum UseCardInRestrictedIndustries for value: useCardInRestrictedIndustries
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedIndustries")]
            UseCardInRestrictedIndustries = 42,

            /// <summary>
            /// Enum UseCardInRestrictedIndustriesCommercial for value: useCardInRestrictedIndustriesCommercial
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedIndustriesCommercial")]
            UseCardInRestrictedIndustriesCommercial = 43,

            /// <summary>
            /// Enum UseCardInRestrictedIndustriesConsumer for value: useCardInRestrictedIndustriesConsumer
            /// </summary>
            [EnumMember(Value = "useCardInRestrictedIndustriesConsumer")]
            UseCardInRestrictedIndustriesConsumer = 44,

            /// <summary>
            /// Enum WithdrawFromAtm for value: withdrawFromAtm
            /// </summary>
            [EnumMember(Value = "withdrawFromAtm")]
            WithdrawFromAtm = 45,

            /// <summary>
            /// Enum WithdrawFromAtmCommercial for value: withdrawFromAtmCommercial
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmCommercial")]
            WithdrawFromAtmCommercial = 46,

            /// <summary>
            /// Enum WithdrawFromAtmConsumer for value: withdrawFromAtmConsumer
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmConsumer")]
            WithdrawFromAtmConsumer = 47,

            /// <summary>
            /// Enum WithdrawFromAtmInRestrictedCountries for value: withdrawFromAtmInRestrictedCountries
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmInRestrictedCountries")]
            WithdrawFromAtmInRestrictedCountries = 48,

            /// <summary>
            /// Enum WithdrawFromAtmInRestrictedCountriesCommercial for value: withdrawFromAtmInRestrictedCountriesCommercial
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmInRestrictedCountriesCommercial")]
            WithdrawFromAtmInRestrictedCountriesCommercial = 49,

            /// <summary>
            /// Enum WithdrawFromAtmInRestrictedCountriesConsumer for value: withdrawFromAtmInRestrictedCountriesConsumer
            /// </summary>
            [EnumMember(Value = "withdrawFromAtmInRestrictedCountriesConsumer")]
            WithdrawFromAtmInRestrictedCountriesConsumer = 50

        }



        /// <summary>
        /// The names of the capabilities to be disallowed.
        /// </summary>
        /// <value>The names of the capabilities to be disallowed.</value>
        [DataMember(Name = "capabilities", IsRequired = false, EmitDefaultValue = false)]
        public List<CapabilitiesEnum> Capabilities { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationDeadline" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerificationDeadline() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationDeadline" /> class.
        /// </summary>
        /// <param name="capabilities">The names of the capabilities to be disallowed. (required).</param>
        /// <param name="entityIds">The unique identifiers of the bank account(s) that the deadline applies to.</param>
        /// <param name="expiresAt">The date that verification is due by before capabilities are disallowed. (required).</param>
        public VerificationDeadline(List<CapabilitiesEnum> capabilities = default(List<CapabilitiesEnum>), List<string> entityIds = default(List<string>), DateTime expiresAt = default(DateTime))
        {
            this.Capabilities = capabilities;
            this.ExpiresAt = expiresAt;
            this.EntityIds = entityIds;
        }

        /// <summary>
        /// The unique identifiers of the bank account(s) that the deadline applies to
        /// </summary>
        /// <value>The unique identifiers of the bank account(s) that the deadline applies to</value>
        [DataMember(Name = "entityIds", EmitDefaultValue = false)]
        public List<string> EntityIds { get; set; }

        /// <summary>
        /// The date that verification is due by before capabilities are disallowed.
        /// </summary>
        /// <value>The date that verification is due by before capabilities are disallowed.</value>
        [DataMember(Name = "expiresAt", IsRequired = false, EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerificationDeadline {\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  EntityIds: ").Append(EntityIds).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerificationDeadline);
        }

        /// <summary>
        /// Returns true if VerificationDeadline instances are equal
        /// </summary>
        /// <param name="input">Instance of VerificationDeadline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerificationDeadline input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.EntityIds == input.EntityIds ||
                    this.EntityIds != null &&
                    input.EntityIds != null &&
                    this.EntityIds.SequenceEqual(input.EntityIds)
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                if (this.EntityIds != null)
                {
                    hashCode = (hashCode * 59) + this.EntityIds.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

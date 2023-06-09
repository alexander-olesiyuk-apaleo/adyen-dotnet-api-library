/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
* Contact: developer-experience@adyen.com
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// StoredPaymentMethodDetails
    /// </summary>
    [DataContract(Name = "StoredPaymentMethodDetails")]
    public partial class StoredPaymentMethodDetails : IEquatable<StoredPaymentMethodDetails>, IValidatableObject
    {
        /// <summary>
        /// The payment method type.
        /// </summary>
        /// <value>The payment method type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BcmcMobile for value: bcmc_mobile
            /// </summary>
            [EnumMember(Value = "bcmc_mobile")]
            BcmcMobile = 1,

            /// <summary>
            /// Enum BcmcMobileQR for value: bcmc_mobile_QR
            /// </summary>
            [EnumMember(Value = "bcmc_mobile_QR")]
            BcmcMobileQR = 2,

            /// <summary>
            /// Enum BcmcMobileApp for value: bcmc_mobile_app
            /// </summary>
            [EnumMember(Value = "bcmc_mobile_app")]
            BcmcMobileApp = 3,

            /// <summary>
            /// Enum MomoWallet for value: momo_wallet
            /// </summary>
            [EnumMember(Value = "momo_wallet")]
            MomoWallet = 4,

            /// <summary>
            /// Enum MomoWalletApp for value: momo_wallet_app
            /// </summary>
            [EnumMember(Value = "momo_wallet_app")]
            MomoWalletApp = 5,

            /// <summary>
            /// Enum Twint for value: twint
            /// </summary>
            [EnumMember(Value = "twint")]
            Twint = 6,

            /// <summary>
            /// Enum PaymayaWallet for value: paymaya_wallet
            /// </summary>
            [EnumMember(Value = "paymaya_wallet")]
            PaymayaWallet = 7,

            /// <summary>
            /// Enum GrabpaySG for value: grabpay_SG
            /// </summary>
            [EnumMember(Value = "grabpay_SG")]
            GrabpaySG = 8,

            /// <summary>
            /// Enum GrabpayMY for value: grabpay_MY
            /// </summary>
            [EnumMember(Value = "grabpay_MY")]
            GrabpayMY = 9,

            /// <summary>
            /// Enum GrabpayTH for value: grabpay_TH
            /// </summary>
            [EnumMember(Value = "grabpay_TH")]
            GrabpayTH = 10,

            /// <summary>
            /// Enum GrabpayID for value: grabpay_ID
            /// </summary>
            [EnumMember(Value = "grabpay_ID")]
            GrabpayID = 11,

            /// <summary>
            /// Enum GrabpayVN for value: grabpay_VN
            /// </summary>
            [EnumMember(Value = "grabpay_VN")]
            GrabpayVN = 12,

            /// <summary>
            /// Enum GrabpayPH for value: grabpay_PH
            /// </summary>
            [EnumMember(Value = "grabpay_PH")]
            GrabpayPH = 13,

            /// <summary>
            /// Enum Oxxo for value: oxxo
            /// </summary>
            [EnumMember(Value = "oxxo")]
            Oxxo = 14,

            /// <summary>
            /// Enum Gcash for value: gcash
            /// </summary>
            [EnumMember(Value = "gcash")]
            Gcash = 15,

            /// <summary>
            /// Enum Kakaopay for value: kakaopay
            /// </summary>
            [EnumMember(Value = "kakaopay")]
            Kakaopay = 16,

            /// <summary>
            /// Enum Truemoney for value: truemoney
            /// </summary>
            [EnumMember(Value = "truemoney")]
            Truemoney = 17,

            /// <summary>
            /// Enum TwintPos for value: twint_pos
            /// </summary>
            [EnumMember(Value = "twint_pos")]
            TwintPos = 18

        }


        /// <summary>
        /// The payment method type.
        /// </summary>
        /// <value>The payment method type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredPaymentMethodDetails" /> class.
        /// </summary>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">The payment method type..</param>
        public StoredPaymentMethodDetails(string checkoutAttemptId = default(string), string recurringDetailReference = default(string), string storedPaymentMethodId = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        [Obsolete]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StoredPaymentMethodDetails {\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as StoredPaymentMethodDetails);
        }

        /// <summary>
        /// Returns true if StoredPaymentMethodDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of StoredPaymentMethodDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredPaymentMethodDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.RecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetailReference.GetHashCode();
                }
                if (this.StoredPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethodId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // StoredPaymentMethodId (string) maxLength
            if (this.StoredPaymentMethodId != null && this.StoredPaymentMethodId.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoredPaymentMethodId, length must be less than 64.", new [] { "StoredPaymentMethodId" });
            }

            yield break;
        }
    }

}
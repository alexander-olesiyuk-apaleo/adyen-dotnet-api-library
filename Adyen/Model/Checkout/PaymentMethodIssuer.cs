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
    /// PaymentMethodIssuer
    /// </summary>
    [DataContract(Name = "PaymentMethodIssuer")]
    public partial class PaymentMethodIssuer : IEquatable<PaymentMethodIssuer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodIssuer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodIssuer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodIssuer" /> class.
        /// </summary>
        /// <param name="disabled">A boolean value indicating whether this issuer is unavailable. Can be &#x60;true&#x60; whenever the issuer is offline. (default to false).</param>
        /// <param name="id">The unique identifier of this issuer, to submit in requests to /payments. (required).</param>
        /// <param name="name">A localized name of the issuer. (required).</param>
        public PaymentMethodIssuer(bool disabled = false, string id = default(string), string name = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Disabled = disabled;
        }

        /// <summary>
        /// A boolean value indicating whether this issuer is unavailable. Can be &#x60;true&#x60; whenever the issuer is offline.
        /// </summary>
        /// <value>A boolean value indicating whether this issuer is unavailable. Can be &#x60;true&#x60; whenever the issuer is offline.</value>
        [DataMember(Name = "disabled", EmitDefaultValue = false)]
        public bool Disabled { get; set; }

        /// <summary>
        /// The unique identifier of this issuer, to submit in requests to /payments.
        /// </summary>
        /// <value>The unique identifier of this issuer, to submit in requests to /payments.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A localized name of the issuer.
        /// </summary>
        /// <value>A localized name of the issuer.</value>
        [DataMember(Name = "name", IsRequired = false, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodIssuer {\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as PaymentMethodIssuer);
        }

        /// <summary>
        /// Returns true if PaymentMethodIssuer instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodIssuer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodIssuer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Disabled == input.Disabled ||
                    this.Disabled.Equals(input.Disabled)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.Disabled.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
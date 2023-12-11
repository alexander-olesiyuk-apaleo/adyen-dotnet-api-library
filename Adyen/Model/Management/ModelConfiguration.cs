/*
* Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// ModelConfiguration
    /// </summary>
    [DataContract(Name = "_Configuration")]
    public partial class ModelConfiguration : IEquatable<ModelConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfiguration" /> class.
        /// </summary>
        /// <param name="brand">Payment method, like **eftpos_australia** or **mc**. See the [possible values](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api).  (required).</param>
        /// <param name="country">Countries, to filter different surcharge amounts for domestic or international cards..</param>
        /// <param name="currencies">Currency, and surcharge percentage or amount. (required).</param>
        /// <param name="sources">Funding source. Possible values: * **Credit** * **Debit**.</param>
        public ModelConfiguration(string brand = default(string), List<string> country = default(List<string>), List<Currency> currencies = default(List<Currency>), List<string> sources = default(List<string>))
        {
            this.Brand = brand;
            this.Currencies = currencies;
            this.Country = country;
            this.Sources = sources;
        }

        /// <summary>
        /// Payment method, like **eftpos_australia** or **mc**. See the [possible values](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api). 
        /// </summary>
        /// <value>Payment method, like **eftpos_australia** or **mc**. See the [possible values](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api). </value>
        [DataMember(Name = "brand", IsRequired = false, EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Countries, to filter different surcharge amounts for domestic or international cards.
        /// </summary>
        /// <value>Countries, to filter different surcharge amounts for domestic or international cards.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public List<string> Country { get; set; }

        /// <summary>
        /// Currency, and surcharge percentage or amount.
        /// </summary>
        /// <value>Currency, and surcharge percentage or amount.</value>
        [DataMember(Name = "currencies", IsRequired = false, EmitDefaultValue = false)]
        public List<Currency> Currencies { get; set; }

        /// <summary>
        /// Funding source. Possible values: * **Credit** * **Debit**
        /// </summary>
        /// <value>Funding source. Possible values: * **Credit** * **Debit**</value>
        [DataMember(Name = "sources", EmitDefaultValue = false)]
        public List<string> Sources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelConfiguration {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
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
            return this.Equals(input as ModelConfiguration);
        }

        /// <summary>
        /// Returns true if ModelConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Country == input.Country ||
                    this.Country != null &&
                    input.Country != null &&
                    this.Country.SequenceEqual(input.Country)
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    input.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
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
                if (this.Brand != null)
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Currencies != null)
                {
                    hashCode = (hashCode * 59) + this.Currencies.GetHashCode();
                }
                if (this.Sources != null)
                {
                    hashCode = (hashCode * 59) + this.Sources.GetHashCode();
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

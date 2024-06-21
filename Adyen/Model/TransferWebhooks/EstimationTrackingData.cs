/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.TransferWebhooks
{
    /// <summary>
    /// EstimationTrackingData
    /// </summary>
    [DataContract(Name = "EstimationTrackingData")]
    public partial class EstimationTrackingData : IEquatable<EstimationTrackingData>, IValidatableObject
    {
        /// <summary>
        /// The type of tracking event.   Possible values:   - **estimation**: the estimated date and time of when the funds will be credited has been determined.
        /// </summary>
        /// <value>The type of tracking event.   Possible values:   - **estimation**: the estimated date and time of when the funds will be credited has been determined.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Estimation for value: estimation
            /// </summary>
            [EnumMember(Value = "estimation")]
            Estimation = 1

        }


        /// <summary>
        /// The type of tracking event.   Possible values:   - **estimation**: the estimated date and time of when the funds will be credited has been determined.
        /// </summary>
        /// <value>The type of tracking event.   Possible values:   - **estimation**: the estimated date and time of when the funds will be credited has been determined.</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimationTrackingData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstimationTrackingData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimationTrackingData" /> class.
        /// </summary>
        /// <param name="estimatedArrivalTime">The estimated time the beneficiary should have access to the funds. (required).</param>
        /// <param name="type">The type of tracking event.   Possible values:   - **estimation**: the estimated date and time of when the funds will be credited has been determined. (required) (default to TypeEnum.Estimation).</param>
        public EstimationTrackingData(DateTime estimatedArrivalTime = default(DateTime), TypeEnum type = TypeEnum.Estimation)
        {
            this.EstimatedArrivalTime = estimatedArrivalTime;
            this.Type = type;
        }

        /// <summary>
        /// The estimated time the beneficiary should have access to the funds.
        /// </summary>
        /// <value>The estimated time the beneficiary should have access to the funds.</value>
        [DataMember(Name = "estimatedArrivalTime", IsRequired = false, EmitDefaultValue = false)]
        public DateTime EstimatedArrivalTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimationTrackingData {\n");
            sb.Append("  EstimatedArrivalTime: ").Append(EstimatedArrivalTime).Append("\n");
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
            return this.Equals(input as EstimationTrackingData);
        }

        /// <summary>
        /// Returns true if EstimationTrackingData instances are equal
        /// </summary>
        /// <param name="input">Instance of EstimationTrackingData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimationTrackingData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EstimatedArrivalTime == input.EstimatedArrivalTime ||
                    (this.EstimatedArrivalTime != null &&
                    this.EstimatedArrivalTime.Equals(input.EstimatedArrivalTime))
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
                if (this.EstimatedArrivalTime != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedArrivalTime.GetHashCode();
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
            yield break;
        }
    }

}
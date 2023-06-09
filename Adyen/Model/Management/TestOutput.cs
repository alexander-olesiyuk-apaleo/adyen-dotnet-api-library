/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// TestOutput
    /// </summary>
    [DataContract(Name = "TestOutput")]
    public partial class TestOutput : IEquatable<TestOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestOutput" /> class.
        /// </summary>
        /// <param name="merchantId">Unique identifier of the merchant account that the notification is about..</param>
        /// <param name="output">The response your server returned for the test webhook.  Your server must respond with **[accepted]** for the test webhook to be successful (&#x60;data.status&#x60;: **success**). Find out more about [accepting notifications](https://docs.adyen.com/development-resources/webhooks#accept-notifications)  You can use the value of this field together with the [&#x60;responseCode&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-responseCode) value to troubleshoot unsuccessful test webhooks..</param>
        /// <param name="requestSent">The [body of the notification webhook](https://docs.adyen.com/development-resources/webhooks/understand-notifications#notification-structure) that was sent to your server..</param>
        /// <param name="responseCode">The HTTP response code for your server&#39;s response to the test webhook.  You can use the value of this field together with the the [&#x60;output&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-output) field value to troubleshoot failed test webhooks..</param>
        /// <param name="responseTime">The time between sending the test webhook and receiving the response from your server. You can use it as an indication of how long your server takes to process a webhook notification. Measured in milliseconds, for example **304 ms**..</param>
        /// <param name="status">The status of the test request. Possible values are: * **success**, if &#x60;data.output&#x60;: **[accepted]** and &#x60;data.responseCode&#x60;: **200**. * **failed**, in all other cases.  You can use the value of the [&#x60;output&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-output) field together with the [&#x60;responseCode&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-responseCode) value to troubleshoot failed test webhooks. (required).</param>
        public TestOutput(string merchantId = default(string), string output = default(string), string requestSent = default(string), string responseCode = default(string), string responseTime = default(string), string status = default(string))
        {
            this.Status = status;
            this.MerchantId = merchantId;
            this.Output = output;
            this.RequestSent = requestSent;
            this.ResponseCode = responseCode;
            this.ResponseTime = responseTime;
        }

        /// <summary>
        /// Unique identifier of the merchant account that the notification is about.
        /// </summary>
        /// <value>Unique identifier of the merchant account that the notification is about.</value>
        [DataMember(Name = "merchantId", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// The response your server returned for the test webhook.  Your server must respond with **[accepted]** for the test webhook to be successful (&#x60;data.status&#x60;: **success**). Find out more about [accepting notifications](https://docs.adyen.com/development-resources/webhooks#accept-notifications)  You can use the value of this field together with the [&#x60;responseCode&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-responseCode) value to troubleshoot unsuccessful test webhooks.
        /// </summary>
        /// <value>The response your server returned for the test webhook.  Your server must respond with **[accepted]** for the test webhook to be successful (&#x60;data.status&#x60;: **success**). Find out more about [accepting notifications](https://docs.adyen.com/development-resources/webhooks#accept-notifications)  You can use the value of this field together with the [&#x60;responseCode&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-responseCode) value to troubleshoot unsuccessful test webhooks.</value>
        [DataMember(Name = "output", EmitDefaultValue = false)]
        public string Output { get; set; }

        /// <summary>
        /// The [body of the notification webhook](https://docs.adyen.com/development-resources/webhooks/understand-notifications#notification-structure) that was sent to your server.
        /// </summary>
        /// <value>The [body of the notification webhook](https://docs.adyen.com/development-resources/webhooks/understand-notifications#notification-structure) that was sent to your server.</value>
        [DataMember(Name = "requestSent", EmitDefaultValue = false)]
        public string RequestSent { get; set; }

        /// <summary>
        /// The HTTP response code for your server&#39;s response to the test webhook.  You can use the value of this field together with the the [&#x60;output&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-output) field value to troubleshoot failed test webhooks.
        /// </summary>
        /// <value>The HTTP response code for your server&#39;s response to the test webhook.  You can use the value of this field together with the the [&#x60;output&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-output) field value to troubleshoot failed test webhooks.</value>
        [DataMember(Name = "responseCode", EmitDefaultValue = false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// The time between sending the test webhook and receiving the response from your server. You can use it as an indication of how long your server takes to process a webhook notification. Measured in milliseconds, for example **304 ms**.
        /// </summary>
        /// <value>The time between sending the test webhook and receiving the response from your server. You can use it as an indication of how long your server takes to process a webhook notification. Measured in milliseconds, for example **304 ms**.</value>
        [DataMember(Name = "responseTime", EmitDefaultValue = false)]
        public string ResponseTime { get; set; }

        /// <summary>
        /// The status of the test request. Possible values are: * **success**, if &#x60;data.output&#x60;: **[accepted]** and &#x60;data.responseCode&#x60;: **200**. * **failed**, in all other cases.  You can use the value of the [&#x60;output&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-output) field together with the [&#x60;responseCode&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-responseCode) value to troubleshoot failed test webhooks.
        /// </summary>
        /// <value>The status of the test request. Possible values are: * **success**, if &#x60;data.output&#x60;: **[accepted]** and &#x60;data.responseCode&#x60;: **200**. * **failed**, in all other cases.  You can use the value of the [&#x60;output&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-output) field together with the [&#x60;responseCode&#x60;](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-responseCode) value to troubleshoot failed test webhooks.</value>
        [DataMember(Name = "status", IsRequired = false, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestOutput {\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  RequestSent: ").Append(RequestSent).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  ResponseTime: ").Append(ResponseTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as TestOutput);
        }

        /// <summary>
        /// Returns true if TestOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of TestOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.RequestSent == input.RequestSent ||
                    (this.RequestSent != null &&
                    this.RequestSent.Equals(input.RequestSent))
                ) && 
                (
                    this.ResponseCode == input.ResponseCode ||
                    (this.ResponseCode != null &&
                    this.ResponseCode.Equals(input.ResponseCode))
                ) && 
                (
                    this.ResponseTime == input.ResponseTime ||
                    (this.ResponseTime != null &&
                    this.ResponseTime.Equals(input.ResponseTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.Output != null)
                {
                    hashCode = (hashCode * 59) + this.Output.GetHashCode();
                }
                if (this.RequestSent != null)
                {
                    hashCode = (hashCode * 59) + this.RequestSent.GetHashCode();
                }
                if (this.ResponseCode != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseCode.GetHashCode();
                }
                if (this.ResponseTime != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseTime.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
/*
* Configuration API
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// TransactionRuleInterval
    /// </summary>
    [DataContract(Name = "TransactionRuleInterval")]
    public partial class TransactionRuleInterval : IEquatable<TransactionRuleInterval>, IValidatableObject
    {
        /// <summary>
        /// The day of week, used when the &#x60;duration.unit&#x60; is **weeks**. If not provided, by default, this is set to **monday**.  Possible values: **sunday**, **monday**, **tuesday**, **wednesday**, **thursday**, **friday**.
        /// </summary>
        /// <value>The day of week, used when the &#x60;duration.unit&#x60; is **weeks**. If not provided, by default, this is set to **monday**.  Possible values: **sunday**, **monday**, **tuesday**, **wednesday**, **thursday**, **friday**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayOfWeekEnum
        {
            /// <summary>
            /// Enum Friday for value: friday
            /// </summary>
            [EnumMember(Value = "friday")]
            Friday = 1,

            /// <summary>
            /// Enum Monday for value: monday
            /// </summary>
            [EnumMember(Value = "monday")]
            Monday = 2,

            /// <summary>
            /// Enum Saturday for value: saturday
            /// </summary>
            [EnumMember(Value = "saturday")]
            Saturday = 3,

            /// <summary>
            /// Enum Sunday for value: sunday
            /// </summary>
            [EnumMember(Value = "sunday")]
            Sunday = 4,

            /// <summary>
            /// Enum Thursday for value: thursday
            /// </summary>
            [EnumMember(Value = "thursday")]
            Thursday = 5,

            /// <summary>
            /// Enum Tuesday for value: tuesday
            /// </summary>
            [EnumMember(Value = "tuesday")]
            Tuesday = 6,

            /// <summary>
            /// Enum Wednesday for value: wednesday
            /// </summary>
            [EnumMember(Value = "wednesday")]
            Wednesday = 7

        }


        /// <summary>
        /// The day of week, used when the &#x60;duration.unit&#x60; is **weeks**. If not provided, by default, this is set to **monday**.  Possible values: **sunday**, **monday**, **tuesday**, **wednesday**, **thursday**, **friday**.
        /// </summary>
        /// <value>The day of week, used when the &#x60;duration.unit&#x60; is **weeks**. If not provided, by default, this is set to **monday**.  Possible values: **sunday**, **monday**, **tuesday**, **wednesday**, **thursday**, **friday**.</value>
        [DataMember(Name = "dayOfWeek", EmitDefaultValue = false)]
        public DayOfWeekEnum? DayOfWeek { get; set; }
        /// <summary>
        /// The [type of interval](https://docs.adyen.com/issuing/transaction-rules#time-intervals) during which the rule conditions and limits apply, and how often counters are reset.  Possible values:   * **perTransaction**: conditions are evaluated and the counters are reset for every transaction.  * **daily**: the counters are reset daily at 00:00:00 CET.  * **weekly**: the counters are reset every Monday at 00:00:00 CET.   * **monthly**: the counters reset every first day of the month at 00:00:00 CET.   * **lifetime**: conditions are applied to the lifetime of the payment instrument.  * **rolling**: conditions are applied and the counters are reset based on a &#x60;duration&#x60;. If the reset date and time are not provided, Adyen applies the default reset time similar to fixed intervals. For example, if the duration is every two weeks, the counter resets every third Monday at 00:00:00 CET.  * **sliding**: conditions are applied and the counters are reset based on the current time and a &#x60;duration&#x60; that you specify.
        /// </summary>
        /// <value>The [type of interval](https://docs.adyen.com/issuing/transaction-rules#time-intervals) during which the rule conditions and limits apply, and how often counters are reset.  Possible values:   * **perTransaction**: conditions are evaluated and the counters are reset for every transaction.  * **daily**: the counters are reset daily at 00:00:00 CET.  * **weekly**: the counters are reset every Monday at 00:00:00 CET.   * **monthly**: the counters reset every first day of the month at 00:00:00 CET.   * **lifetime**: conditions are applied to the lifetime of the payment instrument.  * **rolling**: conditions are applied and the counters are reset based on a &#x60;duration&#x60;. If the reset date and time are not provided, Adyen applies the default reset time similar to fixed intervals. For example, if the duration is every two weeks, the counter resets every third Monday at 00:00:00 CET.  * **sliding**: conditions are applied and the counters are reset based on the current time and a &#x60;duration&#x60; that you specify.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Lifetime for value: lifetime
            /// </summary>
            [EnumMember(Value = "lifetime")]
            Lifetime = 2,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 3,

            /// <summary>
            /// Enum PerTransaction for value: perTransaction
            /// </summary>
            [EnumMember(Value = "perTransaction")]
            PerTransaction = 4,

            /// <summary>
            /// Enum Rolling for value: rolling
            /// </summary>
            [EnumMember(Value = "rolling")]
            Rolling = 5,

            /// <summary>
            /// Enum Sliding for value: sliding
            /// </summary>
            [EnumMember(Value = "sliding")]
            Sliding = 6,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 7

        }


        /// <summary>
        /// The [type of interval](https://docs.adyen.com/issuing/transaction-rules#time-intervals) during which the rule conditions and limits apply, and how often counters are reset.  Possible values:   * **perTransaction**: conditions are evaluated and the counters are reset for every transaction.  * **daily**: the counters are reset daily at 00:00:00 CET.  * **weekly**: the counters are reset every Monday at 00:00:00 CET.   * **monthly**: the counters reset every first day of the month at 00:00:00 CET.   * **lifetime**: conditions are applied to the lifetime of the payment instrument.  * **rolling**: conditions are applied and the counters are reset based on a &#x60;duration&#x60;. If the reset date and time are not provided, Adyen applies the default reset time similar to fixed intervals. For example, if the duration is every two weeks, the counter resets every third Monday at 00:00:00 CET.  * **sliding**: conditions are applied and the counters are reset based on the current time and a &#x60;duration&#x60; that you specify.
        /// </summary>
        /// <value>The [type of interval](https://docs.adyen.com/issuing/transaction-rules#time-intervals) during which the rule conditions and limits apply, and how often counters are reset.  Possible values:   * **perTransaction**: conditions are evaluated and the counters are reset for every transaction.  * **daily**: the counters are reset daily at 00:00:00 CET.  * **weekly**: the counters are reset every Monday at 00:00:00 CET.   * **monthly**: the counters reset every first day of the month at 00:00:00 CET.   * **lifetime**: conditions are applied to the lifetime of the payment instrument.  * **rolling**: conditions are applied and the counters are reset based on a &#x60;duration&#x60;. If the reset date and time are not provided, Adyen applies the default reset time similar to fixed intervals. For example, if the duration is every two weeks, the counter resets every third Monday at 00:00:00 CET.  * **sliding**: conditions are applied and the counters are reset based on the current time and a &#x60;duration&#x60; that you specify.</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRuleInterval" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionRuleInterval() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRuleInterval" /> class.
        /// </summary>
        /// <param name="dayOfMonth">The day of month, used when the &#x60;duration.unit&#x60; is **months**. If not provided, by default, this is set to **1**, the first day of the month..</param>
        /// <param name="dayOfWeek">The day of week, used when the &#x60;duration.unit&#x60; is **weeks**. If not provided, by default, this is set to **monday**.  Possible values: **sunday**, **monday**, **tuesday**, **wednesday**, **thursday**, **friday**..</param>
        /// <param name="duration">duration.</param>
        /// <param name="timeOfDay">The time of day, in **hh:mm:ss** format, used when the &#x60;duration.unit&#x60; is **hours**. If not provided, by default, this is set to **00:00:00**..</param>
        /// <param name="timeZone">The [time zone](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For example, **Europe/Amsterdam**. By default, this is set to **UTC**..</param>
        /// <param name="type">The [type of interval](https://docs.adyen.com/issuing/transaction-rules#time-intervals) during which the rule conditions and limits apply, and how often counters are reset.  Possible values:   * **perTransaction**: conditions are evaluated and the counters are reset for every transaction.  * **daily**: the counters are reset daily at 00:00:00 CET.  * **weekly**: the counters are reset every Monday at 00:00:00 CET.   * **monthly**: the counters reset every first day of the month at 00:00:00 CET.   * **lifetime**: conditions are applied to the lifetime of the payment instrument.  * **rolling**: conditions are applied and the counters are reset based on a &#x60;duration&#x60;. If the reset date and time are not provided, Adyen applies the default reset time similar to fixed intervals. For example, if the duration is every two weeks, the counter resets every third Monday at 00:00:00 CET.  * **sliding**: conditions are applied and the counters are reset based on the current time and a &#x60;duration&#x60; that you specify. (required).</param>
        public TransactionRuleInterval(int? dayOfMonth = default(int?), DayOfWeekEnum? dayOfWeek = default(DayOfWeekEnum?), Duration duration = default(Duration), string timeOfDay = default(string), string timeZone = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Type = type;
            this.DayOfMonth = dayOfMonth;
            this.DayOfWeek = dayOfWeek;
            this.Duration = duration;
            this.TimeOfDay = timeOfDay;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// The day of month, used when the &#x60;duration.unit&#x60; is **months**. If not provided, by default, this is set to **1**, the first day of the month.
        /// </summary>
        /// <value>The day of month, used when the &#x60;duration.unit&#x60; is **months**. If not provided, by default, this is set to **1**, the first day of the month.</value>
        [DataMember(Name = "dayOfMonth", EmitDefaultValue = false)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public Duration Duration { get; set; }

        /// <summary>
        /// The time of day, in **hh:mm:ss** format, used when the &#x60;duration.unit&#x60; is **hours**. If not provided, by default, this is set to **00:00:00**.
        /// </summary>
        /// <value>The time of day, in **hh:mm:ss** format, used when the &#x60;duration.unit&#x60; is **hours**. If not provided, by default, this is set to **00:00:00**.</value>
        [DataMember(Name = "timeOfDay", EmitDefaultValue = false)]
        public string TimeOfDay { get; set; }

        /// <summary>
        /// The [time zone](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For example, **Europe/Amsterdam**. By default, this is set to **UTC**.
        /// </summary>
        /// <value>The [time zone](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For example, **Europe/Amsterdam**. By default, this is set to **UTC**.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionRuleInterval {\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  TimeOfDay: ").Append(TimeOfDay).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(input as TransactionRuleInterval);
        }

        /// <summary>
        /// Returns true if TransactionRuleInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRuleInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRuleInterval input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DayOfMonth == input.DayOfMonth ||
                    this.DayOfMonth.Equals(input.DayOfMonth)
                ) && 
                (
                    this.DayOfWeek == input.DayOfWeek ||
                    this.DayOfWeek.Equals(input.DayOfWeek)
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.TimeOfDay == input.TimeOfDay ||
                    (this.TimeOfDay != null &&
                    this.TimeOfDay.Equals(input.TimeOfDay))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
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
                hashCode = (hashCode * 59) + this.DayOfMonth.GetHashCode();
                hashCode = (hashCode * 59) + this.DayOfWeek.GetHashCode();
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.TimeOfDay != null)
                {
                    hashCode = (hashCode * 59) + this.TimeOfDay.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZone.GetHashCode();
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

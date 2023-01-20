/*
 * Dropbox Sign API
 *
 * Dropbox Sign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Dropbox.Sign.Client.OpenAPIDateConverter;

namespace Dropbox.Sign.Model
{
    /// <summary>
    /// This allows the requester to specify field options for a signature request.
    /// </summary>
    [DataContract(Name = "SubFieldOptions")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SubFieldOptions : IOpenApiTyped, IEquatable<SubFieldOptions>, IValidatableObject
    {
        /// <summary>
        /// Allows requester to specify the date format (see list of allowed [formats](/api/reference/constants/#date-formats))  **Note**: Only available for Premium and higher.
        /// </summary>
        /// <value>Allows requester to specify the date format (see list of allowed [formats](/api/reference/constants/#date-formats))  **Note**: Only available for Premium and higher.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DateFormatEnum
        {
            /// <summary>
            /// Enum MMDDYYYY for value: MM / DD / YYYY
            /// </summary>
            [EnumMember(Value = "MM / DD / YYYY")]
            MMDDYYYY = 1,

            /// <summary>
            /// Enum MM_DD_YYYY for value: MM - DD - YYYY
            /// </summary>
            [EnumMember(Value = "MM - DD - YYYY")]
            MM_DD_YYYY = 2,

            /// <summary>
            /// Enum DDMMYYYY for value: DD / MM / YYYY
            /// </summary>
            [EnumMember(Value = "DD / MM / YYYY")]
            DDMMYYYY = 3,

            /// <summary>
            /// Enum DD_MM_YYYY for value: DD - MM - YYYY
            /// </summary>
            [EnumMember(Value = "DD - MM - YYYY")]
            DD_MM_YYYY = 4,

            /// <summary>
            /// Enum YYYYMMDD for value: YYYY / MM / DD
            /// </summary>
            [EnumMember(Value = "YYYY / MM / DD")]
            YYYYMMDD = 5,

            /// <summary>
            /// Enum YYYY_MM_DD for value: YYYY - MM - DD
            /// </summary>
            [EnumMember(Value = "YYYY - MM - DD")]
            YYYY_MM_DD = 6

        }


        /// <summary>
        /// Allows requester to specify the date format (see list of allowed [formats](/api/reference/constants/#date-formats))  **Note**: Only available for Premium and higher.
        /// </summary>
        /// <value>Allows requester to specify the date format (see list of allowed [formats](/api/reference/constants/#date-formats))  **Note**: Only available for Premium and higher.</value>
        [DataMember(Name = "date_format", IsRequired = true, EmitDefaultValue = true)]
        public DateFormatEnum DateFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubFieldOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubFieldOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubFieldOptions" /> class.
        /// </summary>
        /// <param name="dateFormat">Allows requester to specify the date format (see list of allowed [formats](/api/reference/constants/#date-formats))  **Note**: Only available for Premium and higher. (required).</param>
        public SubFieldOptions(DateFormatEnum dateFormat = default(DateFormatEnum))
        {
            
            this.DateFormat = dateFormat;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static SubFieldOptions Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<SubFieldOptions>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of SubFieldOptions");
            }

            return obj;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubFieldOptions {\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
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
            return this.Equals(input as SubFieldOptions);
        }

        /// <summary>
        /// Returns true if SubFieldOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SubFieldOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubFieldOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DateFormat == input.DateFormat ||
                    this.DateFormat.Equals(input.DateFormat)
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
                hashCode = (hashCode * 59) + this.DateFormat.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "date_format",
                Property = "DateFormat",
                Type = "string",
                Value = DateFormat,
            });

            return types;
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

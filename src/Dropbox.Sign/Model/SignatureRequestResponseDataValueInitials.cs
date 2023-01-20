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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dropbox.Sign.Client.OpenAPIDateConverter;

namespace Dropbox.Sign.Model
{
    /// <summary>
    /// SignatureRequestResponseDataValueInitials
    /// </summary>
    [DataContract(Name = "SignatureRequestResponseDataValueInitials")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueCheckbox), "checkbox")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueCheckboxMerge), "checkbox-merge")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueDateSigned), "date_signed")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueDropdown), "dropdown")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueInitials), "initials")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueRadio), "radio")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueSignature), "signature")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueText), "text")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueTextMerge), "text-merge")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SignatureRequestResponseDataValueInitials : SignatureRequestResponseDataBase, IOpenApiTyped, IEquatable<SignatureRequestResponseDataValueInitials>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseDataValueInitials" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureRequestResponseDataValueInitials() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseDataValueInitials" /> class.
        /// </summary>
        /// <param name="type">An input field for initials (default to &quot;initials&quot;).</param>
        /// <param name="value">The value of the form field..</param>
        /// <param name="apiId">The unique ID for this field..</param>
        /// <param name="signatureId">The ID of the signature to which this response is linked..</param>
        /// <param name="name">The name of the form field..</param>
        /// <param name="required">A boolean value denoting if this field is required..</param>
        public SignatureRequestResponseDataValueInitials(string type = "initials", string value = default(string), string apiId = default(string), string signatureId = default(string), string name = default(string), bool required = default(bool))
        {
            this.ApiId = apiId;
            this.SignatureId = signatureId;
            this.Name = name;
            this.Required = required;
            
            // use default value if no "type" provided
            this.Type = type ?? "initials";
            this.Value = value;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static SignatureRequestResponseDataValueInitials Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<SignatureRequestResponseDataValueInitials>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of SignatureRequestResponseDataValueInitials");
            }

            return obj;
        }

        /// <summary>
        /// An input field for initials
        /// </summary>
        /// <value>An input field for initials</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The value of the form field.
        /// </summary>
        /// <value>The value of the form field.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureRequestResponseDataValueInitials {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as SignatureRequestResponseDataValueInitials);
        }

        /// <summary>
        /// Returns true if SignatureRequestResponseDataValueInitials instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureRequestResponseDataValueInitials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureRequestResponseDataValueInitials input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "type",
                Property = "Type",
                Type = "string",
                Value = Type,
            });
            types.Add(new OpenApiType(){
                Name = "value",
                Property = "Value",
                Type = "string",
                Value = Value,
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}

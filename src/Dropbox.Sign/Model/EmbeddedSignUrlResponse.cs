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
    /// EmbeddedSignUrlResponse
    /// </summary>
    [DataContract(Name = "EmbeddedSignUrlResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class EmbeddedSignUrlResponse : IOpenApiTyped, IEquatable<EmbeddedSignUrlResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedSignUrlResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedSignUrlResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedSignUrlResponse" /> class.
        /// </summary>
        /// <param name="embedded">embedded.</param>
        /// <param name="warnings">A list of warnings..</param>
        public EmbeddedSignUrlResponse(EmbeddedSignUrlResponseEmbedded embedded = default(EmbeddedSignUrlResponseEmbedded), List<WarningResponse> warnings = default(List<WarningResponse>))
        {
            
            this.Embedded = embedded;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static EmbeddedSignUrlResponse Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<EmbeddedSignUrlResponse>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of EmbeddedSignUrlResponse");
            }

            return obj;
        }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name = "embedded", EmitDefaultValue = true)]
        public EmbeddedSignUrlResponseEmbedded Embedded { get; set; }

        /// <summary>
        /// A list of warnings.
        /// </summary>
        /// <value>A list of warnings.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = true)]
        public List<WarningResponse> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmbeddedSignUrlResponse {\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as EmbeddedSignUrlResponse);
        }

        /// <summary>
        /// Returns true if EmbeddedSignUrlResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedSignUrlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedSignUrlResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Embedded == input.Embedded ||
                    (this.Embedded != null &&
                    this.Embedded.Equals(input.Embedded))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Embedded != null)
                {
                    hashCode = (hashCode * 59) + this.Embedded.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "embedded",
                Property = "Embedded",
                Type = "EmbeddedSignUrlResponseEmbedded",
                Value = Embedded,
            });
            types.Add(new OpenApiType(){
                Name = "warnings",
                Property = "Warnings",
                Type = "List<WarningResponse>",
                Value = Warnings,
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

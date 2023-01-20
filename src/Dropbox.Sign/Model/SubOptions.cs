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
    /// Additional options supported by API App.
    /// </summary>
    [DataContract(Name = "SubOptions")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SubOptions : IOpenApiTyped, IEquatable<SubOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubOptions" /> class.
        /// </summary>
        /// <param name="canInsertEverywhere">Determines if signers can use \&quot;Insert Everywhere\&quot; when signing a document. (default to false).</param>
        public SubOptions(bool canInsertEverywhere = false)
        {
            
            this.CanInsertEverywhere = canInsertEverywhere;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static SubOptions Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<SubOptions>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of SubOptions");
            }

            return obj;
        }

        /// <summary>
        /// Determines if signers can use \&quot;Insert Everywhere\&quot; when signing a document.
        /// </summary>
        /// <value>Determines if signers can use \&quot;Insert Everywhere\&quot; when signing a document.</value>
        [DataMember(Name = "can_insert_everywhere", EmitDefaultValue = true)]
        public bool CanInsertEverywhere { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubOptions {\n");
            sb.Append("  CanInsertEverywhere: ").Append(CanInsertEverywhere).Append("\n");
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
            return this.Equals(input as SubOptions);
        }

        /// <summary>
        /// Returns true if SubOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SubOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CanInsertEverywhere == input.CanInsertEverywhere ||
                    this.CanInsertEverywhere.Equals(input.CanInsertEverywhere)
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
                hashCode = (hashCode * 59) + this.CanInsertEverywhere.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "can_insert_everywhere",
                Property = "CanInsertEverywhere",
                Type = "bool",
                Value = CanInsertEverywhere,
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

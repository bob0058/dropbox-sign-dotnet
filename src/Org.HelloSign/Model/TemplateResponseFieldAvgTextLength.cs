/*
 * HelloSign API
 *
 * HelloSign v3 API
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
using OpenAPIDateConverter = Org.HelloSign.Client.OpenAPIDateConverter;

namespace Org.HelloSign.Model
{
    /// <summary>
    /// Average text length in this field.
    /// </summary>
    [DataContract(Name = "TemplateResponseFieldAvgTextLength")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateResponseFieldAvgTextLength : IOpenApiTyped, IEquatable<TemplateResponseFieldAvgTextLength>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseFieldAvgTextLength" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateResponseFieldAvgTextLength() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseFieldAvgTextLength" /> class.
        /// </summary>
        /// <param name="numLines">Number of lines..</param>
        /// <param name="numCharsPerLine">Number of character per line..</param>
        public TemplateResponseFieldAvgTextLength(int numLines = default(int), int numCharsPerLine = default(int))
        {
            
            this.NumLines = numLines;
            this.NumCharsPerLine = numCharsPerLine;
        }

        /// <summary>
        /// Number of lines.
        /// </summary>
        /// <value>Number of lines.</value>
        [DataMember(Name = "num_lines", EmitDefaultValue = true)]
        public int NumLines { get; set; }

        /// <summary>
        /// Number of character per line.
        /// </summary>
        /// <value>Number of character per line.</value>
        [DataMember(Name = "num_chars_per_line", EmitDefaultValue = true)]
        public int NumCharsPerLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateResponseFieldAvgTextLength {\n");
            sb.Append("  NumLines: ").Append(NumLines).Append("\n");
            sb.Append("  NumCharsPerLine: ").Append(NumCharsPerLine).Append("\n");
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
            return this.Equals(input as TemplateResponseFieldAvgTextLength);
        }

        /// <summary>
        /// Returns true if TemplateResponseFieldAvgTextLength instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateResponseFieldAvgTextLength to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateResponseFieldAvgTextLength input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NumLines == input.NumLines ||
                    this.NumLines.Equals(input.NumLines)
                ) && 
                (
                    this.NumCharsPerLine == input.NumCharsPerLine ||
                    this.NumCharsPerLine.Equals(input.NumCharsPerLine)
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
                hashCode = (hashCode * 59) + this.NumLines.GetHashCode();
                hashCode = (hashCode * 59) + this.NumCharsPerLine.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "num_lines",
                Property = "NumLines",
                Type = "int",
                Value = NumLines,
            });
            types.Add(new OpenApiType(){
                Name = "num_chars_per_line",
                Property = "NumCharsPerLine",
                Type = "int",
                Value = NumCharsPerLine,
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

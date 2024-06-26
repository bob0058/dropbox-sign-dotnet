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
    /// TemplateResponseDocument
    /// </summary>
    [DataContract(Name = "TemplateResponseDocument")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateResponseDocument : IOpenApiTyped, IEquatable<TemplateResponseDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateResponseDocument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseDocument" /> class.
        /// </summary>
        /// <param name="name">Name of the associated file..</param>
        /// <param name="index">Document ordering, the lowest index is displayed first and the highest last (0-based indexing)..</param>
        /// <param name="fieldGroups">An array of Form Field Group objects..</param>
        /// <param name="formFields">An array of Form Field objects containing the name and type of each named field..</param>
        /// <param name="customFields">An array of Form Field objects containing the name and type of each named field..</param>
        /// <param name="staticFields">An array describing static overlay fields. **NOTE:** Only available for certain subscriptions..</param>
        public TemplateResponseDocument(string name = default(string), int index = default(int), List<TemplateResponseDocumentFieldGroup> fieldGroups = default(List<TemplateResponseDocumentFieldGroup>), List<TemplateResponseDocumentFormFieldBase> formFields = default(List<TemplateResponseDocumentFormFieldBase>), List<TemplateResponseDocumentCustomFieldBase> customFields = default(List<TemplateResponseDocumentCustomFieldBase>), List<TemplateResponseDocumentStaticFieldBase> staticFields = default(List<TemplateResponseDocumentStaticFieldBase>))
        {
            
            this.Name = name;
            this.Index = index;
            this.FieldGroups = fieldGroups;
            this.FormFields = formFields;
            this.CustomFields = customFields;
            this.StaticFields = staticFields;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static TemplateResponseDocument Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<TemplateResponseDocument>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of TemplateResponseDocument");
            }

            return obj;
        }

        /// <summary>
        /// Name of the associated file.
        /// </summary>
        /// <value>Name of the associated file.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Document ordering, the lowest index is displayed first and the highest last (0-based indexing).
        /// </summary>
        /// <value>Document ordering, the lowest index is displayed first and the highest last (0-based indexing).</value>
        [DataMember(Name = "index", EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// An array of Form Field Group objects.
        /// </summary>
        /// <value>An array of Form Field Group objects.</value>
        [DataMember(Name = "field_groups", EmitDefaultValue = true)]
        public List<TemplateResponseDocumentFieldGroup> FieldGroups { get; set; }

        /// <summary>
        /// An array of Form Field objects containing the name and type of each named field.
        /// </summary>
        /// <value>An array of Form Field objects containing the name and type of each named field.</value>
        [DataMember(Name = "form_fields", EmitDefaultValue = true)]
        public List<TemplateResponseDocumentFormFieldBase> FormFields { get; set; }

        /// <summary>
        /// An array of Form Field objects containing the name and type of each named field.
        /// </summary>
        /// <value>An array of Form Field objects containing the name and type of each named field.</value>
        [DataMember(Name = "custom_fields", EmitDefaultValue = true)]
        public List<TemplateResponseDocumentCustomFieldBase> CustomFields { get; set; }

        /// <summary>
        /// An array describing static overlay fields. **NOTE:** Only available for certain subscriptions.
        /// </summary>
        /// <value>An array describing static overlay fields. **NOTE:** Only available for certain subscriptions.</value>
        [DataMember(Name = "static_fields", EmitDefaultValue = true)]
        public List<TemplateResponseDocumentStaticFieldBase> StaticFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateResponseDocument {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  FieldGroups: ").Append(FieldGroups).Append("\n");
            sb.Append("  FormFields: ").Append(FormFields).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  StaticFields: ").Append(StaticFields).Append("\n");
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
            return this.Equals(input as TemplateResponseDocument);
        }

        /// <summary>
        /// Returns true if TemplateResponseDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateResponseDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateResponseDocument input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.FieldGroups == input.FieldGroups ||
                    this.FieldGroups != null &&
                    input.FieldGroups != null &&
                    this.FieldGroups.SequenceEqual(input.FieldGroups)
                ) && 
                (
                    this.FormFields == input.FormFields ||
                    this.FormFields != null &&
                    input.FormFields != null &&
                    this.FormFields.SequenceEqual(input.FormFields)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.StaticFields == input.StaticFields ||
                    this.StaticFields != null &&
                    input.StaticFields != null &&
                    this.StaticFields.SequenceEqual(input.StaticFields)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.FieldGroups != null)
                {
                    hashCode = (hashCode * 59) + this.FieldGroups.GetHashCode();
                }
                if (this.FormFields != null)
                {
                    hashCode = (hashCode * 59) + this.FormFields.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.StaticFields != null)
                {
                    hashCode = (hashCode * 59) + this.StaticFields.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "name",
                Property = "Name",
                Type = "string",
                Value = Name,
            });
            types.Add(new OpenApiType(){
                Name = "index",
                Property = "Index",
                Type = "int",
                Value = Index,
            });
            types.Add(new OpenApiType(){
                Name = "field_groups",
                Property = "FieldGroups",
                Type = "List<TemplateResponseDocumentFieldGroup>",
                Value = FieldGroups,
            });
            types.Add(new OpenApiType(){
                Name = "form_fields",
                Property = "FormFields",
                Type = "List<TemplateResponseDocumentFormFieldBase>",
                Value = FormFields,
            });
            types.Add(new OpenApiType(){
                Name = "custom_fields",
                Property = "CustomFields",
                Type = "List<TemplateResponseDocumentCustomFieldBase>",
                Value = CustomFields,
            });
            types.Add(new OpenApiType(){
                Name = "static_fields",
                Property = "StaticFields",
                Type = "List<TemplateResponseDocumentStaticFieldBase>",
                Value = StaticFields,
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

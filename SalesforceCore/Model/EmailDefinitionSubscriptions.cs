/* 
 * Marketing Cloud REST API
 *
 * Marketing Cloud's REST API is our newest API. It supports multi-channel use cases, is much more lightweight and easy to use than our SOAP API, and is getting more comprehensive with every release.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: mc_sdk@salesforce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = SalesforceCore.Client.SwaggerDateConverter;

namespace SalesforceCore.Model
{
    /// <summary>
    /// EmailDefinitionSubscriptions
    /// </summary>
    [DataContract]
    public partial class EmailDefinitionSubscriptions :  IEquatable<EmailDefinitionSubscriptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDefinitionSubscriptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailDefinitionSubscriptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDefinitionSubscriptions" /> class.
        /// </summary>
        /// <param name="list">Marketing Cloud external key of the list or all subscribers. Contains the subscriber keys and profile attributes. (required).</param>
        /// <param name="dataExtension">Marketing Cloud external key of the triggered send data extension. Each request inserts as a new row in the data extension..</param>
        /// <param name="autoAddSubscriber">Adds the recipient’s email address and contact key as a subscriber key to subscriptions.list. Default is true. (default to true).</param>
        /// <param name="updateSubscriber">Updates the recipient’s contact key as a subscriber key with the provided email address and profile attributes to subscriptions.list. Default is true..</param>
        public EmailDefinitionSubscriptions(string list = default(string), string dataExtension = default(string), bool? autoAddSubscriber = true, bool? updateSubscriber = default(bool?))
        {
            // to ensure "list" is required (not null)
            if (list == null)
            {
                throw new InvalidDataException("list is a required property for EmailDefinitionSubscriptions and cannot be null");
            }
            else
            {
                this.List = list;
            }
            this.DataExtension = dataExtension;
            // use default value if no "autoAddSubscriber" provided
            if (autoAddSubscriber == null)
            {
                this.AutoAddSubscriber = true;
            }
            else
            {
                this.AutoAddSubscriber = autoAddSubscriber;
            }
            this.UpdateSubscriber = updateSubscriber;
        }
        
        /// <summary>
        /// Marketing Cloud external key of the list or all subscribers. Contains the subscriber keys and profile attributes.
        /// </summary>
        /// <value>Marketing Cloud external key of the list or all subscribers. Contains the subscriber keys and profile attributes.</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public string List { get; set; }

        /// <summary>
        /// Marketing Cloud external key of the triggered send data extension. Each request inserts as a new row in the data extension.
        /// </summary>
        /// <value>Marketing Cloud external key of the triggered send data extension. Each request inserts as a new row in the data extension.</value>
        [DataMember(Name="dataExtension", EmitDefaultValue=false)]
        public string DataExtension { get; set; }

        /// <summary>
        /// Adds the recipient’s email address and contact key as a subscriber key to subscriptions.list. Default is true.
        /// </summary>
        /// <value>Adds the recipient’s email address and contact key as a subscriber key to subscriptions.list. Default is true.</value>
        [DataMember(Name="autoAddSubscriber", EmitDefaultValue=false)]
        public bool? AutoAddSubscriber { get; set; }

        /// <summary>
        /// Updates the recipient’s contact key as a subscriber key with the provided email address and profile attributes to subscriptions.list. Default is true.
        /// </summary>
        /// <value>Updates the recipient’s contact key as a subscriber key with the provided email address and profile attributes to subscriptions.list. Default is true.</value>
        [DataMember(Name="updateSubscriber", EmitDefaultValue=false)]
        public bool? UpdateSubscriber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailDefinitionSubscriptions {\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  DataExtension: ").Append(DataExtension).Append("\n");
            sb.Append("  AutoAddSubscriber: ").Append(AutoAddSubscriber).Append("\n");
            sb.Append("  UpdateSubscriber: ").Append(UpdateSubscriber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmailDefinitionSubscriptions);
        }

        /// <summary>
        /// Returns true if EmailDefinitionSubscriptions instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailDefinitionSubscriptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailDefinitionSubscriptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.List == input.List ||
                    (this.List != null &&
                    this.List.Equals(input.List))
                ) && 
                (
                    this.DataExtension == input.DataExtension ||
                    (this.DataExtension != null &&
                    this.DataExtension.Equals(input.DataExtension))
                ) && 
                (
                    this.AutoAddSubscriber == input.AutoAddSubscriber ||
                    (this.AutoAddSubscriber != null &&
                    this.AutoAddSubscriber.Equals(input.AutoAddSubscriber))
                ) && 
                (
                    this.UpdateSubscriber == input.UpdateSubscriber ||
                    (this.UpdateSubscriber != null &&
                    this.UpdateSubscriber.Equals(input.UpdateSubscriber))
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
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
                if (this.DataExtension != null)
                    hashCode = hashCode * 59 + this.DataExtension.GetHashCode();
                if (this.AutoAddSubscriber != null)
                    hashCode = hashCode * 59 + this.AutoAddSubscriber.GetHashCode();
                if (this.UpdateSubscriber != null)
                    hashCode = hashCode * 59 + this.UpdateSubscriber.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

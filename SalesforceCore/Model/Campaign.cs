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
    /// Campaign
    /// </summary>
    [DataContract]
    public partial class Campaign :  IEquatable<Campaign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Campaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        /// <param name="name">Name of the campaign with a maximum length of 128 characters (required).</param>
        /// <param name="description">Description of the campaign with a maximum length of 512 characters (required).</param>
        /// <param name="campaignCode">Unique identifier for the campaign with a maximum length of 36 characters (required).</param>
        /// <param name="color">Hex color value (required).</param>
        /// <param name="favorite">Determines if the campaign will be flagged as a favorite (required).</param>
        public Campaign(string name = default(string), string description = default(string), string campaignCode = default(string), string color = default(string), bool? favorite = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Campaign and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for Campaign and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "campaignCode" is required (not null)
            if (campaignCode == null)
            {
                throw new InvalidDataException("campaignCode is a required property for Campaign and cannot be null");
            }
            else
            {
                this.CampaignCode = campaignCode;
            }
            // to ensure "color" is required (not null)
            if (color == null)
            {
                throw new InvalidDataException("color is a required property for Campaign and cannot be null");
            }
            else
            {
                this.Color = color;
            }
            // to ensure "favorite" is required (not null)
            if (favorite == null)
            {
                throw new InvalidDataException("favorite is a required property for Campaign and cannot be null");
            }
            else
            {
                this.Favorite = favorite;
            }
        }
        
        /// <summary>
        /// Name of the campaign with a maximum length of 128 characters
        /// </summary>
        /// <value>Name of the campaign with a maximum length of 128 characters</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the campaign with a maximum length of 512 characters
        /// </summary>
        /// <value>Description of the campaign with a maximum length of 512 characters</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Unique identifier for the campaign with a maximum length of 36 characters
        /// </summary>
        /// <value>Unique identifier for the campaign with a maximum length of 36 characters</value>
        [DataMember(Name="campaignCode", EmitDefaultValue=false)]
        public string CampaignCode { get; set; }

        /// <summary>
        /// Hex color value
        /// </summary>
        /// <value>Hex color value</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Determines if the campaign will be flagged as a favorite
        /// </summary>
        /// <value>Determines if the campaign will be flagged as a favorite</value>
        [DataMember(Name="favorite", EmitDefaultValue=false)]
        public bool? Favorite { get; set; }

        /// <summary>
        /// The id of the campaign
        /// </summary>
        /// <value>The id of the campaign</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The date the object was created.
        /// </summary>
        /// <value>The date the object was created.</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// The date the object was modified.
        /// </summary>
        /// <value>The date the object was modified.</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Campaign {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CampaignCode: ").Append(CampaignCode).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Favorite: ").Append(Favorite).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(input as Campaign);
        }

        /// <summary>
        /// Returns true if Campaign instances are equal
        /// </summary>
        /// <param name="input">Instance of Campaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Campaign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CampaignCode == input.CampaignCode ||
                    (this.CampaignCode != null &&
                    this.CampaignCode.Equals(input.CampaignCode))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Favorite == input.Favorite ||
                    (this.Favorite != null &&
                    this.Favorite.Equals(input.Favorite))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
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
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CampaignCode != null)
                    hashCode = hashCode * 59 + this.CampaignCode.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Favorite != null)
                    hashCode = hashCode * 59 + this.Favorite.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 512.", new [] { "Description" });
            }

            // CampaignCode (string) maxLength
            if(this.CampaignCode != null && this.CampaignCode.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CampaignCode, length must be less than 36.", new [] { "CampaignCode" });
            }

            yield break;
        }
    }

}

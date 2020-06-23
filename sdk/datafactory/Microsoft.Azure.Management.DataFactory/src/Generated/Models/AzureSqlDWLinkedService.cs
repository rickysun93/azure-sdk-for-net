// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure SQL Data Warehouse linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureSqlDW")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureSqlDWLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AzureSqlDWLinkedService class.
        /// </summary>
        public AzureSqlDWLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSqlDWLinkedService class.
        /// </summary>
        /// <param name="connectionString">The connection string. Type: string,
        /// SecureString or AzureKeyVaultSecretReference. Type: string,
        /// SecureString or AzureKeyVaultSecretReference.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="password">The Azure key vault secret reference of
        /// password in connection string.</param>
        /// <param name="servicePrincipalId">The ID of the service principal
        /// used to authenticate against Azure SQL Data Warehouse. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="servicePrincipalKey">The key of the service principal
        /// used to authenticate against Azure SQL Data Warehouse.</param>
        /// <param name="tenant">The name or ID of the tenant to which the
        /// service principal belongs. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="azureCloudType">Indicates the azure cloud type of the
        /// service principle auth. Allowed values are AzurePublic, AzureChina,
        /// AzureUsGovernment, AzureGermany. Default value is the data factory
        /// regions’s cloud type. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AzureSqlDWLinkedService(object connectionString, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), AzureKeyVaultSecretReference password = default(AzureKeyVaultSecretReference), object servicePrincipalId = default(object), SecretBase servicePrincipalKey = default(SecretBase), object tenant = default(object), object azureCloudType = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            ConnectionString = connectionString;
            Password = password;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string. Type: string, SecureString or
        /// AzureKeyVaultSecretReference. Type: string, SecureString or
        /// AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of password in
        /// connection string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public AzureKeyVaultSecretReference Password { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against Azure SQL Data Warehouse. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against Azure SQL Data Warehouse.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets indicates the azure cloud type of the service
        /// principle auth. Allowed values are AzurePublic, AzureChina,
        /// AzureUsGovernment, AzureGermany. Default value is the data factory
        /// regions’s cloud type. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.azureCloudType")]
        public object AzureCloudType { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
            if (Password != null)
            {
                Password.Validate();
            }
        }
    }
}

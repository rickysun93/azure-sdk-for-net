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
    /// Rest Service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("RestService")]
    [Rest.Serialization.JsonTransformation]
    public partial class RestServiceLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the RestServiceLinkedService class.
        /// </summary>
        public RestServiceLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestServiceLinkedService class.
        /// </summary>
        /// <param name="url">The base URL of the REST service.</param>
        /// <param name="authenticationType">Type of authentication used to
        /// connect to the REST service. Possible values include: 'Anonymous',
        /// 'Basic', 'AadServicePrincipal', 'ManagedServiceIdentity'</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="enableServerCertificateValidation">Whether to validate
        /// server side SSL certificate when connecting to the endpoint.The
        /// default value is true. Type: boolean (or Expression with resultType
        /// boolean).</param>
        /// <param name="userName">The user name used in Basic authentication
        /// type.</param>
        /// <param name="password">The password used in Basic authentication
        /// type.</param>
        /// <param name="servicePrincipalId">The application's client ID used
        /// in AadServicePrincipal authentication type.</param>
        /// <param name="servicePrincipalKey">The application's key used in
        /// AadServicePrincipal authentication type.</param>
        /// <param name="tenant">The tenant information (domain name or tenant
        /// ID) used in AadServicePrincipal authentication type under which
        /// your application resides.</param>
        /// <param name="azureCloudType">Indicates the azure cloud type of the
        /// service principle auth. Allowed values are AzurePublic, AzureChina,
        /// AzureUsGovernment, AzureGermany. Default value is the data factory
        /// regions’s cloud type. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="aadResourceId">The resource you are requesting
        /// authorization to use.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public RestServiceLinkedService(object url, string authenticationType, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object enableServerCertificateValidation = default(object), object userName = default(object), SecretBase password = default(SecretBase), object servicePrincipalId = default(object), SecretBase servicePrincipalKey = default(SecretBase), object tenant = default(object), object azureCloudType = default(object), object aadResourceId = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            Url = url;
            EnableServerCertificateValidation = enableServerCertificateValidation;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            AadResourceId = aadResourceId;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the base URL of the REST service.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets whether to validate server side SSL certificate when
        /// connecting to the endpoint.The default value is true. Type: boolean
        /// (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableServerCertificateValidation")]
        public object EnableServerCertificateValidation { get; set; }

        /// <summary>
        /// Gets or sets type of authentication used to connect to the REST
        /// service. Possible values include: 'Anonymous', 'Basic',
        /// 'AadServicePrincipal', 'ManagedServiceIdentity'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the user name used in Basic authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets the password used in Basic authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the application's client ID used in
        /// AadServicePrincipal authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the application's key used in AadServicePrincipal
        /// authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the tenant information (domain name or tenant ID) used
        /// in AadServicePrincipal authentication type under which your
        /// application resides.
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
        /// Gets or sets the resource you are requesting authorization to use.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.aadResourceId")]
        public object AadResourceId { get; set; }

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
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (AuthenticationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AuthenticationType");
            }
        }
    }
}

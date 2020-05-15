// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM. </summary>
    public partial class VaultCertificate
    {
        /// <summary> Initializes a new instance of VaultCertificate. </summary>
        public VaultCertificate()
        {
        }

        /// <summary> Initializes a new instance of VaultCertificate. </summary>
        /// <param name="certificateUrl"> This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt;  &quot;data&quot;:&quot;&lt;Base64-encoded-certificate&gt;&quot;,&lt;br&gt;  &quot;dataType&quot;:&quot;pfx&quot;,&lt;br&gt;  &quot;password&quot;:&quot;&lt;pfx-file-password&gt;&quot;&lt;br&gt;}. </param>
        /// <param name="certificateStore"> For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate should be added. The specified certificate store is implicitly in the LocalMachine account. &lt;br&gt;&lt;br&gt;For Linux VMs, the certificate file is placed under the /var/lib/waagent directory, with the file name &amp;lt;UppercaseThumbprint&amp;gt;.crt for the X509 certificate file and &amp;lt;UppercaseThumbprint&amp;gt;.prv for private key. Both of these files are .pem formatted. </param>
        internal VaultCertificate(string certificateUrl, string certificateStore)
        {
            CertificateUrl = certificateUrl;
            CertificateStore = certificateStore;
        }

        /// <summary> This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt;  &quot;data&quot;:&quot;&lt;Base64-encoded-certificate&gt;&quot;,&lt;br&gt;  &quot;dataType&quot;:&quot;pfx&quot;,&lt;br&gt;  &quot;password&quot;:&quot;&lt;pfx-file-password&gt;&quot;&lt;br&gt;}. </summary>
        public string CertificateUrl { get; set; }
        /// <summary> For Windows VMs, specifies the certificate store on the Virtual Machine to which the certificate should be added. The specified certificate store is implicitly in the LocalMachine account. &lt;br&gt;&lt;br&gt;For Linux VMs, the certificate file is placed under the /var/lib/waagent directory, with the file name &amp;lt;UppercaseThumbprint&amp;gt;.crt for the X509 certificate file and &amp;lt;UppercaseThumbprint&amp;gt;.prv for private key. Both of these files are .pem formatted. </summary>
        public string CertificateStore { get; set; }
    }
}

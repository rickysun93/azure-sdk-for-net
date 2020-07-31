// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    public partial class KeyVaultServiceError
    {
        internal static KeyVaultServiceError DeserializeKeyVaultServiceError(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<KeyVaultServiceError> innererror = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innererror"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        innererror = null;
                        continue;
                    }
                    innererror = DeserializeKeyVaultServiceError(property.Value);
                    continue;
                }
            }
            return new KeyVaultServiceError(code.Value, message.Value, innererror.Value);
        }
    }
}

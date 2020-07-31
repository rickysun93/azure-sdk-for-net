// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.FormRecognizer.Training;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class Model
    {
        internal static Model DeserializeModel(JsonElement element)
        {
            CustomFormModelInfo modelInfo = default;
            Optional<KeysResult> keys = default;
            Optional<TrainResult> trainResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelInfo"))
                {
                    modelInfo = CustomFormModelInfo.DeserializeCustomFormModelInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("keys"))
                {
                    keys = KeysResult.DeserializeKeysResult(property.Value);
                    continue;
                }
                if (property.NameEquals("trainResult"))
                {
                    trainResult = TrainResult.DeserializeTrainResult(property.Value);
                    continue;
                }
            }
            return new Model(modelInfo, keys.Value, trainResult.Value);
        }
    }
}

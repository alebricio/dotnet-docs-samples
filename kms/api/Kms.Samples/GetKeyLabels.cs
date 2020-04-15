/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// [START kms_get_key_labels]
using Google.Cloud.Kms.V1;
using System;

public class GetKeyLabelsSample
{
    public CryptoKey GetKeyLabels(string projectId = "my-project", string locationId = "us-east1", string keyRingId = "my-key-ring", string keyId = "my-key")
    {
        // Create the client.
        KeyManagementServiceClient client = KeyManagementServiceClient.Create();

        // Build the request.
        GetCryptoKeyRequest request = new GetCryptoKeyRequest
        {
            CryptoKeyName = new CryptoKeyName(projectId, locationId, keyRingId, keyId),
        };

        // Call the API.
        CryptoKey result = client.GetCryptoKey(request);

        // Extract and print labels.
        foreach (var item in result.Labels)
        {
            Console.WriteLine($"{item.Key}={item.Value}");
        }

        // Return the ciphertext.
        return result;
    }
}
// [END kms_get_key_labels]
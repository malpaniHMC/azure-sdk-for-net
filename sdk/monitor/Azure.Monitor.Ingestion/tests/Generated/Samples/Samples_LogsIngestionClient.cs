// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Monitor.Ingestion.Samples
{
    public class Samples_LogsIngestionClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Upload()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new LogsIngestionClient(endpoint, credential);

            var data = new[] {
    new {}
};

            Response response = client.Upload("<ruleId>", "<streamName>", RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Upload_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new LogsIngestionClient(endpoint, credential);

            var data = new[] {
    new {}
};

            Response response = client.Upload("<ruleId>", "<streamName>", RequestContent.Create(data), "<contentEncoding>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Upload_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new LogsIngestionClient(endpoint, credential);

            var data = new[] {
    new {}
};

            Response response = await client.UploadAsync("<ruleId>", "<streamName>", RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Upload_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new LogsIngestionClient(endpoint, credential);

            var data = new[] {
    new {}
};

            Response response = await client.UploadAsync("<ruleId>", "<streamName>", RequestContent.Create(data), "<contentEncoding>");
            Console.WriteLine(response.Status);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace Locate_People_Package.APIClients
{
    public class EmailSearchClient
    {
        private const string apiName = "EmailSearch";
        private readonly MBBaseClient client;

        public EmailSearchClient(string authorization, Uri baseURL)
        {
            client = new MBBaseClient(authorization, baseURL);
        }

        public EmailSearchClient(MBBaseClient mbClient)
        {
            this.client = mbClient;
        }

        public JsonObject Post(string JSONRequestModel)
        {
            var url = new Uri(client.BaseAddress + apiName);
            var content = new StringContent(JSONRequestModel, Encoding.UTF8, "application/json");
            var response = client.PostAsync(url, content).Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
            return result;
        }
    }
}
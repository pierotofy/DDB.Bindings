﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DDB.Bindings.Model
{
    public class Meta
    {
        public string Id { get; set; }
        public JObject Data { get; set; }

        [JsonProperty("mtime")]
        [JsonConverter(typeof(SecondEpochConverter))]
        public DateTime ModifiedTime { get; set; }
    }
}
﻿using Newtonsoft.Json;

namespace ElectroneumSpace.Models
{

    public partial class Network
    {
        [JsonProperty("difficulty")]
        public double Difficulty { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("reward")]
        public double Reward { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

}

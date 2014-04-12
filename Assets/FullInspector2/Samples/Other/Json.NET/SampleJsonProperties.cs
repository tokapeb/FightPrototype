using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Properties")]
    public class SampleJsonProperties : BaseBehavior<JsonNetSerializer> {
        [JsonObject(MemberSerialization.OptIn)]
        public struct Container {
            [JsonProperty]
            public int SubValue { get; set; }
        }

        public int Value { get; set; }
        public Container ContainedValue { get; set; }
    }
}
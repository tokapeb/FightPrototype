using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Simple Types")]
    public class SampleJsonSimpleTypes : BaseBehavior<JsonNetSerializer> {
        [JsonObject(MemberSerialization.OptIn)]
        public struct StructContainer {
            [JsonProperty]
            public int IntValue;
            [JsonProperty]
            public float FloatValue;
            [JsonProperty]
            public string StringValue;
            [JsonProperty]
            public bool BoolValue;
        }

        public int IntValue;
        public float FloatValue;
        public string StringValue;
        public bool BoolValue;
        public StructContainer StructValue;
    }
}
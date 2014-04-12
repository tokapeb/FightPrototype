using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Structs")]
    public class SampleJsonStruct : BaseBehavior<JsonNetSerializer> {
        [JsonObject(MemberSerialization.OptIn)]
        public struct MyStruct {
            [JsonProperty]
            public int A;
            [JsonProperty]
            public float B;
            [JsonProperty]
            public string C;
        }

        public MyStruct StructValue;
    }
}
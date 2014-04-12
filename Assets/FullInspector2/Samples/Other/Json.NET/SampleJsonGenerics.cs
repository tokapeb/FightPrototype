using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [JsonObject(MemberSerialization.OptIn)]
    public class GenericHolder<T1> {
        [JsonProperty]
        public T1 Value;
    }

    [JsonObject(MemberSerialization.OptIn)]
    public struct GenericHolder<T1, T2> {
        [JsonProperty]
        public T1 Value1;

        [JsonProperty]
        public T2 Value2;
    }

    [AddComponentMenu("Full Inspector Samples/Json.NET/Generics")]
    public class SampleJsonGenerics : BaseBehavior<JsonNetSerializer> {
        public GenericHolder<int> GenericInt;
        public GenericHolder<int, string> GenericIntString;
        public GenericHolder<GenericHolder<int>> GenericGenericInt;
    }
}
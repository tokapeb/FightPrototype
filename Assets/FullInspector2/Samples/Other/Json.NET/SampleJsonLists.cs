using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Lists")]
    public class SampleJsonLists : BaseBehavior<JsonNetSerializer> {
        [JsonObject(MemberSerialization.OptIn)]
        public struct Container {
            [JsonProperty]
            public List<Transform> SubTransformList;

            [JsonObject(MemberSerialization.OptIn)]
            public interface IFace { }
            [JsonObject(MemberSerialization.OptIn)]
            public class DerivedA : IFace { [JsonProperty] public int A; }
            [JsonObject(MemberSerialization.OptIn)]
            public class DerivedB : IFace { [JsonProperty] public string B; }

            [JsonProperty]
            public List<IFace> SubInterfaceList;
        }

        public List<int> IntList;
        public int[] IntArray;
    }
}
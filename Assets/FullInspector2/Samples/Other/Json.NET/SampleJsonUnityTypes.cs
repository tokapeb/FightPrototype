using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Unity Types")]
    public class SampleJsonUnityTypes : BaseBehavior<JsonNetSerializer> {
        [JsonObject(MemberSerialization.OptIn)]
        public struct UnityTypesContainer {
            [JsonProperty]
            public Bounds Bounds;

            [JsonProperty]
            public Color Color;

            [JsonProperty]
            public AnimationCurve AnimationCurve;

            [JsonProperty]
            public Vector2 Vector2;

            [JsonProperty]
            public Vector3 Vector3;

            [JsonProperty]
            public Vector4 Vector4;

            [JsonProperty]
            public LayerMask LayerMask;
        }

        public UnityTypesContainer UnityTypes;
    }
}
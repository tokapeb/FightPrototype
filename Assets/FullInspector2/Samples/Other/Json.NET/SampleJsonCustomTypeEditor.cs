using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [JsonObject(MemberSerialization.OptIn)]
    public class CustomTypeEditorNonGeneric {
        [JsonProperty]
        public int Value;
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class CustomTypeEditorGeneric<T1, T2> {
        [JsonProperty]
        public T1 Value1;
        [JsonProperty]
        public T2 Value2;
    }

    [JsonObject(MemberSerialization.OptIn)]
    public interface ICustomTypeEditorInherited { }
    [JsonObject(MemberSerialization.OptIn)]
    public class CustomTypeEditorInheritedA : ICustomTypeEditorInherited { }
    [JsonObject(MemberSerialization.OptIn)]
    public class CustomTypeEditorInheritedB : ICustomTypeEditorInherited { }

    [AddComponentMenu("Full Inspector Samples/Json.NET/Custom Type Editor")]
    public class SampleJsonCustomTypeEditor : BaseBehavior<JsonNetSerializer> {
        public CustomTypeEditorNonGeneric CustomTypeEditorNonGeneric;
        public CustomTypeEditorGeneric<float, string> CustomTypeEditorFloatString;
        public ICustomTypeEditorInherited ICustomTypeEditorInherited;
        public CustomTypeEditorInheritedA CustomTypeEditorInheritedA;
        public CustomTypeEditorInheritedB CustomTypeEditorInheritedB;
    }
}
using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Inheritance")]
    public class SampleJsonInheritance : BaseBehavior<JsonNetSerializer> {

        // interface
        [JsonObject(MemberSerialization.OptIn)]
        public interface IFace { }
        [JsonObject(MemberSerialization.OptIn)]
        public class DerivedIFaceA : IFace { [JsonProperty] public int A; }
        [JsonObject(MemberSerialization.OptIn)]
        public class DerivedIFaceB : IFace { [JsonProperty] public string B; }

        public IFace Interface;
        public List<IFace> InterfaceList;

        // abstract base class
        [JsonObject(MemberSerialization.OptIn)]
        public abstract class AbstractType { }
        [JsonObject(MemberSerialization.OptIn)]
        public class DerivedAbstractA : AbstractType { [JsonProperty] public int A; }
        [JsonObject(MemberSerialization.OptIn)]
        public class DerivedAbstractB : AbstractType { [JsonProperty] public string B; }

        public AbstractType AbstractValue;
        public List<AbstractType> AbstractTypeList;

        // class with derived types
        [JsonObject(MemberSerialization.OptIn)]
        public abstract class BaseType { }
        [JsonObject(MemberSerialization.OptIn)]
        public class DerivedBaseA : BaseType { [JsonProperty] public int A; }
        [JsonObject(MemberSerialization.OptIn)]
        public class DerivedBaseB : BaseType { [JsonProperty] public string B; }

        public BaseType BaseValue;
        public List<BaseType> BaseTypeList;
    }
}
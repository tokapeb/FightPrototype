using ProtoBuf;
using System;
using UnityEngine;

namespace FullInspector.Samples.AssetStore {
    [ProtoContract]
    public struct MyStruct {
        [ProtoMember(1)]
        public int A;
        [ProtoMember(2)]
        public string B;

        [ProtoMember(3)]
        public GameObject GameObject;
        [ProtoMember(4)]
        public Transform Transform;
        [ProtoMember(5)]
        public Collider Collider;
    }

    [AddComponentMenu("Full Inspector Samples/Asset Store/Structs")]
    public class SampleAssetStoreStructs : BaseBehavior<ProtoBufNetSerializer> {
        public MyStruct Struct;
    }
}
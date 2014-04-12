using System;
using UnityEngine;

namespace FullInspector.Samples.AssetStore {
    [Serializable]
    public class MyGenericType<T> {
        public T Value;
    }

    [AddComponentMenu("Full Inspector Samples/Asset Store/Generics")]
    public class SampleAssetStoreGenerics : BaseBehavior<BinaryFormatterSerializer> {
        public MyGenericType<bool> GenericBool;
        public MyGenericType<float> GenericFloat;
        public MyGenericType<GameObject> GenericObject;
    }
}
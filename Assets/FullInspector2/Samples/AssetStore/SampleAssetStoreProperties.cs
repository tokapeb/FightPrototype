using UnityEngine;

namespace FullInspector.Samples.AssetStore {
    [AddComponentMenu("Full Inspector Samples/Asset Store/Properties")]
    public class SampleAssetStoreProperties : BaseBehavior {
        public int MyProperty { get; private set; }
    }
}
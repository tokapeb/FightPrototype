using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.AssetStore {
    [AddComponentMenu("Full Inspector Samples/Asset Store/Lists")]
    public class SampleAssetStoreList : BaseBehavior<JsonNetSerializer> {
        public List<GameObject> GameObjects;
        public Transform[] Transforms;
    }
}
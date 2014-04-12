using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.AssetStore {
    public interface IInterface { }
    public class Implementation1 : IInterface {
        public int ValueA;
    }
    public class Implementation2 : IInterface {
        public string ValueB;
    }

    [AddComponentMenu("Full Inspector Samples/Asset Store/Abstract Types")]
    public class SampleAssetStoreAbstractTypes : BaseBehavior {
        public List<IInterface> Interfaces;
    }
}
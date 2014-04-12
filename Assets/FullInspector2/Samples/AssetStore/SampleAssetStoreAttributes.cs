using UnityEngine;

namespace FullInspector.Samples.AssetStore {
    [AddComponentMenu("Full Inspector Samples/Asset Store/Attributes")]
    public class SampleAssetStoreAttributes : BaseBehavior {
        [Comment("This is a comment")]
        public int Comment;

        [Tooltip("This is a tooltip")]
        public int Tooltip;

        [Margin(50)]
        public int FarDown;

        [HideInInspector]
        public int NotVisibleInInspector;

        [ShowInInspector]
        [SerializeField]
        private int VisibleInInspector;
    }
}
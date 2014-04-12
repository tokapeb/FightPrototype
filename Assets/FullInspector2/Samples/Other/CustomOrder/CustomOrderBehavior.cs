using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.Other.CustomOrder {
    [AddComponentMenu("Full Inspector Samples/Other/Custom Order")]
    public partial class CustomOrderBehavior : BaseBehavior {
        [Order(2)]
        public int Two;
    }

    public partial class CustomOrderBehavior {
        [Order(1)]
        public int One;

        [Order(2.1)]
        public int TwoPt1 { get; set; }
    }

    public partial class CustomOrderBehavior {
        [Order(3)]
        public int Three { get; private set; }
    }

    public partial class CustomOrderBehavior {
        [Order(-10)]
        public int NegativeTen;
    }

    public partial class CustomOrderBehavior {
        public int NonOrdered;
    }
}
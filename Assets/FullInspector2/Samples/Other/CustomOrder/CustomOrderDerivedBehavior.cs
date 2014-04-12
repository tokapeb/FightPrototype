using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.Other.CustomOrder {
    [AddComponentMenu("Full Inspector Samples/Other/Custom Order Derived")]
    public partial class CustomOrderDerivedBehavior : CustomOrderBehavior {
        [Order(2)]
        public int DerivedTwo;
    }

    public partial class CustomOrderDerivedBehavior {
        [Order(1)]
        public int DerivedOne;

        [Order(2.1)]
        public int DerivedTwoPt1 { get; set; }
    }

    public partial class CustomOrderDerivedBehavior {
        [Order(3)]
        public int DerivedThree { get; private set; }
    }

    public partial class CustomOrderDerivedBehavior {
        [Order(-10)]
        public int DerivedNegativeTen;
    }

    public partial class CustomOrderDerivedBehavior {
        public int DerivedNonOrdered;
    }
}
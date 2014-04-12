using FullInspector.Samples.Button;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.Other.Constructors {
    [AddComponentMenu("Full Inspector Samples/Other/Non-Default Constructors")]
    public class SampleNonDefaultConstructorBehavior : BaseBehavior {
        [Comment("Use the context menu to add items")]
        public IInterface Interface;

        [Comment("Use the context menu to add items")]
        public List<IInterface> Interfaces;

        [ContextMenu("Add Implementation 1")]
        private void AddImpl1() {
            Interface = new Implementation1(1);

            if (Interfaces == null) {
                Interfaces = new List<IInterface>();
            }
            Interfaces.Add(new Implementation1(2));
        }

        [ContextMenu("Add Implementation 2")]
        private void AddImpl2() {
            Interface = new Implementation1(2);

            if (Interfaces == null) {
                Interfaces = new List<IInterface>();
            }
            Interfaces.Add(new Implementation2("impl 2"));
        }
    }
}
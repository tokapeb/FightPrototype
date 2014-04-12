using ProtoBuf;
using UnityEngine;

namespace FullInspector.Samples.Button {
    [AddComponentMenu("Full Inspector Samples/Other/Buttons")]
    public class ButtonSampleBehavior : BaseBehavior {
        public class PrintButton : IButton {
            public void Act() {
                Debug.Log("PrintButton pressed");
            }
        }
        [ShowInInspector]
        private PrintButton PrintSomething;

        public class ErrorButton : IButton {
            public void Act() {
                Debug.LogError("Oops, there was an error!");
            }
        }
        [ShowInInspector]
        private ErrorButton MakeAnError;
    }
}
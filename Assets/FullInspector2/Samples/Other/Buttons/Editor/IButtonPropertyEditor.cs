using UnityEditor;
using UnityEngine;

namespace FullInspector.Samples.Button {
    [CustomPropertyEditor(typeof(IButton), Inherit = true)]
    public class IButtonPropertyEditor<TButton> : PropertyEditor<IButton>
        where TButton : IButton, new() {

        public override IButton Edit(Rect region, GUIContent label, IButton element) {
            if (element == null) {
                element = new TButton();
            }

            if (GUI.Button(region, label)) {
                element.Act();
            }
            return element;
        }

        public override float GetElementHeight(GUIContent label, IButton element) {
            return EditorStyles.largeLabel.CalcHeight(label, 100);
        }
    }
}
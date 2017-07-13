using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

[CustomPropertyDrawer (typeof (MinMaxSliderAttribute))]
class MinMaxSliderDrawer : PropertyDrawer {
	
	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label) {

		if (property.propertyType == SerializedPropertyType.Vector2) {
			Vector2 range = property.vector2Value;
			float min = range.x;
			float max = range.y;
			MinMaxSliderAttribute attr = attribute as MinMaxSliderAttribute;
			EditorGUI.BeginChangeCheck ();
			label.text += (" "+ min.ToString("#.0") +"-"+ max.ToString("#.0"));
			EditorGUI.MinMaxSlider ( label , position, ref min, ref max, attr.min, attr.max);
			//EditorGUI.LabelField(position, (min +":"+ max) );
			if (EditorGUI.EndChangeCheck ()) {
				range.x = min;
				range.y = max;
				property.vector2Value = range;
			}
		} else {
			EditorGUI.LabelField (position, label, "Use only with Vector2");
		}
	}
}
#endif

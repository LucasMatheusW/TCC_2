using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ShowWhenAttribute))]
public class ShowWhenAttributeDrawer : ConditionalPropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (this.IsVisible(property))
        {
            EditorGUI.PropertyField(position, property, label);
        }
    }
}
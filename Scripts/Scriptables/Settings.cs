using UnityEngine;

namespace RefineUI.Scriptables
{
    [CreateAssetMenu(fileName = "SettingsDataObject", menuName = "RefineUI/SettingsDataObject", order = 0)]
    public class Settings : ScriptableObject
    {
        public ThemeData defaultTheme;
    }
}
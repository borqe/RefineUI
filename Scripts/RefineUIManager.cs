using System.Collections.Generic;
using UnityEngine;

namespace RefineUI
{
    public class RefineUIManager : MonoBehaviour
    {
        // Initialization fields
        [SerializeField] private bool initializeOnAwake;
        [SerializeField] private bool keepBetweenScenes;
        [SerializeField] private List<RefineUI.Scriptables.ThemeData> themeData;
        
        // Default settings
        [SerializeField] private RefineUI.Scriptables.Settings settings;
        
        // Getters
        public Scriptables.ThemeData CurrentThemeData => _currentThemeData;
        
        // Private fields
        private Scriptables.ThemeData _currentThemeData;

        /// <summary>
        /// Run this to initialize RefineUI
        /// </summary>
        public void Initialize()
        {
            _currentThemeData = settings.defaultTheme;
        }
        
        // Static access
        private static RefineUIManager _instance;

        public static RefineUIManager Instance
        {
            get => _instance;
        }
        
        // Unity Events
        private void Awake()
        {
            if (initializeOnAwake)
            {
                Initialize();
            }

            if (keepBetweenScenes)
            {
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}

#if UNITY_EDITOR
#if UNITY_2018_1_OR_NEWER
using Appodeal.Editor.AppodealManager.AppodealDependencies;
#endif
using UnityEditor;
using UnityEngine;

namespace AppodealAds.Unity.Editor.Utils
{
    public class AppodealEditorSettings : ScriptableObject
    {
        [MenuItem("Appodeal/SDK Documentation")]
        public static void OpenDocumentation()
        {
            Application.OpenURL("https://wiki.appodeal.com/en/unity/get-started");
        }

        [MenuItem("Appodeal/Appodeal Homepage")]
        public static void OpenAppodealHome()
        {
            Application.OpenURL("https://appodeal.com/");
        }

#if UNITY_2018_1_OR_NEWER        
        [MenuItem("Appodeal/Manage Appodeal SDK")]
        public static void AppodealSdkManager()
        {
            AppodealAdapterManager.ShowSdkManager();
        }
#endif
        
        [MenuItem("Appodeal/Appodeal Settings")]
        public static void SetAdMobAppId()
        {
            AppodealInternalSettings.ShowAppodealInternalSettings();
        }

        [MenuItem("Appodeal/Remove plugin")]
        public static void RemoveAppodealPlugin()
        {
            RemoveHelper.RemovePlugin();
        }
    }
}
#endif

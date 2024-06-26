﻿#if UNITY_EDITOR
using UnityEditor;

namespace Unity.Scenes
{
    public static class CustomBakingSettings
    {
        public static bool PlayModeClosedSubSceneBaking
        {
            get => EditorPrefs.GetBool("Wakety.Entities.Streaming.SubScene.StopPlayModeClosedSubSceneBaking", true);
            set
            {
                if (PlayModeClosedSubSceneBaking == value)
                {
                    return;
                }

                EditorPrefs.SetBool("Wakety.Entities.Streaming.SubScene.StopPlayModeClosedSubSceneBaking", value);
            }
        }
    }
}
#endif
using UnityEditor;
class MyEditorScript
{
     static void PerformBuild ()
     {
         string[] scenes = { "Assets/Scenes.unity" };
         BuildPipeline.BuildPlayer(scenes, ...);
     }
}
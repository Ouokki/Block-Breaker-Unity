using UnityEditor;
class MyEditorScript
{
     static void PerformBuild ()
     {
         string[] scenes = { "Assets/Scenes/Levels.unity" };
          
         BuildPipeline.BuildPlayer(scenes);
     }
}

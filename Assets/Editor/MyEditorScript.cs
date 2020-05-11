using UnityEditor;
class MyEditorScript
{
     static void PerformBuild ()
     {
         string[] scenes = { "Assets/Scenes/Start Menu.unity" };
          
         BuildPipeline.BuildPlayer(scenes, ...);
     }
}

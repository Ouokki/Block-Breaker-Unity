using UnityEditor;
class MyEditorScript
{
      [MenuItem("Custom Utilities/Build StandaloneLinux64")]
        static void PerformBuild()
        {
        string[] defaultScene = { "Assets/Scenes/Levels.unity" };
        BuildPipeline.BuildPlayer(defaultScene, "./builds/game.x86_64",
            BuildTarget.StandaloneLinux64, BuildOptions.None);
              Console.Write("first test ------------------");
        }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEditor;
using System.Collections.Generic;

public class SeparateScore
{
    
    [MenuItem("Tools/Write file")]
    public static void WriteString()
    {
        string path = "Assets/text/scores.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        
        writer.Close();

        //Re-import the file to update the reference in the editor
        //AssetDatabase.ImportAsset(path); 
        //TextAsset asset = Resources.Load("scores");

        //Print the text from the file
        //Debug.Log(asset.text);
    }

    [MenuItem("Tools/Read file")]
    public static void ReadString()
    {
        string path = "Assets/text/scores.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path); 
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
}
  
    
    

    

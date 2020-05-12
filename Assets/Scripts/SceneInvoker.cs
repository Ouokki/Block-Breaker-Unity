using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

 
public class SceneInvoker : MonoBehaviour
{
   
   
    
    public void Invoke(string scene)
    {
        if (scene=="Level 1"){
            SeparateScore.WriteString();
        }

        SceneManager.LoadScene(scene);    
        
        
    }
    
}
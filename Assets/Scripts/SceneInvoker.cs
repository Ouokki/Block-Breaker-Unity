using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class SceneInvoker : MonoBehaviour
{
   
    
    public void Invoke(string scene)
    {
         Debug.Log(Scores.totalScore);
        SceneManager.LoadScene(scene);
    }
    
}
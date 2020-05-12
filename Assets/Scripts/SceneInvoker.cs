using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class SceneInvoker : MonoBehaviour
{
   
    
    public void Invoke(string scene)
    {
         
        SceneManager.LoadScene(scene);
    }
    
}
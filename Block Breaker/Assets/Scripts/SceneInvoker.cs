using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SceneInvoker : MonoBehaviour
{
    public void Invoke(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
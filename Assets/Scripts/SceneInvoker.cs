using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



 
public class SceneInvoker : MonoBehaviour
{
   
   //public GameSession  gamesession;
    public void Invoke(string scene)
    {
        if(scene=="Level 1"){
            //gamesession.ResetGame();
           //FindObjectOfType<GameSession>().ResetGame();
        }
        

        SceneManager.LoadScene(scene);    
        
        
    }
    
}
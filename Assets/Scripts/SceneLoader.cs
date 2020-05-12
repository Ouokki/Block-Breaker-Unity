using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;

    void Start ()
    {
        
        
        audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(clip, volume);

	}
	public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);

        FindObjectOfType<GameSession>().ResetGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}



/*public void LoadNextScene()
	{
			SceneManager.LoadScene(1);
	}*/

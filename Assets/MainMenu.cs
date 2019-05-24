using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// we use this to change scenes
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject quiz;
    

    public void PlayGame()
    {
        // we could change the scene by its name
        //SceneManager.LoadScene("Level");

        // or by index
        // here we are geting the build index of the current active scene
        // and adding 1 to get the next escene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        GameObject.Find("Canvas").SetActive(false);
        quiz.SetActive(true);
        
    }
    

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }


}

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;

public class MainSceneManager : MonoBehaviour {

    

    //HUD
    public Canvas HUD;
    public Canvas PauseMenu;
    public GameObject Player;
    

	void Start ()
    {
        
        PauseMenu.enabled = !PauseMenu.enabled;
        Time.timeScale = 1;
        
    }
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
		
	}



    public void PauseGame()
    {
        PauseMenu.enabled = !PauseMenu.enabled;
        Player playerScript = FindObjectOfType<Player>();

        if (PauseMenu.enabled)
        {
            HUD.enabled = false;
            Time.timeScale = 0;
            playerScript.enabled = false;

        }
        else if (!PauseMenu.enabled)
        {
            HUD.enabled = true;
            Time.timeScale = 1;
            playerScript.enabled = true;
            

        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

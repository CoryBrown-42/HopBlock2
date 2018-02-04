using UnityEngine.SceneManagement;
using UnityEngine;

public class retryMenu : MonoBehaviour {

	public void RetryBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void NoBtn()
    {
        SceneManager.LoadScene(0);
    }
}

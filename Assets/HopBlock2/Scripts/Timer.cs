
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text timerLabel;
	public float time;
    //public float TimeLimit;

    private void Start()
    {

    }

    void Update()
	{

		time += Time.deltaTime;
		var minutes = time / 120;
		var seconds = time % 60;
		timerLabel.text = string.Format("{1:00}", minutes, seconds);

    }
    
}
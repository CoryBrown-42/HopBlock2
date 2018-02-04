using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class PlayAd : MonoBehaviour {

    void Start()
    {
        Advertisement.Initialize("1654618", true);

        //StartCoroutine(ShowAdWhenReady());
    }

    IEnumerator ShowAdWhenReady()
    {
        while (!Advertisement.IsReady())
            yield return null;

        Advertisement.Show();
    }

    public void PlayAdver()
    {

        Advertisement.Show();
    }
}

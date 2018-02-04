using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject GroundTile;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    public ObjectPooler theObjectPool;

    private void Start()
    {
        platformWidth = GroundTile.GetComponent<BoxCollider2D>().size.x;
    }

    // Use this for initialization
    void Update ()
    {
        if(transform.position.x < generationPoint.position.x)
        {

            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween,
                transform.position.y,
                transform.position.z);

            GameObject newPlatform = theObjectPool.GetPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

        }
    }

    public void Regenerate()
    {
        Instantiate(GroundTile, new Vector2(Random.Range(-2,1),Random.Range(0, 1)), gameObject.transform.rotation);
    }
}

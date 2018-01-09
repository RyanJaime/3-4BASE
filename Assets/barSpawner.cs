using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barSpawner : MonoBehaviour
{

    public GameObject obstacle;
    public Vector3 spawnValues;

    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;

    public int startWait;
    public int spawnPos;

    public bool stop;

    List<GameObject> obstacleArr = new List<GameObject>();
    GameObject clone;

    // Use this for initialization
    void Start()
    {
        spawnWait = .5f;//Random.Range(spawnLeastWait, spawnMostWait);
        StartCoroutine(waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
        if (obstacleArr.Count > 0)
        {
            if (obstacleArr[0] != null && obstacleArr[0].transform.position.z < -10)
            {
                GameObject toBeDestroyed = obstacleArr[0];
                obstacleArr.Remove(toBeDestroyed);
                Destroy(toBeDestroyed);
            }
        }
    }

    IEnumerator waitSpawner()
    {
        //yield return new WaitForSeconds(startWait);
        for (;;){
            Vector3 spawnPosition = new Vector3(0, 0, 0);
            clone = Instantiate(obstacle, spawnPosition = transform.TransformPoint(Random.Range(-1, 2), 0, 0), gameObject.transform.rotation);
            obstacleArr.Add(clone);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
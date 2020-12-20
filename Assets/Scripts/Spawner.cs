using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool isGameStart;
    public GameObject[] birdList;
    public float minTime, maxTime;
    // Update is called once per frame
    void Update()
    {
        if(isGameStart == true && objectSpawnCoroutine == null)
        {
           objectSpawnCoroutine = StartCoroutine(objectSpawn(Random.Range(minTime, maxTime)));
        }
    }

    Coroutine objectSpawnCoroutine = null;
    IEnumerator objectSpawn(float time)
    {
        int randomNumber = Random.Range(0, birdList.Length);
        GameObject bird = Instantiate(birdList[randomNumber], gameObject.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time);
        objectSpawnCoroutine = null;
    }
}

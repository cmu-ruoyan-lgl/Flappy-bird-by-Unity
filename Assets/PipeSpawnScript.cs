using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 7f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0f;
        }
    }

    void spawnPipe()
    {
        float lowestPos = transform.position.y - heightOffset;
        float highestPos = transform.position.y + heightOffset;
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPos, highestPos), transform.position.z), transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float destroyXPos = -45f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x < destroyXPos)
        {
            Debug.Log("Pipe destroyed!");
            Destroy(gameObject);
        }
    }
}

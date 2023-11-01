using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesGenerator : MonoBehaviour
{
    public GameObject pipes;
    public float height;
    public float interval;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject newPipes = Instantiate(pipes);
        GameObject newPipes = createPipes();
        // newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > interval) {
            GameObject newPipes = createPipes();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private GameObject createPipes() {
        GameObject newPipes = Instantiate(pipes);
        newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipes, 5f);
        return newPipes;
    }
}

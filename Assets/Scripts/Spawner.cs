using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] eggs;
    public GameObject bomb;
    public float xBound, yBound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnerGameObject());
    }

    IEnumerator SpawnerGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1,2));

        int randomEggs = Random.Range(0, eggs.Length);

        if(Random.value <= .5f)
        {
            Instantiate(eggs[randomEggs], new Vector2(Random.Range(-xBound, xBound), yBound), Quaternion.identity);
        }
        else
        {
            Instantiate(bomb, new Vector2(Random.Range(-xBound, xBound), yBound), Quaternion.identity);
        }
        StartCoroutine(SpawnerGameObject());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject fish;

    [SerializeField]
    private GameObject predator;

    [SerializeField]
    private float fishInterval = 3.5f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnFish(fishInterval, fish));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnFish()
    {
        bool fishSpawned = false;
        while (!fishSpawned)
        {
            Vector3 fishPos = new Vector3(Random.Range(-(transform.position.x) - 8f, (transform.position.x) + 8f), Random.Range(-(transform.position.y) - 8f, (transform.position.y) + 8f), -1f);
            if ((fishPos - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(fish, fishPos, Quaternion.identity);
                fishSpawned = true;
            }
        }
    }

    private IEnumerator spawnFish(float interval, GameObject fish)
    {
        yield return new WaitForSeconds(interval);
        Vector3 fishPos = new Vector3(Random.Range(-(transform.position.x) - 8f, (transform.position.x) + 8f), Random.Range(-(transform.position.y) - 8f, (transform.position.y) + 8f), -1f);
        GameObject newFish = Instantiate(fish, fishPos, Quaternion.identity);
        StartCoroutine(spawnFish(interval, fish));
    }
}


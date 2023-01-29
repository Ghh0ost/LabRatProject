using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager1 : MonoBehaviour
{
    
    public GameObject[] flaskPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FlaskSpawn());
    }
    IEnumerator FlaskSpawn()
    {
        while (true)
        {
            int flaskIndex = Random.Range(0, flaskPrefabs.Length);
            Vector3 flaskspawn = new Vector3(Random.Range(-7.5f,7.5f), 6f, 0);
            Instantiate(flaskPrefabs[flaskIndex], flaskspawn, Quaternion.identity);
            yield return new WaitForSeconds(5);
        }

        
    }
}

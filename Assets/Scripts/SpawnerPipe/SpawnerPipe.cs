using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipe : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject pipeHolder;
    
    void Start() {
        StartCoroutine (Spawner ());
    }

    IEnumerator Spawner() {
        yield return new WaitForSeconds (2);
        Vector3 temp = pipeHolder.transform.position;
        temp.y = Random.Range(-2.5f, 2.5f);
        Instantiate (pipeHolder, temp, Quaternion.identity);
        StartCoroutine (Spawner ());
    }
}

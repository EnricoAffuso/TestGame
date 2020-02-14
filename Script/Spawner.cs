using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //SerializeField serve a rendere visibile la variabile nell'inspector
    [SerializeField] GameObject cubePrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sono spawnato"+ gameObject.name, gameObject);
        //Instantiate(cubePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)) // 0  = Mouse sinistro
        {
            Instantiate(cubePrefab, new Vector3(Random.Range(-5,5), Random.Range(-5, 5)), cubePrefab.transform.rotation);
        }
    }
}

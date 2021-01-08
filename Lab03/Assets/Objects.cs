using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public GameObject prefab;
    List<Vector3> test = new List<Vector3>();
    void Start()
    {
        

        while (test.Count<=10)
        {
            Vector3 position = new Vector3(Random.Range(1, 9), 0, Random.Range(1, 9));
            
            if(!test.Contains(position))
                Instantiate(prefab, position, Quaternion.identity);
            else
                position = new Vector3(Random.Range(1, 9), 0, Random.Range(1, 9));

            test.Add(position);
        }
    }

    
}

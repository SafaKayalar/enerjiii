using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObjects : MonoBehaviour
{
    public Spawner spawner;
    void Start()
    {
        Destroy(gameObject, 2);
    }
}

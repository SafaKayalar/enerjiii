using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Spawner : MonoBehaviour
{
    public GameObject obje;
    public float spawndelay ;
    bool stoptime = false;
    int spawnsayisi = 0;
    void Start()
    {
        StartCoroutine(Applespawner());
    }
    private void Update()
    {
  
    }
    private IEnumerator Applespawner()
    {
      
        while (stoptime == false)
        {
            WaitForSeconds wait = new WaitForSeconds(spawndelay);
            yield return wait;
            Vector2 randomposition = new Vector2(Random.Range(-1.3f, 1.3f), Random.Range(-0.45f, 0.3f));
            Instantiate(obje,randomposition,Quaternion.identity);
            spawnsayisi++;
            if (spawnsayisi % 10 == 0 && spawndelay > 0.4) spawndelay -= 0.2f;           
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    int score = 0;
    public Text scoretext;
    public AudioSource destroyvoice;
    public AudioSource deadvoice;
    float deadtimecontroller = 0;
    public float deadtime;
    public Spawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deadtimecontroller += Time.deltaTime;
        if (Input.GetMouseButtonDown(0)) 
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit,float.MaxValue)) 
            {
                if (hit.collider)
                {
                    hit.collider.gameObject.SetActive(false);
                    score++;
                    scoretext.text = score.ToString();
                    destroyvoice.Play();
                }               
            }
            else 
            {
                deadvoice.Play();
                Time.timeScale = 0;
                score = 0;
                SceneManager.LoadScene(2);
            }
        }
        if (deadtimecontroller >= spawner.spawndelay + spawner.spawndelay )
        {
            deadvoice.Play();
            Time.timeScale = 0;
            score = 0;
            SceneManager.LoadScene(2);
        }
        if (Input.GetMouseButtonDown (0))
        {
            deadtimecontroller =0;
        }    
    }
}   


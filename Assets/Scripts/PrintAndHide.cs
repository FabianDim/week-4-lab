using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update

    private int i = 3;
    public Renderer rend;
    private int rand;
        
    void Start()
    {
        rand = Random.Range(150, 250);
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(gameObject.name + ++i);
        if (GameObject.FindWithTag("Red") && i >= 100)
        {
            GameObject.FindWithTag("Red").SetActive(false);  
        }

        if (GameObject.FindWithTag("Blue") && i == rand)
        {
            rend.enabled = false;
        }
    }
}

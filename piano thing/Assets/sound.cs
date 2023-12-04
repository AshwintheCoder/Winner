using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bwomp;
    public AudioSource UU;
    public AudioSource airhorn;
    public AudioSource sadviolin;
    public AudioSource chinarap;
    public AudioSource fortnitesound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            bwomp.Play();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            UU.Play();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            airhorn.Play();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            sadviolin.Play();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            chinarap.Play();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            fortnitesound.Play();
        }
    }
}

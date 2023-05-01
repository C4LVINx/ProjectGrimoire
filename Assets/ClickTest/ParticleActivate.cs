using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivate : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject particles;


    void Start()
    {
        particles.SetActive(false);
    }

    // Update is called once per frame
    void ParticlesActivare()
    {
        {
            particles.SetActive(true);
        }
    }
}

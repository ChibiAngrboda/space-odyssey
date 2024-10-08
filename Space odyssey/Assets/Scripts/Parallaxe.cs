using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxe : MonoBehaviour
{
    private float lenght, startpos,startposy;
    public GameObject MainCam;
    public float parallaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
        startposy = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (MainCam.transform.position.x * (1 - parallaxEffect));
        float dist = (MainCam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, startposy, transform.position.z);

        if (temp > startpos + lenght) startpos += lenght;
        else if (temp < startpos - lenght) startpos -= lenght;
    }
}

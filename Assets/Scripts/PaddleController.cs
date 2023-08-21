using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float batasAtas;
    public float batasBawah;
    public float kecepatan;
    public string axis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gerak = Input.GetAxis(axis)*kecepatan*Time.deltaTime;
        float nextPos = transform.position.y + gerak;
        if (nextPos > batasAtas){
            gerak = 0;
        }
        if (nextPos < batasBawah){
            gerak = 0;
        }
        transform.Translate(0, gerak, 0);
    }
}

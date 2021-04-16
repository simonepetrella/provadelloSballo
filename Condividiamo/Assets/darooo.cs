using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darooo : MonoBehaviour
{
    public GameObject stocazzo;
    public float alarm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alarm += Time.deltaTime;
    }
}

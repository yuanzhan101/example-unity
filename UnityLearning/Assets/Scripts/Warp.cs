using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{

    // Update is called once per frame
    public Transform warptarget;

    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "warp001")
        {
            this.transform.position = warptarget.position;
        }
    }
}

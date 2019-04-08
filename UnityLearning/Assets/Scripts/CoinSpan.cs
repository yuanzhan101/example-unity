using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpan : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 4, 0, Space.World);
    }
}

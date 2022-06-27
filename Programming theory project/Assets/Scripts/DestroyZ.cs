using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZ : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < - 25)
        {
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.transform.position += new Vector3(0, 0, transform.GetComponent<Renderer>().bounds.size.z * this.gameObject.transform.parent.childCount);
    }
}

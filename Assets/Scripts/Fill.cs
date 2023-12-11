using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Fill : MonoBehaviour
{
    [SerializeField]
    private GameObject beer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z);
        if ((rotation.x > 90f && rotation.x < 270f) || (rotation.z > 90f && rotation.z < 270f))
        {
            beer.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Spout"))
        {
            if (GameObject.FindWithTag("Handle").transform.localEulerAngles.x < 355f)
            {
                beer.SetActive(true);
                //Debug.Log("Beer poured");
            }
        }
    }
}

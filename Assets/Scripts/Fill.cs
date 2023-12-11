using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Mathf.Abs(transform.localRotation.eulerAngles.x) > 135.0f || Mathf.Abs(transform.localRotation.eulerAngles.y) > 135.0f)
        {
//            beer.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spout"))
        {
            beer.SetActive(true);
        }
    }
}

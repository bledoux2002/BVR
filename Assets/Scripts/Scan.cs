using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scan : MonoBehaviour
{
    [SerializeField]
    private GameObject scanner;
    [SerializeField]
    private GameObject back;
    [SerializeField]
    private GameObject confirm;
    [SerializeField]
    private GameObject deny;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!back.activeSelf)
        {
            timer += Time.deltaTime;
        }
        if (timer > 1f)
        {
            back.SetActive(true);
            deny.SetActive(false);
            confirm.SetActive(false);
            timer = 0f;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Scanner"))
        {
            back.SetActive(false);
            int random = Random.Range(0, 10);
            if (random == 0)
            {
                deny.SetActive(true);
            } else
            {
                confirm.SetActive(true);
            }
        }
    }
}

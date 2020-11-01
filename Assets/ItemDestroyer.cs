using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    private GameObject unitychan;

    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        if (this.difference > 10)
        {
            Destroy(this.gameObject);
        }
    }
}

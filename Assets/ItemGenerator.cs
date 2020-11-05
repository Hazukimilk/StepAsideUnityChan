using UnityEngine;
using System.Collections;

public class ItemGenerator : MonoBehaviour
{

    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private GameObject unitychan;

    private int startPos = 80;
    private int goalPos = 360;
    private float interval = 0;
    private float distance = 0;
    private float olddistance = 0;

    private float posRange = 3.4f;



    // Use this for initialization
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        this.distance = unitychan.transform.position.z;
        

        this.interval = (distance - olddistance) + interval;


        if (distance < goalPos)
        {
            if (interval > 15)
            {
                int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab);
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, distance + 80);
                    }
                }
                else
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        int item = Random.Range(1, 11);
                        int offsetZ = Random.Range(-5, 6);

                        if (1 <= item && item <= 6)
                        {
                            GameObject coin = Instantiate(coinPrefab);
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, distance+ 80 + offsetZ);
                        }

                        else if (7 <= item && item <= 9)
                        {
                            GameObject car = Instantiate(carPrefab);
                            car.transform.position = new Vector3(posRange * j, car.transform.position.y, distance + 80  + offsetZ);
                        }
                    }

                }
                this.interval = 0;

            }
            this.olddistance = distance;
        }
    }
}

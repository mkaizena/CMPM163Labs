using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCity : MonoBehaviour
{

    public GameObject[] buildings;
    public int mapWidth = 70;
    public int mapHeight = 70;
    int buildingFootprint = 7;




    // Start is called before the first frame update
    void Start()
    {
        float seed = Random.Range(0, 100);


        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                int result = (int)(Mathf.PerlinNoise(w/10.0f + seed, h/10.0f + seed) * 10);
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                //int n = Random.Range(0, buildings.Length);

                
                if (result < 2)
                {

                    //water
                    Instantiate(buildings[1], pos, Quaternion.identity);

                }
                else if(result < 3)
                {
                    //tree and grassy ground
                    Instantiate(buildings[5], pos, Quaternion.identity);
                    Instantiate(buildings[2], pos, Quaternion.identity);

                
                }
                else if(result < 5)
                {
                    //yellow house on dark gray
                    Instantiate(buildings[7], pos, buildings[7].transform.rotation);
                    Instantiate(buildings[3], pos, Quaternion.identity);
                }
                else if(result < 6)
                {
                    //tree on dirt ground(x) grass 2
                    Instantiate(buildings[5], pos, Quaternion.identity);
                    Instantiate(buildings[2], pos, Quaternion.identity);
                }
                else if(result < 8)
                {

                    //gray house on light gray
                    Instantiate(buildings[4], pos, Quaternion.identity);
                    Instantiate(buildings[0], pos, Quaternion.identity);
                }
                else if(result < 11)
                {

                    //tall house on light gray
                    Instantiate(buildings[0], pos, Quaternion.identity);
                    Instantiate(buildings[6], pos, Quaternion.identity);
                }

            }
        }



    }

    // Update is called once per frame
    void Update()
    {

    }
}

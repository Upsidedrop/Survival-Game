using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnResources : MonoBehaviour
{
    float[] spawnPos = {60, 55};
    public GameObject evergreen;
    public GameObject rock;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int n = 0; n < 12; n++)
            {
                switch (Random.Range(1, 6))
                {
                    case 1:
                        
                        Instantiate(evergreen, new Vector3(spawnPos[0], 4.2f, spawnPos[1]), Quaternion.Euler(-90, 0, 0));
                        break;
                    case 2:
                     
                        Instantiate(evergreen, new Vector3(spawnPos[0], 4.2f, spawnPos[1]), Quaternion.Euler(-90, 0, 0));
                        break;
                    case 3:
                       
                        Instantiate(evergreen, new Vector3(spawnPos[0], 4.2f, spawnPos[1]), Quaternion.Euler(-90, 0, 0));
                        break;
                    case 4:
                
                        Instantiate(evergreen, new Vector3(spawnPos[0], 4.2f, spawnPos[1]), Quaternion.Euler(-90, 0, 0));
                        break;
                    default:
                      
                        Instantiate(rock, new Vector3(spawnPos[0], -0.2f, spawnPos[1]), Quaternion.Euler(-90, 0, 0));
                        break;
                }

                spawnPos[1] -= Random.Range(20, 33);
                spawnPos[0] -= Random.Range(-15, 15);
            }
            spawnPos[0] -= Random.Range(20, 33);
            spawnPos[1] = 55;
        }
        
        
    }

    
}

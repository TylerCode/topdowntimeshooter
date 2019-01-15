using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TimeSwitch : MonoBehaviour
{
    private bool _isPast = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (_isPast)
            {
                List<GameObject> gameObjectsPresent = GameObject.FindGameObjectsWithTag("TNew").ToList();
                List<GameObject> gameObjectsPresentWalls = GameObject.FindGameObjectsWithTag("WNew").ToList();

                List<GameObject> gameObjectsPast = GameObject.FindGameObjectsWithTag("TOld").ToList();
                List<GameObject> gameObjectsPastWalls = GameObject.FindGameObjectsWithTag("WOld").ToList();

                foreach (GameObject go in gameObjectsPresent)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                }

                foreach(GameObject go in gameObjectsPast)
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                }

                foreach (GameObject go in gameObjectsPresentWalls)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                }

                foreach (GameObject go in gameObjectsPastWalls)
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                }

                GameObject.FindGameObjectWithTag("POld").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("PNew").GetComponent<SpriteRenderer>().enabled = true;

                _isPast = false;
            }
            else
            {
                List<GameObject> gameObjectsPresent = GameObject.FindGameObjectsWithTag("TNew").ToList();
                List<GameObject> gameObjectsPresentWalls = GameObject.FindGameObjectsWithTag("WNew").ToList();

                List<GameObject> gameObjectsPast = GameObject.FindGameObjectsWithTag("TOld").ToList();
                List<GameObject> gameObjectsPastWalls = GameObject.FindGameObjectsWithTag("WOld").ToList();

                foreach (GameObject go in gameObjectsPresent)
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                }

                foreach (GameObject go in gameObjectsPast)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                }

                foreach (GameObject go in gameObjectsPresentWalls)
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                }

                foreach (GameObject go in gameObjectsPastWalls)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                }

                GameObject.FindGameObjectWithTag("POld").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("PNew").GetComponent<SpriteRenderer>().enabled = false;

                _isPast = true;
            }
        }
    }
}

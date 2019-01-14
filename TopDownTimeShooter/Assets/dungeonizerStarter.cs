using UnityEngine;
using System.Collections;

public class dungeonizerStarter : MonoBehaviour {
    public Dungeonizer dungeonizer;
    public string difficulty = "easy";
    public GameObject loadingScreen;
    public GameObject chest;

	// Use this for initialization
	void Start () {
        /* we will configurate dungeonizer here */
        StartCoroutine("dungeonStarter");
	}

    public IEnumerator dungeonStarter()
    {
        
        SpawnOption easyFood = new SpawnOption();
        easyFood.maxSpawnCount = 10;
        easyFood.minSpawnCount = 10;
        easyFood.spawnRoom = 0;
        easyFood.spawnByWall = false;
        easyFood.gameObject = chest;
        

        if (difficulty == "easy")
        {
            dungeonizer.maximumRoomCount = 10;
            dungeonizer.spawnOptions[0] = easyFood;
        }
        else if (difficulty == "hard")
        {
            dungeonizer.maximumRoomCount = 20;
        }
        else
        {
            dungeonizer.maximumRoomCount = 50;
        }

        Debug.Log("START");
        dungeonizer.Generate(); //generates
        yield return new WaitForSeconds(0); //<-- here
        loadingScreen.SetActive(false);
        Debug.Log("GENERATED");
    }

    // Update is called once per frame
    void Update () {
	
	}
}

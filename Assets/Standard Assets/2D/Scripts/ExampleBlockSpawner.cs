/*
 *Spawns blocks when keys 1-6 are pressed. 
 * 
 * 
 * 
 * 
 * 
 */



using UnityEngine;
using System.Collections;

public class ExampleBlockSpawner : MonoBehaviour {

	bool[,] Block1, Block2, Block3;
	public GameObject blockSet;
	public Vector3 Team1 = new Vector3(-5, 0, 0);
	public Vector3 Team2 = new Vector3(5, 0, 0);

	// Use this for initialization
	void Start () {
		//Some blocks
		Block1 = new bool[5, 5];
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				Block1[i, j] = false;
			}
		}
		Block1[4, 0] = true;
		Block1[4, 1] = true;
		Block1[4, 3] = true;
		Block1[4, 2] = true;
		Block1[4, 4] = true;
		Block1[3, 2] = true;

		Block2 = new bool[5, 5];
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if (j == 2) Block2[i, j] = true;
				else Block2[i, j] = false;
			}
		}

		Block3 = new bool[5, 5];
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if (j == 2 || j == 4) Block3[i, j] = true;
				else Block3[i, j] = false;
			}
		}
		Block3[2, 3] = true;
		Block3[0, 3] = true;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown("1")){
			GameObject g = (GameObject)Instantiate(blockSet, Team1, Quaternion.identity);
			g.GetComponent<BlockSetCreator>().RealStart(Block1, 1f);
		}
		if (Input.GetKeyDown("2")){
			GameObject g = (GameObject)Instantiate(blockSet, Team1, Quaternion.identity);
			g.GetComponent<BlockSetCreator>().RealStart(Block2, 1f);
		}
		if (Input.GetKeyDown("3")){
			GameObject g = (GameObject)Instantiate(blockSet, Team1, Quaternion.identity);
			g.GetComponent<BlockSetCreator>().RealStart(Block3, 1f);
		}
		if (Input.GetKeyDown("4")){
			GameObject g = (GameObject)Instantiate(blockSet, Team2, Quaternion.identity);
			g.GetComponent<BlockSetCreator>().RealStart(Block1, -1f);
		}
		if (Input.GetKeyDown("5")){
			GameObject g = (GameObject)Instantiate(blockSet, Team2, Quaternion.identity);
			g.GetComponent<BlockSetCreator>().RealStart(Block2, -1f);
		}
		if (Input.GetKeyDown("6")){
			GameObject g = (GameObject)Instantiate(blockSet, Team2, Quaternion.identity);
			g.GetComponent<BlockSetCreator>().RealStart(Block3, -1f);
		}
	}

    public void SpawnBlocks(string input)
    {
        if (input  == "1")
        {
            GameObject g = (GameObject)Instantiate(blockSet, Team1, Quaternion.identity);
            g.GetComponent<BlockSetCreator>().RealStart(Block1, 1f);
        }
        if (input  == "2")
        {
            GameObject g = (GameObject)Instantiate(blockSet, Team1, Quaternion.identity);
            g.GetComponent<BlockSetCreator>().RealStart(Block2, 1f);
        }
        if (input  == "3")
        {
            GameObject g = (GameObject)Instantiate(blockSet, Team1, Quaternion.identity);
            g.GetComponent<BlockSetCreator>().RealStart(Block3, 1f);
        }
        if (input  == "4")
        {
            GameObject g = (GameObject)Instantiate(blockSet, Team2, Quaternion.identity);
            g.GetComponent<BlockSetCreator>().RealStart(Block1, -1f);
        }
        if (input  == "5")
        {
            GameObject g = (GameObject)Instantiate(blockSet, Team2, Quaternion.identity);
            g.GetComponent<BlockSetCreator>().RealStart(Block2, -1f);
        }
        if (input  == "6")
        {
            GameObject g = (GameObject)Instantiate(blockSet, Team2, Quaternion.identity);
            g.GetComponent<BlockSetCreator>().RealStart(Block3, -1f);
        }
    }
}

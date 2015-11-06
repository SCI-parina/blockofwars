using UnityEngine;
using System.Collections;

public class Team : MonoBehaviour {

    public static int starting_income = 10;
    public float money = 0;
    public BlockShop shop;
    public GameObject block_set;

    private int income;
    private Vector3 spawn_point;
    private float direction;

	// Use this for initialization
	void Start () {
        income = starting_income;
        spawn_point = GetComponent<Transform>().position;
        direction = -spawn_point.x / Mathf.Abs(spawn_point.x);
	}
	
	// Update is called once per frame
	void Update () {
        money += income * Time.deltaTime;
	}

    public bool BuyBlock(int type) {
        UnityEngine.Assertions.Assert.IsFalse(type > shop.catalogue.GetLength(0));
        BlockPrice bp = shop.catalogue[type - 1];
        if (money > bp.price) {
            money -= bp.price;
            SpawnBlock(bp.block_type);
            return true;
        }
        else {
            return false;
        }
    }

    void SpawnBlock(bool[,] type) {
        GameObject g = (GameObject)Instantiate(block_set, spawn_point, Quaternion.identity);
        g.GetComponent<BlockSetCreator>().RealStart(type, direction);
    }
}

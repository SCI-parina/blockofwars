using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Globalization;

public class Team : MonoBehaviour {

    public static int starting_income = 10;
    public float money = 0;
    public BlockShop shop;
    public GameObject block_set;
    public Text money_text;
    public TextFade purchace_text;

    private int income;
    private Vector3 spawn_point;
    private int direction;

	// Use this for initialization
	void Start () {
        income = starting_income;
        spawn_point = GetComponent<Transform>().position;
        direction = (int)(-spawn_point.x / Mathf.Abs(spawn_point.x));
	}
	
	// Update is called once per frame
	void Update () {
        money += income * Time.deltaTime;
        money_text.text = money.ToString("C0", CultureInfo.CreateSpecificCulture("fi-FI"));
	}

    public bool BuyBlock(int type) {
        UnityEngine.Assertions.Assert.IsFalse(type > shop.catalogue.GetLength(0));
        BlockPrice bp = shop.catalogue[type - 1];
        if (money > bp.price) {
            money -= bp.price;
            money_text.text = money.ToString("C0", CultureInfo.CreateSpecificCulture("fi-FI"));
            purchace_text.SetText((-bp.price).ToString("C0", CultureInfo.CreateSpecificCulture("fi-FI")), 1, 1);
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

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Globalization;

public class Team : MonoBehaviour {

    public static int starting_income = 10;
    public static int starting_health = 20;
    public float money = 0;
    public BlockShop shop;
    public GameObject block_set;
    public Text money_text;
    public TextFade purchace_text;
    public Text hp_text;

    private int id;
    private int income;
    private int health;
    private Vector3 spawn_point;
    private int direction;             

	// Use this for initialization
	void Start () {
        id = GetInstanceID();
        income = starting_income;
        health = starting_health;
        spawn_point = GetComponent<Transform>().position;
        direction = (int)(-spawn_point.x / Mathf.Abs(spawn_point.x));
        hp_text.text = health.ToString();
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
        g.GetComponent<BlockSetCreator>().RealStart(type, direction, id);
    }

    void OnTriggerEnter2D(Collider2D other) {
        Mover block = other.gameObject.GetComponent<Mover>();
        if (block != null && block.team_id != id) {
            health -= 1;
            hp_text.text = health.ToString();
            if (health < starting_health / 3) {
                hp_text.color = new Color(255, 0, 0);
            }
            Destroy(other.gameObject);
        }
    }
}

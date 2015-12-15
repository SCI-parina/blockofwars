using UnityEngine;
using System.Collections;


public struct BlockPrice {
    public bool[,] block_type;
    public float price;
    public BlockPrice(bool[,] type, float p){
        block_type = type;
        price = p;
    }

}

public class BlockShop : MonoBehaviour {

    public BlockPrice[] catalogue;
    public Color[] colors;

	// Use this for initialization
	void Start () {
        catalogue = new BlockPrice[9] {
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            20),
        new BlockPrice( new bool[5,5] {
            {false, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {false, false, false, false, false}}, 
            20),
        new BlockPrice( new bool[5,5] {
            {false, false, false, false, false}, 
            {false, false, false, false, false}, 
            {true, false, false, false, false}, 
            {false, false, false, false, false}, 
            {false, false, false, false, false}}, 
            20),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, true, true, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            30),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, true, true, true, false}, 
            {true, false, false, false, false}, 
            {true, true, true, true, false}, 
            {true, false, false, false, false}}, 
            40),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, true, true, true, true}, 
            {true, false, false, false, false}}, 
            40),
        new BlockPrice( new bool[5,5] {
            {true, true, true, true, true}, 
            {true, false, false, true, true}, 
            {true, false, true, true, true}, 
            {true, false, false, true, true}, 
            {true, true, true, true, true}}, 
            50),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, true, true, false, false}, 
            {true, false, true, true, false}, 
            {true, true, true, false, false}, 
            {true, false, false, false, false}}, 
            50),
        new BlockPrice( new bool[5,5] {
            {true, true, true, true, true}, 
            {true, true, true, true, true}, 
            {true, true, true, true, true}, 
            {true, true, true, true, true}, 
            {true, true, true, true, true}}, 
            70)
        };

        colors = new Color[] {
            Color.blue,
            Color.cyan, 
            Color.gray, 
            Color.green, 
            Color.magenta, 
            Color.red, 
            Color.yellow, 
            Color.white
        };
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

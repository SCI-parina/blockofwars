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
            0),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, true, true, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            1),
        new BlockPrice( new bool[5,5] {
            {true, true, true, true, true}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            2),
        new BlockPrice( new bool[5,5] {
            {true, true, true, false, false}, 
            {true, false, true, false, false}, 
            {true, true, true, false, false}, 
            {true, false, true, false, false}, 
            {true, false, true, false, false}}, 
            3),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            4),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            5),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            6),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            7),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            8)
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

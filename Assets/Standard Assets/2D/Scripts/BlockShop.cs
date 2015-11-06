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
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            0),
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
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            0),
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
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            0),
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
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            0),
        new BlockPrice( new bool[5,5] {
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}, 
            {true, false, false, false, false}}, 
            0)
        };
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

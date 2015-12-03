using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

    public Team team1;
    public Team team2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            team1.BuyBlock(1);
        } if (Input.GetKeyDown(KeyCode.Alpha2)) {
            team1.BuyBlock(2);
        } if (Input.GetKeyDown(KeyCode.Alpha3)) {
            team1.BuyBlock(3);
        } if (Input.GetKeyDown(KeyCode.Alpha4)) { 
            team1.BuyBlock(4);
        } if (Input.GetKeyDown(KeyCode.Alpha5)) {
            team1.BuyBlock(5);
        } if (Input.GetKeyDown(KeyCode.Alpha6)) {
            team1.BuyBlock(6);
        } if (Input.GetKeyDown(KeyCode.Alpha7)) {
            team1.BuyBlock(7);
        } if (Input.GetKeyDown(KeyCode.Alpha8)) {
            team1.BuyBlock(8);
        } if (Input.GetKeyDown(KeyCode.Alpha9)) {
            team1.BuyBlock(9);
        } if (Input.GetKeyDown(KeyCode.Keypad1)) { 
            team2.BuyBlock(1);
        } if (Input.GetKeyDown(KeyCode.Keypad2)) { 
            team2.BuyBlock(2);
        } if (Input.GetKeyDown(KeyCode.Keypad3)) { 
            team2.BuyBlock(3);
        } if (Input.GetKeyDown(KeyCode.Keypad4)) { 
            team2.BuyBlock(4);
        } if (Input.GetKeyDown(KeyCode.Keypad5)) { 
            team2.BuyBlock(5);
        } if (Input.GetKeyDown(KeyCode.Keypad6)) { 
            team2.BuyBlock(6);
        } if (Input.GetKeyDown(KeyCode.Keypad7)) { 
            team2.BuyBlock(7);
        } if (Input.GetKeyDown(KeyCode.Keypad8)) { 
            team2.BuyBlock(8);
        } if (Input.GetKeyDown(KeyCode.Keypad9)) {
            team2.BuyBlock(9);
        } if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        } if (Input.GetKeyDown(KeyCode.R)) {
            Application.LoadLevel(0);
        }
	}
}

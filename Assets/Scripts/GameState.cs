using UnityEngine;
using System.Collections;
using System.Net;
using System;


public class GameState : MonoBehaviour {

    public Team team1;
    public Team team2;

	// Use this for initialization
	void Start () {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        myConnectionString = "server=vituttaa.soikkelionhomo.pw;uid=parina;" +
            "pwd=sciparina;database=sciparina;";
        ArrayList list = new ArrayList();
        try
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            string query = "SELECT url FROM kuva ORDER BY RAND() LIMIT 20";


            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);

            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                list.Add(reader[0]);
            }

            reader.Close();
            conn.Close();

        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Debug.Log(ex.ToString());
        }

        WebClient webClient = new WebClient();

        

        System.Random rnd = new System.Random();

        string asd = @"C:\temp2\";

        Debug.Log(asd + rnd.Next(1, 124214));

        foreach (string i in list)
        {

            webClient.DownloadFile(i, asd + rnd.Next(1,124214) + ".png");
        }
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
        }
	}
}

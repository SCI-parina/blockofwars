﻿using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class BlockSetCreator : MonoBehaviour {

	public GameObject block;
	public GameObject[,] blocks;
	private int LastBlocks;
    // Use this for initialization
    void Start () {
    }

    public void RealStart(bool[,] blockArray, int direction, int team_id, Color color) {
        // blockArray should be 5x5
        blocks = new GameObject[5, 5];
        System.Random rand = new System.Random();

        string[] FileList = Directory.GetFiles(@"C:\temp2\", "*.png");
        byte[] bytes;
        bytes = System.IO.File.ReadAllBytes(FileList[rand.Next(0, FileList.Length -1)]);

        for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if(blockArray[i, j]){
					Vector3 newPos = transform.position + new Vector3(direction*j*block.GetComponent<Renderer>().bounds.size.x,
                                                                      -i*block.GetComponent<Renderer>().bounds.size.y, 0);
					GameObject b = (GameObject)Instantiate(block, newPos, Quaternion.identity);
					b.GetComponent<Mover>().MoveSpeed = direction * 1.5f;
                    b.GetComponent<Mover>().team_id = team_id;
                    Texture2D tex = new Texture2D(12, 12);
                    ///while(!www.isDone) { }
                    ///www.LoadImageIntoTexture(tex);
                    tex.LoadImage(bytes);
                    TextureScale.Bilinear(tex, 12, 12);
                    Sprite sprite = Sprite.Create(tex, new Rect(0, 0, 12, 12), new Vector2(0, 0));
                    b.GetComponent<SpriteRenderer>().sprite = sprite;
                    b.GetComponent<SpriteRenderer>().color = color;
					blocks[i, j] = b;
				}
			}
		}
		LastBlocks = BlockAmount();
	}
	
	int BlockAmount () {
		int amount = 0;
		foreach (GameObject o in blocks) {
			if (o != null) amount++;
		}
		return amount;
	}
	
	bool IsDestroyed () {
		if(BlockAmount() == 0) return true;
		ArrayList visited = new ArrayList();
		bool found = false;
		int size = BlockAmount();
		int x = 0;
		int y = 0;

		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if(!found && blocks[i, j] != null){
					x = i;
					y = j;
					found = true;
				}
			}
		}

		visited = findConnected(visited, x, y);

		if (visited.Count == size) return false;
		else return true;
	}

	bool wasVisited(ArrayList visited, int x, int y) {
		bool found = false;
		foreach (int[] i in visited) {
			if (i[0] == x && i[1] == y) found = true;
		}
		return found;
	}

	ArrayList findConnected(ArrayList visited, int x, int y) {
		visited.Add (new int[] {x, y});
		int[] next;
		int i = 0;
		ArrayList n = neighbours(x, y);
		while (i < n.Count) {
			next = (int[])n[i];
			if(blocks[next[0], next[1]] != null && !wasVisited(visited, next[0], next[1])){
				visited = findConnected(visited, next[0], next[1]);
			}
			i++;
		}
		return visited;
	}


	ArrayList neighbours(int x, int y) {
		ArrayList n = new ArrayList();
		if(x > 0 && blocks[x-1, y] != null) n.Add (new int[] {x-1, y});
		if(y > 0 && blocks[x, y-1] != null) n.Add (new int[] {x, y-1});
		if(x < 4 && blocks[x+1, y] != null) n.Add (new int[] {x+1, y});
		if(y < 4 && blocks[x, y+1] != null) n.Add (new int[] {x, y+1});
		return n;
	}
	
	// Update is called once per frame
	void Update () {
		int BlocksRemaining = BlockAmount();
        if (BlocksRemaining < LastBlocks) {
			LastBlocks = BlocksRemaining;
			if(IsDestroyed()){
				//Kill all
				foreach (GameObject o in blocks) {
					if (o != null){
						Destroy(o);
					}
				}
				Destroy(gameObject);
			}
		}
		
	}
}

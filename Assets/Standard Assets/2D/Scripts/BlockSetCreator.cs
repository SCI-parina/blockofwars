using UnityEngine;
using System.Collections;

public class BlockSetCreator : MonoBehaviour {

	public GameObject block;
	public GameObject[,] blocks;
	private int LastBlocks;
    private int team_direction;      

	// Use this for initialization
	void Start () {
	}

	public void RealStart (bool[,] blockArray, int direction) {
		// blockArray should be 5x5
		blocks = new GameObject[5, 5];
        team_direction = direction;
		
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if(blockArray[i, j]){
					Vector3 newPos = transform.position + new Vector3(direction*j*block.GetComponent<Renderer>().bounds.size.x,
                                                                      -i*block.GetComponent<Renderer>().bounds.size.y, 0);
					GameObject b = (GameObject)Instantiate(block, newPos, Quaternion.identity);
					b.GetComponent<Mover>().MoveSpeed = direction * 1.5f;
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

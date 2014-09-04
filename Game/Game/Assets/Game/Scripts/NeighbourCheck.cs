using UnityEngine;
using System.Collections;

public class NeighbourCheck : MonoBehaviour {

	// object is called Block
	// color var color:Color;
	// picture uses a name;
	// Array is called GameField
	// 0,0 start point
	// max var as max point

	void Start () {
	
	}
	
	void Update () {
	
	}

	public static bool Check (GameObject b, GameObject[,] bArray, int x, int y) {
		GameObject b2;
		Block block;
		Block block2;
		block = b.GetComponent<Block> ();
		if (bArray[x, y] == null){
			if (x < bArray.GetLength(0)-1){
				b2 = bArray[x+1, y];
				if (b2 != null){
					// if b2.attributes != b.attributes; return false
					block2 = b2.GetComponent<Block>();
					if (!compare(block,block2)){
						return false;
					}
				}
			}
			if (x > 0){
				b2 = bArray[x-1, y];
				if (b2 != null){
					block2 = b2.GetComponent<Block>();
					if (!compare(block,block2)){
						return false;
					}
				}
			}
			if (y < bArray.GetLength(1)-1){
				b2 = bArray[x, y+1];
				if (b2 != null){
					block2 = b2.GetComponent<Block>();
					if (!compare(block,block2)){
						return false;
					}
				}
			}
			if (y > 0){
				b2 = bArray[x, y-1];
				if (b2 != null){
					block2 = b2.GetComponent<Block>();
					if (!compare(block,block2)){
						return false;
					}
				}
			}
			return true;			
		}//else return false;
		return true;
	}
	private static bool compare(Block block1,Block block2){

		if (block1.picture != block2.picture && block1.color != block2.color ){
			return false;
		}
		return true;
	}

}

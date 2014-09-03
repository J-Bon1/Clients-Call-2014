using UnityEngine;
using System.Collections;

public class Neighbourcheck : MonoBehaviour {

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

	public void Check (Block b, GameObject[,] bArray, int x, int y) {
		int x2;
		int y2;
		Block b2;

		
		if (bArray[x, y] == null){			
			if (x < bArray.GetLength(0)){
				x2 = 1;
				y2 = 0;
				x2 += x;
				y2 += y;
				b2 = bArray[x2, y2];
				print(b2);
				// if b2.attributes != b.attributes; return false
			}
			if (x > 0){
				x2 = -1;
				y2 = 0;
				x2 += x;
				y2 += y;
				b2 = bArray[x2, y2];
				print(b2);
				// if b2.attributes != b.attributes; return false
			}
			if (y < bArray.GetLength(1)){
				x2 = 0;
				y2 = 1;
				x2 += x;
				y2 += y;
				b2 = bArray[x2, y2];
				print (b2);
				// if b2.attributes != b.attributes; return false
			}
			if (y > 0){
				x2 = 0;
				y2 = -1;
				x2 += x;
				y2 += y;
				b2 = bArray[x2, y2];
				print (b2);
				// if b2.attributes != b.attributes; return false
			}
			
			
			
		}
		//print(b2);
		//print(bArray [vec]);
		
		
		
	}

}

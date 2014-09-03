using UnityEngine;
using System.Collections;

	

public class MapCreator : MonoBehaviour {

	//dellet this later
	private int dummyX = 5;
	private int dummyY = 5;



	private GameObject[,] GameField;
<<<<<<< HEAD
	private uint[] possibleColors;
	private Texture[] possibleTextures;
=======
	private Color[] possibleColors;
	private Texture2D[] possibleTextures;

	// Inspector stuff
	public GameObject prefapBlock;
>>>>>>> origin/master

	// Use this for initialization
	void Start () {
		loadBrickTyps ();
		createGameField ();
	}
	
	// Update is called once per frame
	void Update () {
	}
	private void loadBrickTyps(){
		possibleColors = new Color[2];
		possibleColors [0] = Color.blue;
		possibleColors [1] = Color.red;
		possibleTextures = new Texture2D[2];
		possibleTextures[0] = new Texture2D(128, 128);
		possibleTextures[0].name = "1";

	}

	private void createGameField(){
		GameField  = new GameObject[dummyX, dummyY];
		fillGameField ();
	}
	private GameObject createRandomBrick(){
		GameObject randomBlock = Instantiate(prefapBlock) as GameObject;
		randomBlock.GetComponent<Block>().color = possibleColors[Random.Range(0, possibleColors.Length)];
		randomBlock.GetComponent<Block>().picture = possibleTextures[Random.Range(0, possibleColors.Length)];
		randomBlock.GetComponent<Block> ().create ();
		return randomBlock;
	
	}
	private void fillGameField(){
		GameObject dummyBlock;


		int i;
		int j;
		print (GameField.GetLength (0));
		for (i = 0; i < GameField.GetLength(0); i++) {
			for (j = 0; j< GameField.GetLength(1); j++) {
				dummyBlock = createRandomBrick ();
				GameField[i,j] = dummyBlock;
				GameField[i,j].transform.position = new Vector3(i,0,j);
			}
		}						
	}
}

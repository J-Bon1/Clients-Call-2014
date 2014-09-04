using UnityEngine;
using System.Collections;

	

public class MapCreator : MonoBehaviour {

	//dellet this later
	private int dummyX = 5;
	private int dummyY = 5;



	public GameObject[,] m_gameField;
	public Color[] possibleColors;
	public Texture2D[] possibleTextures;

	// Inspector stuff
	public GameObject prefapBlock;

	// Use this for initialization
	void Start () {
		prefapBlock = Resources.Load ("Block");
		//loadBrickTyps ();
		createGameField ();
		print ("GameField: " + m_gameField.GetLength(0));
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
		m_gameField  = new GameObject[dummyX, dummyY];
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
		bool found = false;

		int i;
		int j;
		for (i = 0; i < m_gameField.GetLength(0); i++) {
			for (j = 0; j< m_gameField.GetLength(1); j++) {
				while(!found){
					dummyBlock = createRandomBrick ();
					if(NeighbourCheck.Check(dummyBlock,m_gameField,i,j)){
						found = true;
						m_gameField[i,j] = dummyBlock;
						m_gameField[i,j].transform.position = new Vector3(i,0,j);
					}else{
						Destroy(dummyBlock);
					}

				}
				found = false;

			}
		}						
	}
	public GameObject[,] getGameField(){
		return m_gameField;
	}
}

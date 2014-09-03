using UnityEngine;
using System.Collections;

	

public class MapCreator : MonoBehaviour {

	//dellet this later
	private int dummyX = 5;
	private int dummyY = 5;



	private GameObject[,] GameField;
	private uint[] possibleColors;
	private Texture[] possibleTextures;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void loadBrickTyps(){

	}

	private void createGameField(){
		GameField  = new Block[dummyX, dummyY];
	}
	private void fillGameField(){
		
	}
}

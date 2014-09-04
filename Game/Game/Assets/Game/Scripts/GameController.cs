using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private GameObject loader;
	private GameObject mapCreator;
	public string[] path;
	private GameObject[,] gameField;

	// Use this for initialization
	void Start () {
		path = new string[1];
		path[0] = "C:/Users/Steffen/Desktop/Test";
		initialiseGame();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void initialiseGame(){
		loader = new GameObject ();
		loader.AddComponent <ResourceLoader>();
		loader.GetComponent<ResourceLoader> ().path = path;
		loader.GetComponent<ResourceLoader>().getAllFileInfos();

		mapCreator = new GameObject ();
		mapCreator.AddComponent <MapCreator>();
		mapCreator.GetComponent<MapCreator> ().possibleTextures = loader.GetComponent<ResourceLoader> ().pictures;

		gameField = mapCreator.GetComponent<MapCreator> ().getGameField ();


	}
}

using UnityEngine;
using System.Collections;

public class Chess : MonoBehaviour {

    public Board board;

	// Use this for initialization
	void Start () {

        GameObject boardObject = new GameObject("Board");
        boardObject.transform.parent = transform;
        board = boardObject.AddComponent<Board>();
        board.tilePrefab = (GameObject)Resources.Load("Prefabs/Tile");
        board.piecePrefab = (GameObject)Resources.Load("Prefabs/Pawn");
        board.piecePrefab = (GameObject)Resources.Load("Prefabs/Rook");
        board.piecePrefab = (GameObject)Resources.Load("Prefabs/Knight");
        board.piecePrefab = (GameObject)Resources.Load("Prefabs/Queen");
        board.piecePrefab = (GameObject)Resources.Load("Prefabs/King");
        //board.piecePrefab = (GameObject)Resources.Load("Prefabs/Bishop");

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

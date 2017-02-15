using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Board : MonoBehaviour
{

    public int size = 8;
    public Dictionary<int, Tile> tile = new Dictionary<int, Tile> ();
    public Dictionary<int, Pawn> pawn = new Dictionary<int, Pawn>();
    public Dictionary<int, Rook> rook = new Dictionary<int, Rook>();
    //public Dictionary<int, Bishop> bishop = new Dictionary<int, Bishop>();
    public Dictionary<int, Queen> queen = new Dictionary<int, Queen>();
    public Dictionary<int, King> king = new Dictionary<int, King>();
    public Dictionary<int, Knight> knight = new Dictionary<int, Knight>();
    public GameObject tilePrefab;
    public GameObject piecePrefab;
    public GameObject borderPrefab;

    // Use this for initialization
    void Start ()
    {

        int id = 1;

        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++ )
            {
                GameObject tileObject = (GameObject)Instantiate(tilePrefab);
                Tile tile = tileObject.AddComponent<Tile>();
                tileObject.transform.parent = transform;
                tile.coordinates = new Vector2(i, j);
                tileObject.transform.position = new Vector3(i, 0, j);
                MeshRenderer tileObjectMeshRenderer = tileObject.GetComponent<MeshRenderer>();

                if (i % 2 == 0 && j % 2 == 1 || i % 2 == 1 && j % 2 == 0)
                {
                    tileObjectMeshRenderer.material = (Material)Resources.Load("Textures/Materials/White");

                }
                else
                {
                    tileObjectMeshRenderer.material = (Material)Resources.Load("Textures/Materials/Black");
                }

                //MeshRenderer tileObjectMeshRenderer = tileObject.GetComponent<MeshRenderer>();
                //Material tileObjectMaterial = new Material(Shader.Find("Standard"));
                //tileObjectMeshRenderer.material = (Material)Resources.Load("Textures/Materials/Black");
                //tileObjectMaterial.color = tile.color;

                tileObject.name = "Tile " + id;
                id++;
            }
        }

        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
                {
                if (i == 8)
                    {
                        GameObject pieceObject = (GameObject)Instantiate(piecePrefab);

                        if (j == 1 || j == 8)
                        {
                            Rook rook = pieceObject.AddComponent<Rook>();
                         
                        }

                        if (j == 2 || j == 7)
                        {
                            Knight knight = pieceObject.AddComponent<Knight>();
                   
                        }

                        if (j == 3 || j == 6)
                        {
                            Bishop bishop = pieceObject.AddComponent<Bishop>();
                   
                        }

                        if (j == 4)
                        {
                            King king = pieceObject.AddComponent<King>();
                           
                        }

                        if (j == 5)
                        {
                            Queen queen = pieceObject.AddComponent<Queen>();
              
                        }
						pieceObject.transform.parent = transform;
						//pieceObject.coordinates = new Vector2(i, j);
                        pieceObject.transform.position = new Vector3(i, 1, j);
                        MeshRenderer pieceObjectMeshRenderer = pieceObject.GetComponent<MeshRenderer>();
                        pieceObjectMeshRenderer.material = (Material)Resources.Load("Textures/Materials/White");                  
                    }

                    if (i == 7)
                    {
                        GameObject pieceObject = (GameObject)Instantiate(piecePrefab);
                        Pawn pawn = pieceObject.AddComponent<Pawn>();
                        pieceObject.transform.parent = transform;
                        pawn.coordinates = new Vector2(i, j);
                        pieceObject.transform.position = new Vector3(i, 1, j);
                        MeshRenderer pieceObjectMeshRenderer = pieceObject.GetComponent<MeshRenderer>();
                        pieceObjectMeshRenderer.material = (Material)Resources.Load("Textures/Materials/White");
                    }

                    if (i == 1)
                    {
                        GameObject pieceObject = (GameObject)Instantiate(piecePrefab);

                        if (j == 1 || j == 8)
                        {
                            Rook rook = pieceObject.AddComponent<Rook>();

                        }

                        if (j == 2 || j == 7)
                        {
                            Knight knight = pieceObject.AddComponent<Knight>();

                        }

                        if (j == 3 || j == 6)
                        {
                            Bishop bishop = pieceObject.AddComponent<Bishop>();

                        }

                        if (j == 4)
                        {
                            King king = pieceObject.AddComponent<King>();

                        }

                        if (j == 5)
                        {
                            Queen queen = pieceObject.AddComponent<Queen>();

                        }

						pieceObject.transform.parent = transform;
						//pieceObject.coordinates = new Vector2(i, j);
                        pieceObject.transform.position = new Vector3(i, 1, j);
                        //MeshRenderer pieceObjectMeshRenderer = pieceObject.GetComponent<MeshRenderer>();
                        //pieceObjectMeshRenderer.material = (Material)Resources.Load("Textures/Materials/Black");
                    }


                    if (i == 2)
                    {
                    GameObject pieceObject = (GameObject)Instantiate(piecePrefab);
                    Pawn pawn = pieceObject.AddComponent<Pawn>();
                    pieceObject.transform.parent = transform;
                    pawn.coordinates = new Vector2(i, j);
                    pieceObject.transform.position = new Vector3(i, 1, j);
                    MeshRenderer pieceObjectMeshRenderer = pieceObject.GetComponent<MeshRenderer>();
                    pieceObjectMeshRenderer.material = (Material)Resources.Load("Textures/Materials/Black");
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

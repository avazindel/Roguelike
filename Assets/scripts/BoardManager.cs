using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardManager : MonoBehaviour
{
    public int width;
    public int height;


    public Tile[] tiles;
    private Tilemap board;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        board = GetComponentInChildren<Tilemap>();

        //(x, y, z) vector3: all 3 directions in the space
       

        for (int i = -4; i <= 3; i++)
        {
            for (int j = -4; j <= 3; j++)
            {
                print(i + ", " + j);
                Vector3Int coordinate = new Vector3Int(i, j, 0);

                int random = Random.Range(0, tiles.Length - 1);
                board.SetTile(coordinate, tiles[random]);
            }
            //j is the rows, i is the columns
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

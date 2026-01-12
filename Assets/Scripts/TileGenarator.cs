using UnityEngine;

public class TileGenarator : MonoBehaviour
{
    [SerializeField] private GameObject Tile;
    [SerializeField] private int NoTile = 8;
    [SerializeField] private float TileSpace = -1.5f;
    [SerializeField] private float TileStart = -2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float y = TileStart;

        for (int i = 0; i < NoTile; i++)
        {
            float x = TileStart;
            for (int j = 0; j < NoTile; j++)
            {
                Instantiate(Tile, new Vector3(x, y), Quaternion.identity);
                x += TileSpace;
            }
            y += TileSpace;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

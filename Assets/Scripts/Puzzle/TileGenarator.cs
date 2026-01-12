using UnityEngine;

public class TileGenarator : MonoBehaviour
{
    [SerializeField] private GameObject TilePrefab;
    [SerializeField] private int NoTile = 9;
    [SerializeField] private float TileSpace = -3f;
    [SerializeField] private float TileStart = 3f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float y = TileStart;

        for (int i = 0; i < NoTile; i++)
        {
            float x = TileStart;
            for (int j = 0; j < NoTile; j++)
            {
                Instantiate(TilePrefab, new Vector3(x, y), Quaternion.identity);
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

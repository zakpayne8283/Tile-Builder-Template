using UnityEngine;

public class GenerateBase : MonoBehaviour
{
    [Header("Generation Properties")]
    [SerializeField] public int numTilesWidth;
    [SerializeField] public int numTilesHeight;
    [SerializeField] public GameObject baseTilePrefab;
    [SerializeField] public GameObject tileRenderArea;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Renderer tileRenderer = baseTilePrefab.GetComponent<Renderer>();
        float tileWidth  = tileRenderer.bounds.size.x;
        float tileHeight = tileRenderer.bounds.size.y;

        // On start, generate the base game area
        if (numTilesHeight > 0 && numTilesWidth > 0)
        {
            // Draw for each row
            for (int y = 1; y <= numTilesHeight; y++)
            {
                // Offset for placing the tile
                int yFactor = y - numTilesHeight;

                // Draw for each column
                for (int x = 1; x <= numTilesWidth; x++)
                {
                    // Offset for placing the tile
                    int xFactor = x - numTilesWidth;

                    // Generate the new tile
                    GameObject newTile = Instantiate(baseTilePrefab, tileRenderArea.transform);

                    // Position the new tile
                    newTile.transform.position = new Vector3(
                        xFactor * tileWidth,
                        yFactor * tileHeight,
                        0
                    );
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

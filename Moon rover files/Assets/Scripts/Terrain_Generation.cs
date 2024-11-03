using UnityEngine;

public class Terrain_Generation : MonoBehaviour
{
    public int depth = 20;
    public int width = 256;
    public int height = 256;
    public float scale = 20f;

    void Start()
    {
        Terrain ground = GetComponent<Terrain>();
        ground.terrainData = GenerateGround(ground.terrainData);
    }

    TerrainData GenerateGround (TerrainData terrainData)
    {
        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, depth, height);
        terrainData.SetHeights(0, 0, GenHeights());
        return terrainData;
    }
    
    float[,] GenHeights()
    {
        float[,] heights = new float[width, height];
        for (int x=0; x< width; x++)
        {
            for (int y=0; y< height; y++)
            {
                heights[x, y] = CalcHeight(x, y);
            }
        }
        return heights;
    }

    float CalcHeight(int x, int y)
    {
        float CoordX = (float)x / width * scale;
        float CoordY = (float)y / height * scale;
        return Mathf.PerlinNoise(CoordX, CoordY);
    }
}

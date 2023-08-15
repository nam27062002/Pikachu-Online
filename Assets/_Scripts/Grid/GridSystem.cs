using UnityEngine;

public class GridSystem : Singleton<GridSystem>
{
    [Header("Grid System")] 
    public int Width = 18;
    public int Height = 11;
    public int NumberImages = 15; 
    private int[,] grid;

    private void Start()
    {
        grid = new int[Width, Height];
        InitializeGrid();
        PrintGrid();
    }

    private void InitializeGrid()
    {
        for (int x = 1; x < Width - 1; x++)
        {
            for (int y = 1; y < Height - 1; y++)
            {
                grid[x, y] = Random.Range(1, NumberImages + 1);
            }
        }
    }

    private void SpawnBlocks()
    {
        
    }
    private void PrintGrid()
    {
        string gridContents = "Grid contents:\n";

        for (int y = Height - 1; y >= 0; y--)
        {
            string row = "";
            for (int x = 0; x < Width; x++)
            {
                row += grid[x, y].ToString().PadLeft(4); // Adjust padding as needed
            }
            gridContents += row + "\n";
        }

        Debug.Log(gridContents);
    }
}
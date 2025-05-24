using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board
{
    public BoardSquare[,] squares;

    public void CreateBoard(int width, int height, GameObject squarePrefab, Transform parent, Material whiteMaterial, Material blackMaterial)
    {
        squares = new BoardSquare[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector2Int position = new Vector2Int(x, y);
                squares[x, y] = new BoardSquare(position, squarePrefab, parent, whiteMaterial, blackMaterial);
            }
        }
    }
}


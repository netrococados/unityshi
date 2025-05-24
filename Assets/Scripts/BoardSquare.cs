using UnityEngine;

public class BoardSquare
{
    public Vector2Int Position { get; set; }
    public GameObject Piece { get; set; } // GameObject de la pieza
    public bool HasChest { get; set; }

    public BoardSquare(Vector2Int position, GameObject sqPrefab, Transform parent, Material whiteMaterial, Material blackMaterial)
    {
        Position = position;

        GameObject square = GameObject.Instantiate(sqPrefab, new Vector3(position.x, 0, position.y), Quaternion.identity, parent);

        Material material = (position.x + position.y) % 2 == 0 ? whiteMaterial : blackMaterial;
        square.GetComponentInChildren<MeshRenderer>().material = material;
        Piece = null;
        HasChest = false;
    }
}


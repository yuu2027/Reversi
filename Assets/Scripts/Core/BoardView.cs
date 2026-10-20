using System;
using UnityEngine;

public class BoardView : MonoBehaviour
{
    [SerializeField] private CellView cellPrefab;

    private CellView[,] cells = new CellView[8, 8];

    public void Initialize()
    {
        for(int y = 0; y < 8; y++)
        {
            for(int x = 0; x < 8; x++)
            {
                CellView cell = Instantiate(cellPrefab, transform);

                cell.Initialize(x, y);

                

                cells[x, y] = cell;
            }
        }
    }
}

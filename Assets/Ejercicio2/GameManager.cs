using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int rows;
    [SerializeField] private int cols;
    [SerializeField] private GameObject[] boardGameObjects;
    
    private int[,] matrixBoard;

    void Start()
    {
        ConvertBoardToMatrix();
    }
    public void ConvertBoardToMatrix()
    {
        matrixBoard = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int index = (i * cols) + j;
                GameObject cellObject = boardGameObjects[index];
                matrixBoard[i, j] = cellObject.CompareTag("Tile") ? 1 : 0;
            }
        }
    }
}
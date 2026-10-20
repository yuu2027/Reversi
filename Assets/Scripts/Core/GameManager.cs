using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private BoardView boardView;
    
    //private void Awake()
    //{
    //    boardView = GetComponent<BoardView>();
    //}
    void Start()
    {
        if (boardView == null)
        {
            Debug.LogWarning("BoardViewが参照されていない");
        }
        boardView.Initialize();
    }
}

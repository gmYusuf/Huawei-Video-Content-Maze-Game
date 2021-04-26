using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private Board board;

    private void Start()
    {
        
    }

    private void InitializeBoard()
    {
        board = new Board();

    }
}

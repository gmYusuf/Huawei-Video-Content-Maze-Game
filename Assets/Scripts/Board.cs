using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board
{

    private List<Tile> TileArray;
    private Vector2Int BallLocation;
    private Direction MoveDirection;

    public Vector2Int BallLocation1 { get => BallLocation; set => BallLocation = value; }
    public Direction MoveDirection1 { get => MoveDirection; set => MoveDirection = value; }
    public List<Tile> TileArray1 { get => TileArray; set => TileArray = value; }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{

    private bool isWall;
    private Vector2Int location;
    private Color color; // white -> wall, Red -> colored tile, Gray -> non-colored tile
    private bool is_Up_DirectionAvailable;
    private bool is_Left_DirectionAvailable;
    private bool is_Down_DirectionAvailable;
    private bool is_Right_DirectionAvailable;

}

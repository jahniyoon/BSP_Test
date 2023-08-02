using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCreator : MonoBehaviour //  던전 생성
{

    public int dungeonWidth, dungeonLength;
    public int roomWidthMin, roomLengthMin;
    public int maxIterations;
    public int corridorWidth;




    void Start()
    {
        CreateDungeon();
    }

    private void CreateDungeon()
    {
        DungeonGenerator generator = new DungeonGenerator(dungeonWidth, dungeonLength);
        var listtoOfRooms = generator.CaculateRooms(maxIterations, roomWidthMin, roomLengthMin);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}

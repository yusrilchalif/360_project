using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionManager : MonoBehaviour
{
    public Transform[] targetPositions;
    public SpawnPosition spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovePlayerPosition(int positionIndex)
    {
        if (positionIndex >= 0 && positionIndex < targetPositions.Length)
        {
            Vector3 targetPosition = targetPositions[positionIndex].position;
            spawnPosition.MoveToTarget(targetPosition);
        }
        else
        {
            Debug.LogError("Invalid position index");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAISquadCoordinator : MonoBehaviour
{
    [SerializeField] private List<simpleAIBrain> squadMembers;
    [SerializeField] private Transform[] sqaudPosistions;
    
    void Update()
    {
        // cycle through all squad members
        // and make them move to sqaud positions
        for(int i = 0; i < squadMembers.Count; i++)
        {
            if (squadMembers[i].GetComponent<simpleAIBrain>().currentTactics == simpleAIBrain.Tactics.SquadPattern)
            {
                squadMembers[i].agent.SetDestination(sqaudPosistions[i].position);
            }
        }
    }
}

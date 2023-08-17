using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class simpleAIBrain : MonoBehaviour
{
    [SerializeField] private simpleAIVision vision;
    public NavMeshAgent agent;
    [SerializeField] private Vector3 targetPos = new Vector3(8, 0, 8);
    
    public enum Tactics { Undifined, NoPattern, SquadPattern }
    public Tactics currentTactics = Tactics.Undifined;
   
    private void Start()
    {
        agent.SetDestination(targetPos);
    }

    private void Update()
    {
        if(currentTactics == Tactics.NoPattern)
        {
            if (vision != null)
            {
                if (vision.playerCharacter != null)
                {
                    agent.SetDestination(vision.playerCharacter.transform.position);
                }
            }
        }
       

    }


}

using System.IO.Pipes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class CubeWanderScript : MonoBehaviour
{
    public NavMeshAgent agent;

    [SerializeField]
    public Area Area;

    void Start()
    {
        SetRandomDestination();
    }

    void Update()
    {
        if (HasArrived())
        {
            SetRandomDestination();
        }
    }

    bool HasArrived()
    {
        return agent.remainingDistance <= agent.stoppingDistance;
    }

    void SetRandomDestination()
    {
        agent.SetDestination(Area.GetRandomPoint());
    }
}

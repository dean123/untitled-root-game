using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitBehaviour : MonoBehaviour
{
    private GameObject pickupObject = null;
    private GameObject holdingObject = null;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance == 0)
        {
            if (pickupObject && !holdingObject)
            {
                holdingObject = pickupObject;
                holdingObject.transform.SetParent(transform);
                holdingObject.transform.Translate(transform.forward * 0.5f);
            }

            if (holdingObject)
            {
                Debug.Log("Drop this");

            }
        }
    }

    public void setTarget(RaycastHit hit)
    {
        agent.destination = hit.point;

        if (hit.transform.gameObject.layer == 6)
        {
            pickupObject = hit.transform.gameObject;
        }
        else
        {
            pickupObject = null;
        }
    }
}

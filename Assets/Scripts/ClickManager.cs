using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickManager : MonoBehaviour
{
    private GameObject selectedPlayer = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (selectedPlayer)
                {
                    Transform pl = selectedPlayer.transform.Find("Point Light");
                    pl.gameObject.SetActive(false);
                    selectedPlayer = null;
                }

                if (hit.transform.gameObject.tag == "Player")
                {
                    selectedPlayer = hit.transform.gameObject;
                    Transform pl = selectedPlayer.transform.Find("Point Light");
                    pl.gameObject.SetActive(true);

                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (selectedPlayer)
            {
                RaycastHit hit;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
                {
                    UnitBehaviour ub = selectedPlayer.GetComponent<UnitBehaviour>();
                    ub.setTarget(hit);
                }
            }
        }
    }
}

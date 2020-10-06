using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeMaker : MonoBehaviour
{
    [SerializeReference]
    private GameObject smoke = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                smoke.transform.position = hit.point;
                smoke.GetComponentInChildren<MeshRenderer>().sharedMaterial.SetFloat("_startTime", Time.time);
            }
        }
    }
}

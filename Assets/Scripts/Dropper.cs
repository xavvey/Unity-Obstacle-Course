using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderDropObject;
    Rigidbody gravityDropObject;
    [SerializeField] float dropObjectTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        renderDropObject = GetComponent<MeshRenderer>();
        renderDropObject.enabled = false;
    
        gravityDropObject = GetComponent<Rigidbody>();
        gravityDropObject.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= dropObjectTime)
        {
            renderDropObject.enabled = true;
            gravityDropObject.useGravity = true;
        }  
    }
}

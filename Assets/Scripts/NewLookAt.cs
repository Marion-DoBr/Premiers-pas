using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class NewLookAt : MonoBehaviour
{
    public Transform target;
    public bool lookAtCamera = false;
    
    // Update is called once per frame
    void Update()
    {

        float x = target.transform.position.x;
        float y = target.transform.position.y + 10;
        float z = target.transform.position.z - 30; 
        Camera.main.transform.position = new Vector3(x, y, z);

        //if(target != null) {
            //transform.LookAt(target);

        //}

        if (lookAtCamera == true && Camera.main != null) {
                transform.LookAt(Camera.main.transform);
        }
    }
    private void Start() {
        transform.LookAt(target);
        
    }
}
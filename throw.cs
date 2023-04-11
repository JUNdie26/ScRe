using UnityEngine;
using System.Collections;
using Mathf;

public class throw : MonoBehaviour {
    public GameObject bullet;
    void Start(){

        Rigidbody rb = GetComponent<Rigidbody>();

    }

    void Update(){
        float angle = Random.Range(1, 90);




        public Vector3 targetPosition;
        

        targetPosition.x = 0;
        targetPosition.y = Mathf.Cos(angle * Mathf.Deg2Rad);
        

        while(true){
            bullet.position = new Vector3(targetPosition.x, targetPosition.y, 0);

        }
        
    }
    





}
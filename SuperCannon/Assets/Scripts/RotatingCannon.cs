using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCannon : MonoBehaviour
{

    GameObject smallbulletprefab;
    // Start is called before the first frame update
    void Start()
    {
        smallbulletprefab = Resources.Load("SmallBullet") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouselook = this.transform.position - GameData.GetMouseTarget();

        Quaternion newrotation = Quaternion.LookRotation(mouselook, Vector3.forward);
        newrotation.x = 0f;  //reset back any x rotation to 0 since we only want to rotate around the z axis
        newrotation.y = 0f;  //reset back any y rotation to 0 since we only want to rotate around the z axis
       
        //this.transform.rotation = newrotation;   //NO SLERP

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 2);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject mysmallbullet = Instantiate(smallbulletprefab, this.transform.position, Quaternion.identity);
            
        }

    }
}

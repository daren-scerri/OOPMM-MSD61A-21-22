using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCannon : MonoBehaviour
{

    Transform cannontip;
    GameObject smallbulletprefab, largebulletprefab;

    Coroutine fire1coroutine, fire2coroutine;

    // Start is called before the first frame update
    void Start()
    {
        cannontip = this.gameObject.transform.GetChild(0);
        smallbulletprefab = Resources.Load("SmallBullet") as GameObject;
        largebulletprefab = Resources.Load("LargeBullet") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouselook = this.transform.position - GameData.MousePos;

        Quaternion newrotation = Quaternion.LookRotation(mouselook, Vector3.forward);
        newrotation.x = 0f;  //reset back any x rotation to 0 since we only want to rotate around the z axis
        newrotation.y = 0f;  //reset back any y rotation to 0 since we only want to rotate around the z axis
       
        //this.transform.rotation = newrotation;   //NO SLERP

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 2);

        if (Input.GetButtonDown("Fire1"))
        {
            fire1coroutine = StartCoroutine(Smallbulletfiring());
        }
        else if (Input.GetButtonUp("Fire1")) StopCoroutine(fire1coroutine);


        if (Input.GetButtonDown("Fire2"))
        {
            fire2coroutine = StartCoroutine(Largebulletfiring());


        } else if (Input.GetButtonUp("Fire2")) StopCoroutine(fire2coroutine);


        IEnumerator Smallbulletfiring()
        {
            while (true)
            {
                GameObject mysmallbullet = Instantiate(smallbulletprefab, cannontip.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
            }
        }


        IEnumerator Largebulletfiring()
        {
            while (true)
            {
                GameObject mylargebullet = Instantiate(largebulletprefab, cannontip.position, Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }

        }



    }
}

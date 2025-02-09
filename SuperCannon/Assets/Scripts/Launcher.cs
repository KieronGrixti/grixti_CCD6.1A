using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject canonBallPrefab;
    public GameObject shortRangeBulletPrefab;
    Coroutine bulletCoroutine, cannonCoroutine;
    public ObjectPool canonPool, bulletPool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void PointAtMouse() //will rotate the canon to make it face the mouse
    {
        Quaternion newrotation = Quaternion.LookRotation(transform.position - GameData.Target, Vector3.forward);

        newrotation.x = 0f;
        newrotation.y = 0f;

        transform.rotation = Quaternion.Slerp(transform.rotation,newrotation,Time.deltaTime * 3f);
    }

    //Coroutine
    IEnumerator FireContinuously(ObjectPool pool)
    {
        while (true)
        {
            //Instantiate(prefab, transform.position, transform.rotation);

            GameObject bullet = pool.GetPoolObject();
            if (bullet != null)
            {
                bullet.SetActive(true);
                bullet.transform.position = this.transform.position;
                bullet.transform.rotation = this.transform.rotation;
            }

            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        PointAtMouse();

        if (Input.GetMouseButtonDown(0)) //left click
        {
            //Instantiate(canonBallPrefab,transform.position,transform.rotation);
            if (cannonCoroutine == null)
            {
                cannonCoroutine = StartCoroutine(FireContinuously(canonPool));
            }
        }

        if (Input.GetMouseButtonUp(0)) //left click
        {
            StopCoroutine(cannonCoroutine);
            cannonCoroutine = null;
        }

        if (Input.GetMouseButton(1)) //right click
        {
            //Instantiate(shortRangeBulletPrefab, transform.position, transform.rotation);
            if (bulletCoroutine == null)
            {
                bulletCoroutine = StartCoroutine(FireContinuously(bulletPool));
            }
        }

        if (Input.GetMouseButtonUp(1)) //left click
        {
            StopCoroutine(bulletCoroutine);
            bulletCoroutine = null;
        }
    }
}

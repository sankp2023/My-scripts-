using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GunSystem : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Gun;
    public float BulletSpeed;

    void Start()
    {
        StartCoroutine(BulletShoot());
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Gun.transform.position = Gun.transform.position + new Vector3(-0.1f,0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Gun.transform.position = Gun.transform.position + new Vector3(0.1f, 0, 0);
        }
    }
    public void Shoot()
    {
        Instantiate(Bullet, Gun.transform.position, Quaternion.identity);
    }
    void OnTriggerEnter()
    IEnumerator BulletShoot()
    {
        while(true)
        {
            yield return new WaitForSeconds(BulletSpeed);
            Shoot();
        }
    }
}
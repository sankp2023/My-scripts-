using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Spon : MonoBehaviour
{
    public GameObject[] New;
    public Transform[] SponPoint;
    public float Time = 2f;
    public int EnemyCount = 10;
    public int Count;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemysponer());
    }
    void SopnEnemy()
    {
        EnemyCount = EnemyCount - Count;
        int Rendom2 = Random.Range(0, SponPoint.Length);
        int Rendom1 = Random.Range(0, New.Length);
        Instantiate(New[Rendom1], SponPoint[Rendom2].position, Quaternion.identity);
    } 
    IEnumerator Enemysponer()
    {
        while(EnemyCount > 0)
        {
            yield return new WaitForSeconds(Time);
            SopnEnemy();
        }
    }
}

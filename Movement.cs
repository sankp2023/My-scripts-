using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform Enemy;
    public Transform [] Player;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 n = new Vector3(0,0,Player[1].position.z);
        Enemy.Translate(n * speed);
    }
}

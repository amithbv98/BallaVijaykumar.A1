using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public Transform EnemyAim;
    public GameObject EneBullet;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( shootingBulletEnemy() );
    }

    void Eshoot() {
        Instantiate(EneBullet, EnemyAim.position, EnemyAim.rotation);
    }

    IEnumerator shootingBulletEnemy()
    {
        int num;
        while (true) {
            yield return new WaitForSeconds(2);
            num = Random.Range(0, 3);
            if (num == 1)
            {
                Eshoot();
            }
        }

    }


}

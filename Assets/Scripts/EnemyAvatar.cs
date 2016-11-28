using UnityEngine;
using System.Collections;

public class EnemyAvatar : BaseAvatar {
	// Use this for initialization
	void Start () {
        isEnemy = true;
        health = maxHealth;
    }

    int increaseScore(int score)
    {
        return score;
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update () {
        if (health < 1)
        {
            Destroy(this.gameObject);
        }
    }
}

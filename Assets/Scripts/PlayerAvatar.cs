using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAvatar : BaseAvatar {
    public float energy;
    BulletGunPlayer bgp;
    // Use this for initialization
    void Start () {
        bgp = GetComponent<BulletGunPlayer>();
        isEnemy = false;
        health = maxHealth;
    }
    void Update () {
        if (health < 1)
            Destroy(this.gameObject);
        energy = bgp.energy;
    }
}

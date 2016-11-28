using UnityEngine;
using System.Collections;

public abstract class BaseAvatar : MonoBehaviour {
    [SerializeField]
    public float maxSpeed;
    [SerializeField]
    public int maxHealth;
    public bool isEnemy;
    public int health;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        BaseAvatar baseAvatar = collider.GetComponent<BaseAvatar>();
        if (baseAvatar != null)
        {
            if (baseAvatar.isEnemy != this.isEnemy)
                baseAvatar.health -= 3;
        }
    }
}

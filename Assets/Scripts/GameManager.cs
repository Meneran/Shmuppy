using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {
    public int score;
    public GameObject player;
    public GameObject monster;
    private GameObject tmp;
    public float apparitionRate;
    private float apparitionCooldown = 0f;
    void Start () {
        score = 0;
        tmp = Instantiate(player);
    }
    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (apparitionCooldown > 0)
            apparitionCooldown -= Time.deltaTime;
        Apparition();
        PlayerAvatar pA = tmp.GetComponent<PlayerAvatar>();
    }
    public void Apparition()
    {
        if (apparitionCooldown <= 0)
        {
            apparitionCooldown = apparitionRate;
            Instantiate(monster, this.gameObject.transform.position, Quaternion.identity);
        }
    }
}

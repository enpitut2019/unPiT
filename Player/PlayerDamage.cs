using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{


    public int playerHP;
    public Text playerHPText;

    public int playerScore;
    public Text playerScoreText;

    public GameObject bomb;

    public AudioClip sound1;  //Damage sound
    AudioSource audioSource;

    public GameObject plane;  //to erase movie when I die
    
    private void Start()
    {
        playerHP = 3;
        playerScore = 0;     
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = sound1;
    }

    private void Update()
    {
        playerHPText.text = "残りHP:" + playerHP.ToString();
        playerScoreText.text="Score:"+playerScore.ToString();
    }


    //　コライダのIsTriggerのチェックを入れ物理的な衝突をしない（突き抜ける）場合
    void OnTriggerEnter(Collider col) {
        //Debug.Log(col.gameObject.tag);
		if(col.tag == "Enemy") {
            Instantiate(bomb, col.gameObject.transform.position, col.gameObject.transform.rotation);
            playerHP -= 1;
            //playerHPText.text = "残りHP:" + playerHP.ToString();
            // audioSource.PlayOneShot(sound1);
            audioSource.Play();
            if (playerHP == 0)
            {
                AudioSource.PlayClipAtPoint(sound1,Camera.main.transform.position);
                Destroy(this.gameObject);  //Erase Player
                Destroy(plane.gameObject);
                this.gameObject.SetActive(false);
                SceneManager.LoadScene("GameOver");

            }
            Debug.Log(playerHP);

        }
        
        if(col.tag == "Coin"){
            //Debug.Log("you get coin");
            playerScore+=1;
            // playerScoreText.text="Score:"+playerScore.ToString();
        }

        Destroy(col.gameObject);

	}

}

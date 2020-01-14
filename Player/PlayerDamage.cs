using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public int playerHP;
    public Text playerHPText;

    public static int playerScore;
    public Text playerScoreText;

    public GameObject bomb;

    AudioSource audioSource;
    public AudioClip sound1;  //Damage sound
    public AudioClip sound2;  //Get Coin sound

    private void Start()
    {
        //playerHP = 2;
        playerScore = 0;     
        audioSource = gameObject.AddComponent<AudioSource>();
        //audioSource.clip = sound1;
    }

    private void Update()
    {
        playerHPText.text = playerHP.ToString();
        playerScoreText.text = playerScore.ToString();
    }

    //　コライダのIsTriggerのチェックを入れ物理的な衝突をしない（突き抜ける）場合
    void OnTriggerEnter(Collider col) {
        //Debug.Log(col.gameObject.tag);
		if(col.tag == "Enemy") {
            Instantiate(bomb, col.gameObject.transform.position, col.gameObject.transform.rotation);
            playerHP -= 1;
            audioSource.PlayOneShot(sound1);
            //audioSource.Play();
            if (playerHP == 0)
            {
                AudioSource.PlayClipAtPoint(sound1,Camera.main.transform.position);
                Destroy(this.gameObject);  //Erase Player
                this.gameObject.SetActive(false);
                SceneManager.LoadScene("GameOver");

            }
            //Debug.Log(playerHP);

        }
        
        if(col.tag == "Coin"){
            //Debug.Log("you get coin");
            audioSource.PlayOneShot(sound2);
            playerScore += 5;
            // playerScoreText.text="Score:"+playerScore.ToString();
        }

        Destroy(col.gameObject);

	}

}

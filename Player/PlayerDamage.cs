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

    bool waitLoad; //true in the time between player7s death and loading gameover scene, false at the start
    float waitTimeCount;

    private void Start()
    {
        playerScore = 0;     
        audioSource = gameObject.AddComponent<AudioSource>();
        waitLoad = false;
        waitTimeCount=0;
        //audioSource.clip = sound1;
    }

    private void Update()
    {
        playerHPText.text = playerHP.ToString();
        playerScoreText.text = playerScore.ToString();

        if(waitLoad){ //when player dead
            waitTimeCount+=Time.deltaTime;
            if(waitTimeCount>0.5f){
                Destroy(this.gameObject);  //Erase Player
                //this.gameObject.SetActive(false);
                SceneManager.LoadScene("GameOver");
            } 
        }
    }

    void OnTriggerEnter(Collider col) {
		if(col.tag == "Enemy") {
            Instantiate(bomb, col.gameObject.transform.position, col.gameObject.transform.rotation);
            playerHP -= 1;
            audioSource.PlayOneShot(sound1);
            //audioSource.Play();
            if (playerHP <= 0)
            {
                AudioSource.PlayClipAtPoint(sound1,Camera.main.transform.position);
                waitLoad=true;
            }
        }
        
        if(col.tag == "Coin"){
            audioSource.PlayOneShot(sound2);
            playerScore += 5;
        }

        Destroy(col.gameObject);

	}

}

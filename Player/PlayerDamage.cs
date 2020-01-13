using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public int playerHP;
    public Text playerHPText;
    public AudioClip sound1;
    AudioSource audioSource;
    public GameObject plane;
    

    private void Start()
    {
        playerHP = 3;        
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = sound1;
    }

    private void Update()
    {
        playerHPText.text = "残りHP:" + playerHP.ToString();
    }


    //　コライダのIsTriggerのチェックを入れ物理的な衝突をしない（突き抜ける）場合
    void OnTriggerEnter(Collider col) {
        Debug.Log("hit something");
		if(col.tag == "Enemy") {
            playerHP -= 1;
            playerHPText.text = "残りHP:" + playerHP.ToString();
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
	}

}

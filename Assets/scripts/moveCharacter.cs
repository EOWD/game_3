using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour
{
    private Rigidbody playerRb;
    public ParticleSystem explosion;
    public AudioClip jump;
    public AudioClip crash;
    public AudioSource playAudio;
    public ParticleSystem dirt;
    private bool alive=true;
    public float jumpForce = 10;
    public bool gameOver = false;
    public float gravityModifier;
    public bool isOnGround = true;
    private Animator playerAnimation;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimation = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        playAudio=GetComponent<AudioSource>();

        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && alive)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;

            playerAnimation.SetTrigger("Jump_trig");
            dirt.Stop();
           playAudio.PlayOneShot(jump,1.5f);
        }



    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

            isOnGround = true;
            dirt.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            explosion.Play();
            playerAnimation.SetBool("Death_b",true);
playerAnimation.SetInteger("DeathType_int",1);
            gameOver = true;
            alive=false;
            dirt.Stop();
            Debug.LogWarning("Game Over ");
            playAudio.PlayOneShot(crash,1.5f);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    private AudioSource audioPlayer;
    public AudioClip jump;
    public AudioClip scoreHighlight;
    // Start is called before the first frame update
    void Start()
    {
         audioPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class theActualSection : MonoBehaviour {

    float rhythmTimer;
    public GameObject note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;
    private int numNotes;
    Vector2 firstNote;
    Vector2 secondNote;
    Vector2 thirdNote;
    Vector2 fourthNote;
    AudioSource theAudio;
    


    // Use this for initialization
    void Start () {
        theAudio = GetComponent<AudioSource>();
        //timer1 = 0;
        rhythmTimer = 0; //the time that the song
        //timeForRhythm = false;
        //theAudio.PlayDelayed(3.7f); //plays the audio at a 3 second delay (the time it takes for the first note to reach the thing)
        theAudio.PlayDelayed(3.4f);
        numNotes = 0;
        //isPlayed = new bool[130]; //an array saying whether the note has been spawned or not
        fourthNote = new Vector2(14.26f, -2.16f); //position of the bottom note
        thirdNote = new Vector2(14.26f, -0.18f); // position of the first up from the bottom note
        secondNote = new Vector2(14.26f, 1.94f); // position of the second up from the bottom note
        firstNote = new Vector2(14.26f, 3.92f); // position of the top note
    }
	
	// Update is called once per frame
	void Update () {
        rhythmTimer += Time.deltaTime;
        rhythmTimer = Mathf.Round(rhythmTimer * 1000f) / 1000f;


        if (numNotes <= 25)
        {

            if ((rhythmTimer > .302) && numNotes == 0)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > .625) && numNotes == 1)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > .809) && numNotes == 2)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > .940) && numNotes == 3)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 1.256) && numNotes == 4)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 1.736) && numNotes == 5)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 2.190) && numNotes == 6)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 2.519) && numNotes == 7)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 2.842) && numNotes == 8)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 3.157) && numNotes == 9)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 3.302) && numNotes == 10)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 3.467) && numNotes == 11)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 3.782) && numNotes == 12)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 3.782) && numNotes == 12)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 4.250) && numNotes == 13)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 4.730) && numNotes == 14)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 5.052) && numNotes == 15)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 5.671) && numNotes == 16)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 6.309) && numNotes == 17)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 6.927) && numNotes == 18)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 7.559) && numNotes == 19)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 7.901) && numNotes == 20)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 8.203) && numNotes == 21)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 8.368) && numNotes == 22)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 8.506) && numNotes == 23)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 8.677) && numNotes == 24)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 8.828) && numNotes == 25)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
        }

        //START OF SECTION 2 MEASURES 9-16

        else if (numNotes > 25 && numNotes <= 49)
        {
            if ((rhythmTimer > 10.098) && numNotes == 26)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 10.743) && numNotes == 27)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 11.368) && numNotes == 28)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 11.671) && numNotes == 29)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 12.00) && numNotes == 30)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 12.309) && numNotes == 31)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 12.631) && numNotes == 32)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 13.269) && numNotes == 33)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 13.888) && numNotes == 34)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 14.526) && numNotes == 35)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 15.151) && numNotes == 36)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 15.467) && numNotes == 37)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 15.782) && numNotes == 38)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 16.092) && numNotes == 39)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 16.414) && numNotes == 40)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 16.723) && numNotes == 41)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 17.039) && numNotes == 42)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 17.355) && numNotes == 43)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 17.677) && numNotes == 44)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 17.986) && numNotes == 45)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 18.309) && numNotes == 46)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 18.605) && numNotes == 47)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 18.940) && numNotes == 48)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 19.578) && numNotes == 49)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            
        }

        // END OF SECTION ONE, MEASURES 8-16

        else if (numNotes > 49 && numNotes <= 69)
        {
            if ((rhythmTimer > 20.210) && numNotes == 50)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 20.835) && numNotes == 51)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 21.473) && numNotes == 52)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 21.782) && numNotes == 53)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 22.078) && numNotes == 54)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 22.407) && numNotes == 55)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 22.736) && numNotes == 56)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 23.190) && numNotes == 57)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 23.361) && numNotes == 58)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 23.671) && numNotes == 59)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 23.993) && numNotes == 60)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 24.618) && numNotes == 61)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 25.256) && numNotes == 62)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 25.881) && numNotes == 63)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 26.506) && numNotes == 64)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 26.986) && numNotes == 65)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 27.151) && numNotes == 66)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 27.460) && numNotes == 67)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 27.789) && numNotes == 68)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 29.052) && numNotes == 69)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }

        }

        // END OF SECTION 3, MEASURES 16-24

        else if (numNotes > 69)
        {
            if ((rhythmTimer > 30.309) && numNotes == 70)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 30.618) && numNotes == 71)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 30.960) && numNotes == 72)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 31.098) && numNotes == 73)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 31.256) && numNotes == 74)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 31.427) && numNotes == 75)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 31.578) && numNotes == 76)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 32.059) && numNotes == 77)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 32.526) && numNotes == 78)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 32.835) && numNotes == 79)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 33.171) && numNotes == 80)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 33.453) && numNotes == 81)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 33.625) && numNotes == 81)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 33.782) && numNotes == 82)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 33.927) && numNotes == 83)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 34.092) && numNotes == 84)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 34.572) && numNotes == 85)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 35.059) && numNotes == 86)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 35.368) && numNotes == 87)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 35.690) && numNotes == 88)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 35.986) && numNotes == 89)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 36.157) && numNotes == 90)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 36.309) && numNotes == 91)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 36.473) && numNotes == 92)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 36.618) && numNotes == 93)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 37.105) && numNotes == 94)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 37.559) && numNotes == 95)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 37.888) && numNotes == 96)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 38.052) && numNotes == 97)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 38.217) && numNotes == 98)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 38.375) && numNotes == 99)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 38.506) && numNotes == 100)
            {
                Instantiate(note1, firstNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 38.684) && numNotes == 101)
            {
                Instantiate(note2, secondNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 38.835) && numNotes == 102)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 39.00) && numNotes == 103)
            {
                Instantiate(note4, fourthNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 39.164) && numNotes == 104)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }
            else if ((rhythmTimer > 39.789) && numNotes == 105)
            {
                Instantiate(note3, thirdNote, Quaternion.identity);
                //Debug.Log("would spawn");
                numNotes += 1;
            }

            else if ((rhythmTimer > 48) && numNotes == 106)
            {
                SceneManager.LoadScene("ikeGarage2");
            }
        }
    }
}

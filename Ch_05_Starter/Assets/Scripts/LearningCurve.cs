using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Time for action p. 57
    private int currentAge = 30;
    public int addedAge = 1;

    // Time for action p. 59
    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    /// <summary>
    /// Other Time for action variables
    /// </summary>
    public int currentGold = 32;
    int diceRoll = 7;
    int playerLives = 3;
    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "Relic Stone";
    string characterAction = "Attack";

    // Start is called before the first frame update
    void Start()
    {
        // Time for action p. 36
        Debug.Log(30 + 1);
        Debug.Log(currentAge + 1);

        // Time for action p. 41
        ComputeAge();

        // Time for action p. 60
        Debug.Log($"A string can have variables like {firstName} inserted directly!");

        // Time for action p. 68
        //Debug.Log(firstName * pi);

        // Time for action p. 71
        //GenerateCharacter();

        // Time for action p. 74
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);

        // Time for action p. 76
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));

        // Time for action p. 85
        Thievery();

        // Time for action p. 90
        OpenTreasureChamber();

        // Time for action p. 93
        PrintCharacterAction();

        // Time for action p. 100
        List<string> questPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        // Time for action p. 103
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5 },
            { "Antidote", 7 },
            { "Aspirin", 1 }
        };
        Debug.LogFormat("Items: {0}", itemInventory.Count);

        // Time for action p. 107
        FindPartyMember();

        // Time for action p. 112
        HealthStatus();
    }

    public void HealthStatus()
    {
        while(playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }

        Debug.Log("Player KO'd...");
    }

    public void FindPartyMember()
    {
        // Time for action p. 100
        List<string> questPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        for(int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);

            if(questPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }
    }

    public void RollDice()
    {
        switch(diceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
        }
    }

    public void PrintCharacterAction()
    {
        switch(characterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up.");
                break;
        }
    }

    public void OpenTreasureChamber()
    {
        if(pureOfHeart && rareItem == "Relic Stone")
        {
            if(!hasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            } else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        } else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }

    public void Thievery()
    {
        if(currentGold > 50)
        {
            Debug.Log("You're rolling in it!");
        } else if (currentGold < 15)
        {
            Debug.Log("Not much there to steal...");
        } else
        {
            Debug.Log("Looks like your purse is in the sweet spot :)");
        }
    }

    public int GenerateCharacter(string name, int level)
    {
        // Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        // Time for action p. 75
        return level += 5;
    }

    /// <summary>
    /// Time for action p. 45
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
}

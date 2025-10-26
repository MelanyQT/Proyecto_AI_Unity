using System.Threading.Tasks;
using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public TextMeshProUGUI npcDialogueText;

    public async void OnPlayerInteract(string playerMessage)
    {
        string prompt = $"Jugador: {playerMessage}\nNPC:";
        string response = await GenerateResponse(prompt);
        npcDialogueText.text = response;
    }

    private async Task<string> GenerateResponse(string prompt)
    {
        await Task.Delay(500);
        return "He escuchado lo que dices, aventurero. ¿Qué te trae por este lugar?";
    }
}

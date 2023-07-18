using UnityEngine;
using TMPro;
using Oculus.Voice;

public class TranscriptionHandler : MonoBehaviour
{
    public TextMeshProUGUI transcriptionText; // Your TextMeshPro text object
    public AppVoiceExperience voiceExperience; // Your AppVoiceExperience script

    private void OnEnable()
    {
        // Add listeners for transcription events
        voiceExperience.VoiceEvents.OnPartialTranscription.AddListener(OnPartialTranscription);
        voiceExperience.VoiceEvents.OnFullTranscription.AddListener(OnFullTranscription);
    }

    private void OnDisable()
    {
        // Remove listeners when the script is disabled to avoid memory leaks
        voiceExperience.VoiceEvents.OnPartialTranscription.RemoveListener(OnPartialTranscription);
        voiceExperience.VoiceEvents.OnFullTranscription.RemoveListener(OnFullTranscription);
    }

    // This will be called when a partial transcription is available
    public void OnPartialTranscription(string transcription)
    {
        // Update the TextMeshPro text
        transcriptionText.text = transcription;
    }

    // This will be called when a full transcription is available
    public void OnFullTranscription(string transcription)
    {
        // Update the TextMeshPro text
        transcriptionText.text = transcription;
    }
}

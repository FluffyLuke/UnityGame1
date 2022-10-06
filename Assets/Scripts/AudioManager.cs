using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void PlayAudio(string name)
    {
        Sound currentSound = Array.Find(sounds, sound => sound.name == name);
        if (currentSound == null)
        {
            Debug.Log($"Audio clip not found - {name}");
            return;
        }
        Debug.Log($"Playing: {currentSound}");
        currentSound.source.Play();
        Debug.Log($"Playing: {currentSound}");
    }

    public void PlayIfNotRepeated(string name)
    {
        Sound currentSound = Array.Find(sounds, sound => sound.name == name);
        if (currentSound == null)
        {
            Debug.Log($"Audio clip not found - {name}");
            return;
        }
        if (!currentSound.source.isPlaying)
        {
            currentSound.source.Play();
        }
    }
    public void StopPlaying(string name)
    {
        Sound currentSound = Array.Find(sounds, sound => sound.name == name);
        if (currentSound == null)
        {
            Debug.Log($"Audio clip not found - {name}");
            return;
        }
        currentSound.source.Stop();
    }
}

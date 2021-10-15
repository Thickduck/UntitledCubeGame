using UnityEngine;
using System; 

public class AudioManager : MonoBehaviour
{
    // Author of this code is "ThickduckPlayz" ;)
    
    // Start is called before the first frame update

    public Sound[] sounds;

    public static AudioManager instance; 
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return; 
        }
            
        
        
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop; 
        }
    }

    private void Start()
    {
        Play("Theme"); 
    }


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
            return; 
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound st = Array.Find(sounds, sound => sound.name == name);
        st.source.Stop(); 
    }
}

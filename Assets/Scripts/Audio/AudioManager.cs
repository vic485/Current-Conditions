using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Audio
{
    public class AudioManager : MonoBehaviour
    {
        private readonly string _musicPath = Path.Combine(Application.streamingAssetsPath, "music");

        private readonly List<string> _songs = new List<string>();

        private AudioSource _source;
        private bool _isChanging;

        private void OnEnable()
        {
            Directory.CreateDirectory(_musicPath);
            _source = GetComponent<AudioSource>();
            var songFiles = Directory.GetFiles(_musicPath);

            foreach (var song in songFiles)
            {
                switch (Path.GetExtension(song))
                {
                    case ".mp3":
                        _songs.Add(song);
                        break;
                    case ".meta":
                        Debug.Log("Skipping editor meta files.");
                        break;
                    default:
                        Debug.Log($"Unknown or unsupported audio file {song}");
                        break;
                }
            }

            if (_songs.Count == 0)
            {
                Debug.Log("No music files were found! Audio will be disabled.");
                enabled = false;
            }

            StartCoroutine(ChangeClip());
        }

        private void Update()
        {
            if (_source.isPlaying || _isChanging)
                return;

            StartCoroutine(ChangeClip());
        }

        private IEnumerator ChangeClip()
        {
            _isChanging = true;
            var songToPlay = _songs[Random.Range(0, _songs.Count)];

            _source.clip = Mp3Util.GetAudio(songToPlay);
            _source.Play();
            _isChanging = false;
            yield return null;
        }
    }
}

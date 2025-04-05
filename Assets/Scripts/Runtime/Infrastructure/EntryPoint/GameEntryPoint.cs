using UnityEngine;

namespace Runtime.Infrastructure.EntryPoint
{
    public class GameEntryPoint : MonoBehaviour
    {
        private void Start()
        {
            int _characterId = PlayerPrefs.GetInt(PrefsNames.characterIndex);

            CharacterInstaller _characterInstaller = FindObjectOfType<CharacterInstaller>();

            Transform _characterToSpawn = _characterInstaller._characters[_characterId];
            Transform _currentCharacter = Instantiate(_characterToSpawn, _characterToSpawn.transform.position, Quaternion.identity);
        }
    }
}
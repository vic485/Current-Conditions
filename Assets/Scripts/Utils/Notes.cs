using UnityEngine;

#if UNITY_EDITOR
namespace Utils
{
    public class Notes : MonoBehaviour
    {
        [TextArea(15, 10000)] public string notes;
    }
}
#endif
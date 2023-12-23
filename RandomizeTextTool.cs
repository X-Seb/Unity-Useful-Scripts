using TMPro;
using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// Used to randomize the text value of each element in an array from the possible text options.
/// </summary>
public class RandomizeTextTool : MonoBehaviour
{
    [Header("Should the text values be randomized on start?")]
    [SerializeField] private bool m_randomizeOnStart;
    [Header("UI elements:")]
    [SerializeField] private TextMeshProUGUI[] m_textTMProArray;
    [SerializeField] private Text[] m_textLegacyArray;
    [Header("Random Text Options:")]
    [SerializeField] private string[] m_textOptions;

    void Start()
    {
        if (m_randomizeOnStart)
        {
            Randomize();
        }
    }

    public void Randomize()
    {
        if (m_textLegacyArray != null)
        {
            foreach (Text textElement in m_textLegacyArray)
            {
                textElement.text = m_textOptions[Random.Range(0, m_textOptions.Length - 1)];
            }
        }

        if (m_textTMProArray != null)
        {
            foreach (TextMeshProUGUI textElement in m_textTMProArray)
            {
                textElement.text = m_textOptions[Random.Range(0, m_textOptions.Length - 1)];
            }
        }
    }
}

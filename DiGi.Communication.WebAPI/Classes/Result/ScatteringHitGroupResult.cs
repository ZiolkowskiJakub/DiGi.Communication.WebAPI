using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents the scattering hits of one azimuth and elevation bin that hit scattering objects sharing the same electrical properties.
    /// <para>A populated bin holds hundreds of hits but only a handful of distinct materials, so the hits are grouped rather than sent flat: the consuming application counts the groups of a bin, lists them, and drills into the hits of one group.</para>
    /// <para><see cref="Key"/> identifies the electrical properties across the whole payload. It is required because equal properties are described by a separate <see cref="ElectricalPropertiesResult"/> instance in every bin they occur in, and because <see cref="ElectricalPropertiesResult"/> carries no frequency range, so its values alone do not distinguish two materials that differ only by that range.</para>
    /// </summary>
    public class ScatteringHitGroupResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScatteringHitGroupResult"/> class.
        /// </summary>
        /// <param name="key">The payload wide identifier of the electrical properties the group was formed on.</param>
        /// <param name="electricalProperties">The electrical properties shared by the scattering objects the hits of the group point at.</param>
        /// <param name="hits">The scattering hits of the group.</param>
        public ScatteringHitGroupResult(int key, ElectricalPropertiesResult? electricalProperties, List<ScatteringHitResult>? hits)
        {
            Key = key;
            ElectricalProperties = electricalProperties;
            Hits = hits ?? [];
        }

        /// <summary> Gets the electrical properties shared by the scattering objects the hits of the group point at. </summary>
        [JsonPropertyName("electricalProperties")]
        public ElectricalPropertiesResult? ElectricalProperties { get; }

        /// <summary> Gets the scattering hits of the group. </summary>
        [JsonPropertyName("hits")]
        public List<ScatteringHitResult> Hits { get; }

        /// <summary>
        /// Gets the payload wide identifier of the electrical properties the group was formed on.
        /// <para>Equal across every bin the same electrical properties occur in, so groups of neighbouring bins merged by the consuming application can be matched on it.</para>
        /// </summary>
        [JsonPropertyName("key")]
        public int Key { get; }
    }
}

using System.Text.Json.Serialization;

namespace DiGi.Communication.WebAPI.Classes
{
    /// <summary>
    /// Represents a triangulated geometry of the propagation calculation result in world coordinates.
    /// <para>The geometry is flattened into two parallel buffers so it can be uploaded to the consuming application renderer without further conversion: <see cref="Vertices"/> holds the coordinates as consecutive X, Y, Z triples and <see cref="Indices"/> holds three vertex indices per triangle.</para>
    /// </summary>
    public class Mesh3DResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh3DResult"/> class.
        /// </summary>
        /// <param name="vertices">The vertex coordinates as consecutive X, Y, Z triples.</param>
        /// <param name="indices">The vertex indices, three per triangle.</param>
        public Mesh3DResult(List<double>? vertices, List<int>? indices)
        {
            Vertices = vertices ?? [];
            Indices = indices ?? [];
        }

        /// <summary> Gets the vertex indices, three per triangle. </summary>
        [JsonPropertyName("indices")]
        public List<int> Indices { get; }

        /// <summary> Gets the vertex coordinates as consecutive X, Y, Z triples. </summary>
        [JsonPropertyName("vertices")]
        public List<double> Vertices { get; }
    }
}

using system;

namespace engine
{
  public sealed class FlatWorld
  {
    // cm
    public static readonly float MinBodySize = 0.01f * 0.01f;
    public static readonly float MaxBodySize = 64f * 64f;

    // g / cm^3
    public static readonly float MinDensity = 0.5f;
    public static readonly float MaxDensity = 21.4f;
  }
}
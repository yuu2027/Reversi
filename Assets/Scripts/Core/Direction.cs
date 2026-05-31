public readonly struct Direction
{
    public int Dx { get; }
    public int Dy { get; }

    public Direction(int dx, int dy)
    {
        Dx = dx;
        Dy = dy;
    }

    public static readonly Direction[] All =
    {
        new Direction(-1, 1), // ç∂è„
        new Direction(0, 1),  // âE
        new Direction(1, 1),  // âEè„

        new Direction(-1, 0),
        new Direction(1, 0),

        new Direction(-1, -1),
        new Direction(0, -1),
        new Direction(1, -1),
    };
}

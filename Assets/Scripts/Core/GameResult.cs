
public readonly struct GameResult
{
    public int BlackCount { get; }
    public int WhiteCount { get; }
    public CellState Winner { get; }
    public bool IsDraw { get; }

    public GameResult(int  blackCount, int whiteCount, CellState winner, bool isDraw)
    {
        BlackCount = blackCount;
        WhiteCount = whiteCount;
        Winner = winner;
        IsDraw = isDraw;
    }
}

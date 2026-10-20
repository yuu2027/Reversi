public enum Disc
{
    Empty = 0,
    Black = 1,
    White = 2
}

public class BoardState
{
    private Disc[,] board = new Disc[8, 8];

    public BoardState()
    {
        // 初期配置
        board[3, 3] = Disc.White;
        board[4, 4] = Disc.White;
        board[3, 4] = Disc.Black;
        board[4, 3] = Disc.Black;
    }

    public Disc GetDisc(int x, int y)
    {
        return board[x, y];
    }
}

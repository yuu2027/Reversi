public class Board
{
    public const int Size = 8;
    private readonly CellState[,] cells = new CellState[Size, Size];

    public Board(CellState[,] cells, int blackCount, int whiteCount)
    {
        this.cells = cells;
    }

    public bool IsInside(int x, int y)
    {
        if (0 <= x && x < Size && 0 <= y && y < Size) return true;
        return false;
    }

    // 石を反転
    public void FlipCell(int x, int y)
    {
        if (cells[x, y] == CellState.Empty) return;
        else if (cells[x, y] == CellState.Black) cells[x, y] = CellState.White;
        else if (cells[x, y] == CellState.White) cells[x, y] = CellState.Black;
    }

    // 指定座標の状態を取得
    public CellState GetCell(int x, int y)
    {
        return cells[x, y];
    }

    // 指定座標に石を置く
    public void SetCell(int x,int y, CellState state)
    {
        if (GetCell(x, y) == CellState.Empty) cells[x, y] = state;
    }

    // 初期配置を作る
    public void ResetToInitialPosition()
    {
        cells[3, 3] = CellState.Black;
        cells[3, 4] = CellState.Black;
        cells[4, 3] = CellState.White;
        cells[4, 4] = CellState.White;
    }

    // 石数を数える
    public int Count(CellState state)
    {
        int count = 0;
        for (int y = 0; y < Size; y++)
        {
            for (int x = 0; x < Size; x++)
            {
                if (cells[y, x] == state) count++;
            }
        }

        return count;
    }

    // AI探索用に盤面を複製する
    public Board Clone()
    {
        return null;
    }
}

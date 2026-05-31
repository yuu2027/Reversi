using System.Collections.Generic;

public class ReversiRules
{
    // 黒なら白、白なら黒を返す
    public CellState GetOpponent(CellState player)
    {
        if (player == CellState.Black) return CellState.White;
        else if (player == CellState.White) return CellState.Black;
        return CellState.Empty;
    }

    // 指定マスに置いたとき反転できる全座標を返す
    public List<BoardPosition> GetFlippablePositions(Board board, int x, int y, CellState player)
    {
        List<BoardPosition> flippablePositions = new List<BoardPosition>();
        
        for (int i = 0; i < 8; i++)
        {
            flippablePositions.AddRange(GetFlippablePositionsInDirection(board, x, y, player, Direction.All[i]));
        }

        return flippablePositions;
    }

    // 1枚以上反転できるならtrue
    public bool IsLegalMove(Board board, int x, int y, CellState player)
    {
        if (GetFlippablePositions(board, x, y, player).Count > 0) return true;
        return false;
    }

    // 盤面全体から合法手一覧を作る
    public List<Move> GetLegalMoves(Board board, CellState player, int turnNumber)
    {
        List<Move> legalMoves = new List<Move>();

        for (int y = 0; y < Board.Size; y++)
        {
            for (int x = 0; x < Board.Size; x++)
            {
                if (IsLegalMove(board, x, y, player)) legalMoves.Add(new Move(x, y, player, turnNumber));
            }
        }

        return legalMoves;
    }

    // 石を置き、反転し、反転座標を返す
    public List<BoardPosition> ApplyMove(Board board, Move move)
    {
        board.SetCell(move.X, move.Y, move.Player);

        List<BoardPosition> flippablePositions = GetFlippablePositions(board, move.X, move.Y, move.Player);

        foreach (BoardPosition position in flippablePositions)
        {
            board.FlipCell(position.X, position.Y);
        }

        return flippablePositions;
    }

    // その色が置ける手を持つか返す
    public bool HasAnyLegalMove(Board  board, CellState player)
    {
        return false;
    }

    public bool IsGameOver(Board board)
    {
        return false;
    }

    public GameResult CreateResult(Board board)
    {
        return new GameResult();
    }

    // 1方向だけを調べる
    private List<BoardPosition> GetFlippablePositionsInDirection(Board board, int startX, int startY, CellState player, Direction direction)
    {
        List<BoardPosition> flippablePositions = new List<BoardPosition>();
        
        while (true)
        {
            startX += direction.Dx;
            startY += direction.Dy;

            if (board.GetCell(startX, startY) == CellState.Empty || board.GetCell(startX, startY) == player) break;
            else if (board.GetCell(startX, startY) != player)
            {
                flippablePositions.Add(new BoardPosition(startX, startY));
            }
        }

        return flippablePositions;
    }
}

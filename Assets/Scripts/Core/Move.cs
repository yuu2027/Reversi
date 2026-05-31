
// 1手の情報を表す
public readonly struct Move
{
    public int X { get; } // x座標
    public int Y { get; } // y座標
    public CellState Player { get; } // プレイヤーの色
    public int TurnNumber {  get; } // ターン番号

    // どこに誰が何ターン目に置いたか
    public Move(int x, int y, CellState player, int turnNumber)
    {
        X = x;
        Y = y;
        Player = player;
        TurnNumber = turnNumber;
    }   
}

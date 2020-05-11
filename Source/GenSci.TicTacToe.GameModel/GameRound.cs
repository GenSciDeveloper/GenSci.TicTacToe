namespace GenSci.TicTacToe.GameModel
{
    public class GameRound : NotifyPropertyBase
    {
        private PlayGround _playGround;

        public PlayGround PlayGround
        {
            get => _playGround;
            set
            {
                if (value != _playGround)
                {
                    _playGround = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool CheckGameEnd()
        {
            return true;
        }

        public void FinishGame()
        {

        }
    }
}

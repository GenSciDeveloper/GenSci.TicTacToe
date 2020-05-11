namespace GenSci.TicTacToe.GameModel
{
    public class PlayGround : NotifyPropertyBase
    {
        private eGameType _gameType;

        public eGameType GameType
        {
            get { return _gameType; }
            set
            {
                if (value != _gameType)
                {
                    _gameType = value;
                    OnPropertyChanged();
                }
            }
        }

        public int PlayGroundSide
        {
            get
            {
                switch (_gameType)
                {
                    case eGameType.Gomoku:
                        return 15;
                    case eGameType.TicTacToe:
                    default:
                        return 3;
                }
            }
        }

        public int NumberRowToWin
        {
            get
            {
                switch (_gameType)
                {
                    case eGameType.Gomoku:
                        return 5;
                    case eGameType.TicTacToe:
                    default:
                        return 3;
                }
            }
        }
    }
}

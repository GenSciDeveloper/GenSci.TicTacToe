namespace GenSci.TicTacToe.GameModel
{
    public class Player : NotifyPropertyBase
    {
        private string _playerName = "Player";
        private int _victoryCounter = 0;
        private eItemType _currentItemType = eItemType.X;

        public string PlayerName
        {
            get => _playerName;
            set
            {
                if (value != _playerName)
                {
                    _playerName = value;
                    OnPropertyChanged();
                }
            }
        }

        public int VictoryCounter
        {
            get => _victoryCounter;
            set
            {
                if (value != _victoryCounter)
                {
                    _victoryCounter = value;
                    OnPropertyChanged();
                }
            }
        }

        public eItemType CurrentItemType
        {
            get => _currentItemType;
            set
            {
                if (value != _currentItemType)
                {
                    _currentItemType = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}

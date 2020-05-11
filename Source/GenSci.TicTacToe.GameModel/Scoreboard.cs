using System;

namespace GenSci.TicTacToe.GameModel
{
    [Serializable]
    public class Scoreboard : NotifyPropertyBase
    {
        private Player _firstPlayer;
        private Player _secondPlayer;

        public Player FirstPlayer
        {
            get => _firstPlayer;
            set
            {
                if (value != _firstPlayer)
                {
                    _firstPlayer = value;
                    OnPropertyChanged();
                }
            }
        }

        public Player SecondPlayer
        {
            get => _secondPlayer;
            set
            {
                if (value != _secondPlayer)
                {
                    _secondPlayer = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}

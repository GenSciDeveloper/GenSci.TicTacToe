using System;

namespace GenSci.TicTacToe.GameModel
{
    [Serializable]
    class GameSettings : NotifyPropertyBase
    {
        private eGameType _gameType;
        private Scoreboard _scoreboard;

        public eGameType GameType
        {
            get => _gameType;
            set
            {
                if (value != _gameType)
                {
                    _gameType = value;
                    OnPropertyChanged();
                }
            }
        }

        public Scoreboard Scoreboard
        {
            get => _scoreboard;
            set
            {
                if (value != _scoreboard)
                {
                    _scoreboard = value;
                    OnPropertyChanged();
                }
            }
        }

        public void ResetScore()
        {
            Scoreboard.FirstPlayer.VictoryCounter = default;
            Scoreboard.SecondPlayer.VictoryCounter = default;
        }
    }
}

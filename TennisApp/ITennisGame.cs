using System;

namespace TennisApp
{
    public interface ITennisGame
    {
        void WonPoint(string playerName);

        string GetScore();
    }
}
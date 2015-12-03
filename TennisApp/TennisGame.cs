using System;

namespace TennisApp
{
    public interface TennisGame
    {
        void WonPoint(string playerName);
        string GetScore();
    }
}
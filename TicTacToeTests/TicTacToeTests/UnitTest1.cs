using NUnit.Framework;
using System;
using TicTacToeTests.TicTacToe;

namespace Tests
{
    [TestFixture]
    public class TicTacToeTests
    {
        
        [Test]
        public void CreateGame_GameIsInCorrectState()
        {
            Game game = new Game();
            Assert.AreEqual(0, game.MovesCounter);
            Assert.AreEqual(State.Unset, game.GetState(1));
        }

        [Test]
        public void MakeMove_CounterIncreases()
        {
            Game game = new Game();
            game.MakeMove(1);

            Assert.AreEqual(1, game.MovesCounter);
        }

        [Test]
        public void MakeInvalidMove_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                var game = new Game();
                game.MakeMove(0);
            });
        }

        [Test]
        public void MoveOnTheSameSquare_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => {
                var game = new Game();
                game.MakeMove(1);
                game.MakeMove(1);
            });
        }

        [Test]
        public void MakingMoves_SetStateCorrectly()
        {
            Game game = new Game();
            MakeMoves(game, 1, 2, 3, 4);

            Assert.AreEqual(State.X, game.GetState(1));
            Assert.AreEqual(State.O, game.GetState(2));
            Assert.AreEqual(State.X, game.GetState(3));
            Assert.AreEqual(State.O, game.GetState(4));
        }

        [Test]
        public void GetWinner_OsWinVertically_ReturnOs()
        {
            Game game = new Game();

            // 2, 5, 8 - Os win
            MakeMoves(game, 1, 2, 3, 5, 7, 8);

            Assert.AreEqual(Game.Winner.Os, game.GetWinner());
        }

        [Test]
        public void GetWinner_XsWinDiagonal_ReturnXs()
        {
            Game game = new Game();

            //1, 5, 9 Xs win
            MakeMoves(game, 1, 4, 5, 2, 9);

            Assert.AreEqual(Game.Winner.Xs, game.GetWinner());
        }

        [Test]
        public void GetWinner_GameIsUnfinished_ReturnsGameIsUnfinished()
        {
            Game game = new Game();

            MakeMoves(game, 1, 2, 4);

            Assert.AreEqual(Game.Winner.GameIsUnfinished, game.GetWinner());

        }

        private void MakeMoves(Game game, params int[] indexes)
        {
            foreach (var index in indexes)
            {
                game.MakeMove(index);
            }
        }

        
    }
}
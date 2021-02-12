using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("oyun güncellendi");
        }
    }
}

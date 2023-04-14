﻿namespace CSGO_Animal_Kingdom
{
    public class Gameplay
    {
        public void Start(CharacterList cat, bool dogsTurn)
        {
            ChangeTurn(dogsTurn);
            if (dogsTurn)
            {
                var dogGameplay = new DogGameplay();
                dogGameplay.Play(cat);
            }
            else
            {
                var catGameplay = new CatGameplay();
                catGameplay.Play();
            }
        }

        public void Kill()
        {
            int index = new Random().Next(0, 10);
        }

        public void ChangeTurn(bool dogsTurn)
        {
            dogsTurn = !dogsTurn;
        }


    }
}

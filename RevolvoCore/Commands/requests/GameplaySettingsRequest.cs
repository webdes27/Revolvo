﻿namespace RevolvoCore.Commands.requests
{
    class GameplaySettingsRequest
    {
        public const short ID = 27274;

        public bool autoBoost = false;
      
        public bool autoRefinement = false;
      
        public bool quickslotStopAttack = false;
      
        public bool doubleclickAttack = false;
      
        public bool autoChangeAmmo = false;
      
        public bool autoStart = false;
      
        public bool autoBuyGreenBootyKeys = false;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            autoBoost = parser.readBool();
            autoRefinement = parser.readBool();
            quickslotStopAttack = parser.readBool();
            doubleclickAttack = parser.readBool();
            autoChangeAmmo = parser.readBool();
            autoStart = parser.readBool();
            autoBuyGreenBootyKeys = parser.readBool();
        }

    }
}

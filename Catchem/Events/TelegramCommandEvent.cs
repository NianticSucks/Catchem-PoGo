﻿using PoGo.PokeMobBot.Logic.Event;

namespace Catchem.Events
{
    public class TelegramCommandEvent : IEvent
    {
        public string Command;
        public long ChatId;
        public string[] Args;
    }
}

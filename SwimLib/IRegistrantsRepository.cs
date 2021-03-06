﻿namespace SwimLib
{
    public interface IRegistrantsRepository
    {
        int Number { get; }

        void Add(Registrant aSwimmer);
        Registrant GetByRegNum(uint regNumber);
        void Load(string filename, string delimiter);
        void Save(string filename, string delimiter);
    }
}
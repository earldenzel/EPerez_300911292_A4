namespace SwimLib
{
    public interface IClubsRepository
    {
        int Number { get; }

        void Add(Club aClub);
        Club GetByRegNum(uint regNumber);
        void Load(string filename, string delimiter);
        void Save(string filename, string delimiter);
    }
}
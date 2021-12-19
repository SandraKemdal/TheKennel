using TheKennel.Data;

namespace TheKennel
{
    public interface IMockUpData
    {
        IDatabaseLists Db { get; set; }

        public void CreateMockData();
    }
}
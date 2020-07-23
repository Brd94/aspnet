using System.Data;

namespace aspnet.Models.Services.Infrastructure
{
    public interface IDataBaseAccessor
    {
        DataSet Query(string SQL);
    }
}
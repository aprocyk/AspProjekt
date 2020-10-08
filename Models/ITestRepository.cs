using System.Collections.Generic;

namespace AspProjekt.Models
{
    public interface ITestRepository
    {
        IEnumerable<TestModel> GetItems();
    }
}
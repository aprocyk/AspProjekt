using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProjekt.Models
{
    public class TestRepository : ITestRepository
    {
        public IEnumerable<TestModel> GetItems()
        {
            return new List<TestModel>
            {
                new TestModel {ProductName="Nike Sneakers", ProductDesc="Pair of a brand new sneakers", ProductPrice=250},
                new TestModel {ProductName="Timberland Boots", ProductDesc="Pair of a shoes suitable for rainy weather", ProductPrice=370},
                new TestModel {ProductName="Kubota flip-flops", ProductDesc="Pair of a very stylish swimming pool flip-flops", ProductPrice=420}
            };

        }
    }
}

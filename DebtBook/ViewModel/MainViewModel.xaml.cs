using System.Collections.Generic;

namespace DebtBook
{

    public class MainViewModel
    {

        public List<int> List;
 

        public MainViewModel()
        {
            List = new List<int>();
            List.Add(1);
            List.Add(2);
            List.Add(3);
            List.Add(4);
        }

    }

}
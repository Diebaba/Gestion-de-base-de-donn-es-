using System;
using System.Data;

namespace dataGridView1
{
    internal class Data
    {
        public static implicit operator Data(string v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Data(DataSet v)
        {
            throw new NotImplementedException();
        }
    }
}
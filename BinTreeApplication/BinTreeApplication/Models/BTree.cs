using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinTreeApplication.Models
{
    public class BTree
    {
        private Student value;
        private BTree left;
        private BTree right;

        public void Insert(Student obj)
        {
            if (value == null)
                value = obj;
            else
            {
                if (value.GetRating() > obj.GetRating())
                {
                    if (left == null)
                        left = new BTree();
                    left.Insert(obj);
                }
                else if (value.GetRating() < obj.GetRating())
                {
                    if (right == null)
                        right = new BTree();
                    right.Insert(obj);
                }
                else
                    throw new Exception("Узел уже существует");
            }
        }

    }
}
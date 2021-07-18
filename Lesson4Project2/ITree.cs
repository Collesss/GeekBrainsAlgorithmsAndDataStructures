using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Project2
{
    public interface ITree<T>
    {
        TreeNode<T> GetRoot();
        void AddItem(T value); // добавить узел
        void RemoveItem(T value); // удалить узел по значению
        TreeNode<T> GetNodeByValue(T value); //получить узел дерева по значению
        void PrintTree(); //вывести дерево в консоль
    }
}

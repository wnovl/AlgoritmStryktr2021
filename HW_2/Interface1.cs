using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    public interface ILinkedList
    {
        /// <summary>Возвращает количество элементов в списке.</summary>
        int GetCount();

        /// <summary>Добавляет новый элемент списка.</summary>
        void AddNode(int value);

        /// <summary> Добавляет новый элемент списка после определённого элемента.</summary>
        void AddNodeAfter(Node node, int value);

        /// <summary>Удаляет элемент по порядковому номеру.</summary>
        void RemoveNode(int index);

        /// <summary>Удаляет указанный элемент.</summary>
        void RemoveNode(Node node);

        /// <summary>Ищет элемент по его значению.></summary>
        Node FindNode(int searchValue);
    }
}

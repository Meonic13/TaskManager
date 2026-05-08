using System;
using System.Collections.Generic;
using TaskManager.Models;

namespace TaskManager.Algorithms
{
    public class MaxHeapPriorityQueue
    {
        private readonly List<TaskItem> _heap = new List<TaskItem>();

        public int Count => _heap.Count;

        public void Enqueue(TaskItem item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            _heap.Add(item);
            SiftUp(_heap.Count - 1);
        }

        public TaskItem Dequeue()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("Очередь пуста");

            TaskItem top = _heap[0];
            int lastIdx = _heap.Count - 1;
            _heap[0] = _heap[lastIdx];
            _heap.RemoveAt(lastIdx);

            if (_heap.Count > 0)
                SiftDown(0);

            return top;
        }

        public TaskItem Peek()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("Очередь пуста");
            return _heap[0];
        }

        private void SiftUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (_heap[index].CompareTo(_heap[parent]) <= 0)
                    break;

                Swap(index, parent);
                index = parent;
            }
        }

        private void SiftDown(int index)
        {
            int size = _heap.Count;
            while (true)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int largest = index;

                if (left < size && _heap[left].CompareTo(_heap[largest]) > 0)
                    largest = left;
                if (right < size && _heap[right].CompareTo(_heap[largest]) > 0)
                    largest = right;

                if (largest == index)
                    break;

                Swap(index, largest);
                index = largest;
            }
        }

        private void Swap(int i, int j)
        {
            var temp = _heap[i];
            _heap[i] = _heap[j];
            _heap[j] = temp;
        }
    }
}
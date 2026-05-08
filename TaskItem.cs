using System;

namespace TaskManager.Models
{
    public class TaskItem : IComparable<TaskItem>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public int EstimatedMinutes { get; set; }
        public bool IsCompleted { get; set; }

        public int CompareTo(TaskItem? other)
        {
            if (other == null) return 1;
            return other.Priority.CompareTo(this.Priority); // Обратный порядок для Max Heap
        }

        public override string ToString()
        {
            return $"[{Priority}] {Title} ({EstimatedMinutes} мин)";
        }
    }
}
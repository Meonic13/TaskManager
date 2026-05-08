using System;

namespace TaskManager.Models
{
    public class TaskItem : IComparable<TaskItem>
    {
        private static int _globalSequence = 0;
        private readonly int _sequenceNumber;

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public int EstimatedMinutes { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem()
        {
            _sequenceNumber = _globalSequence++;
        }

        public int CompareTo(TaskItem? other)
        {
            if (other == null) return 1;

            // Сначала сравниваем по приоритету (больший приоритет первым)
            int priorityComparison = this.Priority.CompareTo(other.Priority);

            // Если приоритеты равны, сравниваем по порядку вставки (кто раньше добавлен - тот первый)
            if (priorityComparison == 0)
            {
                return this._sequenceNumber.CompareTo(other._sequenceNumber);
            }

            return priorityComparison;
        }

        public override string ToString()
        {
            return $"[{Priority}] {Title} ({EstimatedMinutes} мин)";
        }

        public override bool Equals(object? obj)
        {
            if (obj is TaskItem other)
            {
                return Id == other.Id &&
                       Title == other.Title &&
                       Priority == other.Priority &&
                       EstimatedMinutes == other.EstimatedMinutes;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, Priority, EstimatedMinutes);
        }

        public static void ResetSequence()
        {
            _globalSequence = 0;
        }
    }
}